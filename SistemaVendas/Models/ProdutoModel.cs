using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Uteis;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace SistemaVendas.Models
{
    public class ProdutoModel
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "Informe o nome do produto.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Informe a descrição do produto.")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Informe o preço unitário do produto.")]
        public string preco_unitario { get; set; }
        [Required(ErrorMessage = "Informe a quantidade em estoque do produto.")]
        public string quantidade_estoque { get; set; }
        [Required(ErrorMessage = "Informe a unidade de medida do produto.")]
        public string unidade_medida { get; set; }
        [Required(ErrorMessage = "Informe o link da foto do produto.")]
        public string link_foto { get; set; }

        public List<ProdutoModel> ListagemDeProdutos()
        {
            List<ProdutoModel> Lista = new List<ProdutoModel>();
            ProdutoModel item;
            var sql = "SELECT ID, Nome, Descricao, Preco_Unitario, Quantidade_Estoque, Unidade_Medida, Link_Foto FROM Produto";
            DAL objDAL = new DAL();
            DataTable datatable = objDAL.RetornaDataTable(sql);

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                item = new ProdutoModel
                {
                    ID = datatable.Rows[i]["ID"].ToString(),
                    nome = datatable.Rows[i]["nome"].ToString(),
                    descricao = datatable.Rows[i]["descricao"].ToString(),
                    preco_unitario = datatable.Rows[i]["preco_unitario"].ToString(),
                    quantidade_estoque = datatable.Rows[i]["quantidade_estoque"].ToString(),
                    unidade_medida = datatable.Rows[i]["unidade_medida"].ToString(),
                    link_foto = datatable.Rows[i]["link_foto"].ToString()
                };

                Lista.Add(item);

            }
            return Lista;
        }

        public ProdutoModel RetornarProduto(int? ID)
        {
            ProdutoModel item = new ProdutoModel();
            var sql = "SELECT * FROM Produto";
            DAL objDAL = new DAL();
            DataTable dataTable = objDAL.RetornaDataTable(sql);

            item.ID = dataTable.Rows[0]["ID"].ToString();
            item.nome = dataTable.Rows[0]["nome"].ToString();
            item.descricao = dataTable.Rows[0]["descricao"].ToString();
            item.preco_unitario = dataTable.Rows[0]["preco_unitario"].ToString();
            item.quantidade_estoque = dataTable.Rows[0]["quantidade_estoque"].ToString();
            item.unidade_medida = dataTable.Rows[0]["unidade_medida"].ToString();
            item.link_foto = dataTable.Rows[0]["link_foto"].ToString();

            return item;
        }

        public void Cadastrar()
        {
            DAL objDAL = new DAL();

            string sql = $"INSERT INTO Produto(nome, descricao, preco_unitario, quantidade_estoque, unidade_medida, link_foto)" +
                $"VALUES('{nome}','{descricao}','{preco_unitario}','{quantidade_estoque}','{unidade_medida}','{link_foto}')";

            objDAL.ExecutarComandoSQL(sql);
        }

        public void Editar(ProdutoModel produto)
        {
            DAL objDAL = new DAL();
            string sql = $"UPDATE Produto SET nome = '{produto.nome}'," +
                                           $" descricao = '{produto.descricao}', " +
                                           $" preco_unitario = '{produto.preco_unitario}', " +
                                           $" quantidade_estoque = '{produto.quantidade_estoque}'," +
                                           $" unidade_medida = '{produto.unidade_medida}', " +
                                           $" link_foto = '{produto.link_foto}' " +
                                           $" WHERE ID = '{produto.ID}'";

            objDAL.ExecutarComandoSQL(sql);
        }

        public void Excluir(int ID)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM Produto WHERE ID = '{ID}'";

            objDAL.ExecutarComandoSQL(sql);
        }

    }
}

