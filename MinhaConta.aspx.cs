using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Diogenes
{
    public partial class MinhaConta : System.Web.UI.Page
    {
        DataServices.DataBase.DAO dataBase = new DataServices.DataBase.DAO();
        Model.Usuarios usu = new Model.Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        { 
            if(!IsPostBack)
            {
                ExibeUsuarios();
                txtNome.Enabled = false;
                txtLogin.Enabled = false;
                txtEmail.Enabled = false;
            }
            
        }

        protected void ExibeUsuarios()
        {
            if (Session["UsuarioId"] != null)
            {
                Mensagem.Text = "";
                btnEditar.Visible = true;
                

                string comando = "SELECT * FROM Usuarios WHERE UsuarioId=" + Session["UsuarioId"].ToString() + ";";
                //1. DEFINIR A CONEXÃO
                dataBase.ConnectionString = App_Code.AppSettings.ConexaoBD();
                //2. DEFINIR O BANCO DE DADOS
                dataBase.DataProviderName = DataServices.DataBase.DAO.ProviderName.OleDb;

                DataTable tb = (DataTable)dataBase.Query(comando);

                txtNome.Text = tb.Rows[0]["Nome"].ToString();
                txtEmail.Text = tb.Rows[0]["Email"].ToString();
                txtLogin.Text = tb.Rows[0]["NomeAcesso"].ToString();
            }
            else
            {
                Mensagem.Text = "Usuário não logado!";
                btnEditar.Visible = false;
            }

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            btnSalvar.Visible = true;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtEmail.Enabled = true;
            btnEditar.Visible = false;
            limpaMensagem();

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Trim() == "")
            {
                Mensagem.Text = "Digite seu nome por favor!";
                txtNome.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;
            }

            else if (txtLogin.Text.Trim() == "")
            {
                Mensagem.Text = "Digite seu login por favor!";
                txtLogin.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;
            }

            else if (txtEmail.Text.Trim() == "")
            {
                Mensagem.Text = "Digite seu email por favor!";
                txtEmail.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;
            }
            else if (!PossoGravarEmail(txtEmail.Text, Session["UsuarioId"].ToString()))
            {
                Mensagem.Text = "Já possui alguém cadastrado com esse email!";
                txtEmail.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;

            }
            else if (!PossoGravarNome(txtLogin.Text, Session["UsuarioId"].ToString()))
            {
                Mensagem.Text = "Já possui alguém cadastrado com esse login!";
                txtLogin.Focus();
                Mensagem.ForeColor = System.Drawing.Color.Red;

            }

            else
            {
                usu.Nome = txtNome.Text;
                usu.Email = txtEmail.Text;
                usu.NomeAcesso = txtLogin.Text;
                //1. DEFINIR A CONEXÃO
                dataBase.ConnectionString = App_Code.AppSettings.ConexaoBD();
                //2. DEFINIR O BANCO DE DADOS
                dataBase.DataProviderName = DataServices.DataBase.DAO.ProviderName.OleDb;

                dataBase.Update(usu, "UsuarioId", Session["UsuarioId"].ToString());
                Mensagem.ForeColor = System.Drawing.Color.GreenYellow;
                Mensagem.Text = "Dados alterados com sucesso!";
                btnSalvar.Visible = false;
                btnEditar.Visible = true;

            }


        }



        protected bool PossoGravarNome(string nomeAcesso, string id)
        {
            string comando = "SELECT * FROM Usuarios WHERE NomeAcesso='" + nomeAcesso + "';";

            //1. DEFINIR A CONEXÃO
            dataBase.ConnectionString = App_Code.AppSettings.ConexaoBD();
            //2. DEFINIR O BANCO DE DADOS
            dataBase.DataProviderName = DataServices.DataBase.DAO.ProviderName.OleDb;

            DataTable tb = (DataTable)dataBase.Query(comando);

            if (tb.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                if (tb.Rows[0]["UsuarioId"].ToString() == id)
                {
                    //CÓDIGO DA PESSOA
                    return true;
                }
                else
                {
                    //CÓDIGO NÃO É DA PESSOA
                    return false;
                }
            }
        }

        protected bool PossoGravarEmail(string email, string id)
        {
            string comando = "SELECT * FROM Usuarios WHERE Email='" + email + "';";

            //1. DEFINIR A CONEXÃO
            dataBase.ConnectionString = App_Code.AppSettings.ConexaoBD();
            //2. DEFINIR O BANCO DE DADOS
            dataBase.DataProviderName = DataServices.DataBase.DAO.ProviderName.OleDb;

            DataTable tb = (DataTable)dataBase.Query(comando);

            if (tb.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                if (tb.Rows[0]["UsuarioId"].ToString() == id)
                {
                    //CÓDIGO DA PESSOA
                    return true;
                }
                else
                {
                    //CÓDIGO NÃO É DA PESSOA
                    return false;
                }
            }
        }


        private void limpaMensagem()
        {
            Mensagem.Text = "";
        }






    }
}