namespace e_Agenda2._0.WinFormsApp
{
    partial class AtualizacaoItemTarefa
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
            this.l_AtualizacaoItem = new System.Windows.Forms.Label();
            this.l_Linha = new System.Windows.Forms.Label();
            this.l_TarefaSelecionada = new System.Windows.Forms.Label();
            this.l_Titulo = new System.Windows.Forms.Label();
            this.checkedLb_Itens = new System.Windows.Forms.CheckedListBox();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_AtualizacaoItem
            // 
            this.l_AtualizacaoItem.AutoSize = true;
            this.l_AtualizacaoItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_AtualizacaoItem.Location = new System.Drawing.Point(103, 9);
            this.l_AtualizacaoItem.Name = "l_AtualizacaoItem";
            this.l_AtualizacaoItem.Size = new System.Drawing.Size(193, 24);
            this.l_AtualizacaoItem.TabIndex = 2;
            this.l_AtualizacaoItem.Text = "Atualização de Item";
            // 
            // l_Linha
            // 
            this.l_Linha.AutoSize = true;
            this.l_Linha.Location = new System.Drawing.Point(-8, 19);
            this.l_Linha.Name = "l_Linha";
            this.l_Linha.Size = new System.Drawing.Size(417, 20);
            this.l_Linha.TabIndex = 3;
            this.l_Linha.Text = "____________________________________________________________________";
            // 
            // l_TarefaSelecionada
            // 
            this.l_TarefaSelecionada.AutoSize = true;
            this.l_TarefaSelecionada.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_TarefaSelecionada.Location = new System.Drawing.Point(12, 51);
            this.l_TarefaSelecionada.Name = "l_TarefaSelecionada";
            this.l_TarefaSelecionada.Size = new System.Drawing.Size(154, 19);
            this.l_TarefaSelecionada.TabIndex = 4;
            this.l_TarefaSelecionada.Text = "Tarefa Selecionada:";
            // 
            // l_Titulo
            // 
            this.l_Titulo.AutoSize = true;
            this.l_Titulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_Titulo.Location = new System.Drawing.Point(12, 70);
            this.l_Titulo.Name = "l_Titulo";
            this.l_Titulo.Size = new System.Drawing.Size(151, 19);
            this.l_Titulo.TabIndex = 5;
            this.l_Titulo.Text = "TarefaSelecionada";
            // 
            // checkedLb_Itens
            // 
            this.checkedLb_Itens.FormattingEnabled = true;
            this.checkedLb_Itens.Location = new System.Drawing.Point(12, 105);
            this.checkedLb_Itens.Name = "checkedLb_Itens";
            this.checkedLb_Itens.Size = new System.Drawing.Size(379, 224);
            this.checkedLb_Itens.TabIndex = 6;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Atualizar.Location = new System.Drawing.Point(12, 360);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(379, 47);
            this.btn_Atualizar.TabIndex = 7;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 413);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(379, 47);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // AtualizacaoItemTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 478);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.checkedLb_Itens);
            this.Controls.Add(this.l_Titulo);
            this.Controls.Add(this.l_TarefaSelecionada);
            this.Controls.Add(this.l_AtualizacaoItem);
            this.Controls.Add(this.l_Linha);
            this.Name = "AtualizacaoItemTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização de Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_AtualizacaoItem;
        private System.Windows.Forms.Label l_Linha;
        private System.Windows.Forms.Label l_TarefaSelecionada;
        private System.Windows.Forms.Label l_Titulo;
        private System.Windows.Forms.CheckedListBox checkedLb_Itens;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}