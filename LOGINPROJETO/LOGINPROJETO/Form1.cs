using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGINPROJETO
{
    public partial class Login : Form
    {
        private CadastroEmpresa cadastroEmpresa;
        private CadastroUsuarioLista cadastroUsuarioLista;
        private List<string> listaEmail = new List<string>();
        private List<string> listaSenha = new List<string>();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;



            if (listaEmail.Contains(email) && listaSenha.Contains(senha)) // Corrigir a condição de verificação
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;



            if (email.Length == 0 && senha.Length == 0)
            {
                MessageBox.Show("Nenhum campo foi preenchido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            listaEmail.Add(txtEmail.Text);
            listaSenha.Add(txtSenha.Text);



            txtEmail.Clear();
            txtSenha.Clear();

            MessageBox.Show("Seu email e senha foram listados com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuarioLista Usuario = new CadastroUsuarioLista();
            Usuario.ShowDialog();
        }

        private void eMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmpresa Empresa = new CadastroEmpresa();
            Empresa.ShowDialog();
        }
    }
}
