<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPhongKham.Master" AutoEventWireup="true" CodeBehind="DM_SoDoToChuc.aspx.cs" Inherits="QLPhongKham.Admin.DM_SoDoToChuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/sodotochuc.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="divTree">
        <h2>Sơ đồ chức năng</h2>
        <asp:treeview id="TreeSoDoToChuc" OnSelectedNodeChanged="TreeSoDoToChuc_SelectedNodeChanged" runat="server">
        </asp:treeview>        
    </div>
    <div class="divEdit">
        <h2>Cập nhật sơ đồ chức năng</h2>
        <table>
            <tr>
                <td><label>Mức cha</label></td>
                <td><input type="text" id="txtCha" runat="server" /></td>
            </tr>
            <tr>
                <td><label>Tên</label></td>
                <td><input type="text" id="txtTen" runat="server" /></td>
            </tr>
            <tr>
                <td><button type="button" id="btnThemMoi" onclick="sctThemMoi();">Thêm mới</button></td>
                <td><button type="button" id="btnSua" onclick="sctSua(this.attribute('id'));">Sửa</button></td>
            </tr>
        </table>
    </div>
    
</asp:Content>
