<%@ Page Title="" Language="C#" MasterPageFile="~/Crowd.Master" AutoEventWireup="true" CodeBehind="UserCenter.aspx.cs" Inherits="Crowd.web.UserCenter" %>

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
            <div class="pbcon">
                <div class="pbconl">
                    <a href="#">
                        <img class="fdhead" src="#" alt="" />
                    </a>
                    <ul class="fdheadmenu">
                        
                    </ul>
                    
                </div>
                <div class="pbconr">
                    <div class="pbconrhd">
                        <a href="#"></a>
                    </div>
                    <div class="pbconrcnt">
                    </div>
                    <div class="pbconrbtm">
                    </div>
                </div>
            </div>
        </div>
        <div class="right">
            <div id="user">
                <div id="userinfo">
                    <div id="ushead">
                        <img src="#" alt="" />
                    </div>
                    <div id="username">
                        <asp:Label ID="txtusername" Text="" runat="server" />
                      
                    </div>
                </div>
                <div id="userfans">
                </div>
            </div>
        </div>
   </div>
</asp:Content>
