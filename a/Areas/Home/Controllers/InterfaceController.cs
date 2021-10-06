using Serviçoa.Cadastros;
using Serviçoa.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace a.Areas.Home.Controllers
{
    public class InterfaceController : Controller
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        private CategoriaServico categoriaServico = new CategoriaServico();
        // GET: Home/Interface
        public ActionResult Index()
        {
            return View();
        }
    }
}