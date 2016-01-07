<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="CRUD.Web.Apartamentos.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CpfConteudo" runat="server">
    <h2>Editar o Apartamento <asp:Label ID="lblNumero" runat="server"></asp:Label></h2>
    <p>Andar:<asp:TextBox ID="txtAndar" runat="server"></asp:TextBox>
    </p>
    <p>Proprietário:<asp:TextBox ID="txtDono" runat="server"></asp:TextBox>
    </p>
    <p>Área:<asp:TextBox ID="txtArea" runat="server"></asp:TextBox>
    </p>
    <p>Vagas na Garagem:<asp:TextBox ID="txtVagas" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
    </p>
    <p>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </p>
</asp:Content>
