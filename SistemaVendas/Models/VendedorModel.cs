using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Uteis;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class VendedorModel
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "Informe o nome do vendedor.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Informe o E-mail do cliente.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O E-mail informado é inválido!")]
        public string email { get; set; }
        public string senha { get; set; }

        public List<VendedorModel> ListarTodosVendedores()
        {
            //Lista dos vendedores.
            List<VendedorModel> lista = new List<VendedorModel>();
            //Objeto deste modelo que será usado para preencher a lista, item por item.
            VendedorModel item;
            //Objeto de conexão com o banco de dados.
            DAL objDAL = new DAL();
            //Comando SQL que retorna a lista.
            string sql = "SELECT ID, nome, email, senha FROM Vendedor ORDER BY nome asc";
            //Através do objeto de conexão com o banco de dados, retornar o resultado do comando SQL convertido em uma tabela de memória. 
            DataTable dataTable = objDAL.RetornaDataTable(sql);

            //Usando a contagem de linhas contidas no dataTable para iniciar o laço de repetição.
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                item = new VendedorModel
                {
                    ID = dataTable.Rows[i]["ID"].ToString(),
                    nome = dataTable.Rows[i]["nome"].ToString(),
                    email = dataTable.Rows[i]["email"].ToString(),
                    senha = dataTable.Rows[i]["senha"].ToString()
                };

                lista.Add(item);
            }

            return lista;
        }

        public VendedorModel RetornarVendedor(int? ID)
        {
            VendedorModel vendedor;
            DAL objDAL = new DAL();
            string sql = $"SELECT * FROM Vendedor WHERE ID = {ID}";
            DataTable dataTable = objDAL.RetornaDataTable(sql);

            vendedor = new VendedorModel
            {
                ID = dataTable.Rows[0]["ID"].ToString(),
                nome = dataTable.Rows[0]["nome"].ToString(),
                email = dataTable.Rows[0]["email"].ToString(),
                senha = dataTable.Rows[0]["senha"].ToString(),
            };

            return vendedor;
        }

        public void CadastrarVendedor(VendedorModel vendedor)
        {
            DAL objDal = new DAL();
            string sql = string.Empty;

            if (vendedor.ID != null)
            {
                sql = $"UPDATE Vendedor SET nome = '{nome}', email = '{email}', senha = '{senha}' WHERE ID = '{ID}'";
            }
            else
            {
                sql = $"INSERT INTO Vendedor(nome, email, senha) VALUES ('{nome}', '{email}', '{senha}')";
            }

            objDal.ExecutarComandoSQL(sql);
        }

        public void ExcluirVendedor(int ID)
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

            sql = $"DELETE FROM Vendedor WHERE ID = '{ID}'";

            objDAL.ExecutarComandoSQL(sql);
        }

    }
}

