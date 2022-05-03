namespace e_Agenda2._0.WinFormsApp
{
    partial class GerenciadorContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciadorContato));
            this.l_GerenciadorContato = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.lb_Contatos = new System.Windows.Forms.ListBox();
            this.l_linha = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_VisualizarCargo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_GerenciadorContato
            // 
            this.l_GerenciadorContato.AutoSize = true;
            this.l_GerenciadorContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_GerenciadorContato.Location = new System.Drawing.Point(383, 9);
            this.l_GerenciadorContato.Name = "l_GerenciadorContato";
            this.l_GerenciadorContato.Size = new System.Drawing.Size(237, 24);
            this.l_GerenciadorContato.TabIndex = 0;
            this.l_GerenciadorContato.Text = "Gerenciador de Contato";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(12, 48);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(242, 55);
            this.btn_Inserir.TabIndex = 3;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(260, 48);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(242, 55);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(508, 48);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(242, 55);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // lb_Contatos
            // 
            this.lb_Contatos.FormattingEnabled = true;
            this.lb_Contatos.ItemHeight = 20;
            this.lb_Contatos.Location = new System.Drawing.Point(12, 120);
            this.lb_Contatos.Name = "lb_Contatos";
            this.lb_Contatos.Size = new System.Drawing.Size(986, 184);
            this.lb_Contatos.TabIndex = 6;
            // 
            // l_linha
            // 
            this.l_linha.AutoSize = true;
            this.l_linha.Location = new System.Drawing.Point(-92, 19);
            this.l_linha.Name = "l_linha";
            this.l_linha.Size = new System.Drawing.Size(1281, 20);
            this.l_linha.TabIndex = 7;
            this.l_linha.Text = resources.GetString("l_linha.Text");
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 326);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(986, 44);
            this.btn_Voltar.TabIndex = 10;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_VisualizarCargo
            // 
            this.btn_VisualizarCargo.Location = new System.Drawing.Point(756, 48);
            this.btn_VisualizarCargo.Name = "btn_VisualizarCargo";
            this.btn_VisualizarCargo.Size = new System.Drawing.Size(242, 55);
            this.btn_VisualizarCargo.TabIndex = 11;
            this.btn_VisualizarCargo.Text = "Visualizar por Cargo";
            this.btn_VisualizarCargo.UseVisualStyleBackColor = true;
            this.btn_VisualizarCargo.Click += new System.EventHandler(this.btn_VisualizarCargo_Click);
            // 
            // GerenciadorContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 385);
            this.Controls.Add(this.btn_VisualizarCargo);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.lb_Contatos);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.l_GerenciadorContato);
            this.Controls.Add(this.l_linha);
            this.Name = "GerenciadorContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_GerenciadorContato;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.ListBox lb_Contatos;
        private System.Windows.Forms.Label l_linha;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_VisualizarCargo;
    }
}