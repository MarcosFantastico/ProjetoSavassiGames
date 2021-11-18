using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3a1Marcos33.Code.BLL;
using _3a1Marcos33.Code.DTO;
namespace _3a1Marcos33
{
    public partial class frm_CadastroJogos : Form
    {
        JogosBLL obj_jogosBLL = new JogosBLL();
        JogosDTO obj_jogosDTO = new JogosDTO();

        public frm_CadastroJogos()
        {
            
            InitializeComponent();
            dgv_cadastro_jogos.DataSource = obj_jogosBLL.listar();
            txt_id.Enabled = false;
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dgv_cadastro_jogos.DataSource = obj_jogosBLL.listar();

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            obj_jogosDTO.Id = Convert.ToInt32(txt_id.Text);
            obj_jogosDTO.Nome = txt_nome.Text;
            obj_jogosDTO.Preco = txt_preco.Text;
            obj_jogosDTO.Estoque = Convert.ToInt32(txt_estoque.Text);
            obj_jogosDTO.Datalancamento = mtxt_data_lancamento.Text;
            obj_jogosBLL.alterar(obj_jogosDTO);
            MessageBox.Show("Registro alterado com sucesso!", "Alteraçao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_cadastro_jogos.DataSource = obj_jogosBLL.listar();

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            obj_jogosDTO.Id = Convert.ToInt32(txt_id.Text);
            obj_jogosBLL.excluir(obj_jogosDTO);
            MessageBox.Show("Registro excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_cadastro_jogos.DataSource = obj_jogosBLL.listar();

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            obj_jogosDTO.Nome = txt_nome.Text;
            obj_jogosDTO.Preco = txt_preco.Text;
            obj_jogosDTO.Estoque = Convert.ToInt32(txt_estoque.Text);
            obj_jogosDTO.Datalancamento = mtxt_data_lancamento.Text;
            obj_jogosBLL.inserir(obj_jogosDTO);
            MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_cadastro_jogos.DataSource = obj_jogosBLL.listar();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroJogos_Load(object sender, EventArgs e)
        {
            dgv_cadastro_jogos.DataSource = obj_jogosBLL.listar();

        }

        private void dgv_cadastro_jogos_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_cadastro_jogos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_cadastro_jogos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_preco.Text = dgv_cadastro_jogos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_estoque.Text = dgv_cadastro_jogos.Rows[e.RowIndex].Cells[3].Value.ToString();
            mtxt_data_lancamento.Text = dgv_cadastro_jogos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
