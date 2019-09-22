using Sebrae.Models;
using Sebrae.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sebrae.DAL
{
    public class PessoaJuridicaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static List<PessoaJuridica> CarregarUsuario(long teste)
        {
            return ctx.PESSOA_JURIDICA.Where(x => x.CPF_CNPJ == teste).ToList();
        }
    }
}