using Modeloa.Cadastros;
using Modeloa.Tabelas;
using Serviçoa.Cadastros;
using Serviçoa.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace a.Areas.Home.Controllers
{
    public class InterfaceController : Controller
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        private CategoriaServico categoriaServico = new CategoriaServico();
        // GET: Home/Interface
        public FileContentResult GetLogotipo(long id)
        {
            Produto produto = produtoServico.ObterProdutoPorId(id);
            if (produto != null)
            {
                return File(produto.Logotipo, produto.LogotipoMimeType);
            }
            return null;
        }
        private ActionResult ObterVisaoProdutoPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = produtoServico.ObterProdutoPorId((long)id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }
        private ActionResult ObterVisaoCategoriaPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = categoriaServico.ObterCategoriaPorId((long)id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        public ActionResult Index()
        {
            return View(produtoServico.ObterProdutosClassificadosPorNome());
        }
        public ActionResult DetailsProduto(long? id)
        {
            return ObterVisaoProdutoPorId(id);
        }
        public ActionResult DetailsCategoria(long? id)
        {
            return ObterVisaoCategoriaPorId(id);
        }
    }
}