
namespace _3a1Marcos33
{
    partial class frm_CadastroJogos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroJogos));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_data_lancamento = new System.Windows.Forms.Label();
            this.dgv_cadastro_jogos = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.txt_estoque = new System.Windows.Forms.TextBox();
            this.mtxt_data_lancamento = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_ld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cadastro_jogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(226, 23);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(43, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(113, 80);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(40, 15);
            this.lbl_preco.TabIndex = 1;
            this.lbl_preco.Text = "Preço:";
            // 
            // lbl_data_lancamento
            // 
            this.lbl_data_lancamento.AutoSize = true;
            this.lbl_data_lancamento.Location = new System.Drawing.Point(445, 80);
            this.lbl_data_lancamento.Name = "lbl_data_lancamento";
            this.lbl_data_lancamento.Size = new System.Drawing.Size(116, 15);
            this.lbl_data_lancamento.TabIndex = 2;
            this.lbl_data_lancamento.Text = "Data de lançamento:";
            // 
            // dgv_cadastro_jogos
            // 
            this.dgv_cadastro_jogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cadastro_jogos.Location = new System.Drawing.Point(12, 134);
            this.dgv_cadastro_jogos.Name = "dgv_cadastro_jogos";
            this.dgv_cadastro_jogos.RowTemplate.Height = 25;
            this.dgv_cadastro_jogos.Size = new System.Drawing.Size(709, 150);
            this.dgv_cadastro_jogos.TabIndex = 3;
            this.dgv_cadastro_jogos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cadastro_jogos_cell_click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(68, 319);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(106, 37);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(226, 319);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(106, 37);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(384, 319);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(106, 37);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(542, 319);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(106, 37);
            this.btn_listar.TabIndex = 7;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // lbl_estoque
            // 
            this.lbl_estoque.AutoSize = true;
            this.lbl_estoque.Location = new System.Drawing.Point(273, 80);
            this.lbl_estoque.Name = "lbl_estoque";
            this.lbl_estoque.Size = new System.Drawing.Size(52, 15);
            this.lbl_estoque.TabIndex = 8;
            this.lbl_estoque.Text = "Estoque:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(275, 21);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(407, 23);
            this.txt_nome.TabIndex = 9;
            this.txt_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(163, 76);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(100, 23);
            this.txt_preco.TabIndex = 11;
            // 
            // txt_estoque
            // 
            this.txt_estoque.Location = new System.Drawing.Point(335, 76);
            this.txt_estoque.Name = "txt_estoque";
            this.txt_estoque.Size = new System.Drawing.Size(100, 23);
            this.txt_estoque.TabIndex = 12;
            // 
            // mtxt_data_lancamento
            // 
            this.mtxt_data_lancamento.Location = new System.Drawing.Point(571, 76);
            this.mtxt_data_lancamento.Mask = "00/00/0000";
            this.mtxt_data_lancamento.Name = "mtxt_data_lancamento";
            this.mtxt_data_lancamento.Size = new System.Drawing.Size(111, 23);
            this.mtxt_data_lancamento.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(140, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(74, 23);
            this.txt_id.TabIndex = 16;
            // 
            // lbl_ld
            // 
            this.lbl_ld.AutoSize = true;
            this.lbl_ld.Location = new System.Drawing.Point(114, 24);
            this.lbl_ld.Name = "lbl_ld";
            this.lbl_ld.Size = new System.Drawing.Size(20, 15);
            this.lbl_ld.TabIndex = 15;
            this.lbl_ld.Text = "Id:";
            // 
            // frm_CadastroJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 376);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_ld);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtxt_data_lancamento);
            this.Controls.Add(this.txt_estoque);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_estoque);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.dgv_cadastro_jogos);
            this.Controls.Add(this.lbl_data_lancamento);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_CadastroJogos";
            this.Text = "CadastroJogos";
            this.Load += new System.EventHandler(this.CadastroJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cadastro_jogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_data_lancamento;
        private System.Windows.Forms.DataGridView dgv_cadastro_jogos;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Label lbl_estoque;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.TextBox txt_estoque;
        private System.Windows.Forms.MaskedTextBox mtxt_data_lancamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_ld;
    }
}