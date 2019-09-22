using Sebrae.Models;
using Sebrae.DAL;
using Sebrae.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Sebrae.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(PessoaJuridicaDAO.CarregarUsuario(Convert.ToInt64(Sessao.RetornarUsuario())));
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(PessoaJuridica pj)
        {
            using (Context ctx = new Context())
            {
                var usuario = ctx.PESSOA_JURIDICA.FirstOrDefault(x => x.CPF_CNPJ == pj.CPF_CNPJ);
                if (usuario != null)
                {
                    FormsAuthentication.SetAuthCookie(Convert.ToString(pj.CPF_CNPJ), false);
                    pj = ctx.PESSOA_JURIDICA.FirstOrDefault(x => x.CPF_CNPJ.Equals(pj.CPF_CNPJ));
                    Sessao.Login(pj.CPF_CNPJ);
                    Sessao.Razao(pj.DS_RAZAO);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Usuário ou Senha Inválidos!");
                return View();
            }
        }

        public ActionResult Pontos()
        {
            return View();
        }

        public ActionResult Situacao()
        {
            return View();
        }

        public ActionResult Localizacao()
        {
            return View();
        }
    }
}
