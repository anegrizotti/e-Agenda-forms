using System;
using System.Collections.Generic;
using System.Windows.Forms;
using e_Agenda2._0.Dominio.ModuloCompromisso;
using e_Agenda2._0.Dominio.ModuloContato;
using e_Agenda2._0.Infra.Arquivos;
using e_Agenda2._0.Infra.Arquivos.SerializaçãoEmJson;

namespace e_Agenda2._0.WinFormsApp.TelasCompromisso
{
    public partial class CadastroCompromisso : Form
    {
        private Compromisso compromisso;
        private IRepositorioContato repositorioContato;

        public CadastroCompromisso()
        {
            InitializeComponent();

            SerializacaoDeContatosEmJsonDotnet serializadorContato = new SerializacaoDeContatosEmJsonDotnet();
            repositorioContato = new RepositorioContatoEmArquivo(serializadorContato);

            List<Contato> contatos = repositorioContato.SelecionarTodos();
            
            cb_Contato.Items.Clear();

            //passando o contato (nome) para o combo box de contatos
            foreach (Contato c in contatos)
            {
                cb_Contato.Items.Add(c.Nome);
            }

        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
                tb_Assunto.Text = compromisso.Assunto;
                tb_Local.Text = compromisso.Local;

                if (compromisso.DataCompromisso < dt_Data.MinDate)
                {
                    dt_Data.Value = DateTime.Now;
                }
                else
                {
                    dt_Data.Value = compromisso.DataCompromisso;
                }

                tb_HoraInicio.Text = compromisso.HoraInicio;
                tb_HoraTermino.Text = compromisso.HoraTermino;

                if (!String.IsNullOrEmpty(cb_Contato.Text))
                {
                    cb_Contato.Text = compromisso.Contato.Nome;
                }

            }
        }

        //método que pega o objeto contato a partir do nome selecionado pelo usuario no combo box
        private Contato ReceberContato(string nome)
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            foreach (Contato contato in contatos)
            {
                if (contato.Nome == nome)
                    return contato;
            }

            return null;
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = tb_Assunto.Text;
            compromisso.Local = tb_Local.Text;
            compromisso.DataCompromisso = dt_Data.Value;
            compromisso.HoraInicio = tb_HoraInicio.Text;
            compromisso.HoraTermino = tb_HoraTermino.Text;
            compromisso.Contato = ReceberContato(cb_Contato.Text);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metódo serve apenas para não deixar o usuario movimentar o formulario
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
