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
using e_Agenda2._0.Infra.Arquivos;
using e_Agenda2._0.Infra.Arquivos.SerializaçãoEmJson;

namespace e_Agenda2._0.WinFormsApp
{
    public partial class AtualizacaoItemTarefa : Form
    {
        private readonly Tarefa tarefa;
        private IRepositorioTarefa repositorioTarefa;

        public AtualizacaoItemTarefa(Tarefa tarefa)
        {
            SerializacaoDeTarefasEmJsonDotnet serializadorTarefa = new SerializacaoDeTarefasEmJsonDotnet();
            repositorioTarefa = new RepositorioTarefaEmArquivo(serializadorTarefa);

            InitializeComponent();
            this.tarefa = tarefa;

            //passando o titulo da tarefa para a tela
            l_Titulo.Text = tarefa.Titulo;

            CarregarItensTarefa(tarefa);
        }

        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                checkedLb_Itens.Items.Add(item);

                if (item.Concluido)
                    checkedLb_Itens.SetItemChecked(i, true);

                i++;
            }

            foreach (var item in tarefa.Itens)
            {
                if (checkedLb_Itens.SelectedItems.Count == checkedLb_Itens.Items.Count)
                {
                    repositorioTarefa.Excluir(tarefa);
                }
                
            }
        }

        public List<Item> ItensConcluidos
        {
            get
            {
                return checkedLb_Itens.CheckedItems
                    .Cast<Item>()
                    .ToList();
            }
        }

        public List<Item> ItensPendentes
        {
            get
            {
                return checkedLb_Itens.Items
                    .Cast<Item>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
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
