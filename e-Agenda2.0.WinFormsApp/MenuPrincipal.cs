using System;
using System.Collections.Generic;
using System.Windows.Forms;
using e_Agenda2._0.Dominio.ModuloCompromisso;
using e_Agenda2._0.Dominio.ModuloContato;
using e_Agenda2._0.Dominio.ModuloTarefa;
using e_Agenda2._0.Infra.Arquivos;
using e_Agenda2._0.Infra.Arquivos.SerializadorJsonDotnet;

namespace e_Agenda2._0.WinFormsApp
{
    public partial class MenuPrincipal : Form
    {
        private IRepositorioTarefa repositorioTarefa;
        private IRepositorioContato repositorioContato;
        private IRepositorioCompromisso repositorioCompromisso;

        public MenuPrincipal()
        {
            ISerializador serializador = new SerializadorDadosJsonDotnet();

            DataContext contextoDados = new DataContext();

            repositorioTarefa = new RepositorioTarefaEmArquivo(serializador, contextoDados);
            repositorioContato = new RepositorioContatoEmArquivo(serializador, contextoDados);
            repositorioCompromisso = new RepositorioCompromissoEmArquivo(serializador, contextoDados);

            InitializeComponent();

            CarregarTarefa();
            CarregarContato();
            CarregarCompromisso();
        }

        private void CarregarTarefa()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            lb_Tarefas.Items.Clear();

            foreach (Tarefa t in tarefas)
            {
                lb_Tarefas.Items.Add(t);
            }
        }

        private void CarregarContato()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            lb_Contatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                lb_Contatos.Items.Add(c);
            }
        }

        private void CarregarCompromisso()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            lb_Compromissos.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                lb_Compromissos.Items.Add(c);
            }
        }


        private void btn_GerenciarTarefas_Click(object sender, EventArgs e)
        {
            GerenciadorTarefa tela = new GerenciadorTarefa(repositorioTarefa);
            tela.Show();

        }

        private void btn_GerenciarCompromissos_Click(object sender, EventArgs e)
        {
            GerenciadorCompromisso tela = new GerenciadorCompromisso(repositorioCompromisso, repositorioContato);
            tela.Show();

        }

        private void btn_GerenciarContatos_Click(object sender, EventArgs e)
        {
            GerenciadorContato tela = new GerenciadorContato(repositorioContato, repositorioCompromisso);
            tela.Show();

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
