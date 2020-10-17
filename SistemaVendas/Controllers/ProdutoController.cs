using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ProdutoModel produtoModel = new ProdutoModel();
            ViewBag.ListaDeProdutos = produtoModel.ListagemDeProdutos();
            return View();
        }


        public IActionResult Cadastro(int? ID)
        {
            if (ID != null)
            {                
                ViewBag.Produto = new ProdutoModel().RetornarProduto(ID);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                if (produto.ID != null)
                {
                    produto.Editar(produto);                    
                }
                else
                {
                    produto.Cadastrar();
                    RedirectToAction("Index");
                }
            }

            return View();
        }

        public IActionResult Excluir(int ID)
        {
            ViewBag.ProdutoID = ID;

            return View();
        }

        public IActionResult ExcluirProduto(int ID)
        {
            ProdutoModel produtoModel = new ProdutoModel();
            produtoModel.Excluir(ID);
            
            return View();
        }

    }
}