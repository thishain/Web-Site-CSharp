using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Diogenes
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAR OS DADOS
                if (NomeCompleto.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite seu nome";
                    NomeCompleto.Focus();
                }
                else if (SeuEmail.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite seu e-mail";
                    SeuEmail.Focus();
                }
                else if (Mensagem.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite a mensagem";
                    Mensagem.Focus();
                }
                else
                {
                    // ENVIAR O E-MAIL

                    // 1. MONTAR O PACOTE DO EMAIL
                    MailMessage email = new MailMessage();
                    email.To.Add("contato@seudominio.com.br");
                    MailAddress from = new MailAddress("contato@seudominio.com.br");
                    email.From = from;
                    email.Subject = "Email enviado pelo form de contato";
                    email.Body = "Dados enviados\n";
                    email.Body += "Nome: " + NomeCompleto.Text + "\n";
                    email.Body += "Email: " + SeuEmail.Text + "\n";
                    email.Body += "Mensagem: " + Mensagem.Text + "\n";
                    email.IsBodyHtml = false;

                    // 2. ENVIAR O EMAIL
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.seudominio.com.br";
                    smtp.Credentials = new System.Net.NetworkCredential("contato@seudominio.com", "suasenha");
                    smtp.EnableSsl = true;
                    smtp.Send(email);

                }

            }
            catch (Exception ex)
            {
                // SE HOUVER FALHA O SISTEMA É DIRECIONADO PARA CÁ.
                MensagemErro.Text = "Houve uma falha ao tentar enviar o e-mail";

            }
        }
    }
}