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

namespace e_Agenda2._0.WinFormsApp
{
    public partial class CadastroItemTarefa : Form
    {
        public readonly Tarefa tarefa;

        public CadastroItemTarefa(Tarefa tarefa)
        {
            InitializeComponent();

            this.tarefa = tarefa;

            //passando a tarefa para a tela
            l_TarefaSelecionada.Text = tarefa.Titulo;

            //passando os itens já cadastrados
            foreach (Item item in tarefa.Itens)
            {
                lb_Itens.Items.Add(item);
            }
        }

        public List<Item> ItensAdicionados
        {
            get
            {
                return lb_Itens.Items.Cast<Item>().ToList();
            }
        }

        private void btn_AdicionarItem_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(tb_Titulo.Text) == false)
            {
                Item item = new Item();

                item.Titulo = tb_Titulo.Text;
                
                if (cb_Status.SelectedIndex == 0)
                {
                    item.Concluido = false;
                }
                else if (cb_Status.SelectedIndex == 1)
                {
                    item.Concluido = true;
                }

                lb_Itens.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_Titulo.Clear();
            tb_Descricao.Clear();
            cb_Status.SelectedIndex = -1;

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
