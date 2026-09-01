using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class Form1 : Form
    {
        private const string EmailCadastrado = "augusto@teste.com";
        private const string SenhaCadastrada = "1234";

        public Form1()
        {
            InitializeComponent();

            this.Resize += (s, e) => CentralizarPainel();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void pnlEntrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CentralizarPainel()
        {
            pnlEntrar.Left = (this.ClientSize.Width - pnlEntrar.Width) / 2;
            pnlEntrar.Top = (this.ClientSize.Height - pnlEntrar.Height) / 2;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;

            
        }
    }
}
