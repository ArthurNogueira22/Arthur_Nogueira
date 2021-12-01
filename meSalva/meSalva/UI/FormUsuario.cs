using meSalva.BLL;
using meSalva.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meSalva.UI
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        UsuarioBLL usuarioBLL = new UsuarioBLL();
        UsuarioDTO usuarioDTO = new UsuarioDTO();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            usuarioDTO.Nome = txtNome.Text;
            usuarioDTO.Cpf = int.Parse(txtCpf.Text);
            usuarioDTO.Email = txtEmail.Text;
            usuarioDTO.Senha = txtSenha.Text;

            usuarioBLL.Inserir(usuarioDTO);
            dgvCadastro.DataSource = usuarioBLL.Listar();

            MessageBox.Show("Cadastrado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            usuarioBLL.Listar();
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            usuarioDTO.Nome = txtNome.Text;
            usuarioDTO.Cpf = int.Parse(txtCpf.Text);
            usuarioDTO.Email = txtEmail.Text;
            usuarioDTO.Senha = txtSenha.Text;

            usuarioBLL.Inserir(usuarioDTO);

            MessageBox.Show("Cadastrado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvCadastro.DataSource = usuarioBLL.Listar();

            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            dgvCadastro.DataSource = usuarioBLL.Listar();
        }

        private void dgvCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCpf.Text = dgvCadastro.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvCadastro.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvCadastro.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSenha.Text = dgvCadastro.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
