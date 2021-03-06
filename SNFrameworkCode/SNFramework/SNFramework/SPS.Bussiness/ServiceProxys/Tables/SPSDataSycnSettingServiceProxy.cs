// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SPSDataSycnSettingServiceProxy.cs">
//   Copyright (c) Foreveross Enterprises. All rights reserved.
// </copyright>
// <summary>
//   Generated by MyGeneration Version # (1.3.0.9)
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using SPS.Data.Tables;
using SPS.Entity.Tables;


namespace SPS.Bussiness.ServiceProxys.Tables
{
	public interface ISPSDataSycnSettingServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SPSDataSycnSettingEntity,int> ,ISPSDataSycnSettingServiceProxyDesigner
    {


    }

    internal partial class SPSDataSycnSettingServiceProxy : BaseSpringNHibernateEntityServiceProxy<SPSDataSycnSettingEntity,int>, ISPSDataSycnSettingServiceProxy
    {


    }
}
