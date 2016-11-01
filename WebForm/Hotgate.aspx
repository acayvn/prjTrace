<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageHotgate.Master" AutoEventWireup="true" CodeBehind="Hotgate.aspx.cs" Inherits="WebForm.Hotgate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .divClass {
            color: blue;
        }

        .divhead {
            margin-top: 70px;
            padding-bottom: 20px;
            font-size: xx-large;
            font-weight: 300;
            text-align: center;
        }

        .textModule {
            color: blue;
            text-transform: uppercase;
        }
    </style>
    <div class="divhead">
        WELLCOME
    </div>

    <asp:DataList Width="100%" ID="viewHotgate" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
        <ItemTemplate>
            <div class="divClass">
                <asp:ImageButton ID="btnImage" runat="server" CommandArgument='<%# Eval("IdTree") %>' CommandName="ClickImage" ImageUrl='<%# Eval("Link") %>' />
                <asp:LinkButton ID="btnLink" runat="server" CommandArgument='<%# Eval("IdTree") %>' CommandName="Click" Text='<%# Eval("NameTree") %>'></asp:LinkButton>
            </div>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
