using meSalva.BLL;
using meSalva.DTO;
using meSalva.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meSalva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LoginDTO loginDTO = new LoginDTO();
        LoginBLL loginBLL = new LoginBLL();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginDTO.Cpf = int.Parse(txtCpf.Text);
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                FormUsuario Frm_Usuario = new FormUsuario();
                Frm_Usuario.ShowDialog();
            }

            else
            {
                {
                    MessageBox.Show("Confira se há algo errado.", "Há algo errado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
