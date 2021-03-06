﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Legendigital.Framework.Common.Utility;
using Newtonsoft.Json;

namespace SPS.Bussiness.HttpUtils
{
    public class HttpRequestLog
    {
        private Hashtable requestParams;

        private string requestData;

        private string requestPostFileData;

        public string RequestPostFileData
        {
            get { return requestPostFileData; }
            set { requestPostFileData = value; }
        }

        private string requestIP;

        private string _dataAdaptorUrl;

        private string requestUrl;

        public string RequestUrl
        {
            get { return requestUrl; }
            set { requestUrl = value; }
        }

        private string requestQueryString;

        public string RequestQueryString
        {
            get { return requestQueryString; }
            set { requestQueryString = value; }
        }

        public string RequestData
        {
            get { return requestData; }
            set { requestData = value; }
        }

        public string RequestIp
        {
            get { return requestIP; }
            set { requestIP = value; }
        }

        public string DataAdaptorUrl
        {
            get { return _dataAdaptorUrl; }
            set { _dataAdaptorUrl = value; }
        }

        public Hashtable RequestParams
        {
            get { return requestParams; }
            set { requestParams = value; }
        }

        public static HashSet<string> recordParamsNames = new HashSet<string>() { "url", "query_string" };

        public static HashSet<string> filterParamsNames = new HashSet<string>() { ".basewebmanageframework", "currentloginid", "asp.net_sessionid" };

        public HttpRequestLog(HttpRequest request)
        {
            requestParams = PraseHttpGetPostRequestValue(request);

            requestData = JsonConvert.SerializeObject(requestParams);

            requestIP = HttpUtil.GetIP(request);

            _dataAdaptorUrl = Path.GetFileName(request.PhysicalPath);

            requestUrl = request.Url.ToString();

            requestQueryString = request.Url.Query;

            if (request.InputStream != null)
                requestPostFileData = GetXmlPostValueFromRequest(request);
        }



        public static string GetXmlPostValueFromRequest(HttpRequest request)
        {
            StringBuilder fileContent = new StringBuilder();

            using (StreamReader sr = new StreamReader(request.InputStream, request.ContentEncoding))
            {

                fileContent.Append(sr.ReadToEnd());
                sr.Close();
            }

            return fileContent.ToString();
        }

        public static Hashtable PraseHttpGetPostRequestValue(HttpRequest request)
        {
            Hashtable hb = new Hashtable();

            foreach (string key in request.Params.Keys)
            {
                if (string.IsNullOrEmpty(key))
                    continue;

                if (filterParamsNames.Contains(key.ToLower()))
                    continue;

                if ((recordParamsNames.Contains(key.ToLower())))
                {
                    hb.Add(key.ToLower(), request.Params[key.ToLower()]);
                    continue;
                }

                if (request.ServerVariables[key] == null)
                {
                    hb.Add(key.ToLower(), request.Params[key.ToLower()]);
                    continue;
                }

            }

            return hb;
        }
    }
}
