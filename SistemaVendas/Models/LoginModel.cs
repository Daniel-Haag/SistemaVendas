using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SistemaVendas.Uteis;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class LoginModel
    {
        //Variáveis criadas para definir ID e Nome do usuário na atual sessão.
        public string Id { get; set; }

        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do usuário!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O e-mail informado é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário!")]
        public string Senha { get; set; }
        
        public bool ValidarLogin()
        {
            string sql = $"SELECT * FROM Vendedor WHERE Email = '{Email}' AND Senha = '{Senha}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetornaDataTable(sql);

            if (dt.Rows.Count >= 1)
            {
                //A consulta acima retorna apenas uma linha de registro, e logo abaixo, as variáveis deste modelo são
                //atribuidas com os respectivos dados.
                Id = dt.Rows[0]["ID"].ToString();
                Nome = dt.Rows[0]["NOME"].ToString();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
