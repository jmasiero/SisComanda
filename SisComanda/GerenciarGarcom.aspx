<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="GerenciarGarcom.aspx.cs" Inherits="SisComanda.GerenciarGarcom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
         <div class="col-lg-6">
             <form runat="server">
                <asp:Button ID="BtnIncluir" runat="server" CssClass="btn btn-primary" Text="Incluir" OnClick="BtnIncluir_Click" />
                 <hr />

             </form>
         </div>
    </div>
</asp:Content>
