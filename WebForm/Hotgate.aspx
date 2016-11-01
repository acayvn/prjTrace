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
                <img height="50" width="50" src='<%# Eval("Link") %>' />
                <a href="#" class="textModule"><%#  Eval("NameTree") %></a>
            </div>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
