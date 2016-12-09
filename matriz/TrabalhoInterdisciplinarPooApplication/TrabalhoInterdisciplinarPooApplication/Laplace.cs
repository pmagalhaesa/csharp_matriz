using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterdisciplinarPooApplication
{
    class Laplace : Matriz
    {
        public Laplace(int[,] matrizParametro, int ordem) : base(matrizParametro, ordem){}

        // Utilizamos a TERCEIRA COLUNA
        public override int resolverMatriz()
        {
            int[,] matriz = this.getArrayMatriz();

            // Objeto Sarrus, vamos utilizar sarrus ja que ele resolve matriz de ordem 3
             Sarrus resolveOrdem3;

            // COFATOR 1,3
            int a13 = matriz[0,2] * (int)Math.Pow(-1, (1+3));

            resolveOrdem3 = new Sarrus(this.montaMatriz(0,2,3), 3); 
            a13 *= resolveOrdem3.resolverMatriz();


            // COFATOR 2,3
            int a23 = matriz[1, 2] * (int)Math.Pow(-1, (2 + 3));

            resolveOrdem3 = new Sarrus(this.montaMatriz(1, 2, 3), 3); 
            a23 *= resolveOrdem3.resolverMatriz();

            // COFATOR 3,3
            int a33 = matriz[2, 2] * (int)Math.Pow(-1, (3 + 3));

            resolveOrdem3 = new Sarrus(this.montaMatriz(2, 2, 3), 3); 
            a33 *= resolveOrdem3.resolverMatriz();

            // COFATOR 4,3
            int a43 = matriz[3, 2] * (int)Math.Pow(-1, (4 + 3));

            resolveOrdem3 = new Sarrus(this.montaMatriz(0, 2, 3), 3); 
            a43 *= resolveOrdem3.resolverMatriz();

           return a13 + a23 + a33 + a43;
            
        }

        protected override int[,] montaMatriz(int linha, int coluna, int ordem)
        {
            return base.montaMatriz(linha, coluna, ordem);
        }
    }
}
