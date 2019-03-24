namespace Exercicios1403
{
    partial class Exercicio04
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNovoValor = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDSemana = new System.Windows.Forms.TextBox();
            this.txtNSala = new System.Windows.Forms.TextBox();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label01 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Novo valor:";
            // 
            // txtNovoValor
            // 
            this.txtNovoValor.Enabled = false;
            this.txtNovoValor.Location = new System.Drawing.Point(216, 184);
            this.txtNovoValor.Name = "txtNovoValor";
            this.txtNovoValor.Size = new System.Drawing.Size(100, 20);
            this.txtNovoValor.TabIndex = 4;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(211, 258);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(105, 58);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(216, 145);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.Text = "8,00";
            // 
            // txtDSemana
            // 
            this.txtDSemana.Location = new System.Drawing.Point(216, 108);
            this.txtDSemana.Name = "txtDSemana";
            this.txtDSemana.Size = new System.Drawing.Size(100, 20);
            this.txtDSemana.TabIndex = 2;
            // 
            // txtNSala
            // 
            this.txtNSala.Location = new System.Drawing.Point(216, 70);
            this.txtNSala.Name = "txtNSala";
            this.txtNSala.Size = new System.Drawing.Size(100, 20);
            this.txtNSala.TabIndex = 1;
            // 
            // txtFilme
            // 
            this.txtFilme.Location = new System.Drawing.Point(216, 36);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(100, 20);
            this.txtFilme.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dia da semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Número da Sala";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(59, 258);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(105, 58);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(56, 36);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(31, 13);
            this.label01.TabIndex = 23;
            this.label01.Text = "Filme";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(145, 338);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 58);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNovoValor);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDSemana);
            this.Controls.Add(this.txtNSala);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Exercicio04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNovoValor;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDSemana;
        private System.Windows.Forms.TextBox txtNSala;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Button btnVoltar;
    }
}