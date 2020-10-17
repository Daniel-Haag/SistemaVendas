using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaVendas.Uteis
{
    //Data Access Layer
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "sistema_venda";
        private static string User = "root";
        private static string Password = "1234567";
        private static string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;Charset=utf8;";
        private static MySqlConnection Connection;

        public DAL()
        {            
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }        

        /// <summary>
        /// Espera um parametro do tipo string, contendo um comando SQL do tipo SELECT.
        /// O objeto dataTable é como um container que odemos usar para armazenar informações de praticamente qualquer fonte de dados,
        /// sendo composto por uma coleção de linhas e colunas.
        /// É possível criar um DataTable para armazenar dados em memória e realizar operações para inserir, alterar e excluir.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable RetornaDataTable(string sql)
        {
            //criando objeto DataTable
            DataTable data = new DataTable();

            //Permite buscar dados no banco de dados 
            MySqlCommand Command = new MySqlCommand(sql, Connection);

            //Os dados que serão retornados no objeto Command não são capazes de serem convertidos para dataTable
            //Então é precisa usar o adaptador MySqlDataAdapter
            MySqlDataAdapter da = new MySqlDataAdapter(Command);

            //Método capaz de preencher um dataTable
            da.Fill(data);
            return data;
        }

        //Espera um parametro do tipo string
        //contendo um comando SQL do tipo INSERT, UPDATE, DELETE
        //Método que vai permitir executar Inserts, deletes, e updates
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

    }
}
