﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Crowd.Web.admin.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		adminID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadminID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adminName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadminName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adminPwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadminPwd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		creatAdmin
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkcreatAdmin" Text="creatAdmin" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		deleteAdmin
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkdeleteAdmin" Text="deleteAdmin" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ban
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkban" Text="ban" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		postInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkpostInfo" Text="postInfo" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		see
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chksee" Text="see" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		updateV
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkupdateV" Text="updateV" runat="server" Checked="False" />
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
