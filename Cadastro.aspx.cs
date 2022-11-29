using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Diogenes
{
    public partial class Cadastro : System.Web.UI.Page
    {
        //PÚBLICA PARA TODOS OS MÉTODOS DESTA CLASSE
        Model.Usuarios usu = new Model.Usuarios();
      

        // INSTANCIA DA CLASSE DE ACESSO AO BANCO DE DADOS
        //DAO = Data Access Object / Acesso ao banco de dados
        DataServices.DataBase.DAO dataBase = new DataServices.DataBase.DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void limpaCampos()
        {
            Nome.Text = "";
            Senha.Text = "";
            repSenha.Text = "";
            NomeAcesso.Text = "";
            Email.Text = "";
            Mensagem.ForeColor = System.Drawing.Color.White;
        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            string comandoSQLnomeAcesso = "SELECT * FROM Usuarios WHERE NomeAcesso='" + NomeAcesso.Text + "';";
            string comandoSQLEmail = "SELECT * FROM Usuarios WHERE Email='" + Email.Text + "';";



            dataBase.ConnectionString = App_Code.AppSettings.ConexaoBD();
            dataBase.DataProviderName = DataServices.DataBase.DAO.ProviderName.OleDb;

            DataTable tb = (DataTable)dataBase.Query(comandoSQLnomeAcesso);
            DataTable tb2 = (DataTable)dataBase.Query(comandoSQLEmail);

            if(Nome.Text.Trim() == "")
            {
                Mensagem.Text = "Digite seu nome por favor!";
                Nome.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;
            }


            else if(NomeAcesso.Text.Trim() == "")
            {
                Mensagem.Text = "Digite seu login por favor!";
                NomeAcesso.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;
            }

            else if (Email.Text.Trim() == "")
            {
                Mensagem.Text = "Digite seu email por favor!";
                Email.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;
            }

            else if (Senha.Text.Trim() == "")
            {
                Mensagem.Text = "Digite sua senha por favor!";
                Senha.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;
            }

            else if (Senha.Text.Trim() != repSenha.Text.Trim())
            {
                Mensagem.Text = "Senhas não são iguais!";
                Senha.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;
            }


            else
            {
                if (tb.Rows.Count == 1)
                {
                    Mensagem.Text = "Já possui alguém cadastrado com esse login!";
                    Mensagem.ForeColor = System.Drawing.Color.Red;
                    NomeAcesso.Text = "";
                    NomeAcesso.Focus();
                }
                else if (tb2.Rows.Count == 1)
                {
                    Mensagem.Text = "Já possui alguém cadastrado com esse email!";
                    Mensagem.ForeColor = System.Drawing.Color.Red;
                    Email.Text = "";
                    Email.Focus();
                }
                else
                {
                    usu.Nome = Nome.Text;
                    usu.Email = Email.Text;
                    usu.NomeAcesso = NomeAcesso.Text;
                    usu.Senha = Senha.Text;
                    dataBase.Insert(usu, "UsuarioId");
                    Mensagem.Text = "Usuário Cadastrado!";
                    limpaCampos();
                    Mensagem.ForeColor = System.Drawing.Color.Green;

                }
            }

            
        }
    }
}