namespace Calculadora_Propiedades
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDividir = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btRestar = new System.Windows.Forms.Button();
            this.btSumar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Valor2 = new System.Windows.Forms.TextBox();
            this.Valor1 = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(355, 236);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(75, 23);
            this.btDividir.TabIndex = 3;
            this.btDividir.Text = "Dividir";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(355, 193);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btMultiplicar.TabIndex = 4;
            this.btMultiplicar.Text = "Multiplicar";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btRestar
            // 
            this.btRestar.Location = new System.Drawing.Point(355, 149);
            this.btRestar.Name = "btRestar";
            this.btRestar.Size = new System.Drawing.Size(75, 23);
            this.btRestar.TabIndex = 5;
            this.btRestar.Text = "Restar";
            this.btRestar.UseVisualStyleBackColor = true;
            this.btRestar.Click += new System.EventHandler(this.btRestar_Click);
            // 
            // btSumar
            // 
            this.btSumar.Location = new System.Drawing.Point(355, 106);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(75, 23);
            this.btSumar.TabIndex = 6;
            this.btSumar.Text = "Sumar";
            this.btSumar.UseVisualStyleBackColor = true;
            this.btSumar.Click += new System.EventHandler(this.btSumar_Click);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(160, 176);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(100, 23);
            this.Resultado.TabIndex = 7;
            // 
            // Valor2
            // 
            this.Valor2.Location = new System.Drawing.Point(160, 111);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(100, 23);
            this.Valor2.TabIndex = 8;
            // 
            // Valor1
            // 
            this.Valor1.Location = new System.Drawing.Point(160, 43);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(100, 23);
            this.Valor1.TabIndex = 9;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(262, 236);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 10;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 286);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btSumar);
            this.Controls.Add(this.btRestar);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btDividir;
        private Button btMultiplicar;
        private Button btRestar;
        private Button btSumar;
        private TextBox Resultado;
        private TextBox Valor2;
        private TextBox Valor1;
        private Button Limpiar;
    }
}