namespace e_Agenda2._0.WinFormsApp
{
    partial class GerenciadorCompromisso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciadorCompromisso));
            this.l_GerenciadorCompromisso = new System.Windows.Forms.Label();
            this.l_linha = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.tb_PassadosFuturos = new System.Windows.Forms.TabControl();
            this.tab_Passados = new System.Windows.Forms.TabPage();
            this.listCompromissosPassados = new System.Windows.Forms.ListBox();
            this.tab_Futuros = new System.Windows.Forms.TabPage();
            this.listCompromissosFuturos = new System.Windows.Forms.ListBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_VisualizarPeriodo = new System.Windows.Forms.Button();
            this.tb_PassadosFuturos.SuspendLayout();
            this.tab_Passados.SuspendLayout();
            this.tab_Futuros.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_GerenciadorCompromisso
            // 
            this.l_GerenciadorCompromisso.AutoSize = true;
            this.l_GerenciadorCompromisso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_GerenciadorCompromisso.Location = new System.Drawing.Point(423, 9);
            this.l_GerenciadorCompromisso.Name = "l_GerenciadorCompromisso";
            this.l_GerenciadorCompromisso.Size = new System.Drawing.Size(293, 24);
            this.l_GerenciadorCompromisso.TabIndex = 0;
            this.l_GerenciadorCompromisso.Text = "Gerenciador de Compromisso";
            // 
            // l_linha
            // 
            this.l_linha.AutoSize = true;
            this.l_linha.Location = new System.Drawing.Point(-24, 21);
            this.l_linha.Name = "l_linha";
            this.l_linha.Size = new System.Drawing.Size(1221, 20);
            this.l_linha.TabIndex = 1;
            this.l_linha.Text = resources.GetString("l_linha.Text");
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(16, 50);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(282, 55);
            this.btn_Inserir.TabIndex = 2;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(304, 50);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(282, 55);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(592, 50);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(282, 55);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // tb_PassadosFuturos
            // 
            this.tb_PassadosFuturos.Controls.Add(this.tab_Passados);
            this.tb_PassadosFuturos.Controls.Add(this.tab_Futuros);
            this.tb_PassadosFuturos.Location = new System.Drawing.Point(12, 112);
            this.tb_PassadosFuturos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_PassadosFuturos.Name = "tb_PassadosFuturos";
            this.tb_PassadosFuturos.SelectedIndex = 0;
            this.tb_PassadosFuturos.Size = new System.Drawing.Size(1150, 246);
            this.tb_PassadosFuturos.TabIndex = 8;
            // 
            // tab_Passados
            // 
            this.tab_Passados.Controls.Add(this.listCompromissosPassados);
            this.tab_Passados.Location = new System.Drawing.Point(4, 29);
            this.tab_Passados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Passados.Name = "tab_Passados";
            this.tab_Passados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Passados.Size = new System.Drawing.Size(1142, 213);
            this.tab_Passados.TabIndex = 0;
            this.tab_Passados.Text = "Compromissos Passados";
            this.tab_Passados.UseVisualStyleBackColor = true;
            // 
            // listCompromissosPassados
            // 
            this.listCompromissosPassados.FormattingEnabled = true;
            this.listCompromissosPassados.ItemHeight = 20;
            this.listCompromissosPassados.Location = new System.Drawing.Point(0, 20);
            this.listCompromissosPassados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listCompromissosPassados.Name = "listCompromissosPassados";
            this.listCompromissosPassados.Size = new System.Drawing.Size(1142, 164);
            this.listCompromissosPassados.TabIndex = 6;
            // 
            // tab_Futuros
            // 
            this.tab_Futuros.Controls.Add(this.listCompromissosFuturos);
            this.tab_Futuros.Location = new System.Drawing.Point(4, 29);
            this.tab_Futuros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Futuros.Name = "tab_Futuros";
            this.tab_Futuros.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Futuros.Size = new System.Drawing.Size(1142, 213);
            this.tab_Futuros.TabIndex = 1;
            this.tab_Futuros.Text = "Compromissos Futuros";
            this.tab_Futuros.UseVisualStyleBackColor = true;
            // 
            // listCompromissosFuturos
            // 
            this.listCompromissosFuturos.FormattingEnabled = true;
            this.listCompromissosFuturos.ItemHeight = 20;
            this.listCompromissosFuturos.Location = new System.Drawing.Point(0, 20);
            this.listCompromissosFuturos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listCompromissosFuturos.Name = "listCompromissosFuturos";
            this.listCompromissosFuturos.Size = new System.Drawing.Size(1142, 164);
            this.listCompromissosFuturos.TabIndex = 7;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 383);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(1146, 44);
            this.btn_Voltar.TabIndex = 9;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_VisualizarPeriodo
            // 
            this.btn_VisualizarPeriodo.Location = new System.Drawing.Point(880, 50);
            this.btn_VisualizarPeriodo.Name = "btn_VisualizarPeriodo";
            this.btn_VisualizarPeriodo.Size = new System.Drawing.Size(282, 55);
            this.btn_VisualizarPeriodo.TabIndex = 10;
            this.btn_VisualizarPeriodo.Text = "Visualizar por Periodo";
            this.btn_VisualizarPeriodo.UseVisualStyleBackColor = true;
            this.btn_VisualizarPeriodo.Click += new System.EventHandler(this.btn_VisualizarPeriodo_Click);
            // 
            // GerenciadorCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 444);
            this.Controls.Add(this.btn_VisualizarPeriodo);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.tb_PassadosFuturos);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.l_GerenciadorCompromisso);
            this.Controls.Add(this.l_linha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GerenciadorCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Compromisso";
            this.tb_PassadosFuturos.ResumeLayout(false);
            this.tab_Passados.ResumeLayout(false);
            this.tab_Futuros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_GerenciadorCompromisso;
        private System.Windows.Forms.Label l_linha;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.TabControl tb_PassadosFuturos;
        private System.Windows.Forms.TabPage tab_Passados;
        private System.Windows.Forms.ListBox listCompromissosPassados;
        private System.Windows.Forms.TabPage tab_Futuros;
        private System.Windows.Forms.ListBox listCompromissosFuturos;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_VisualizarPeriodo;
    }
}