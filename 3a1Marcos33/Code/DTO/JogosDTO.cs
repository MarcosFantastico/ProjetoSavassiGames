using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3a1Marcos33.Code.DTO
{
    class JogosDTO
    {
        private int _id, _estoque;
        private string _preco;
        private string _nome, _datalancamento;

        public int Id { get => _id; set => _id = value; }
        public int Estoque { get => _estoque; set => _estoque = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Datalancamento { get => _datalancamento; set => _datalancamento = value; }
        public string Preco { get => _preco; set => _preco = value; }
    }
}
