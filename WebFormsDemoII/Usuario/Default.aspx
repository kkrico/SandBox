<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsDemoII.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <div class="row">
        <div class="col-sm-12">
            <div class="page-header">
                <div class="btn-toolbar pull-right">
                    <div class="btn-group">
                        <asp:HyperLink runat="server" CssClass="btn btn-primary" NavigateUrl="~/Usuario/NovoUsuario.aspx">Novo</asp:HyperLink>
                    </div>
                </div>
                <h1>Usuário <small>Todos os usuários cadastrados</small>
                </h1>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-sm-12">
            <asp:GridView runat="server" ID="gvListaUsuarios" AutoGenerateColumns="False"
                OnRowDataBound="gvListaUsuarios_OnRowDataBound" EmptyDataText="Nenhum usuário cadastrado" CssClass="table table-striped table-responsive table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Setor" HeaderText="Setor do Usuário" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="linkDetalhar" runat="server" CausesValidation="false" CommandName=""
                                Text="Detalhar" OnClick="linkDetalhar_OnClick" CommandArgument='<%#Eval("IdUsuario") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
