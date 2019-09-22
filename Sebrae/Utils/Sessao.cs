using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sebrae.Utils
{
    public class Sessao
    {
        private static string Usuario = "ID";
        private static string UsuarioRazao = "RAZAO";

        public static string Login(long login)
        {
            HttpContext.Current.Session[Usuario] = login;
            return HttpContext.Current.Session[Usuario].ToString();
        }

        public static string RetornarUsuario()
        {
            if (HttpContext.Current.Session[Usuario] == null)
            {
                return null;
            }
            return HttpContext.Current.Session[Usuario].ToString();
        }
        public static string Razao(string razao)
        {
            HttpContext.Current.Session[UsuarioRazao] = razao;
            return HttpContext.Current.Session[UsuarioRazao].ToString();
        }
        public static string RetornaRazao()
        {
            if (HttpContext.Current.Session[UsuarioRazao] == null)
            {
                return null;
            }
            return HttpContext.Current.Session[UsuarioRazao].ToString();
        }

    }
}