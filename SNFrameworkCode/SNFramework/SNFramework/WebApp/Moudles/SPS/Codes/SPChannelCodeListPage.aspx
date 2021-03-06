﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminMaster.Master" AutoEventWireup="true"
    CodeBehind="SPChannelCodeListPage.aspx.cs" Inherits="Legendigital.Common.WebApp.Moudles.SPS.Codes.SPChannelCodeListPage" %>

<%@ Register Src="UCSPCodeAdd.ascx" TagName="UCSPCodeAdd" TagPrefix="uc1" %>
<%@ Register Src="UCSPCodeEdit.ascx" TagName="UCSPCodeEdit" TagPrefix="uc2" %>
<%@ Register Src="UCSPCodeView.ascx" TagName="UCSPCodeView" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <ext:ResourceManagerProxy ID="ScriptManagerProxy1" runat="server">
    </ext:ResourceManagerProxy>
    <script type="text/javascript">
        var rooturl ='<%=this.ResolveUrl("~/")%>';

        var FormatBool = function(value) {
            if (value)
                return '<%= GetGlobalResourceObject("GlobalResource","msgTrue").ToString() %>';
            else
                return '<%= GetGlobalResourceObject("GlobalResource","msgFalse").ToString() %>';
        };


        var RefreshData = function(btn) {
            <%= this.storeSPCode.ClientID %>.reload();
        };


        function RefreshstoreSPCode() {
            <%= this.storeSPCode.ClientID %>.reload();
        };
        
        function showAddForm() {
                Ext.net.DirectMethods.UCSPCodeAdd.Show( 
                                                                {
                                                                    failure: function(msg) {
                                                                        Ext.Msg.alert('操作失败', msg,RefreshData);
                                                                    },
                                                                    eventMask: {
                                                                                showMask: true,
                                                                                msg: 'Processing...'
                                                                               }
                                                                });    
        
        }
        
                  var ShowCommands = function(grid, toolbar, rowIndex, record)
          {

              if (record.data.MOType=="0")
              {
                  toolbar.items.items[0].menu.items.items[0].hide();
                  toolbar.items.items[0].menu.items.items[1].hide();
              }

              else {
                  toolbar.items.items[0].menu.items.items[0].show();
                  toolbar.items.items[0].menu.items.items[1].show();

              }

          };

        function processcmd(cmd, id) {

            if (cmd == "cmdEdit") {
                Ext.net.DirectMethods.UCSPCodeEdit.Show(id.id,
                                                                {
                                                                    failure: function(msg) {
                                                                        Ext.Msg.alert('操作失败', msg,RefreshData);
                                                                    },
                                                                    eventMask: {
                                                                                showMask: true,
                                                                                msg: '处理中...'
                                                                               }
                                                                }              
                );
            }
			
			            if (cmd == "cmdView") {
                Ext.net.DirectMethods.UCSPCodeView.Show(id.id,
                                                                {
                                                                    failure: function(msg) {
                                                                        Ext.Msg.alert('操作失败', msg,RefreshData);
                                                                    },
                                                                    eventMask: {
                                                                                showMask: true,
                                                                                msg: '处理中...'
                                                                               }
                                                                }              
                );
            }
            
            			            if (cmd == "cmdChannelTest") {
                var win = <%= this.winSendTestRequestForm.ClientID %>;
                

                win.setTitle(' 通道 [<%= this.ChannelID.Name %>]  发送模拟数据 ');
                
                win.autoLoad.url = '../Channels/SPChannelSendTestRequestForm.aspx';
                
                win.autoLoad.params.ChannelID = <%= this.ChannelID.Id.ToString() %>;
        
            	win.autoLoad.params.CodeID = id.data.Id;		                
            			                
                win.show(); 
            }

            if (cmd == "cmdDelete") {
                Ext.MessageBox.confirm('警告','确认要删除该条数据？ ',
                    function(e) {
                        if (e == 'yes')
                            Ext.net.DirectMethods.DeleteRecord(
                                                                id.id,
                                                                {
                                                                    failure: function(msg) {
                                                                        Ext.Msg.alert('操作失败', msg);
                                                                    },
                                                                    success: function(result) { 
                                                                        Ext.Msg.alert('操作成功', '删除记录成功！',RefreshData);            
                                                                    },
                                                                    eventMask: {
                                                                                showMask: true,
                                                                                msg: '处理中 ......'
                                                                               }
                                                                }
                                                            );
                    }
                    );
            }
        }

    </script>
    <ext:Store ID="storeSPCode" runat="server" AutoLoad="true" RemoteSort="true" RemotePaging="true"
        OnRefreshData="storeSPCode_Refresh">
        <AutoLoadParams>
            <ext:Parameter Name="start" Value="0" Mode="Raw" />
            <ext:Parameter Name="limit" Value="8" Mode="Raw" />
        </AutoLoadParams>
        <Proxy>
            <ext:PageProxy />
        </Proxy>
        <Reader>
            <ext:JsonReader IDProperty="Id">
                <Fields>
                    <ext:RecordField Name="Id" Type="int" />
                    <ext:RecordField Name="Name" />
                    <ext:RecordField Name="CodeAssignedClientName" />
                    <ext:RecordField Name="Description" />
                    <ext:RecordField Name="Code" />
                    <ext:RecordField Name="MoCode" />
                    <ext:RecordField Name="MO" />
                    <ext:RecordField Name="MOType" />
                    <ext:RecordField Name="OrderIndex" Type="int" />
                    <ext:RecordField Name="SPCode" />
                    <ext:RecordField Name="Province" />
                    <ext:RecordField Name="DisableCity" />
                    <ext:RecordField Name="IsDiable" Type="Boolean" />
                    <ext:RecordField Name="SPType" />
                    <ext:RecordField Name="CodeLength" Type="int" />
                    <ext:RecordField Name="DayLimit" Type="int" />
                    <ext:RecordField Name="MonthLimit" Type="int" />
                    <ext:RecordField Name="Price" Type="int" />
                    <ext:RecordField Name="SendText" />
                    <ext:RecordField Name="HasFilters" Type="Boolean" />
                </Fields>
            </ext:JsonReader>
        </Reader>
    </ext:Store>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCSPCodeAdd ID="UCSPCodeAdd1" runat="server" />
    <uc2:UCSPCodeEdit ID="UCSPCodeEdit1" runat="server" />
    <uc3:UCSPCodeView ID="UCSPCodeView1" runat="server" />
    <ext:Viewport ID="viewPortMain" runat="server" Layout="fit">
        <Items>
            <ext:GridPanel ID="gridPanelSPCode" runat="server" StoreID="storeSPCode" StripeRows="true"
                Title="通道指令管理" Icon="Table">
                <TopBar>
                    <ext:Toolbar ID="tbTop" runat="server">
                        <Items>
                            <ext:Button ID='btnAdd' runat="server" Text="添加" Icon="Add">
                                <Listeners>
                                    <Click Handler="showAddForm();" />
                                </Listeners>
                            </ext:Button>
                            <ext:Button ID='btnRefresh' runat="server" Text="刷新" Icon="Reload">
                                <Listeners>
                                    <Click Handler="#{storeSPCode}.reload();" />
                                </Listeners>
                            </ext:Button>
                        </Items>
                    </ext:Toolbar>
                </TopBar>
                <View>
                    <ext:GridView ForceFit="true" ID="GridView1">
                        <GetRowClass Handler="" FormatHandler="False"></GetRowClass>
                    </ext:GridView>
                </View>
                <ColumnModel ID="ColumnModel1" runat="server">
                    <Columns>
                        <ext:RowNumbererColumn>
                        </ext:RowNumbererColumn>
                        <ext:Column ColumnID="colID" DataIndex="Id" Header="主键" Width="30" Sortable="true">
                        </ext:Column>
                        <ext:Column ColumnID="colCode" DataIndex="MoCode" Header="指令" Sortable="true">
                        </ext:Column>
                        <ext:Column ColumnID="colCodeAssignedClientName" DataIndex="CodeAssignedClientName"
                            Header="分配" Sortable="true">
                        </ext:Column>
                        <ext:Column ColumnID="colIsDiable" DataIndex="IsDiable" Header="禁用" Width="30" Sortable="true">
                            <Renderer Fn="FormatBool" />
                        </ext:Column>
                        <ext:Column ColumnID="colHasFilters" DataIndex="HasFilters" Header="过滤" Width="30"
                            Sortable="true">
                            <Renderer Fn="FormatBool" />
                        </ext:Column>
                        <ext:CommandColumn ColumnID="colManage" Header="管理" Width="60">
                            <Commands>
                                <ext:SplitCommand Text="操作" Icon="ApplicationEdit">
                                    <Menu>
                                        <Items>
                                            <ext:MenuCommand Icon="ApplicationEdit" CommandName="cmdEdit" Text="编辑">
                                            </ext:MenuCommand>
                                            <ext:MenuCommand Icon="ApplicationDelete" CommandName="cmdDelete" Text="删除">
                                            </ext:MenuCommand>
                                            <ext:MenuCommand Icon="ApplicationViewDetail" CommandName="cmdView" Text="查看">
                                            </ext:MenuCommand>
                                            <ext:MenuCommand Icon="TelephoneGo" CommandName="cmdChannelTest" Text="通道测试">
                                            </ext:MenuCommand>
                                        </Items>
                                    </Menu>
                                </ext:SplitCommand>
                            </Commands>
                            <PrepareToolbar Fn="ShowCommands" />
                        </ext:CommandColumn>
                    </Columns>
                </ColumnModel>
                <LoadMask ShowMask="true" />
                <BottomBar>
                    <ext:PagingToolbar ID="PagingToolBar1" runat="server" PageSize="8" StoreID="storeSPCode"
                        DisplayInfo="true" DisplayMsg="显示指令 {0} - {1} 共 {2}" EmptyMsg="没有符合条件的指令" />
                </BottomBar>
                <Listeners>
                    <Command Handler="processcmd(command, record);" />
                </Listeners>
            </ext:GridPanel>
        </Items>
    </ext:Viewport>
    <ext:Window ID="winSendTestRequestForm" runat="server" Title="通道模拟数据测试" Frame="true"
        Width="640" ConstrainHeader="true" Height="480" Maximizable="true" Closable="true"
        Resizable="true" Modal="true" Hidden="true" AutoScroll="true">
        <AutoLoad Url="../Channels/SPChannelSendTestRequestForm.aspx" Mode="IFrame" NoCache="true"
            TriggerEvent="show" ReloadOnEvent="true" ShowMask="true">
            <Params>
                <ext:Parameter Name="ChannelID" Mode="Raw" Value="0">
                </ext:Parameter>
                <ext:Parameter Name="CodeID" Mode="Raw" Value="0">
                </ext:Parameter>
            </Params>
        </AutoLoad>
        <Listeners>
            <Hide Handler="this.clearContent();" />
        </Listeners>
    </ext:Window>
</asp:Content>
