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
    public partial class frm_gestaoSenha : Form
    {
        public frm_gestaoSenha()
        {
            InitializeComponent();
        }

        private void frm_gestaoSenha_Load(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------ATENDIMENTO TOTAL --------------------------------------------------------------------//

        private void lbl_atTotal_Click(object sender, EventArgs e)
        {
            // NOME DA LABEL DA SENHA
        }

        private void lbl_quantidade_Click(object sender, EventArgs e)
        {
            // QUANTIDADE DE ATENDIMENTOS PUXADA VIA BANCO EX: lbl_quantidade.Text = "quantidade puxada via banco(25)";
            


        }

        private void lbl_qtdPessoas_Click(object sender, EventArgs e)
        {
            // IF ELSE PARA SABER SE É PESSOA OU PESSOAS EX: NUMERO = 1 ? lbl_qtdPessoas.Text = "pessoa" : lbl_qtdPessoas.Text = "pessoas";
        }


        //--------------------------------------------------------------------- RECEPÇÃO --------------------------------------------------------------------//



        private void label3_Click(object sender, EventArgs e)
        {
            // NOME DA LABEL DA SENHA
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // QUANTIDADE DE ATENDIMENTOS PUXADA VIA BANCO EX: lbl_quantidade.Text = "quantidade puxada via banco(25)";

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // IF ELSE PARA SABER SE É PESSOA OU PESSOAS EX: NUMERO = 1 ? lbl_qtdPessoas.Text = "pessoa" : lbl_qtdPessoas.Text = "pessoas";

        }

        //--------------------------------------------------------------------- RETIRADA DE EXAMES --------------------------------------------------------------------//


        private void label6_Click(object sender, EventArgs e)
        {
            // NOME DA LABEL DA SENHA

        }

        private void label4_Click(object sender, EventArgs e)
        {
            // QUANTIDADE DE ATENDIMENTOS PUXADA VIA BANCO EX: lbl_quantidade.Text = "quantidade puxada via banco(25)";

        }


        private void label5_Click(object sender, EventArgs e)
        {
            // IF ELSE PARA SABER SE É PESSOA OU PESSOAS EX: NUMERO = 1 ? lbl_qtdPessoas.Text = "pessoa" : lbl_qtdPessoas.Text = "pessoas";

        }

        //--------------------------------------------------------------------- PREFERÊNCIAL --------------------------------------------------------------------//


        private void label9_Click(object sender, EventArgs e)
        {
            // NOME DA LABEL DA SENHA

        }

        private void label7_Click(object sender, EventArgs e)
        {
            // QUANTIDADE DE ATENDIMENTOS PUXADA VIA BANCO EX: lbl_quantidade.Text = "quantidade puxada via banco(25)";

        }

        private void label8_Click(object sender, EventArgs e)
        {
            // IF ELSE PARA SABER SE É PESSOA OU PESSOAS EX: NUMERO = 1 ? lbl_qtdPessoas.Text = "pessoa" : lbl_qtdPessoas.Text = "pessoas";

        }

        //--------------------------------------------------------------------- BOTÃO DE ATUALIZAR --------------------------------------------------------------------//


        private void button1_Click(object sender, EventArgs e)
        {
            //BOTAO PARA ATUALIZAR AS INFORMAÇÕES DA TELA OU FAZER ESQUEMA AUTOMATICO DE PUSHAR AS INFORMAÇÕES
            CarregarDadosDoBanco();

        }

        private void CarregarDadosDoBanco()
        {
            // LÓGICA PARA CARREGAR OS DADOS DO BANCO DE DADOS E ATUALIZAR AS LABELS NA TELA
            // Simulação
            int total = 45;
            int recepcao = 20;
            int retirada = 10;
            int preferencial = 1;

            lblTotal.Text = total.ToString();
            lblRecepcao.Text = recepcao.ToString();
            lblRetiradaExames.Text = retirada.ToString();
            lblPreferencial.Text = preferencial.ToString();

            MessageBox.Show("Dados atualizados com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (total == 1)
            {
                lbl_qtdPessoas.Text = "PESSOA" + ContentAlignment.MiddleCenter;
            }
            else
            {
                lbl_qtdPessoas.Text = "PESSOAS";
            }
            if (recepcao == 1)
            {
                lbl_pessoas.Text = "PESSOA";
            }
            else
            {
                lbl_pessoas.Text = "PESSOAS";
            }
            if (retirada == 1)
            {
                label5.Text = "PESSOA";
            }
            else
            {
                label5.Text = "PESSOAS";
            }
            if (preferencial == 1)
            {
                label8.Text = "PESSOA";
            }
            else
            {
                label8.Text = "PESSOAS";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
