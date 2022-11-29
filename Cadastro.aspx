<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto_Diogenes.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-4">
            <div class="box border content-wrap" style="margin-top: 30%;color:#fff;">
                <div class="cadastro">
                    <h1>Cadastro</h1>
                    <br />
                    <br />
                    <br />
                    <label style="letter-spacing: 1px;">NOME</label>
                    <asp:TextBox ID="Nome" runat="server" placeholder="Digite seu nome"></asp:TextBox>
                    <label style="letter-spacing: 1px;">LOGIN</label>
                    <asp:TextBox ID="NomeAcesso" runat="server" placeholder="Digite seu login"></asp:TextBox>
                    <label style="letter-spacing: 1px;">EMAIL</label>
                    <asp:TextBox ID="Email" runat="server" placeholder="Digite seu email"></asp:TextBox>
                    <label style="letter-spacing: 1px;">SENHA</label>
                    <asp:TextBox ID="Senha" TextMode="Password" runat="server" placeholder="Digite sua senha"></asp:TextBox>
                    <label style="letter-spacing: 1px;">REPETIR SENHA</label>
                    <asp:TextBox ID="repSenha" TextMode="Password" runat="server" placeholder="Repita sua senha"> </asp:TextBox>


                    <div style="text-align: center; margin-top: 15px; letter-spacing: 0.5px;">
                        <asp:Label ID="Mensagem" runat="server">
                        </asp:Label>
                    </div>

                    <div style="text-align: center; margin-top: -20px;">
                        <asp:Button ID="Cadastrar" OnClick="Cadastrar_Click" runat="server" Text="Cadastrar" />
                    </div>

                    <div style="text-align: center; margin-top: 15px; letter-spacing: 0.5px; margin-bottom: -20px;">
                        <asp:Label ID="msgCadastro" runat="server" Text="Já possui cadastro?"></asp:Label>
                        <a runat="server" style="text-decoration: none;" href="~/Login.aspx">LOGIN</a>
                    </div>
                </div>

                <br />
            </div>
        </div>
    </div>
</asp:Content>
