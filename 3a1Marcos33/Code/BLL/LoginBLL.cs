using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3a1Marcos33.Code.DAL;
using _3a1Marcos33.Code.DTO;
using System.Data;
namespace _3a1Marcos33.Code.BLL
{
    class LoginBLL
    {
        AcessoBancoDados obj_conexao = new AcessoBancoDados();

        public bool realizarLogin(LoginDTO logindto)
        {
            obj_conexao.Conectar();
            string sql = $"SELECT * FROM login WHERE login.email = '{logindto.Email}' AND login.senha = '{logindto.Senha}'; ";
            DataTable result = obj_conexao.ExecutarConsulta(sql);

            if (result.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        }
    }
