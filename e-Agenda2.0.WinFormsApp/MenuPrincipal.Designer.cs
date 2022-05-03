namespace e_Agenda2._0.WinFormsApp
{
    partial class MenuPrincipal
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
            this.l_eAgenda = new System.Windows.Forms.Label();
            this.lb_linha = new System.Windows.Forms.Label();
            this.btn_GerenciarTarefas = new System.Windows.Forms.Button();
            this.btn_GerenciarCompromissos = new System.Windows.Forms.Button();
            this.btn_GerenciarContatos = new System.Windows.Forms.Button();
            this.lb_Tarefas = new System.Windows.Forms.ListBox();
            this.lb_Compromissos = new System.Windows.Forms.ListBox();
            this.lb_Contatos = new System.Windows.Forms.ListBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_eAgenda
            // 
            this.l_eAgenda.AutoSize = true;
            this.l_eAgenda.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_eAgenda.Location = new System.Drawing.Point(422, 9);
            this.l_eAgenda.Name = "l_eAgenda";
            this.l_eAgenda.Size = new System.Drawing.Size(119, 27);
            this.l_eAgenda.TabIndex = 0;
            this.l_eAgenda.Text = "e-Agenda";
            // 
            // lb_linha
            // 
            this.lb_linha.AutoSize = true;
            this.lb_linha.Location = new System.Drawing.Point(-5, 24);
            this.lb_linha.Name = "lb_linha";
            this.lb_linha.Size = new System.Drawing.Size(1059, 20);
            this.lb_linha.TabIndex = 1;
            this.lb_linha.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______________";
            // 
            // btn_GerenciarTarefas
            // 
            this.btn_GerenciarTarefas.Location = new System.Drawing.Point(12, 61);
            this.btn_GerenciarTarefas.Name = "btn_GerenciarTarefas";
            this.btn_GerenciarTarefas.Size = new System.Drawing.Size(936, 47);
            this.btn_GerenciarTarefas.TabIndex = 2;
            this.btn_GerenciarTarefas.Text = "Gerenciar Tarefas";
            this.btn_GerenciarTarefas.UseVisualStyleBackColor = true;
            this.btn_GerenciarTarefas.Click += new System.EventHandler(this.btn_GerenciarTarefas_Click);
            // 
            // btn_GerenciarCompromissos
            // 
            this.btn_GerenciarCompromissos.Location = new System.Drawing.Point(12, 555);
            this.btn_GerenciarCompromissos.Name = "btn_GerenciarCompromissos";
            this.btn_GerenciarCompromissos.Size = new System.Drawing.Size(936, 47);
            this.btn_GerenciarCompromissos.TabIndex = 3;
            this.btn_GerenciarCompromissos.Text = "Gerenciar Compromissos";
            this.btn_GerenciarCompromissos.UseVisualStyleBackColor = true;
            this.btn_GerenciarCompromissos.Click += new System.EventHandler(this.btn_GerenciarCompromissos_Click);
            // 
            // btn_GerenciarContatos
            // 
            this.btn_GerenciarContatos.Location = new System.Drawing.Point(12, 307);
            this.btn_GerenciarContatos.Name = "btn_GerenciarContatos";
            this.btn_GerenciarContatos.Size = new System.Drawing.Size(936, 47);
            this.btn_GerenciarContatos.TabIndex = 4;
            this.btn_GerenciarContatos.Text = "Gerenciar Contatos";
            this.btn_GerenciarContatos.UseVisualStyleBackColor = true;
            this.btn_GerenciarContatos.Click += new System.EventHandler(this.btn_GerenciarContatos_Click);
            // 
            // lb_Tarefas
            // 
            this.lb_Tarefas.Enabled = false;
            this.lb_Tarefas.FormattingEnabled = true;
            this.lb_Tarefas.ItemHeight = 20;
            this.lb_Tarefas.Location = new System.Drawing.Point(12, 114);
            this.lb_Tarefas.Name = "lb_Tarefas";
            this.lb_Tarefas.Size = new System.Drawing.Size(936, 124);
            this.lb_Tarefas.TabIndex = 5;
            // 
            // lb_Compromissos
            // 
            this.lb_Compromissos.Enabled = false;
            this.lb_Compromissos.FormattingEnabled = true;
            this.lb_Compromissos.ItemHeight = 20;
            this.lb_Compromissos.Location = new System.Drawing.Point(12, 608);
            this.lb_Compromissos.Name = "lb_Compromissos";
            this.lb_Compromissos.Size = new System.Drawing.Size(936, 124);
            this.lb_Compromissos.TabIndex = 6;
            // 
            // lb_Contatos
            // 
            this.lb_Contatos.Enabled = false;
            this.lb_Contatos.FormattingEnabled = true;
            this.lb_Contatos.ItemHeight = 20;
            this.lb_Contatos.Location = new System.Drawing.Point(12, 362);
            this.lb_Contatos.Name = "lb_Contatos";
            this.lb_Contatos.Size = new System.Drawing.Size(936, 124);
            this.lb_Contatos.TabIndex = 7;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(12, 802);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(936, 46);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 860);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lb_Contatos);
            this.Controls.Add(this.lb_Compromissos);
            this.Controls.Add(this.lb_Tarefas);
            this.Controls.Add(this.btn_GerenciarContatos);
            this.Controls.Add(this.btn_GerenciarCompromissos);
            this.Controls.Add(this.btn_GerenciarTarefas);
            this.Controls.Add(this.l_eAgenda);
            this.Controls.Add(this.lb_linha);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_eAgenda;
        private System.Windows.Forms.Label lb_linha;
        private System.Windows.Forms.Button btn_GerenciarTarefas;
        private System.Windows.Forms.Button btn_GerenciarCompromissos;
        private System.Windows.Forms.Button btn_GerenciarContatos;
        private System.Windows.Forms.ListBox lb_Tarefas;
        private System.Windows.Forms.ListBox lb_Compromissos;
        private System.Windows.Forms.ListBox lb_Contatos;
        private System.Windows.Forms.Button btn_Sair;
    }
}
