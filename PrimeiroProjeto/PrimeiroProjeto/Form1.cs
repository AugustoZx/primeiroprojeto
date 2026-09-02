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

            if (email == "" || senha == "")
            {
                MessageBox.Show(
                    "Preencha o email e a senha.",
                    "Atencao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (email.ToLower() == EmailCadastrado
        && senha == SenhaCadastrada)
            {
                MessageBox.Show(
                    "Login realizado com sucesso!",
                    "Bem-vindo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            else
            {
                MessageBox.Show(
                    "Email ou senha incorretos.",
                    "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
            }


        }
    }
}
