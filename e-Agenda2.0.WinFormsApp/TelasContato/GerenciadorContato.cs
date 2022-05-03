using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using e_Agenda2._0.Dominio;
using e_Agenda2._0.Dominio.ModuloCompromisso;
using e_Agenda2._0.Dominio.ModuloContato;
using e_Agenda2._0.Infra.Arquivos;
using e_Agenda2._0.Infra.Arquivos.SerializaçãoEmJson;
using e_Agenda2._0.WinFormsApp.TelasContato;

namespace e_Agenda2._0.WinFormsApp
{
    public partial class GerenciadorContato : Form
    {
        private IRepositorioContato repositorioContato;
        private IRepositorioCompromisso repositorioCompromisso;
        private Validar validar = new Validar();

        public GerenciadorContato()
        {
            SerializacaoDeContatosEmJsonDotnet serializadorContato = new SerializacaoDeContatosEmJsonDotnet();
            SerializacaoDeCompromissosEmJsonDotnet serializadorCompromisso = new SerializacaoDeCompromissosEmJsonDotnet();

            repositorioContato = new RepositorioContatoEmArquivo(serializadorContato);
            repositorioCompromisso = new RepositorioCompromissoEmArquivo(serializadorCompromisso);

            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            lb_Contatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                lb_Contatos.Items.Add(c);
            }
        }


        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroContato tela = new CadastroContato();
            tela.Contato = new Contato();

            DialogResult resultado = tela.ShowDialog();

            //confere se telefone, email e nome não estão vazios
            if (resultado == DialogResult.OK && !String.IsNullOrEmpty(tela.Contato.Telefone)
                && !String.IsNullOrEmpty(tela.Contato.Email) && !String.IsNullOrEmpty(tela.Contato.Nome))
            {
                //valida email e telefone com regex
                if (validar.TelefoneEstaValido(tela.Contato.Telefone) && validar.EmailEstaValido(tela.Contato.Email))
                {
                    List<Contato> contatos = repositorioContato.SelecionarTodos();

                    //verifica se existe um contato com o mesmo nome, email ou telefone
                    foreach(Contato contato in contatos)
                    {
                        if (tela.Contato.Telefone == contato.Telefone ||
                            tela.Contato.Email == contato.Email ||
                            tela.Contato.Nome == contato.Nome)
                        {
                            MessageBox.Show("Este contato já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                  return;
                        } 
                    }

                    //se tudo estiver ok, insira
                    repositorioContato.Inserir(tela.Contato);
                    CarregarContatos();
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)lb_Contatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContato tela = new CadastroContato();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)lb_Contatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                List<Compromisso> compromissos = repositorioCompromisso.SelecionarCompromissoFuturo();

                //verifica na lista de compromissos futuros se o contato escolhido para excluir está presente
                foreach (Compromisso compromisso in compromissos)
                {
                    if (compromisso.Contato.Nome == contatoSelecionado.Nome)
                    {
                        MessageBox.Show("Você não pode excluir este contato pois ele esta vinculado a um compromisso.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VisualizarCargo_Click(object sender, EventArgs e)
        {
            VisualizarPorCargo tela = new VisualizarPorCargo();

            DialogResult resultado = tela.ShowDialog();
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
