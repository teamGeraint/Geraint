<%@ Page Title="" Language="C#" MasterPageFile="~/Crowd.Master" AutoEventWireup="true" CodeBehind="UserCenter.aspx.cs" Inherits="Crowd.web.UserCenter" %>

<%@ Register src="uspb.ascx" tagname="uspb" tagprefix="uc1" %>

<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/UserCenter.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="main">
        <div id="left">
            <div id="publish">
                <div id="userhead" class="uhead" runat="server">
                </div>
                <ul id="publishul">
                    <li>
                        <span id="pbtxt"></span>
                    </li>
                    <li>
                        <span id="pbimg"></span>
                    </li>
                    <li>
                        <span id="pbmusic"></span>
                    </li>
                    <li>
                        <span id="pbvideo"></span>
                    </li>
                    
                </ul>
            </div>
            <asp:PlaceHolder ID="pholder" runat="server">
            
            
            
            
            </asp:PlaceHolder>
          
        </div>
        <div id="right">
            <div id="user">
                <div id="userinfo">
                    <div id="ushead">
                        <asp:Image ID="imguserhead" class="imgushead" ImageUrl="" runat="server" />
                    </div>
                    <div id="usname">
                        <asp:Label ID="txtusername" class="txtusname" Text="" runat="server" />
                        <asp:Label ID="txtuserdesc" class="txtusdesc" Text="" runat="server" />
                    </div>
                </div>
                <div id="userfans">
                    <div class="ufdiv">
                        <asp:Label ID="txtguanzhu" Text="" runat="server" />
                        <span class="ufspan">关注</span>
                    </div>
                     <div class="ufdiv">
                        <asp:Label ID="txtfans" Text="" runat="server" />
                        <span class="ufspan">粉丝</span>
                    </div>
                     <div class="ufdiv ufdivr">
                        <asp:Label ID="txtpublsh" Text="" runat="server" />
                        <span class="ufspan">动态</span>
                    </div>
                </div>
            </div>

            <div id="">
            </div>
        </div>
   </div>
</asp:Content>
