<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKyTaiKhoan.aspx.cs" Inherits="WebForm.DangKyTaiKhoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script src="CSS/vendor/jquery/jquery.js"></script>
    <script src="CSS/vendor/jquery/jquery.min.js"></script>
    <link href="CSS/cssDangky.css" rel="stylesheet" />
    <%--<script>
        $(document).ready(function () {
            $("#txtTenDangNhap").blur(function () {
                $.ajax({
                    type: "POST",
                    url: "DangKyTaiKhoan.aspx/KiemTraKeyUserName",
                    data: "{'key':'" + $("#txtTenDangNhap").val() + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (message) {
                        if (message.d == false) {
                            $("#valiUserName").css({
                                "color": "red",
                                "position": "absolute"
                            });
                            $("#valiUserName").text("Tài khoản đã tồn tại");
                        }                        
                    },
                    error: function(errormessage) {
                        //Hiển thị lỗi nếu xảy ra
                        $("#valiUserName").text(errormessage.responseText);
                    }
                });
            });
            
        });
    </script>--%>
    <form id="form1" runat="server">
        <div>
            <table class="table">
                <tr>
                    <td colspan="3" class="tit">Đăng ký tài khoản
                    </td>
                </tr>
                <tr>
                    <td class="fildText">Tên đăng nhập<span>*</span></td>
                    <td>
                        <input runat="server" id="txtTenDangNhap" type="text" />
                        <span id="valiUserName" runat="server" class="err"></span>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="fildText">Email<span>*</span></td>
                    <td>
                        <input runat="server" id="txtEmail" type="text" />
                        <span id="valiEmail" runat="server" class="err"></span>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="fildText">Mật khẩu<span>*</span></td>
                    <td>
                        <input runat="server" id="txtMatKhau" type="password" />
                        <span id="valiPass1" runat="server" class="err"></span>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="fildText">Nhắc lại mật khẩu<span>*</span></td>
                    <td>
                        <input runat="server" id="txtReMatKhau" type="password" />
                        <span id="valiPass2" runat="server" class="err"></span>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="fildText" colspan="3">
                        <span runat="server" id="lblResult"></span>

                    </td>
                </tr>
                <tr>
                    <td class="btn" colspan="3">
                        <asp:Button runat="server" ID="btnDangKy" Text="Đăng ký" OnClick="btnDangKy_Click" />
                    </td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
