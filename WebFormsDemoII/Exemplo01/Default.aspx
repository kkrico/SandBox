<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsDemoII.Exemplo01.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label runat="server" ID="lblNome"></asp:Label>
    <br />
    <asp:TextBox runat="server" ID="txtNome"></asp:TextBox>
    <br />
    <asp:Button runat="server" OnClick="OnClick" Text="Enviar" />
    
    
    <asp:Button runat="server" OnClick="OnClickButton2"/>
</asp:Content>
