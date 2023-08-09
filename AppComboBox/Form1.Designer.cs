namespace AppComboBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.bntInserir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblQtde = new System.Windows.Forms.Label();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de itens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Indice do combo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Texto do combo";
            // 
            // txtTexto
            // 
            this.txtTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTexto.Location = new System.Drawing.Point(188, 28);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(423, 20);
            this.txtTexto.TabIndex = 5;
            // 
            // txtIndice
            // 
            this.txtIndice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIndice.Location = new System.Drawing.Point(204, 451);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(407, 20);
            this.txtIndice.TabIndex = 7;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtConteudo.Location = new System.Drawing.Point(204, 492);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(407, 20);
            this.txtConteudo.TabIndex = 8;
            // 
            // bntInserir
            // 
            this.bntInserir.Location = new System.Drawing.Point(209, 66);
            this.bntInserir.Name = "bntInserir";
            this.bntInserir.Size = new System.Drawing.Size(134, 57);
            this.bntInserir.TabIndex = 9;
            this.bntInserir.Text = "Inserir no combo";
            this.bntInserir.UseVisualStyleBackColor = true;
            this.bntInserir.Click += new System.EventHandler(this.bntInserir_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(394, 66);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(134, 57);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar combo";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(287, 350);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(148, 74);
            this.btnExibir.TabIndex = 11;
            this.btnExibir.Text = "Exibir dados do combo";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(287, 185);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(147, 74);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover de combo";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.ForeColor = System.Drawing.Color.Blue;
            this.lblQtde.Location = new System.Drawing.Point(347, 288);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(32, 36);
            this.lblQtde.TabIndex = 13;
            this.lblQtde.Text = "0";
            // 
            // cboLista
            // 
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(188, 146);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(423, 21);
            this.cboLista.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.bntInserir);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button bntInserir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.ComboBox cboLista;
    }
}

