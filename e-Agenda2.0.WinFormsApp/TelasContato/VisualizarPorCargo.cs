using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Agenda2._0.Dominio.ModuloContato;
using e_Agenda2._0.Infra.Arquivos;
using e_Agenda2._0.Infra.Arquivos.SerializaçãoEmJson;

namespace e_Agenda2._0.WinFormsApp.TelasContato
{
    public partial class VisualizarPorCargo : Form
    {
        private Contato contato;
        private IRepositorioContato repositorioContato;

        public VisualizarPorCargo()
        {
            InitializeComponent();

            SerializacaoDeContatosEmJsonDotnet serializadorContato = new SerializacaoDeContatosEmJsonDotnet();
            repositorioContato = new RepositorioContatoEmArquivo(serializadorContato);

            List<Contato> contatos = repositorioContato.SelecionarTodos();

            cb_Cargos.Items.Clear();

            //passando os cargos para o combo box
            foreach (Contato c in contatos)
            {
                //se o cargo não for vazio e se ele ainda não esta no combo box, inserir
                if (!String.IsNullOrEmpty(c.Cargo) && !cb_Cargos.Items.Contains(c.Cargo))
                    cb_Cargos.Items.Add(c.Cargo);
            }
        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            lb_Contatos.Items.Clear();

            List<Contato> contatos = repositorioContato.SelecionarTodos();

            foreach (var contato in contatos)
            {
                if (cb_Cargos.Text == contato.Cargo)
                {
                    lb_Contatos.Items.Add(contato);
                }
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
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
