using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3a1Marcos33.Code.DTO;
using _3a1Marcos33.Code.BLL;
namespace _3a1Marcos33
{
    public partial class Login : Form
    {
        LoginDTO obj_login_dto = new LoginDTO();
        LoginBLL obj_login_bll = new LoginBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj_login_dto.Email = txt_email.Text;
            obj_login_dto.Senha = txt_senha.Text;

            if (obj_login_bll.realizarLogin(obj_login_dto) == true)
            {
                frm_CadastroJogos frm = new frm_CadastroJogos();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
