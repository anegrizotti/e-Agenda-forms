using System;
using System.Collections.Generic;
using System.Windows.Forms;
using e_Agenda2._0.Dominio;
using e_Agenda2._0.Dominio.ModuloCompromisso;
using e_Agenda2._0.Dominio.ModuloContato;
using e_Agenda2._0.Infra.Arquivos;
using e_Agenda2._0.Infra.Arquivos.SerializadorJsonDotnet;
using e_Agenda2._0.WinFormsApp.TelasCompromisso;

namespace e_Agenda2._0.WinFormsApp
{
    public partial class GerenciadorCompromisso : Form
    {
        IRepositorioCompromisso repositorioCompromisso;
        IRepositorioContato repositorioContato;
        private Validar validar;

        public GerenciadorCompromisso(IRepositorioCompromisso repositorioCompromisso, IRepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;

            validar = new Validar();

            InitializeComponent();
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissosPassados = repositorioCompromisso.SelecionarCompromissoPassado();

            listCompromissosPassados.Items.Clear();

            foreach (Compromisso c in compromissosPassados)
            {
                listCompromissosPassados.Items.Add(c);
            }

            List<Compromisso> compromissosFuturos = repositorioCompromisso.SelecionarCompromissoFuturo();

            listCompromissosFuturos.Items.Clear();

            foreach (Compromisso c in compromissosFuturos)
            {
                listCompromissosFuturos.Items.Add(c);
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroCompromisso tela = new CadastroCompromisso(repositorioContato);
            tela.Compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            //confere se assunto e local não estão vazios e se o horário inputado esta no formado esperado >>"00:00"
            if (resultado == DialogResult.OK &&
                !String.IsNullOrEmpty(tela.Compromisso.Assunto) &&
                !String.IsNullOrEmpty(tela.Compromisso.Local) &&
                validar.HorarioEstaValido(tela.Compromisso.HoraInicio) &&
                validar.HorarioEstaValido(tela.Compromisso.HoraTermino)) 
            {
                //confere se a data do compromisso não é menor do que a data de hoje
                if (tela.Compromisso.DataCompromisso >= DateTime.Today &&
                    TimeSpan.Parse(tela.Compromisso.HoraTermino) > TimeSpan.Parse(tela.Compromisso.HoraInicio))
                {
                    //confere se não tem um compromisso no mesmo dia e mesmo horario
                    List<Compromisso> compromissos = repositorioCompromisso.SelecionarCompromissoFuturo();

                    foreach (Compromisso compromisso in compromissos)
                    {
                        if (tela.Compromisso.DataCompromisso.Date == compromisso.DataCompromisso.Date && TimeSpan.Parse(compromisso.HoraTermino) > TimeSpan.Parse(tela.Compromisso.HoraInicio))
                        {
                            MessageBox.Show("Você não pode cadastrar compromissos na mesma data e horario!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    //se todas as verificações estiverem ok, inserir
                    repositorioCompromisso.Inserir(tela.Compromisso);
                    CarregarCompromissos();
                    return;
                }
            }

            MessageBox.Show("Preencha os campos corretamente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSemanal = (Compromisso)listCompromissosPassados.SelectedItem;
            Compromisso compromissoFuturo = (Compromisso)listCompromissosFuturos.SelectedItem;

            if (compromissoSemanal == null && compromissoFuturo == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroCompromisso tela = new CadastroCompromisso(repositorioContato);

            //verificando se o usuario selecionou um compromisso semanal ou futuro 

            //se ele selecionou um semanal
            if (compromissoSemanal != null)
            {
                tela.Compromisso = compromissoSemanal;

                DialogResult resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioCompromisso.Editar(tela.Compromisso);
                    CarregarCompromissos();
                }
            }
            
            //se não se ele selecionou um futuro
            else if (compromissoFuturo != null)
            {
                tela.Compromisso = compromissoFuturo;

                DialogResult resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioCompromisso.Editar(tela.Compromisso);
                    CarregarCompromissos();
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSemanal = (Compromisso)listCompromissosPassados.SelectedItem;
            Compromisso compromissoFuturo = (Compromisso)listCompromissosFuturos.SelectedItem;

            if (compromissoSemanal == null && compromissoFuturo == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o compromisso?",
                "Exclusão de Compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                //verificando se o usuario selecionou um compromisso semanal ou futuro 

                //se ele selecionou um futuro
                if (compromissoFuturo != null)
                {
                    repositorioCompromisso.Excluir(compromissoFuturo);
                    CarregarCompromissos();
                }
                //se não se ele selecionou um semanal
                else if (compromissoSemanal != null)
                {
                    repositorioCompromisso.Excluir(compromissoSemanal);
                    CarregarCompromissos();
                }

            }

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VisualizarPeriodo_Click(object sender, EventArgs e)
        {
            VisualizarPorPeriodo tela = new VisualizarPorPeriodo(repositorioCompromisso);
            tela.Compromisso = new Compromisso();

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
