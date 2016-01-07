<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Novo.aspx.cs" Inherits="CRUD.Web.Apartamentos.Novo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CpfConteudo" runat="server">
    <h2>Novo Apartamento</h2>
    <p>Número:<asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
    </p>
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
        <asp:Button ID="btnNovo" runat="server" OnClick="btnNovo_Click" Text="Novo" />
    </p>
    <p>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </p>
</asp:Content>
