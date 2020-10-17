using SistemaVendas.Uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;

namespace SistemaVendas.Models
{
    public class VendaModel
    {
        public string ID { get; set; }
        public string data { get; set; }
        public decimal total { get; set; }
        public string vendedorID { get; set; }
        public string vendedor { get; set; }
        public string clienteID { get; set; }
        public string cliente { get; set; }
        public string ListaProdutosJSON { get; set; }

        public List<VendaModel> ListaVendas(DateTime? dataInicio, DateTime? dataFim, bool apenasListagem)
        {
            {
                List<VendaModel> Lista = new List<VendaModel>();

                VendaModel item;

                var sql = string.Empty;

                if (dataInicio != null && dataFim != null)
                {
                    string dataInicioString = dataInicio.ToString();
                    string dataFimString = dataFim.ToString();

                    string diaInicio = string.Empty;
                    string mesInicio = string.Empty;
                    string anoInicio = string.Empty;

                    string diaFim = string.Empty;
                    string mesFim = string.Empty;
                    string anoFim = string.Empty;

                    string[] arrayDataInicio = dataInicioString.Split("/");
                    string[] arrayDataFim = dataFimString.Split("/");

                    diaInicio = arrayDataInicio[0];
                    mesInicio = arrayDataInicio[1];
                    anoInicio = arrayDataInicio[2].Substring(0,4);

                    diaFim = arrayDataFim[0];
                    mesFim = arrayDataFim[1];
                    anoFim = arrayDataFim[2].Substring(0,4);

                    dataInicioString = (anoInicio + "-" + mesInicio + "-" + diaInicio + " 00:00:00");
                    dataFimString = (anoFim + "-" + mesFim + "-" + diaFim + " 23:59:59");

                    sql = "SELECT " +
                          "venda.ID AS vendaID, " +
                          "venda.data, " +
                          "venda.total, " +
                          "vendedor.nome AS Vendedor, " +
                          "cliente.nome AS Cliente " +
                          "FROM venda " +
                          "INNER JOIN " +
                          "vendedor ON (venda.vendedor_ID = vendedor.ID) " +
                          "INNER JOIN " +
                          "cliente ON (venda.cliente_ID = cliente.ID) " +
                          $"WHERE venda.data between '{dataInicioString}' AND '{dataFimString}' " +
                          "ORDER BY " +
                          "venda.data, " +
                          "venda.total";
                }
                else if(dataInicio == null && dataFim == null && apenasListagem)
                {
                    sql = "SELECT " +
                          "venda.ID AS vendaID, " +
                          "venda.data, " +
                          "venda.total, " +
                          "vendedor.nome AS Vendedor, " +
                          "cliente.nome AS Cliente " +
                          "FROM venda " +
                          "INNER JOIN " +
                          "vendedor ON (venda.vendedor_ID = vendedor.ID) " +
                          "INNER JOIN " +
                          "cliente ON (venda.cliente_ID = cliente.ID) " +
                          "ORDER BY " +
                          "venda.data, " +
                          "venda.total";
                }
                else
                {
                    sql = "SELECT " +
                          "venda.ID AS vendaID, " +
                          "venda.data, " +
                          "venda.total, " +
                          "vendedor.nome AS Vendedor, " +
                          "cliente.nome AS Cliente " +
                          "FROM venda " +
                          "INNER JOIN " +
                          "vendedor ON (venda.vendedor_ID = vendedor.ID) " +
                          "INNER JOIN " +
                          "cliente ON (venda.cliente_ID = cliente.ID) " +
                          $"WHERE venda.data between '111' AND '111' " +
                          "ORDER BY " +
                          "venda.data, " +
                          "venda.total";
                }


                DAL objDAL = new DAL();

                DataTable datatable = objDAL.RetornaDataTable(sql);

                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    item = new VendaModel
                    {
                        ID = datatable.Rows[i]["vendaID"].ToString(),
                        data = datatable.Rows[i]["data"].ToString(),
                        total = Convert.ToDecimal(datatable.Rows[i]["total"]),
                        vendedor = datatable.Rows[i]["Vendedor"].ToString(),
                        cliente = datatable.Rows[i]["Cliente"].ToString(),
                    };

                    Lista.Add(item);

                }
                return Lista;
            }

        }


        public void Inserir()
        {
            DAL objDAL = new DAL();

            string dataVenda = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            //string datavendaComHorario = DateTime.Now.Date

            string sql = "INSERT INTO Venda(data, total, Vendedor_ID, Cliente_ID)" +
                $"VALUES('{dataVenda}', {total.ToString().Replace(",", ".")}, {vendedorID}, {clienteID})";

            objDAL.ExecutarComandoSQL(sql);

            //Obter ID da venda inserida
            sql = $"SELECT ID FROM Venda WHERE data = '{dataVenda}' AND Vendedor_ID = {vendedorID} AND Cliente_ID = {clienteID} limit 1";

            DataTable dataTable = objDAL.RetornaDataTable(sql);
            string vendaID = dataTable.Rows[0]["ID"].ToString();

            //Deserializar o JSON da lista de produtos selecionados e gravá-los na tabela itens_venda
            List<ItemVendaModel> listaProdutos = JsonConvert.DeserializeObject<List<ItemVendaModel>>(ListaProdutosJSON);
            for (int i = 0; i < listaProdutos.Count; i++)
            {
                sql = "INSERT INTO itens_venda(Venda_ID, Produto_ID, qtde_produto, preco_produto)" +
                    $"VALUES({vendaID},{listaProdutos[i].CodigoProduto},{listaProdutos[i].QtdProduto},{listaProdutos[i].PrecoUnitario})";

                objDAL.ExecutarComandoSQL(sql);

            }


        }

    }
}
