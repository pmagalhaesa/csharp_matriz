using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterdisciplinarPooApplication
{
    class InvalidOrdemException : Exception 
    {
        private const string mensagem = "Para gerar a matriz é necessário que o campo 'Ordem da matriz' seja preenchido!";

        public InvalidOrdemException(): base(mensagem){}
        public InvalidOrdemException(String msg) : base(msg) { }
    }
}
