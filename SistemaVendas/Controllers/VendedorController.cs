using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class VendedorController : Controller
    {
        /// <summary>
        /// IActionResult usado para retornar a View Index.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ViewBag.ListaVendedores = new VendedorModel().ListarTodosVendedores();
            return View();
        }

        /// <summary>
        /// IActionResult do tipo HttpGet usado para retornar a View Cadastro.
        /// </summary>
        /// <returns></returns>
        //HttpGet definido aqui para renderizar a tela de cadastro.
        [HttpGet]
        public IActionResult Cadastro(int? ID)
        {
            if(ID != null)
            {
                ViewBag.Vendedor = new VendedorModel().RetornarVendedor(ID);
            }
            return View();
        }

        /// <summary>
        /// IActionResult do tipo HttpPost usado para retornar a View Cadastro e consequentemente,
        /// cadastrar o que foi digitado pelo usuário.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastro(VendedorModel vendedor)
        {

            if (ModelState.IsValid)
            {
                //VendedorModel vendedorModel = new VendedorModel();
                vendedor.CadastrarVendedor(vendedor);
                RedirectToAction("Index");
            }
            else
            {
                return View();
            }

            return View();
        }

        public IActionResult Excluir(int ID)
        {
            VendedorModel vendedorModel = new VendedorModel();
            vendedorModel.ExcluirVendedor(ID);
            return View();
        }

        public IActionResult ExcluirVendedor(int ID)
        {
            ViewBag.VendedorID = ID;            
            return View();
        }

    }
}