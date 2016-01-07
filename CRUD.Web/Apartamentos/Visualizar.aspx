<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Visualizar.aspx.cs" Inherits="CRUD.Web.Apartamentos.Visualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CpfConteudo" runat="server">
    <h2>Visualizar o Apartamento <asp:Label ID="lblNumero" runat="server"></asp:Label></h2>
    <p>Andar:<asp:Label ID="lblAndar" runat="server"></asp:Label>
    </p>
    <p>Proprietário:<asp:Label ID="lblDono" runat="server"></asp:Label>
    </p>
    <p>Área:<asp:Label ID="lblArea" runat="server"></asp:Label>
    </p>
    <p>Vagas na Garagem:<asp:Label ID="lblVagas" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
        <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click" Text="Excluir" />
    </p>
</asp:Content>
