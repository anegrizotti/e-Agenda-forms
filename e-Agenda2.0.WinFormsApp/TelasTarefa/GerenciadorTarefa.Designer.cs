namespace e_Agenda2._0.WinFormsApp
{
    partial class GerenciadorTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciadorTarefa));
            this.l_GerenciadorTarefa = new System.Windows.Forms.Label();
            this.l_linha = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_InserirItem = new System.Windows.Forms.Button();
            this.btn_AtualizarItem = new System.Windows.Forms.Button();
            this.tc_PendenteConcluida = new System.Windows.Forms.TabControl();
            this.tp_Pendentes = new System.Windows.Forms.TabPage();
            this.listTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tp_Concluidas = new System.Windows.Forms.TabPage();
            this.listTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.tc_PendenteConcluida.SuspendLayout();
            this.tp_Pendentes.SuspendLayout();
            this.tp_Concluidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_GerenciadorTarefa
            // 
            this.l_GerenciadorTarefa.AutoSize = true;
            this.l_GerenciadorTarefa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_GerenciadorTarefa.Location = new System.Drawing.Point(427, 9);
            this.l_GerenciadorTarefa.Name = "l_GerenciadorTarefa";
            this.l_GerenciadorTarefa.Size = new System.Drawing.Size(222, 24);
            this.l_GerenciadorTarefa.TabIndex = 0;
            this.l_GerenciadorTarefa.Text = "Gerenciador de Tarefa";
            // 
            // l_linha
            // 
            this.l_linha.AutoSize = true;
            this.l_linha.Location = new System.Drawing.Point(-42, 22);
            this.l_linha.Name = "l_linha";
            this.l_linha.Size = new System.Drawing.Size(1257, 20);
            this.l_linha.TabIndex = 1;
            this.l_linha.Text = resources.GetString("l_linha.Text");
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(12, 49);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(205, 48);
            this.btn_Inserir.TabIndex = 2;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(223, 49);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(205, 48);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(434, 49);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(205, 48);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_InserirItem
            // 
            this.btn_InserirItem.Location = new System.Drawing.Point(645, 49);
            this.btn_InserirItem.Name = "btn_InserirItem";
            this.btn_InserirItem.Size = new System.Drawing.Size(205, 48);
            this.btn_InserirItem.TabIndex = 5;
            this.btn_InserirItem.Text = "Inserir Item";
            this.btn_InserirItem.UseVisualStyleBackColor = true;
            this.btn_InserirItem.Click += new System.EventHandler(this.btn_InserirItem_Click);
            // 
            // btn_AtualizarItem
            // 
            this.btn_AtualizarItem.Location = new System.Drawing.Point(856, 49);
            this.btn_AtualizarItem.Name = "btn_AtualizarItem";
            this.btn_AtualizarItem.Size = new System.Drawing.Size(205, 48);
            this.btn_AtualizarItem.TabIndex = 6;
            this.btn_AtualizarItem.Text = "Atualizar Item";
            this.btn_AtualizarItem.UseVisualStyleBackColor = true;
            this.btn_AtualizarItem.Click += new System.EventHandler(this.btn_AtualizarItem_Click);
            // 
            // tc_PendenteConcluida
            // 
            this.tc_PendenteConcluida.Controls.Add(this.tp_Pendentes);
            this.tc_PendenteConcluida.Controls.Add(this.tp_Concluidas);
            this.tc_PendenteConcluida.Location = new System.Drawing.Point(12, 122);
            this.tc_PendenteConcluida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tc_PendenteConcluida.Name = "tc_PendenteConcluida";
            this.tc_PendenteConcluida.SelectedIndex = 0;
            this.tc_PendenteConcluida.Size = new System.Drawing.Size(1049, 220);
            this.tc_PendenteConcluida.TabIndex = 7;
            // 
            // tp_Pendentes
            // 
            this.tp_Pendentes.Controls.Add(this.listTarefasPendentes);
            this.tp_Pendentes.Location = new System.Drawing.Point(4, 29);
            this.tp_Pendentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tp_Pendentes.Name = "tp_Pendentes";
            this.tp_Pendentes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tp_Pendentes.Size = new System.Drawing.Size(1041, 187);
            this.tp_Pendentes.TabIndex = 0;
            this.tp_Pendentes.Text = "Tarefas Pendentes";
            this.tp_Pendentes.UseVisualStyleBackColor = true;
            // 
            // listTarefasPendentes
            // 
            this.listTarefasPendentes.FormattingEnabled = true;
            this.listTarefasPendentes.ItemHeight = 20;
            this.listTarefasPendentes.Location = new System.Drawing.Point(0, 20);
            this.listTarefasPendentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listTarefasPendentes.Name = "listTarefasPendentes";
            this.listTarefasPendentes.Size = new System.Drawing.Size(1041, 164);
            this.listTarefasPendentes.TabIndex = 6;
            // 
            // tp_Concluidas
            // 
            this.tp_Concluidas.Controls.Add(this.listTarefasConcluidas);
            this.tp_Concluidas.Location = new System.Drawing.Point(4, 29);
            this.tp_Concluidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tp_Concluidas.Name = "tp_Concluidas";
            this.tp_Concluidas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tp_Concluidas.Size = new System.Drawing.Size(1041, 187);
            this.tp_Concluidas.TabIndex = 1;
            this.tp_Concluidas.Text = "Tarefas Concluídas";
            this.tp_Concluidas.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 20;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(0, 20);
            this.listTarefasConcluidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(1041, 164);
            this.listTarefasConcluidas.TabIndex = 7;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 370);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(1045, 44);
            this.btn_Voltar.TabIndex = 10;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // GerenciadorTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 426);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_InserirItem);
            this.Controls.Add(this.tc_PendenteConcluida);
            this.Controls.Add(this.btn_AtualizarItem);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.l_GerenciadorTarefa);
            this.Controls.Add(this.l_linha);
            this.Name = "GerenciadorTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Tarefa";
            this.tc_PendenteConcluida.ResumeLayout(false);
            this.tp_Pendentes.ResumeLayout(false);
            this.tp_Concluidas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_GerenciadorTarefa;
        private System.Windows.Forms.Label l_linha;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_InserirItem;
        private System.Windows.Forms.Button btn_AtualizarItem;
        private System.Windows.Forms.TabControl tc_PendenteConcluida;
        private System.Windows.Forms.TabPage tp_Pendentes;
        private System.Windows.Forms.ListBox listTarefasPendentes;
        private System.Windows.Forms.TabPage tp_Concluidas;
        private System.Windows.Forms.ListBox listTarefasConcluidas;
        private System.Windows.Forms.Button btn_Voltar;
    }
}