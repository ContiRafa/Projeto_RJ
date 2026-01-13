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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_preferencial_Click(object sender, EventArgs e)
        {
            Width = 19;
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            modalSucess tela = new modalSucess();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modalSucess tela = new modalSucess();
            tela.Show();
        }
    }
}
