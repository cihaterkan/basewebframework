﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCSPClientChannelSettingEdit.ascx.cs"
    Inherits="Legendigital.Common.Web.Moudles.SPS.ClientChannelSettings.UCSPClientChannelSettingEdit" %>
<ext:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
</ext:ScriptManagerProxy>
<ext:Window ID="winSPClientChannelSettingEdit" runat="server" Icon="ApplicationEdit"
    Title="编辑通道下家设置" Width="640" Height="460" AutoShow="false" Maximizable="true"
     Modal="true" ShowOnLoad="false">
    <Body>
        <ext:FitLayout ID="fitLayoutMain" runat="server">
            <ext:FormPanel ID="formPanelSPClientChannelSettingAdd" runat="server" Frame="true"
                Header="false" MonitorValid="true" BodyStyle="padding:5px;" AutoScroll=true>
                <Body>
                    <ext:ContainerLayout ID="ContainerLayout1" runat="server">
                        <ext:FieldSet ID="FieldSet1" runat="server" CheckboxToggle="false" Title="基本信息" Collapsed="false">
                            <Body>
                                <ext:FormPanel ID="pnlSPClientChannelSettingAdd1" runat="server">
                                    <Body>
                                        <ext:FormLayout ID="FormLayout4" runat="server">
                                            <Anchors>
                                                <ext:Anchor Horizontal="95%">
                                                    <ext:Hidden ID="hidId" runat="server">
                                                    </ext:Hidden>
                                                </ext:Anchor>
                                                <ext:Anchor Horizontal="95%">
                                                    <ext:TextField ID="txtName" runat="server" FieldLabel="名称" AllowBlank="False" />
                                                </ext:Anchor>
                                                <ext:Anchor Horizontal="95%">
                                                    <ext:TextArea ID="txtDescription" runat="server" FieldLabel="描述" AllowBlank="False" />
                                                </ext:Anchor>
                                            </Anchors>
                                        </ext:FormLayout>
                                    </Body>
                                </ext:FormPanel>
                                <ext:Panel ID="Panel1" runat="server">
                                    <Body>
                                        <ext:ColumnLayout ID="ColumnLayout1" runat="server">
                                            <ext:LayoutColumn ColumnWidth=".5">
                                                <ext:FormPanel ID="pnlSPClientChannelSettingAdd2" runat="server" Border="false" Header="false">
                                                    <Body>
                                                        <ext:FormLayout ID="FormLayout2" runat="server">
                                                            <Anchors>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:Checkbox ID="chkDisable" runat="server" FieldLabel="禁用">
                                                                    </ext:Checkbox>
                                                                </ext:Anchor>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:Label ID="lblChannelName" runat="server" FieldLabel="通道">
                                                                    </ext:Label>
                                                                </ext:Anchor>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:NumberField ID="txtInterceptRate" runat="server" FieldLabel="扣率(%)" AllowBlank="False"
                                                                        Text="50" DecimalPrecision="0" MinValue="0" MaxValue="100" />
                                                                </ext:Anchor>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:ComboBox ID="cmbCommandType" runat="server" FieldLabel="指令匹配规则" AllowBlank="False"
                                                                        Editable="false" TypeAhead="true" ForceSelection="true" Mode="Local" TriggerAction="All"
                                                                        EmptyText="请选择指令匹配规则">
                                                                        <Items>
                                                                            <ext:ListItem Text="完全匹配" Value="1" />
                                                                            <ext:ListItem Text="包含" Value="2" />
                                                                            <ext:ListItem Text="以开头" Value="3" />
                                                                            <ext:ListItem Text="以结尾" Value="4" />
                                                                            <ext:ListItem Text="正则表达式" Value="5" />
                                                                            <ext:ListItem Text="自定义解析" Value="6" />
                                                                            <ext:ListItem Text="无条件匹配" Value="7" />
                                                                        </Items>
                                                                    </ext:ComboBox>
                                                                </ext:Anchor>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:TextField ID="txtChannleCode" runat="server" FieldLabel="通道号" AllowBlank="true">
                                                                    </ext:TextField>
                                                                </ext:Anchor>
                                                            </Anchors>
                                                        </ext:FormLayout>
                                                    </Body>
                                                </ext:FormPanel>
                                            </ext:LayoutColumn>
                                            <ext:LayoutColumn ColumnWidth=".5">
                                                <ext:FormPanel ID="pnlSPClientChannelSettingAdd3" runat="server">
                                                    <Body>
                                                        <ext:FormLayout ID="FormLayout3" runat="server">
                                                            <Anchors>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:NumberField ID="numOrderIndex" runat="server" FieldLabel="排序号" AllowBlank="False"
                                                                        Text="1" DecimalPrecision="0" MinValue="0" MaxValue="1000" />
                                                                </ext:Anchor>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:Label ID="lblClientName" runat="server" FieldLabel="下家">
                                                                    </ext:Label>
                                                                </ext:Anchor>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:ComboBox ID="cmbChannelCodeParamsName" Editable="false" runat="server" FieldLabel="指令映射字段"
                                                                        AllowBlank="True" TriggerAction="All" SelectedIndex="0">
                                                                        <Items>
                                                                            <ext:ListItem Value="cpid" Text="cpid"></ext:ListItem>
                                                                            <ext:ListItem Value="ywid" Text="ywid"></ext:ListItem>
                                                                            <ext:ListItem Value="mid" Text="mid"></ext:ListItem>
                                                                            <ext:ListItem Value="mobile" Text="mobile"></ext:ListItem>
                                                                            <ext:ListItem Value="port" Text="port"></ext:ListItem>
                                                                            <ext:ListItem Value="msg" Text="msg"></ext:ListItem>
                                                                            <ext:ListItem Value="linkid" Text="linkid"></ext:ListItem>
                                                                            <ext:ListItem Value="dest" Text="dest"></ext:ListItem>
                                                                            <ext:ListItem Value="price" Text="price"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield1" Text="extendfield1"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield2" Text="extendfield2"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield3" Text="extendfield3"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield4" Text="extendfield4"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield5" Text="extendfield5"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield6" Text="extendfield6"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield7" Text="extendfield7"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield8" Text="extendfield8"></ext:ListItem>
                                                                            <ext:ListItem Value="extendfield9" Text="extendfield9"></ext:ListItem>
                                                                        </Items>
                                                                        <Triggers>
                                                                            <ext:FieldTrigger Icon="Clear" HideTrigger="true" />
                                                                        </Triggers>
                                                                        <Listeners>
                                                                            <Select Handler="this.triggers[0].show();" />
                                                                            <BeforeQuery Handler="this.triggers[0][ this.getRawValue().toString().length == 0 ? 'hide' : 'show']();" />
                                                                            <TriggerClick Handler="if (index == 0) { this.clearValue(); this.triggers[0].hide(); }" />
                                                                        </Listeners>
                                                                    </ext:ComboBox>
                                                                </ext:Anchor>
                                                                <ext:Anchor Horizontal="95%">
                                                                    <ext:TextField ID="txtCommandCode" runat="server" FieldLabel="指令代码" AllowBlank="False" />
                                                                </ext:Anchor>
                                                            </Anchors>
                                                        </ext:FormLayout>
                                                    </Body>
                                                </ext:FormPanel>
                                            </ext:LayoutColumn>
                                        </ext:ColumnLayout>
                                    </Body>
                                </ext:Panel>
                            </Body>
                        </ext:FieldSet>
                        <ext:FieldSet ID="fsAllowSycnData" runat="server" CheckboxToggle="true" Title="允许同步数据"
                            Collapsed="true">
                            <Body>
                                <ext:FormLayout ID="FormLayout1" runat="server" LabelSeparator=":" LabelWidth="100">
                                    <ext:Anchor Horizontal="95%">
                                        <ext:TextField ID="txtSyncDataUrl" runat="server" FieldLabel="数据同步URL" AllowBlank="true">
                                        </ext:TextField>
                                    </ext:Anchor>
                                    <ext:Anchor Horizontal="95%">
                                        <ext:TextField ID="txtOkMessage" runat="server" FieldLabel="同步数据成功信息" AllowBlank="True" />
                                    </ext:Anchor>
                                    <ext:Anchor Horizontal="95%">
                                        <ext:TextField ID="txtFailedMessage" runat="server" FieldLabel="同步数据失败信息" AllowBlank="True" />
                                    </ext:Anchor>
                                    <ext:Anchor Horizontal="95%">
                                        <ext:ComboBox ID="cmbSycnType" Editable="false" runat="server" FieldLabel="同步数据类型"
                                            AllowBlank="True" SelectedIndex="0" Hidden="true">
                                            <Items>
                                                <ext:ListItem Value="即时同步" Text="即时同步"></ext:ListItem>
                                                <ext:ListItem Value="异步同步" Text="异步同步"></ext:ListItem>
                                            </Items>
                                        </ext:ComboBox>
                                    </ext:Anchor>
                                </ext:FormLayout>
                            </Body>
                            <Listeners>
                                <Collapse Handler="#{txtSyncDataUrl}.setValue('');#{txtOkMessage}.setValue('');#{txtFailedMessage}.setValue('');#{cmbSycnType}.setValue('');" />
                            </Listeners>
                        </ext:FieldSet>
                    </ext:ContainerLayout>
                </Body>
            </ext:FormPanel>
        </ext:FitLayout>
    </Body>
    <Buttons>
        <ext:Button ID="btnSaveSPClientChannelSetting" runat="server" Text="编辑" Icon="ApplicationEdit">
            <AjaxEvents>
                <Click Before="if (!AllValidate(#{pnlSPClientChannelSettingAdd1},#{pnlSPClientChannelSettingAdd2},#{pnlSPClientChannelSettingAdd3})) return false;"
                    OnEvent="btnSaveSPClientChannelSetting_Click" Success="Ext.MessageBox.alert('操作成功', '成功的编辑了通道下家设置。',callback);function callback(id) { #{storeSPClientChannelSetting}.reload(); };
" Failure="Ext.Msg.alert('操作失败', result.errorMessage);">
                    <EventMask ShowMask="true" Msg="数据保存中，请稍候....." />
                </Click>
            </AjaxEvents>
        </ext:Button>
        <ext:Button ID="btnCancelSPClientChannelSetting" runat="server" Text="取消" Icon="Cancel">
            <Listeners>
                <Click Handler="#{winSPClientChannelSettingEdit}.hide();" />
            </Listeners>
        </ext:Button>
    </Buttons>
</ext:Window>
