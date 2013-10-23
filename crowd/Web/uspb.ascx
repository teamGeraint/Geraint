<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uspb.ascx.cs" Inherits="Crowd.Web.uspb" %>
<link href="Styles/uspb.css" rel="stylesheet" type="text/css" />
            <div id="fdpb" class="pbcon" >
                    <div class="pbconl">
                        <a href="#">
                            <asp:Image ID="fdhead" class="imgfdhead" ImageUrl="" runat="server" />
                            
                        </a>
                        <ul class="fdheadmenu">
                        
                        </ul>
                    
                    </div>
                    <div class="pbconr">
                        <div class="pbconrhd">                 
                            
                        </div>
                        <div class="pbconrcnt">
                            <p id="pbcntp">
                                <a href="#" ID="fdnamea" class="fdnamec" runat="server">
                                    <asp:Label ID="txtfdname" Text="" runat="server" />
                                </a>
                            </p>
                            <p>
                            <asp:Image ID="imgcnt" class="imgcntc" ImageUrl="" runat="server" />
                            <asp:Label ID="txtcnt" class="txtcntc" Text="" runat="server" />
                            </p>
                            <div class="pbconrbtm">
                                <ul>
                                    <li>
                                        <asp:Label ID="txtzan" class="pbbtma" Text="赞" runat="server" />
                                    </li>
                                     <li>
                                        <asp:Label ID="txtpl" class="pbbtma" Text="评论" runat="server" />
                                    </li>
                                     <li>
                                        <asp:Label ID="txtzhf" class="pbbtma" Text="转发" runat="server" />
                                    </li>
                                     <li>
                                         <asp:Image ID="imgshc" class="pbbtma" ImageUrl="" runat="server" />
                                    </li>
                                </ul>
                            </div>
                        </div>
                        
                    </div>
                </div>




