<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="CRUD.Web.Apartamentos.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CpfConteudo" runat="server">
    <h2>Listar Apartamentos</h2>
    <asp:Literal ID="litTabela" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:HyperLink ID="lnkNovo" runat="server" NavigateUrl="~/Apartamentos/Novo.aspx">Novo Apartamento</asp:HyperLink>
</asp:Content>
