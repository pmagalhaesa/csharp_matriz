using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterdisciplinarPooApplication
{
    class InvalidMatrizValorException : Exception 
    {
        private const string mensagem = "Para calcular a determinante é necessário preencher todos os campos da matriz!";

        public InvalidMatrizValorException(): base(mensagem){}
        public InvalidMatrizValorException(String msg) : base(msg) { }
    }
}
