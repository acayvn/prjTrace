<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="WebForm.DangNhap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="CSS/vendor/metisMenu/metisMenu.min.css" rel="stylesheet">
    <link href="CSS/dist/css/sb-admin-2.css" rel="stylesheet">
    <link href="CSS/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <script src="CSS/vendor/jquery/jquery.min.js"></script>
    <script src="CSS/vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="CSS/vendor/metisMenu/metisMenu.min.js"></script>
    <script src="CSS/dist/js/sb-admin-2.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="login-panel panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Đăng nhập</h3>
                        </div>
                        <div class="panel-body">
                        </div>
                        <fieldset>
                            <div class="form-group">
                                <asp:TextBox ID="txtTenDangNhap" runat="server" class="form-control" placeholder="Tên đăng nhâp"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtPass" runat="server" class="form-control" placeholder="Mật khẩu" TextMode="Password"></asp:TextBox>
                            </div>
                            <div style="text-align: center">
                                <asp:Button CssClass="btn btn-success" ID="btnDangNhap" runat="server" Text="Đăng nhập"
                                    OnClick="btnDangNhap_Click" />
                                <asp:Label ID="lblThongBao" ForeColor="Red" runat="server" Visible="false"></asp:Label>
                            </div>
                        </fieldset>

                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
