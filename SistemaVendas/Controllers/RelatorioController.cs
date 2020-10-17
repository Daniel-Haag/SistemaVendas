using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class RelatorioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RelatorioVendas()
        {
            List<VendaModel> listaVendas = new VendaModel().ListaVendas(null, null, false);
            ViewBag.listaVendas = listaVendas;

            return View();
        }

        [HttpPost]
        public IActionResult RelatorioVendas(RelatorioModel relatorio)
        {
            List<VendaModel> listaVendas = new VendaModel().ListaVendas(relatorio.DataInicio, relatorio.DataFim, false);
            ViewBag.listaVendas = listaVendas;

            return View();
        }

        [HttpGet]
        public IActionResult Grafico()
        {
            List<GraficoProdutos> lista = new GraficoProdutos().RetornarGrafico();
            string valores = string.Empty;
            string labels = string.Empty;
            string cores = string.Empty;

            var random = new Random();

            //Percorre a lista de itens para compor o gráfico.
            for (int i = 0; i < lista.Count; i++)
            {
                valores += lista[i].QtdVendido.ToString() + ",";
                labels += "'" + lista[i].DescricaoProduto.ToString() + "',";
                //Escolher aleatoriamente as cores para compor as partes do grafico tipo torta
                cores += "'" + string.Format("#{0:X6}", random.Next(0x1000000)) +"',";
            }

            ViewBag.Valores = valores;
            ViewBag.Labels = labels;
            ViewBag.Cores = cores;

            return View();
        }
    }
}