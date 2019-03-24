namespace Exercicios1403
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExercicio01 = new System.Windows.Forms.Button();
            this.btnExercicio02 = new System.Windows.Forms.Button();
            this.btnExercicio03 = new System.Windows.Forms.Button();
            this.btnExercicio04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercicio01
            // 
            this.btnExercicio01.Location = new System.Drawing.Point(30, 29);
            this.btnExercicio01.Name = "btnExercicio01";
            this.btnExercicio01.Size = new System.Drawing.Size(186, 52);
            this.btnExercicio01.TabIndex = 0;
            this.btnExercicio01.Text = "Exercicio 01";
            this.btnExercicio01.UseVisualStyleBackColor = true;
            this.btnExercicio01.Click += new System.EventHandler(this.btnExercicio01_Click);
            // 
            // btnExercicio02
            // 
            this.btnExercicio02.Location = new System.Drawing.Point(30, 117);
            this.btnExercicio02.Name = "btnExercicio02";
            this.btnExercicio02.Size = new System.Drawing.Size(186, 52);
            this.btnExercicio02.TabIndex = 1;
            this.btnExercicio02.Text = "Exercicio 02";
            this.btnExercicio02.UseVisualStyleBackColor = true;
            this.btnExercicio02.Click += new System.EventHandler(this.btnExercicio02_Click);
            // 
            // btnExercicio03
            // 
            this.btnExercicio03.Location = new System.Drawing.Point(30, 208);
            this.btnExercicio03.Name = "btnExercicio03";
            this.btnExercicio03.Size = new System.Drawing.Size(186, 52);
            this.btnExercicio03.TabIndex = 2;
            this.btnExercicio03.Text = "Exercicio 03";
            this.btnExercicio03.UseVisualStyleBackColor = true;
            this.btnExercicio03.Click += new System.EventHandler(this.btnExercicio03_Click);
            // 
            // btnExercicio04
            // 
            this.btnExercicio04.Location = new System.Drawing.Point(30, 293);
            this.btnExercicio04.Name = "btnExercicio04";
            this.btnExercicio04.Size = new System.Drawing.Size(186, 52);
            this.btnExercicio04.TabIndex = 3;
            this.btnExercicio04.Text = "Exercicio 04";
            this.btnExercicio04.UseVisualStyleBackColor = true;
            this.btnExercicio04.Click += new System.EventHandler(this.btnExercicio04_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 378);
            this.Controls.Add(this.btnExercicio04);
            this.Controls.Add(this.btnExercicio03);
            this.Controls.Add(this.btnExercicio02);
            this.Controls.Add(this.btnExercicio01);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExercicio01;
        private System.Windows.Forms.Button btnExercicio02;
        private System.Windows.Forms.Button btnExercicio03;
        private System.Windows.Forms.Button btnExercicio04;
    }
}

