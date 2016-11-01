<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="WebForm.DoiMatKhau" MasterPageFile="~/MasterPageHotgate.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="content1" runat="server">
    
    
    
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Đăng ký tài khoản</h3>
                    </div>
                    <div class="panel-body">
                        <table>
                            <tr>
                                <td>Tên đăng nhập</td>
                                <td><input runat="server" id="txtUserName" /></td>
                            </tr>
                            <tr>
                                <td>Mật khẩu:</td>
                                <td><input runat="server" id="txtPass" type="password" /></td>
                            </tr>
                            <tr>
                                <td>Nhập lại mật khẩu</td>
                                <td><input runat="server" id="txtRePass" type="password" /></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
