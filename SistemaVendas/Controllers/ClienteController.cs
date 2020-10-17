using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class ClienteController : Controller
    {
        /// <summary>
        /// IActionResult usado para retornar a View Index.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ClienteModel clienteModel = new ClienteModel();
            ViewBag.ListaClientes = clienteModel.ListarTodosClientes();
            
            return View();
        }

        /// <summary>
        /// IActionResult usado para retornar a View Cadastro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //HttpGet está aqui para renderizar a tela de cadastro.
        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            if (id != null)
            {
                //Carregando o registro do cliente em uma ViewBag
                ViewBag.Cliente = new ClienteModel().RetornarCliente(id);
            }

            return View();
        }

        /// <summary>
        /// IActionResult usado para receber os dados do formulário via POST,
        /// caso os dados estejam conformes, os dados serão cadastrados, e a tela será redirecionada para a Index,
        /// caso os dados não estiverem conformes, o retorno será apenas a View Cadastro.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        //HttpPost está aqui para receber os dados do formulário via POST
        [HttpPost]
        public IActionResult Cadastro(ClienteModel cliente)
        {
            //Validando se os dados são consistentes no controller
            if (ModelState.IsValid)
            {
                cliente.Cadastrar();
                return RedirectToAction("Index");
            }
            return View();
        }

        /// <summary>
        /// IActionResult usada para retornar a View Excluir.(Tela de exclusão.)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Excluir(int id)
        {
            ViewData["IDExcluir"] = id;
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ExcluirCliente(int id)
        {
            new ClienteModel().Excluir(id);
            return View();
        }
    }
}