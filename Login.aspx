<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto_Diogenes.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-4">
            <div class="box border content-wrap" style="margin-top: 50%;color:#fff;">
                <div class="login">
                    <h1>Entrar</h1>
                    <br />
                    <br />
                    <br />
                    <label style="letter-spacing: 1px;">LOGIN</label>
                    <asp:TextBox ID="NomeAcesso" runat="server" placeholder="Digite seu login"></asp:TextBox>
                    <label style="letter-spacing: 1px;">SENHA</label>
                    <asp:TextBox ID="Senha" TextMode="Password" runat="server" placeholder="Digite sua senha"></asp:TextBox>


                    <div style="text-align: center; margin-top: 15px; letter-spacing: 0.5px;">
                        <asp:Label ID="Mensagem" runat="server">
                        </asp:Label>
                    </div>

                    <div style="text-align: center; margin-top: -20px;">
                        <asp:Button ID="Entrar" OnClick="Entrar_Click" runat="server" Text="Entrar" />
                    </div>

                    <div style="text-align: center; margin-top: 15px; letter-spacing: 0.5px; margin-bottom: -20px;">
                        <asp:Label runat="server" ID="msgCadastro" Text="Não possui cadastro?"></asp:Label>
                        <a runat="server" id="Cadastro" style="text-decoration: none;" href="~/Cadastro.aspx">CADASTRE-SE</a>
                    </div>
                </div>

                <br />
            </div>
        </div>
    </div>
</asp:Content>
