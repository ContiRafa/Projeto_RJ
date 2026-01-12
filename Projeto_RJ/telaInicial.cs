using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_RJ
{
    public partial class telaInicial : Form
    {
        public object frmInicial_Load { get; private set; }

        public telaInicial()
        {
            InitializeComponent();
        }

        private void lbl_name_header_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_header_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            modalSucess telaok = new modalSucess();
            telaok.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            senhaPref tela = new senhaPref();

            tela.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modalSucess telaok = new modalSucess();
            telaok.ShowDialog();
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
