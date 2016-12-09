using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterdisciplinarPooApplication
{
    class Sarrus : Matriz
    {
        public Sarrus(int[,] matrizParametro, int ordem) : base(matrizParametro, ordem)
        {
  
        }


        public override int resolverMatriz()
        { 
            int [,] matriz = this.getArrayMatriz();

            // Montando diagonal principal
            int diagonalPrincipal = ( matriz[0, 0] * matriz[1, 1] * matriz[2, 2] ) + ( matriz[0, 1] * matriz[1, 2] * matriz[2, 0] ) + (matriz[0, 2]*matriz[1, 0] *matriz[2, 1]);
            

             // Montando diagonal secundaria
            int diagonalSecundaria = (matriz[0, 1]* matriz[1, 0] * matriz[2, 2]) + (matriz[0, 0] * matriz[1, 2] * matriz[2, 1] ) + ( matriz[0, 2] * matriz[1, 1] * matriz[2, 0]);

            return this.diferencaEntreDiagonais(diagonalPrincipal, diagonalSecundaria);
        
        }
    }
}
