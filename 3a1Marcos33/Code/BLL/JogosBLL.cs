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
    class JogosBLL
    {
        AcessoBancoDados obj_conexao = new AcessoBancoDados();
        //O método inserir recebe os dados via DTO
        public void inserir(JogosDTO jogosDTO)
        {
            obj_conexao.Conectar();
            obj_conexao.ExecutarComando($"INSERT INTO jogos VALUES(NULL, '{jogosDTO.Nome}','{jogosDTO.Preco}',  {jogosDTO.Estoque}, '{jogosDTO.Datalancamento}')");
        }

        public void alterar(JogosDTO jogosDTO)
        {
            obj_conexao.Conectar();
            obj_conexao.ExecutarComando($"UPDATE jogos SET nome = '{jogosDTO.Nome}',data_lancamento = '{jogosDTO.Datalancamento}',preco = '{jogosDTO.Preco}', estoque = {jogosDTO.Estoque} WHERE id = {jogosDTO.Id}");
        }

        public void excluir(JogosDTO jogosDTO)
        {
            obj_conexao.Conectar();
            obj_conexao.ExecutarComando($"DELETE FROM jogos WHERE id = {jogosDTO.Id}");
        }

        public DataTable listar()
        {
            obj_conexao.Conectar();
            string sql = "SELECT * FROM jogos";
            return obj_conexao.ExecutarConsulta(sql);
        }
    }
}
