namespace EscalaDeServico
{
    partial class FrmMain
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblUnidadeCabecalho = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(3, 167);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1017, 402);
            this.dg.TabIndex = 0;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(12, 63);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(98, 13);
            this.lblCargaHoraria.TabIndex = 1;
            this.lblCargaHoraria.Text = "Carga horária 00Hs";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(12, 9);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(70, 16);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipe.Location = new System.Drawing.Point(12, 34);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(57, 16);
            this.lblEquipe.TabIndex = 3;
            this.lblEquipe.Text = "Equipe";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(414, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(135, 16);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Escala de Serviço";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(414, 37);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(86, 13);
            this.lblPeriodo.TabIndex = 5;
            this.lblPeriodo.Text = "Mês - [Mês/Ano]";
            // 
            // lblUnidadeCabecalho
            // 
            this.lblUnidadeCabecalho.AutoSize = true;
            this.lblUnidadeCabecalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeCabecalho.Location = new System.Drawing.Point(685, 9);
            this.lblUnidadeCabecalho.Name = "lblUnidadeCabecalho";
            this.lblUnidadeCabecalho.Size = new System.Drawing.Size(67, 16);
            this.lblUnidadeCabecalho.TabIndex = 6;
            this.lblUnidadeCabecalho.Text = "Unidade";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(685, 37);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(99, 13);
            this.lblUnidade.TabIndex = 7;
            this.lblUnidade.Text = "[Nome da Unidade]";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 93);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(175, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Alocações";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Preencher Finais de Semana";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblUnidadeCabecalho);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.dg);
            this.Name = "FrmMain";
            this.Text = "Escala de Serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblUnidadeCabecalho;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button1;
    }
}

