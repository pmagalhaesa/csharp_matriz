using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterdisciplinarPooApplication
{
    class InvalidOrdemIntervaloException : Exception 
    {
        private const string mensagem = "A ordem da matrizs deve estar no intervalo de 1 a 4 !";

        public InvalidOrdemIntervaloException(): base(mensagem){}
        public InvalidOrdemIntervaloException(String msg) : base(msg) { }
    }
}
