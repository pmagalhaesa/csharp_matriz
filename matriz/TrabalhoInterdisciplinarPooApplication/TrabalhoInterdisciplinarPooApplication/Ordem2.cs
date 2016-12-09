using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterdisciplinarPooApplication
{
    class Ordem2 : Matriz
    {
        public Ordem2(int[,] matrizParametro, int ordem) : base(matrizParametro, ordem){}

        public override int resolverMatriz()
        {
            // Matriz 
            int [,] matriz = this.getArrayMatriz();

            
            // Montando diagonal principal
            int diagonalPrincipal = matriz[0,0] * matriz[1,1];

             // Montando diagonal secundaria
            int diagonalSecundaria = matriz[0,1] * matriz[1,0];

            return this.diferencaEntreDiagonais(diagonalPrincipal, diagonalSecundaria);
        }
    }
}
