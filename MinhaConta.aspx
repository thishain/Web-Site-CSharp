<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="MinhaConta.aspx.cs" Inherits="Projeto_Diogenes.MinhaConta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-wrap">
        <div class="row">
            <div class="col-4">
                <div class="minhaconta">
                    <div style="padding: 30px;" class="border margin-top-60">
                        <h1 style="text-align: center;">Meus Dados </h1>
                        <br />  
                        <label>NOME</label>
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                        <label>Email</label>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <label>Login</label>
                        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                        <div style="text-align:center;margin-top: 20px;"><asp:Label ID="Mensagem" runat="server"></asp:Label></div>

                        <div style="text-align: center; padding-top: 50px; padding: 5px;">
                            <asp:Button CssClass="botao-editar" OnClick="btnEditar_Click" ID="btnEditar" runat="server" Text="Editar" />

                            <asp:Button CssClass="botao-inserir" ID="btnSalvar" OnClick="btnSalvar_Click" runat="server" Text="Salvar" Visible="false" />
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
