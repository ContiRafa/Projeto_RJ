using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void lbl_name_header_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pesquisa_nome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //barra de pesquisa por nome de usuario
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            // fazer uma procedure e chamar para realizar um select * from cad_usuarios where nome like '% + txt_pesquisaNome.Text + %' ....  + 
            // pesquisar com caixa alta ou baixa e realizar o código para popular o datagridview com os resultados
            // depois fazer o código para quando clicar em um registro do datagridview, popular os campos abaixo para edição/exclusão
        }

        private void tbl_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // popular os campos abaixo com os dados do registro selecionado no datagridview
        }
    }
}
