using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class VendaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.listaVendas = new VendaModel().ListaVendas(null, null, true);
            return View();
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            ViewBag.listaClientes = new ClienteModel().ListarTodosClientes();
            ViewBag.listaVendedores = new VendedorModel().ListarTodosVendedores();
            ViewBag.listaProdutos = new ProdutoModel().ListagemDeProdutos();
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(VendaModel venda)
        {
            ViewBag.listaClientes = new ClienteModel().ListarTodosClientes();
            ViewBag.listaVendedores = new VendedorModel().ListarTodosVendedores();
            ViewBag.listaProdutos = new ProdutoModel().ListagemDeProdutos();
            venda.Inserir();
            return View();
        }
    }
}