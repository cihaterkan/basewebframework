﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SPALLClientGroupReportService.aspx.cs" Inherits="Legendigital.Common.Web.Moudles.SPS.Reports.SPALLClientGroupReportService" %>
<%@ Register TagPrefix="rsweb" Namespace="Microsoft.Reporting.WebForms" Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"  style="width:100%; height:100%;">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="100%" AsyncRendering="False" SizeToReportContent="True" onreportrefresh="ReportViewer1_ReportRefresh">
    </rsweb:ReportViewer>
    </form>
</body>
</html>
