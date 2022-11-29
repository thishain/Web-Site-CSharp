using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Diogenes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // INSTANCIA DA CLASSE DE ACESSO AO BANCO DE DADOS
        //DAO = Data Access Object / Acesso ao banco de dados
        DataServices.DataBase.DAO dataBase = new DataServices.DataBase.DAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Entrar_Click(object sender, EventArgs e)
        {
         
            {
                string comandoSQL = "SELECT * FROM Usuarios WHERE NomeAcesso='" + dataBase.Filter(NomeAcesso.Text) + "'AND Senha='" + dataBase.Filter(Senha.Text) + "';";        
                
                dataBase.ConnectionString = App_Code.AppSettings.ConexaoBD();
                dataBase.DataProviderName = DataServices.DataBase.DAO.ProviderName.OleDb;

                DataTable tb = (DataTable)dataBase.Query(comandoSQL);


                if (tb.Rows.Count == 1)
                {
                    // Cria a variavel de sessão para identificar que o usuário esta autenticado e
                    // permitir a exibição das opções do menu.
                    Session["UsuarioId"] = tb.Rows[0]["UsuarioId"].ToString();
                   
                    // 1. Inicializa a classe de autenticação

                    FormsAuthentication.Initialize();
                    // 2. CRIAR O TICKET
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, Session["UsuarioId"].ToString(), DateTime.Now, DateTime.Now.AddMinutes(20), false, FormsAuthentication.FormsCookiePath);

                    // 3. CRIPTOGRAFA P TICKET E GRAVAR NO COOKIE DO NAVEGADOR
                    Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)));

                    // Redireciona para o form que o usuário tentou acessar
                    Response.Redirect(FormsAuthentication.GetRedirectUrl(Session["UsuarioId"].ToString(), false));
                    
                }
                else
                {
                    Mensagem.Text = "Dados de acesso invalidos";
                }
            }
        }
    }
}