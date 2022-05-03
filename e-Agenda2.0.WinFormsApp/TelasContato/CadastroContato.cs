using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Agenda2._0.Dominio.ModuloContato;
using e_Agenda2._0.Dominio;

namespace e_Agenda2._0.WinFormsApp.TelasContato
{
    public partial class CadastroContato : Form
    {
        private Contato contato;

        public CadastroContato()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                tb_Nome.Text = contato.Nome;
                tb_Email.Text = contato.Email;
                tb_Telefone.Text = contato.Telefone;
                tb_Empresa.Text = contato.Empresa;
                tb_Cargo.Text = contato.Cargo;
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            contato.Nome = tb_Nome.Text;
            contato.Email = tb_Email.Text;
            contato.Telefone = tb_Telefone.Text;
            contato.Empresa = tb_Empresa.Text;
            contato.Cargo = tb_Cargo.Text;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
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
