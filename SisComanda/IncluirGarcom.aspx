<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IncluirGarcom.aspx.cs" Inherits="SisComanda.IncluirGarcom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formNovoGarcom" runat="server">
        <div class="col-md-6 column">
            <div class="form-group">
                <label for="txtnome">Nome</label>
                <asp:TextBox class="form-control" ID="txtnome" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPreco">CPF</label>
                <asp:TextBox class="form-control" ID="txtPreco" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPreco">Código</label>
                <asp:TextBox class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="BtnIncluir" runat="server" CssClass="btn btn-primary" Text="Incluir" OnClick="BtnIncluir_Click" />
    </form>
</asp:Content>
