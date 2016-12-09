using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoInterdisciplinarPooApplication
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            this.mostraTodosCampos(false);
        }


        private void zerarCampos()
        {
            mskTxtBxResultado.Text = "";
            a11.Text = "";
            a12.Text = "";
            a13.Text = "";
            a14.Text = "";
            a21.Text = "";
            a22.Text = "";
            a23.Text = "";
            a24.Text = "";
            a31.Text = "";
            a32.Text = "";
            a33.Text = "";
            a34.Text = "";
            a41.Text = "";
            a42.Text = "";
            a43.Text = "";
            a44.Text = "";
        }
        
        // Funcao utilizada para zerar todos os campos
        private void definirCampos(string ordem)
        {
            
            this.zerarCampos();

            this.mostraTodosCampos(false);

            try
            {
                this.validaOrdem(ordem);

           
                int ordemConvertida = int.Parse(ordem);

                // Exibindo e escondendo campos
                if (ordemConvertida == 1)
                {
                    this.mostraCamposOrdem1();
                }
                else if (ordemConvertida == 2)
                {
                    this.mostraCamposOrdem2();
                }
                else if (ordemConvertida == 3)
                {
                    this.mostraCamposOrdem3();
                }
                else if (ordemConvertida == 4)
                {
                    this.mostraTodosCampos(true);
                }        

            }
            catch(InvalidOrdemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOrdemIntervaloException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            /*catch (Exception ex3)
            {
                
            }
            */
        }

        // Verifica campo esta vazio e lanca excecao
        private void validaMatrizValores(string valor)
        {
            if (valor.Equals(""))
            {
                throw new InvalidMatrizValorException();
            }
        }

        private int[,] criaMatrizOrdem1(int[,] matrizParametro)
        {
            try
            {
                matrizParametro[0, 0] = int.Parse(a11.Text);
            }
            catch (Exception)
            {
                
                throw new InvalidMatrizValorException();
            }
           
            return matrizParametro;
        }
        // Cria matriz bidimenisonal de acordo com a ordem informada
        private int[,] criaMatrizOrdem2(int[,] matrizParametro)
        {
            try
            {
                this.criaMatrizOrdem1(matrizParametro);
                matrizParametro[0, 1] = int.Parse(a12.Text);
                matrizParametro[1, 0] = int.Parse(a21.Text);
                matrizParametro[1, 1] = int.Parse(a22.Text);
            }
            catch (Exception)
            {

                throw new InvalidMatrizValorException();
            }
            return matrizParametro;
        }

        // Cria ORDEM 3
        private int[,] criaMatrizOrdem3(int[,] matrizParametro)
        {
            try
            {

                matrizParametro = this.criaMatrizOrdem2(matrizParametro);
                matrizParametro[0, 2] = int.Parse(a13.Text);
                matrizParametro[1, 2] = int.Parse(a23.Text);
                matrizParametro[2, 2] = int.Parse(a33.Text);

                matrizParametro[2, 0] = int.Parse(a31.Text);
                matrizParametro[2, 1] = int.Parse(a32.Text);
                matrizParametro[2, 2] = int.Parse(a33.Text);
            }
            catch (Exception)
            {

                throw new InvalidMatrizValorException();
            }

            return matrizParametro;
        }


        // Cria ORDEM 4
        private int[,] criaMatrizOrdem4(int[,] matrizParametro)
        {
            try
            {


                matrizParametro = this.criaMatrizOrdem3(matrizParametro);
                matrizParametro[0, 3] = int.Parse(a14.Text);
                matrizParametro[1, 3] = int.Parse(a24.Text);
                matrizParametro[2, 3] = int.Parse(a34.Text);
                matrizParametro[3, 3] = int.Parse(a44.Text);

                matrizParametro[3, 0] = int.Parse(a41.Text);
                matrizParametro[3, 1] = int.Parse(a42.Text);
                matrizParametro[3, 2] = int.Parse(a43.Text);

            }
            catch (Exception)
            {

                throw new InvalidMatrizValorException();
            }

            return matrizParametro;
        }


        // Mostrar campos quando for de ordem 3
        private void duplicacao()
        {
            a14.Enabled = false;
            a24.Enabled = false;
            a34.Enabled = false;
            
            a14.Visible = true;
            a24.Visible = true;
            a34.Visible = true;

            a15.Visible = true; 
            a25.Visible = true; 
            a35.Visible = true; 

            // Replicando colunas
            a14.Text = a12.Text; 
            a24.Text = a22.Text;
            a34.Text = a32.Text; 
            
            a15.Text = a13.Text; 
            a25.Text = a23.Text; 
            a35.Text = a33.Text; 


        }

        // Esconde todos os campos da MATRIZ
        private void mostraTodosCampos(bool opcao = false)
        {
            // Linha 1
            a11.Visible = opcao;
            a12.Visible = opcao;
            a13.Visible = opcao;
            a14.Visible = opcao;
            a15.Visible = false; 

            // Linha 2
            a21.Visible = opcao;
            a22.Visible = opcao;
            a23.Visible = opcao;
            a24.Visible = opcao;
            a25.Visible = false; 

            // Linha 3
            a31.Visible = opcao;
            a32.Visible = opcao;
            a33.Visible = opcao;
            a34.Visible = opcao;
            a35.Visible = false; 

            a41.Visible = opcao;
            a42.Visible = opcao;
            a43.Visible = opcao;
            a44.Visible = opcao;

            
            a14.Enabled = true;
            a24.Enabled = true;
            a34.Enabled = true;
            a44.Enabled = true;
        }
       
        // Mostra campos de ordem 1
        private void mostraCamposOrdem1()
        {
            a11.Visible = true;
        }

        // Mostra campos de ordem 2
        private void mostraCamposOrdem2()
        {
            // Linha 1
            a11.Visible = true;
            a12.Visible = true;

            // Linha 2
            a21.Visible = true;
            a22.Visible = true;
        }

        // Mostra campos de ordem 3
        private void mostraCamposOrdem3()
        {
            // Linha 1
            a11.Visible = true;
            a12.Visible = true;
            a13.Visible = true;

            // Linha 2
            a21.Visible = true;
            a22.Visible = true;
            a23.Visible = true;

            // Linha 3
            a31.Visible = true;
            a32.Visible = true;
            a33.Visible = true;
        }
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para calcular a determinante é necessário preencher todos os campos da matriz!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para gerar a matriz é necessário que o campo 'Ordem da matriz' seja preenchido!");
        }


        // Valida ORDEM
        private void validaOrdem(string ordem){
        
            if (mskTxtBxOrdem.Text.Equals(""))
            {
                throw new InvalidOrdemException();
            }
            
            int ordemConvertida = int.Parse(mskTxtBxOrdem.Text);

            if (ordemConvertida < 1 || ordemConvertida > 4)
            {
                throw new InvalidOrdemIntervaloException();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            // Objeto para ser utilizado
            Matriz matriz;
            
            try
            {
                
                this.validaOrdem(mskTxtBxOrdem.Text);

                int ordemConvertida = int.Parse(mskTxtBxOrdem.Text);

                 int[,] matrizValores = new int[ordemConvertida , ordemConvertida];

                 int resultado = 0;

                if (ordemConvertida == 1)
                {
                    matriz = new Ordem1(this.criaMatrizOrdem1(matrizValores), ordemConvertida);

                    resultado = matriz.resolverMatriz();
                    
                }
                else if (ordemConvertida == 2)
                {
                   
                    matriz = new Ordem2(this.criaMatrizOrdem2(matrizValores), ordemConvertida);

                    resultado = matriz.resolverMatriz();
                }
                else if (ordemConvertida == 3)
                {

                    this.duplicacao();

                    matriz = new Sarrus(this.criaMatrizOrdem3(matrizValores), ordemConvertida);

                    resultado = matriz.resolverMatriz();
                }
                else if (ordemConvertida == 4)
                {
                    matriz = new Laplace(this.criaMatrizOrdem4(matrizValores), ordemConvertida);

                    resultado = matriz.resolverMatriz();
                }

                mskTxtBxResultado.Text = Convert.ToString(resultado);

                MessageBox.Show("Determinante calculada com sucesso!");

            }
            catch (InvalidOrdemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOrdemIntervaloException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
                
            catch (InvalidMatrizValorException ex3)
            {

                MessageBox.Show(ex3.Message);
            }
            /*catch (Exception)
            {
                
            }
           */
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.definirCampos(mskTxtBxOrdem.Text);
        }

        private void mskTxtBxOrdem_ModifiedChanged(object sender, EventArgs e)
        {
            
        }

        private void mskTxtBxOrdem_KeyUp(object sender, KeyEventArgs e)
        {
            this.zerarCampos();
            this.mostraTodosCampos(false);
        }
    }
}
