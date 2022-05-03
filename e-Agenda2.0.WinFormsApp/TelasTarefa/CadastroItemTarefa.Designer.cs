namespace e_Agenda2._0.WinFormsApp
{
    partial class CadastroItemTarefa
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
            this.l_CadastroItem = new System.Windows.Forms.Label();
            this.l_Linha = new System.Windows.Forms.Label();
            this.l_Tarefa = new System.Windows.Forms.Label();
            this.l_TarefaSelecionada = new System.Windows.Forms.Label();
            this.l_Titulo = new System.Windows.Forms.Label();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.tb_Descricao = new System.Windows.Forms.TextBox();
            this.l_Descricao = new System.Windows.Forms.Label();
            this.l_Status = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.btn_AdicionarItem = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lb_Itens = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // l_CadastroItem
            // 
            this.l_CadastroItem.AutoSize = true;
            this.l_CadastroItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_CadastroItem.Location = new System.Drawing.Point(89, 8);
            this.l_CadastroItem.Name = "l_CadastroItem";
            this.l_CadastroItem.Size = new System.Drawing.Size(171, 24);
            this.l_CadastroItem.TabIndex = 0;
            this.l_CadastroItem.Text = "Cadastro de Item";
            // 
            // l_Linha
            // 
            this.l_Linha.AutoSize = true;
            this.l_Linha.Location = new System.Drawing.Point(-40, 18);
            this.l_Linha.Name = "l_Linha";
            this.l_Linha.Size = new System.Drawing.Size(417, 20);
            this.l_Linha.TabIndex = 1;
            this.l_Linha.Text = "____________________________________________________________________";
            // 
            // l_Tarefa
            // 
            this.l_Tarefa.AutoSize = true;
            this.l_Tarefa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Tarefa.Location = new System.Drawing.Point(12, 50);
            this.l_Tarefa.Name = "l_Tarefa";
            this.l_Tarefa.Size = new System.Drawing.Size(154, 19);
            this.l_Tarefa.TabIndex = 2;
            this.l_Tarefa.Text = "Tarefa Selecionada:";
            // 
            // l_TarefaSelecionada
            // 
            this.l_TarefaSelecionada.AutoSize = true;
            this.l_TarefaSelecionada.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_TarefaSelecionada.Location = new System.Drawing.Point(12, 69);
            this.l_TarefaSelecionada.Name = "l_TarefaSelecionada";
            this.l_TarefaSelecionada.Size = new System.Drawing.Size(151, 19);
            this.l_TarefaSelecionada.TabIndex = 3;
            this.l_TarefaSelecionada.Text = "TarefaSelecionada";
            // 
            // l_Titulo
            // 
            this.l_Titulo.AutoSize = true;
            this.l_Titulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Titulo.Location = new System.Drawing.Point(12, 108);
            this.l_Titulo.Name = "l_Titulo";
            this.l_Titulo.Size = new System.Drawing.Size(53, 19);
            this.l_Titulo.TabIndex = 4;
            this.l_Titulo.Text = "Título:";
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Location = new System.Drawing.Point(71, 104);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(274, 27);
            this.tb_Titulo.TabIndex = 5;
            // 
            // tb_Descricao
            // 
            this.tb_Descricao.Location = new System.Drawing.Point(103, 155);
            this.tb_Descricao.Name = "tb_Descricao";
            this.tb_Descricao.Size = new System.Drawing.Size(242, 27);
            this.tb_Descricao.TabIndex = 7;
            // 
            // l_Descricao
            // 
            this.l_Descricao.AutoSize = true;
            this.l_Descricao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Descricao.Location = new System.Drawing.Point(12, 159);
            this.l_Descricao.Name = "l_Descricao";
            this.l_Descricao.Size = new System.Drawing.Size(89, 19);
            this.l_Descricao.TabIndex = 6;
            this.l_Descricao.Text = "Descrição:";
            // 
            // l_Status
            // 
            this.l_Status.AutoSize = true;
            this.l_Status.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Status.Location = new System.Drawing.Point(12, 211);
            this.l_Status.Name = "l_Status";
            this.l_Status.Size = new System.Drawing.Size(59, 19);
            this.l_Status.TabIndex = 8;
            this.l_Status.Text = "Status:";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Pendente",
            "Concluído"});
            this.cb_Status.Location = new System.Drawing.Point(77, 207);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(268, 28);
            this.cb_Status.TabIndex = 9;
            // 
            // btn_AdicionarItem
            // 
            this.btn_AdicionarItem.Location = new System.Drawing.Point(12, 270);
            this.btn_AdicionarItem.Name = "btn_AdicionarItem";
            this.btn_AdicionarItem.Size = new System.Drawing.Size(333, 38);
            this.btn_AdicionarItem.TabIndex = 10;
            this.btn_AdicionarItem.Text = "Adicionar Item";
            this.btn_AdicionarItem.UseVisualStyleBackColor = true;
            this.btn_AdicionarItem.Click += new System.EventHandler(this.btn_AdicionarItem_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Location = new System.Drawing.Point(12, 491);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(333, 38);
            this.btn_Gravar.TabIndex = 11;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 535);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(333, 38);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lb_Itens
            // 
            this.lb_Itens.Enabled = false;
            this.lb_Itens.FormattingEnabled = true;
            this.lb_Itens.ItemHeight = 20;
            this.lb_Itens.Location = new System.Drawing.Point(12, 314);
            this.lb_Itens.Name = "lb_Itens";
            this.lb_Itens.Size = new System.Drawing.Size(333, 104);
            this.lb_Itens.TabIndex = 13;
            // 
            // CadastroItemTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 586);
            this.Controls.Add(this.lb_Itens);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.btn_AdicionarItem);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.l_Status);
            this.Controls.Add(this.tb_Descricao);
            this.Controls.Add(this.l_Descricao);
            this.Controls.Add(this.tb_Titulo);
            this.Controls.Add(this.l_Titulo);
            this.Controls.Add(this.l_TarefaSelecionada);
            this.Controls.Add(this.l_Tarefa);
            this.Controls.Add(this.l_CadastroItem);
            this.Controls.Add(this.l_Linha);
            this.Name = "CadastroItemTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_CadastroItem;
        private System.Windows.Forms.Label l_Linha;
        private System.Windows.Forms.Label l_Tarefa;
        private System.Windows.Forms.Label l_TarefaSelecionada;
        private System.Windows.Forms.Label l_Titulo;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.TextBox tb_Descricao;
        private System.Windows.Forms.Label l_Descricao;
        private System.Windows.Forms.Label l_Status;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button btn_AdicionarItem;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ListBox lb_Itens;
    }
}