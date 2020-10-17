using SistemaVendas.Uteis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class RelatorioModel
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

    }

    public class GraficoProdutos
    {
        public decimal QtdVendido { get; set; }
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }

        public List<GraficoProdutos> RetornarGrafico()
        {
            DAL objDAL = new DAL();
            string sql = "SELECT SUM(IV.qtde_produto) as Quantidade, P.nome as NomeProduto FROM itens_venda IV INNER JOIN produto P ON (IV.Produto_ID = P.ID) GROUP BY P.nome;";
            DataTable dataTable = objDAL.RetornaDataTable(sql);

            List<GraficoProdutos> lista = new List<GraficoProdutos>();
            GraficoProdutos item;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                

                item = new GraficoProdutos
                {
                    QtdVendido = decimal.Parse(dataTable.Rows[i]["Quantidade"].ToString()),
                    DescricaoProduto = dataTable.Rows[i]["NomeProduto"].ToString()

                };

                lista.Add(item);


            }

            return lista;

        }
    }
}
