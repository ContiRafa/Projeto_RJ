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
    public partial class frm_ADM : Form
    {
        public frm_ADM()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //coloquei um "gap" entre os botões de 10 px
            btn_gestaoSenhas.Margin = new Padding(10);
            btn_controleSenha.Margin = new Padding(10);
            btn_config.Margin = new Padding(10);
        }

        private void btn_gestaoSenhas_Click(object sender, EventArgs e)
        {
            btn_gestaoSenhas.Text = $"{Environment.NewLine}{Environment.NewLine}GESTÃO DE SENHAS";
            frm_gestaoSenha tela = new frm_gestaoSenha();
            tela.ShowDialog();
        }
    }
}
