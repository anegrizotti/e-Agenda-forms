using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Agenda2._0.Dominio.ModuloTarefa;

namespace e_Agenda2._0.WinFormsApp.TelasTarefa
{

    public partial class EdicaoTarefa : Form
    {

        private Tarefa tarefa;

        public EdicaoTarefa()
        {
            InitializeComponent();

            //inserindo as prioridades no combo box
            cb_Prioridade.Items.Add("Alta");
            cb_Prioridade.Items.Add("Normal");
            cb_Prioridade.Items.Add("Baixa");

            //vai inicializar com "Baixa" selecionado
            cb_Prioridade.SelectedIndex = 2;
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                tb_Titulo.Text = tarefa.Titulo;
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_Titulo.Text))
            {
                tarefa.Titulo = tb_Titulo.Text;

                if (cb_Prioridade.SelectedIndex == 0)
                {
                    tarefa.Prioridade = 0;
                }
                else if (cb_Prioridade.SelectedIndex == 1)
                {
                    tarefa.Prioridade = (PrioridadeTarefa)1;
                }
                else if (cb_Prioridade.SelectedIndex == 2)
                {
                    tarefa.Prioridade = (PrioridadeTarefa)2;
                }

            }
            else
            {

                MessageBox.Show("Você não pode cadastrar uma tarefa sem um título!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metodo serve apenas para não deixar o usuario movimentar o formulario
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

    }
}
