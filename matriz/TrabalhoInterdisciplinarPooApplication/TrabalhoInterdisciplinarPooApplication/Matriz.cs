using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoInterdisciplinarPooApplication
{
    abstract class Matriz
    {

        public Matriz() { }

        public Matriz(int[,] matrizParametro, int ordem)
        {
            this.arrayMatriz = matrizParametro;
            this.ordem = ordem;
        }

        protected int ordem;

        protected int[,] arrayMatriz;

        public void setOrdem(int ordem)
        {
            this.ordem = ordem;
        }

        public int getOrdem()
        {
            return this.ordem;
        }

        public int[,] getArrayMatriz()
        {
            return this.arrayMatriz;
        }

        public void setArrayMatriz(int[,] arrayMatriz)
        {
            this.arrayMatriz = arrayMatriz;
        }

         // Retorna a Diferença entre diagonal PRINCIPAL - SECUNDARIA
        protected int diferencaEntreDiagonais(int diagonalPrincipal, int diagonalSecundaria)
        {
            return diagonalPrincipal - diagonalSecundaria;
        }
   
        abstract public int resolverMatriz();


        // Metodo que cria uma MATRIZ de ORDEM scom os indices CORRETOS e elimina a LINHA E COLUNA passada no parametro
        protected virtual int[,] montaMatriz(int linha, int coluna, int ordem)
        {
      
            int[,] novaMatriz = new int[ordem, ordem];

            int linhaNovaMatriz = 0;
   
            for (int i = 0; i < this.ordem; i++)
            {
                // verifica se linha é diferente da ignorada se for incrementa
                if (i != linha)
                {
                    int colunaNovaMatriz = 0;

                    for (int j = 0; j < this.ordem; j++)
                    {
                       
                        // Verifica se a coluna pode ser percorrida
                        if (j != coluna)
                        {

                            novaMatriz[linhaNovaMatriz, colunaNovaMatriz] = this.arrayMatriz[i, j];
                            colunaNovaMatriz++;
                        }

                    }
                    linhaNovaMatriz++;
                }
               
               
            }

            return novaMatriz;
        }
    }
}
