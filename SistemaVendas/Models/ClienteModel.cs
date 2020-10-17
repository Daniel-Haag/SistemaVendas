﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Uteis;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class ClienteModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do cliente.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o CPF do cliente.")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Informe o E-mail do cliente.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O E-mail informado é invalido!")]
        public string Email { get; set; }
        public string Senha { get; set; }

        public List<ClienteModel> ListarTodosClientes()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            ClienteModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT Id, Nome, cpf_cnpj, Email, Senha FROM Cliente order by nome asc";
            DataTable dt = objDAL.RetornaDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ClienteModel
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    CPF = dt.Rows[i]["cpf_cnpj"].ToString(),
                    Email = dt.Rows[i]["Email"].ToString(),
                    Senha = dt.Rows[i]["Senha"].ToString()
                };

                lista.Add(item);
            }

            return lista;
        }

        public ClienteModel RetornarCliente(int? id)
        {
            ClienteModel item;
            DAL objDAL = new DAL();
            string sql = $"SELECT Id, Nome, cpf_cnpj, Email, Senha FROM Cliente WHERE id = '{id}' order by nome asc";
            DataTable dt = objDAL.RetornaDataTable(sql);

            item = new ClienteModel
            {
                Id = dt.Rows[0]["Id"].ToString(),
                Nome = dt.Rows[0]["Nome"].ToString(),
                CPF = dt.Rows[0]["cpf_cnpj"].ToString(),
                Email = dt.Rows[0]["Email"].ToString(),
                Senha = dt.Rows[0]["Senha"].ToString()
            };

            return item;
        }


        //Insert ou Update
        public void Cadastrar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

            if (Id != null)
            {
                sql = $"UPDATE CLIENTE SET NOME = '{Nome}', CPF_CNPJ = '{CPF}', EMAIL = '{Email}' WHERE ID = '{Id}'";
            }
            else
            {
                sql = $"INSERT INTO CLIENTE(NOME, CPF_CNPJ, EMAIL, SENHA) VALUES('{Nome}', '{CPF}', '{Email}', '123456')";
            }
            objDAL.ExecutarComandoSQL(sql);
        }

        //Delete
        public void Excluir(int id)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM CLIENTE WHERE ID = '{id}'";
            objDAL.ExecutarComandoSQL(sql);

        }


    }
}
