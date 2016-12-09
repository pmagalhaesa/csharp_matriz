using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterdisciplinarPooApplication
{
    class Ordem1 : Matriz
    {
        public Ordem1(int[,] matrizParametro, int ordem) : base(matrizParametro, ordem){}
        
        // Basta apenas retornar o proprio elemento, como so tem uma posicao retorna linha e coluna 0
        public override int resolverMatriz()
        {
            return this.getArrayMatriz()[0, 0];
        }
    }
}
