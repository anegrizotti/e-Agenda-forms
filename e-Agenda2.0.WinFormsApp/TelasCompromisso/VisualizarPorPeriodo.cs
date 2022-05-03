using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Agenda2._0.Dominio.ModuloCompromisso;
using e_Agenda2._0.Infra.Arquivos;
using e_Agenda2._0.Infra.Arquivos.SerializaçãoEmJson;

namespace e_Agenda2._0.WinFormsApp.TelasCompromisso
{
    public partial class VisualizarPorPeriodo : Form
    {
        private Compromisso compromisso;
        private IRepositorioCompromisso repositorioCompromisso;

        public VisualizarPorPeriodo()
        {
            InitializeComponent();

            SerializacaoDeCompromissosEmJsonDotnet serializadorCompromisso = new SerializacaoDeCompromissosEmJsonDotnet();
            repositorioCompromisso = new RepositorioCompromissoEmArquivo(serializadorCompromisso);
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarCompromissoPorPeriodo(dt_DataInicial.Value, dt_DataFinal.Value);

            lb_Compromissos.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                lb_Compromissos.Items.Add(c);
            }
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
