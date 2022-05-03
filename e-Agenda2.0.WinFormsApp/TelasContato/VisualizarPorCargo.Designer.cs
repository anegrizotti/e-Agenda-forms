namespace e_Agenda2._0.WinFormsApp.TelasContato
{
    partial class VisualizarPorCargo
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
            this.l_linha = new System.Windows.Forms.Label();
            this.l_Visualizacao = new System.Windows.Forms.Label();
            this.cb_Cargos = new System.Windows.Forms.ComboBox();
            this.l_Selecione = new System.Windows.Forms.Label();
            this.lb_Contatos = new System.Windows.Forms.ListBox();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_linha
            // 
            this.l_linha.AutoSize = true;
            this.l_linha.Location = new System.Drawing.Point(-65, 18);
            this.l_linha.Name = "l_linha";
            this.l_linha.Size = new System.Drawing.Size(885, 20);
            this.l_linha.TabIndex = 8;
            this.l_linha.Text = "_________________________________________________________________________________" +
    "_________________________________________________________________";
            // 
            // l_Visualizacao
            // 
            this.l_Visualizacao.AutoSize = true;
            this.l_Visualizacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_Visualizacao.Location = new System.Drawing.Point(284, 8);
            this.l_Visualizacao.Name = "l_Visualizacao";
            this.l_Visualizacao.Size = new System.Drawing.Size(228, 24);
            this.l_Visualizacao.TabIndex = 9;
            this.l_Visualizacao.Text = "Visualização por Cargo";
            // 
            // cb_Cargos
            // 
            this.cb_Cargos.FormattingEnabled = true;
            this.cb_Cargos.Location = new System.Drawing.Point(12, 74);
            this.cb_Cargos.Name = "cb_Cargos";
            this.cb_Cargos.Size = new System.Drawing.Size(791, 28);
            this.cb_Cargos.TabIndex = 10;
            // 
            // l_Selecione
            // 
            this.l_Selecione.AutoSize = true;
            this.l_Selecione.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Selecione.Location = new System.Drawing.Point(12, 52);
            this.l_Selecione.Name = "l_Selecione";
            this.l_Selecione.Size = new System.Drawing.Size(163, 19);
            this.l_Selecione.TabIndex = 11;
            this.l_Selecione.Text = "Selecione um Cargo:";
            // 
            // lb_Contatos
            // 
            this.lb_Contatos.Enabled = false;
            this.lb_Contatos.FormattingEnabled = true;
            this.lb_Contatos.ItemHeight = 20;
            this.lb_Contatos.Location = new System.Drawing.Point(12, 204);
            this.lb_Contatos.Name = "lb_Contatos";
            this.lb_Contatos.Size = new System.Drawing.Size(791, 124);
            this.lb_Contatos.TabIndex = 12;
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(12, 119);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(791, 46);
            this.btn_Visualizar.TabIndex = 13;
            this.btn_Visualizar.Text = "Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 392);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(791, 46);
            this.btn_Voltar.TabIndex = 14;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // VisualizarPorCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.lb_Contatos);
            this.Controls.Add(this.l_Selecione);
            this.Controls.Add(this.cb_Cargos);
            this.Controls.Add(this.l_Visualizacao);
            this.Controls.Add(this.l_linha);
            this.Name = "VisualizarPorCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar por Cargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_linha;
        private System.Windows.Forms.Label l_Visualizacao;
        private System.Windows.Forms.ComboBox cb_Cargos;
        private System.Windows.Forms.Label l_Selecione;
        private System.Windows.Forms.ListBox lb_Contatos;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.Button btn_Voltar;
    }
}