namespace e_Agenda2._0.WinFormsApp.TelasTarefa
{
    partial class EdicaoTarefa
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
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.cb_Prioridade = new System.Windows.Forms.ComboBox();
            this.l_Prioridade = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.l_EdicaoTarefa = new System.Windows.Forms.Label();
            this.l_linha = new System.Windows.Forms.Label();
            this.l_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Location = new System.Drawing.Point(11, 75);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(210, 27);
            this.tb_Titulo.TabIndex = 21;
            // 
            // cb_Prioridade
            // 
            this.cb_Prioridade.FormattingEnabled = true;
            this.cb_Prioridade.Location = new System.Drawing.Point(12, 140);
            this.cb_Prioridade.Name = "cb_Prioridade";
            this.cb_Prioridade.Size = new System.Drawing.Size(210, 28);
            this.cb_Prioridade.TabIndex = 20;
            // 
            // l_Prioridade
            // 
            this.l_Prioridade.AutoSize = true;
            this.l_Prioridade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Prioridade.Location = new System.Drawing.Point(12, 118);
            this.l_Prioridade.Name = "l_Prioridade";
            this.l_Prioridade.Size = new System.Drawing.Size(90, 19);
            this.l_Prioridade.TabIndex = 19;
            this.l_Prioridade.Text = "Prioridade:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 260);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(210, 43);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Cadastrar.Location = new System.Drawing.Point(12, 211);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(210, 43);
            this.btn_Cadastrar.TabIndex = 13;
            this.btn_Cadastrar.Text = "Cadastrar Tarefa";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // l_EdicaoTarefa
            // 
            this.l_EdicaoTarefa.AutoSize = true;
            this.l_EdicaoTarefa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_EdicaoTarefa.Location = new System.Drawing.Point(32, 10);
            this.l_EdicaoTarefa.Name = "l_EdicaoTarefa";
            this.l_EdicaoTarefa.Size = new System.Drawing.Size(169, 24);
            this.l_EdicaoTarefa.TabIndex = 12;
            this.l_EdicaoTarefa.Text = "Edição de Tarefa";
            // 
            // l_linha
            // 
            this.l_linha.AutoSize = true;
            this.l_linha.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_linha.Location = new System.Drawing.Point(-172, 20);
            this.l_linha.Name = "l_linha";
            this.l_linha.Size = new System.Drawing.Size(504, 19);
            this.l_linha.TabIndex = 15;
            this.l_linha.Text = "_______________________________________________________";
            // 
            // l_Titulo
            // 
            this.l_Titulo.AutoSize = true;
            this.l_Titulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Titulo.Location = new System.Drawing.Point(12, 53);
            this.l_Titulo.Name = "l_Titulo";
            this.l_Titulo.Size = new System.Drawing.Size(53, 19);
            this.l_Titulo.TabIndex = 22;
            this.l_Titulo.Text = "Título:";
            // 
            // EdicaoTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 318);
            this.Controls.Add(this.l_Titulo);
            this.Controls.Add(this.tb_Titulo);
            this.Controls.Add(this.cb_Prioridade);
            this.Controls.Add(this.l_Prioridade);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.l_EdicaoTarefa);
            this.Controls.Add(this.l_linha);
            this.Name = "EdicaoTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.ComboBox cb_Prioridade;
        private System.Windows.Forms.Label l_Prioridade;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label l_EdicaoTarefa;
        private System.Windows.Forms.Label l_linha;
        private System.Windows.Forms.Label l_Titulo;
    }
}