namespace TrabalhoInterdisciplinarPooApplication
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTxtBxOrdem = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTxtBxResultado = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.a11 = new System.Windows.Forms.MaskedTextBox();
            this.a21 = new System.Windows.Forms.MaskedTextBox();
            this.a31 = new System.Windows.Forms.MaskedTextBox();
            this.a12 = new System.Windows.Forms.MaskedTextBox();
            this.a22 = new System.Windows.Forms.MaskedTextBox();
            this.a13 = new System.Windows.Forms.MaskedTextBox();
            this.a23 = new System.Windows.Forms.MaskedTextBox();
            this.a43 = new System.Windows.Forms.MaskedTextBox();
            this.a24 = new System.Windows.Forms.MaskedTextBox();
            this.a44 = new System.Windows.Forms.MaskedTextBox();
            this.a34 = new System.Windows.Forms.MaskedTextBox();
            this.a41 = new System.Windows.Forms.MaskedTextBox();
            this.a42 = new System.Windows.Forms.MaskedTextBox();
            this.a33 = new System.Windows.Forms.MaskedTextBox();
            this.a32 = new System.Windows.Forms.MaskedTextBox();
            this.a14 = new System.Windows.Forms.MaskedTextBox();
            this.a15 = new System.Windows.Forms.MaskedTextBox();
            this.a35 = new System.Windows.Forms.MaskedTextBox();
            this.a25 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo da determinante de matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preencha os campos com o valor da respectiva matriz:";
            // 
            // mskTxtBxOrdem
            // 
            this.mskTxtBxOrdem.Location = new System.Drawing.Point(234, 81);
            this.mskTxtBxOrdem.Mask = "0";
            this.mskTxtBxOrdem.Name = "mskTxtBxOrdem";
            this.mskTxtBxOrdem.Size = new System.Drawing.Size(69, 31);
            this.mskTxtBxOrdem.TabIndex = 2;
            this.mskTxtBxOrdem.ValidatingType = typeof(int);
            this.mskTxtBxOrdem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskTxtBxOrdem_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ordem da matriz:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(321, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gerar matriz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado:";
            // 
            // mskTxtBxResultado
            // 
            this.mskTxtBxResultado.Enabled = false;
            this.mskTxtBxResultado.Location = new System.Drawing.Point(190, 136);
            this.mskTxtBxResultado.Name = "mskTxtBxResultado";
            this.mskTxtBxResultado.Size = new System.Drawing.Size(69, 31);
            this.mskTxtBxResultado.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Calcular determinante";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // a11
            // 
            this.a11.Location = new System.Drawing.Point(106, 257);
            this.a11.Name = "a11";
            this.a11.Size = new System.Drawing.Size(69, 31);
            this.a11.TabIndex = 8;
            this.a11.ValidatingType = typeof(int);
            // 
            // a21
            // 
            this.a21.Location = new System.Drawing.Point(106, 327);
            this.a21.Name = "a21";
            this.a21.Size = new System.Drawing.Size(69, 31);
            this.a21.TabIndex = 9;
            this.a21.ValidatingType = typeof(int);
            this.a21.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // a31
            // 
            this.a31.Location = new System.Drawing.Point(106, 401);
            this.a31.Name = "a31";
            this.a31.Size = new System.Drawing.Size(69, 31);
            this.a31.TabIndex = 10;
            this.a31.ValidatingType = typeof(int);
            // 
            // a12
            // 
            this.a12.Location = new System.Drawing.Point(234, 257);
            this.a12.Name = "a12";
            this.a12.Size = new System.Drawing.Size(69, 31);
            this.a12.TabIndex = 11;
            // 
            // a22
            // 
            this.a22.Location = new System.Drawing.Point(234, 327);
            this.a22.Name = "a22";
            this.a22.Size = new System.Drawing.Size(69, 31);
            this.a22.TabIndex = 12;
            this.a22.ValidatingType = typeof(int);
            // 
            // a13
            // 
            this.a13.Location = new System.Drawing.Point(347, 257);
            this.a13.Name = "a13";
            this.a13.Size = new System.Drawing.Size(69, 31);
            this.a13.TabIndex = 14;
            this.a13.ValidatingType = typeof(int);
            // 
            // a23
            // 
            this.a23.Location = new System.Drawing.Point(347, 327);
            this.a23.Name = "a23";
            this.a23.Size = new System.Drawing.Size(69, 31);
            this.a23.TabIndex = 16;
            this.a23.ValidatingType = typeof(int);
            // 
            // a43
            // 
            this.a43.Location = new System.Drawing.Point(347, 470);
            this.a43.Name = "a43";
            this.a43.Size = new System.Drawing.Size(69, 31);
            this.a43.TabIndex = 17;
            this.a43.ValidatingType = typeof(int);
            this.a43.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox12_MaskInputRejected);
            // 
            // a24
            // 
            this.a24.Location = new System.Drawing.Point(466, 327);
            this.a24.Name = "a24";
            this.a24.Size = new System.Drawing.Size(69, 31);
            this.a24.TabIndex = 18;
            this.a24.ValidatingType = typeof(int);
            // 
            // a44
            // 
            this.a44.Location = new System.Drawing.Point(466, 470);
            this.a44.Name = "a44";
            this.a44.Size = new System.Drawing.Size(69, 31);
            this.a44.TabIndex = 19;
            this.a44.ValidatingType = typeof(int);
            // 
            // a34
            // 
            this.a34.Location = new System.Drawing.Point(466, 401);
            this.a34.Name = "a34";
            this.a34.Size = new System.Drawing.Size(69, 31);
            this.a34.TabIndex = 23;
            // 
            // a41
            // 
            this.a41.Location = new System.Drawing.Point(106, 470);
            this.a41.Name = "a41";
            this.a41.Size = new System.Drawing.Size(69, 31);
            this.a41.TabIndex = 24;
            this.a41.ValidatingType = typeof(int);
            // 
            // a42
            // 
            this.a42.Location = new System.Drawing.Point(234, 470);
            this.a42.Name = "a42";
            this.a42.Size = new System.Drawing.Size(69, 31);
            this.a42.TabIndex = 25;
            this.a42.ValidatingType = typeof(int);
            // 
            // a33
            // 
            this.a33.Location = new System.Drawing.Point(347, 401);
            this.a33.Name = "a33";
            this.a33.Size = new System.Drawing.Size(69, 31);
            this.a33.TabIndex = 26;
            this.a33.ValidatingType = typeof(int);
            // 
            // a32
            // 
            this.a32.Location = new System.Drawing.Point(234, 401);
            this.a32.Name = "a32";
            this.a32.Size = new System.Drawing.Size(69, 31);
            this.a32.TabIndex = 27;
            this.a32.ValidatingType = typeof(int);
            // 
            // a14
            // 
            this.a14.Location = new System.Drawing.Point(466, 257);
            this.a14.Name = "a14";
            this.a14.Size = new System.Drawing.Size(69, 31);
            this.a14.TabIndex = 28;
            this.a14.ValidatingType = typeof(int);
            // 
            // a15
            // 
            this.a15.Enabled = false;
            this.a15.Location = new System.Drawing.Point(585, 257);
            this.a15.Name = "a15";
            this.a15.Size = new System.Drawing.Size(69, 31);
            this.a15.TabIndex = 32;
            this.a15.ValidatingType = typeof(int);
            this.a15.Visible = false;
            // 
            // a35
            // 
            this.a35.Enabled = false;
            this.a35.Location = new System.Drawing.Point(585, 401);
            this.a35.Name = "a35";
            this.a35.Size = new System.Drawing.Size(69, 31);
            this.a35.TabIndex = 31;
            this.a35.Visible = false;
            // 
            // a25
            // 
            this.a25.Enabled = false;
            this.a25.Location = new System.Drawing.Point(585, 327);
            this.a25.Name = "a25";
            this.a25.Size = new System.Drawing.Size(69, 31);
            this.a25.TabIndex = 29;
            this.a25.ValidatingType = typeof(int);
            this.a25.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 513);
            this.Controls.Add(this.a15);
            this.Controls.Add(this.a35);
            this.Controls.Add(this.a25);
            this.Controls.Add(this.a14);
            this.Controls.Add(this.a32);
            this.Controls.Add(this.a33);
            this.Controls.Add(this.a42);
            this.Controls.Add(this.a41);
            this.Controls.Add(this.a34);
            this.Controls.Add(this.a44);
            this.Controls.Add(this.a24);
            this.Controls.Add(this.a43);
            this.Controls.Add(this.a23);
            this.Controls.Add(this.a13);
            this.Controls.Add(this.a22);
            this.Controls.Add(this.a12);
            this.Controls.Add(this.a31);
            this.Controls.Add(this.a21);
            this.Controls.Add(this.a11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskTxtBxResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTxtBxOrdem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormPrincipal";
            this.Text = "Determinante de matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTxtBxOrdem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTxtBxResultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox a11;
        private System.Windows.Forms.MaskedTextBox a21;
        private System.Windows.Forms.MaskedTextBox a31;
        private System.Windows.Forms.MaskedTextBox a12;
        private System.Windows.Forms.MaskedTextBox a22;
        private System.Windows.Forms.MaskedTextBox a13;
        private System.Windows.Forms.MaskedTextBox a23;
        private System.Windows.Forms.MaskedTextBox a43;
        private System.Windows.Forms.MaskedTextBox a24;
        private System.Windows.Forms.MaskedTextBox a44;
        private System.Windows.Forms.MaskedTextBox a34;
        private System.Windows.Forms.MaskedTextBox a41;
        private System.Windows.Forms.MaskedTextBox a42;
        private System.Windows.Forms.MaskedTextBox a33;
        private System.Windows.Forms.MaskedTextBox a32;
        private System.Windows.Forms.MaskedTextBox a14;
        private System.Windows.Forms.MaskedTextBox a15;
        private System.Windows.Forms.MaskedTextBox a35;
        private System.Windows.Forms.MaskedTextBox a25;
    }
}

