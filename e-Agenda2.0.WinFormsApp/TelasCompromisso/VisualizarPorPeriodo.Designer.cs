namespace e_Agenda2._0.WinFormsApp.TelasCompromisso
{
    partial class VisualizarPorPeriodo
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
            this.l_Visualizar = new System.Windows.Forms.Label();
            this.l_linha = new System.Windows.Forms.Label();
            this.dt_DataInicial = new System.Windows.Forms.DateTimePicker();
            this.l_DataInicial = new System.Windows.Forms.Label();
            this.dt_DataFinal = new System.Windows.Forms.DateTimePicker();
            this.l_DataFinal = new System.Windows.Forms.Label();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.lb_Compromissos = new System.Windows.Forms.ListBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Visualizar
            // 
            this.l_Visualizar.AutoSize = true;
            this.l_Visualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_Visualizar.Location = new System.Drawing.Point(261, 9);
            this.l_Visualizar.Name = "l_Visualizar";
            this.l_Visualizar.Size = new System.Drawing.Size(355, 24);
            this.l_Visualizar.TabIndex = 6;
            this.l_Visualizar.Text = "Visualizar Compromisso por Periodo";
            // 
            // l_linha
            // 
            this.l_linha.AutoSize = true;
            this.l_linha.Location = new System.Drawing.Point(-7, 20);
            this.l_linha.Name = "l_linha";
            this.l_linha.Size = new System.Drawing.Size(1029, 20);
            this.l_linha.TabIndex = 7;
            this.l_linha.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________";
            // 
            // dt_DataInicial
            // 
            this.dt_DataInicial.Location = new System.Drawing.Point(12, 80);
            this.dt_DataInicial.Name = "dt_DataInicial";
            this.dt_DataInicial.Size = new System.Drawing.Size(889, 27);
            this.dt_DataInicial.TabIndex = 13;
            // 
            // l_DataInicial
            // 
            this.l_DataInicial.AutoSize = true;
            this.l_DataInicial.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_DataInicial.Location = new System.Drawing.Point(12, 58);
            this.l_DataInicial.Name = "l_DataInicial";
            this.l_DataInicial.Size = new System.Drawing.Size(96, 19);
            this.l_DataInicial.TabIndex = 12;
            this.l_DataInicial.Text = "Data Inicial:";
            // 
            // dt_DataFinal
            // 
            this.dt_DataFinal.Location = new System.Drawing.Point(12, 163);
            this.dt_DataFinal.Name = "dt_DataFinal";
            this.dt_DataFinal.Size = new System.Drawing.Size(889, 27);
            this.dt_DataFinal.TabIndex = 15;
            // 
            // l_DataFinal
            // 
            this.l_DataFinal.AutoSize = true;
            this.l_DataFinal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_DataFinal.Location = new System.Drawing.Point(12, 141);
            this.l_DataFinal.Name = "l_DataFinal";
            this.l_DataFinal.Size = new System.Drawing.Size(88, 19);
            this.l_DataFinal.TabIndex = 14;
            this.l_DataFinal.Text = "Data Final:";
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(14, 208);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(887, 49);
            this.btn_Visualizar.TabIndex = 16;
            this.btn_Visualizar.Text = "Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // lb_Compromissos
            // 
            this.lb_Compromissos.Enabled = false;
            this.lb_Compromissos.FormattingEnabled = true;
            this.lb_Compromissos.ItemHeight = 20;
            this.lb_Compromissos.Location = new System.Drawing.Point(14, 302);
            this.lb_Compromissos.Name = "lb_Compromissos";
            this.lb_Compromissos.Size = new System.Drawing.Size(887, 144);
            this.lb_Compromissos.TabIndex = 17;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Voltar.Location = new System.Drawing.Point(12, 502);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(889, 49);
            this.btn_Voltar.TabIndex = 18;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // VisualizarPorPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 563);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.lb_Compromissos);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.dt_DataFinal);
            this.Controls.Add(this.l_DataFinal);
            this.Controls.Add(this.dt_DataInicial);
            this.Controls.Add(this.l_DataInicial);
            this.Controls.Add(this.l_Visualizar);
            this.Controls.Add(this.l_linha);
            this.Name = "VisualizarPorPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar por Periodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Visualizar;
        private System.Windows.Forms.Label l_linha;
        private System.Windows.Forms.DateTimePicker dt_DataInicial;
        private System.Windows.Forms.Label l_DataInicial;
        private System.Windows.Forms.DateTimePicker dt_DataFinal;
        private System.Windows.Forms.Label l_DataFinal;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.ListBox lb_Compromissos;
        private System.Windows.Forms.Button btn_Voltar;
    }
}