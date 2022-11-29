using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Diogenes.App_Code
{
    public class AppSettings
    {
        //String de conexão com o banco de dados ACESS
        //https://www.connectionstrings.com/
        public static string ConexaoBD()
        {
            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/ADS2022T.accdb") + ";Persist Security Info=False;";
        }
    }
}