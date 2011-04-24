﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCSystemDictionaryAdd.ascx.cs"
    Inherits="Legendigital.Common.WebApp.Moudles.SystemManage.DictionaryManage.UCSystemDictionaryAdd" %>
<ext:Store runat="server" ID="storeGroup" AutoLoad="false" OnRefreshData="storeGroup_Refresh">
    <Reader>
        <ext:JsonReader IDProperty="Name">
            <Fields>
                <ext:RecordField Name="Name" Type="String" Mapping="Name" />
            </Fields>
        </ext:JsonReader>
    </Reader>
</ext:Store>
<ext:Window ID="winSystemDictionaryAdd" runat="server" Icon="ApplicationAdd" Title="<%$ Resources:msgFormTitle %>"
    Width="400" Height="270" AutoShow="false" Maximizable="true" Modal="true" Hidden="true"
    ConstrainHeader="true" Resizable="true" Layout="Fit">
    <Content>
        <ext:FormPanel ID="formPanelSystemDictionaryAdd" runat="server" Frame="true" Header="false"
            MonitorValid="true" BodyStyle="padding:5px;" LabelSeparator=":" LabelWidth="100"
            Layout="Form">
            <Items>
                <ext:ComboBox ID="cmbGroup" runat="server" StoreID="storeGroup" Editable="true" TypeAhead="true"
                    FieldLabel="<%$ Resources:msgFiledCategory %>" Mode="Local" TriggerAction="All" DisplayField="Name" ValueField="Name"
                    AllowBlank="True" ForceSelection="false" AnchorHorizontal="95%" />
                <ext:TextField ID="txtSystemDictionaryKey" runat="server" FieldLabel="<%$ Resources:msgFiledKey %>" AllowBlank="True"
                    AnchorHorizontal="95%" />
                <ext:TextField ID="txtSystemDictionaryValue" runat="server" FieldLabel="<%$ Resources:msgFiledValue %>" AllowBlank="True"
                    AnchorHorizontal="95%" />
                <ext:TextField ID="txtSystemDictionaryDesciption" runat="server" FieldLabel="<%$ Resources:msgFiledDescription %>"
                    AllowBlank="True" AnchorHorizontal="95%" />
                <ext:TextField ID="txtSystemDictionaryOrder" runat="server" FieldLabel="<%$ Resources:msgFiledOrder %>"
                    AllowBlank="True" AnchorHorizontal="95%" />
                <ext:Checkbox ID="chkSystemDictionaryIsEnable" runat="server" FieldLabel="<%$ Resources:msgFiledIsEnable %>"
                    Checked="false" AnchorHorizontal="95%" />
                 <ext:Checkbox ID="chkSystemDictionaryIsSystem" runat="server" FieldLabel="<%$ Resources:msgFiledIsSystem %>"
                    Checked="false" AnchorHorizontal="95%" />
            </Items>
        </ext:FormPanel>
    </Content>
    <Buttons>
        <ext:Button ID="btnSavelSystemDictionary" runat="server" Text="<%$ Resources : GlobalResource, msgAdd  %>"
            Icon="Add">
            <DirectEvents>
                <Click Before="if(!#{formPanelSystemDictionaryAdd}.getForm().isValid()) return false;"
                    OnEvent="btnSaveSystemDictionary_Click" Success="<%$ Resources : msgAddScript  %>" Failure="<%$ Resources : GlobalResource, msgShowError  %>">
                    <EventMask ShowMask="true" Msg="<%$ Resources : GlobalResource, msgSavingWaiting  %>" />
                </Click>
            </DirectEvents>
        </ext:Button>
        <ext:Button ID="btnCancelSystemDictionary" runat="server" Text="<%$ Resources : GlobalResource, msgCancel  %>"
            Icon="Cancel">
            <Listeners>
                <Click Handler="#{winSystemDictionaryAdd}.hide();" />
            </Listeners>
        </ext:Button>
    </Buttons>
    <Listeners>
        <BeforeShow Handler="#{storeGroup}.reload();" />
    </Listeners>
</ext:Window>
