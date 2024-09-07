using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadora_recarga_de_celular
{
    public partial class Frm_RecargaParaCelular : Form
    {
        public Frm_RecargaParaCelular()
        {
            InitializeComponent();
        }

        private void Rad_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Operadora.Text = "Vivo";
            
            BackColor = Color.DarkViolet; //Formatação da cor
            Lbl_BemVindo.ForeColor = Color.White;
            Lbl_Nome.ForeColor = Color.White;
            Grp_Operadoras.ForeColor = Color.White;
            Lbl_Operadora.ForeColor = Color.White;
            Lbl_DDD.ForeColor = Color.White;
            Lbl_Celular.ForeColor = Color.White;
            Lbl_Valor.ForeColor = Color.White;
            Lbl_SelecioneoValorDeRecarga.ForeColor = Color.White;
            Lbl_Validade1.ForeColor = Color.White;
            Lbl_Validade2.ForeColor = Color.White;
            Lbl_Validade3.ForeColor = Color.White;
            Lbl_Validade4.ForeColor = Color.White;
            Lbl_Validade5.ForeColor = Color.White;
            Lbl_Validade6.ForeColor = Color.White;
            Lbl_Validade7.ForeColor = Color.White;
            Lbl_Validade8.ForeColor = Color.White;

            // Formatação de cores Dos botões
            Btn_Validade1.ForeColor = Color.White;
            Btn_Validade1.FlatAppearance.MouseOverBackColor = Color.LightPink;
            
            Btn_Validade2.ForeColor = Color.White;
            Btn_Validade2.FlatAppearance.MouseOverBackColor = Color.LightPink;
            Btn_Validade3.ForeColor = Color.White;
            Btn_Validade3.FlatAppearance.MouseOverBackColor = Color.LightPink;
            Btn_Validade4.ForeColor = Color.White;
            Btn_Validade4.FlatAppearance.MouseOverBackColor = Color.LightPink;
            Btn_Validade5.ForeColor = Color.White;
            Btn_Validade5.FlatAppearance.MouseOverBackColor = Color.LightPink;
            Btn_Validade6.ForeColor = Color.White;
            Btn_Validade6.FlatAppearance.MouseOverBackColor = Color.LightPink;
            Btn_Validade7.ForeColor = Color.White;
            Btn_Validade7.FlatAppearance.MouseOverBackColor = Color.LightPink;
            Btn_Validade8.ForeColor = Color.White;
            Btn_Validade8.FlatAppearance.MouseOverBackColor = Color.LightPink;

            //Validando o Formulário 
            Lbl_BemVindo.Enabled = true;
            Lbl_Celular.Enabled = true;
            Lbl_DDD.Enabled = true;
            Lbl_Nome.Enabled = true;
            Lbl_Operadora.Enabled = true;
            Lbl_SelecioneoValorDeRecarga.Enabled = true;
            Lbl_Validade1.Enabled = true;
            Lbl_Validade2.Enabled = true;
            Lbl_Validade3.Enabled = true;
            Lbl_Validade4.Enabled = true;
            Lbl_Validade5.Enabled = true;
            Lbl_Validade6.Enabled = true;
            Lbl_Validade7.Enabled = true;
            Lbl_Validade8.Enabled = true;
            Lbl_Valor.Enabled = true;
            Btn_Validade1.Enabled = true;
            Btn_Validade2.Enabled = true;
            Btn_Validade2.Enabled = true;
            Btn_Validade3.Enabled = true;
            Btn_Validade4.Enabled = true;
            Btn_Validade5.Enabled = true;
            Btn_Validade6.Enabled = true;
            Btn_Validade7.Enabled = true;
            Btn_Validade8.Enabled = true;
            Lbl_Dados.Enabled = true;
            Txt_DDD.Enabled = true;
            Txt_Nome.Enabled = true;
            Txt_Numero.Enabled = true;
            
            
            // Formatando as caixas de validade
            Btn_Validade1.Text = "12 Reais";
            Lbl_Validade1.Text = "30 Dias";

            Btn_Validade2.Text = "15 Reais";
            Lbl_Validade2.Text = "30 Dias";

            Btn_Validade3.Text = "20 Reais";
            Lbl_Validade3.Text = "30 Dias";

            Btn_Validade4.Text = "30 Reais";
            Lbl_Validade4.Text = "30 Dias";

            Btn_Validade5.Text = "35 Reais";
                Lbl_Validade5.Text = "90 Dias";

            Btn_Validade6.Text = "40 Reais";
            Lbl_Validade6.Text = "90 Dias";

            Btn_Validade7.Text = "100 Reais";
            Lbl_Validade7.Text = "180 Dias";

            Btn_Validade8.Text = "200 Reais";
            Lbl_Validade8.Text = "365 Dias";


        }
        // Alterando os Valores da Recarga de cada Plano
        private void Btn_Validade1_Click(object sender, EventArgs e)
        {
            Txt_ValorDaRecarga.Text = Btn_Validade1.Text;
            
        }

        private void Btn_Validade2_Click(object sender, EventArgs e)
        {
            Txt_ValorDaRecarga.Text = Btn_Validade2.Text;
        }

        private void Btn_Validade3_Click(object sender, EventArgs e)
        {
            Txt_ValorDaRecarga.Text = Btn_Validade3.Text;
        }

        private void Btn_Validade4_Click(object sender, EventArgs e)
        {
            Txt_ValorDaRecarga.Text = Btn_Validade4.Text;
        }

        private void Btn_Validade5_Click(object sender, EventArgs e)
        {
            Txt_ValorDaRecarga.Text = Btn_Validade5.Text;
        }

        private void Btn_Validade6_Click(object sender, EventArgs e)
        {
            Txt_ValorDaRecarga.Text = Btn_Validade6.Text;
        }

        private void Btn_Validade7_Click(object sender, EventArgs e)
        {
            Txt_ValorDaRecarga.Text = Btn_Validade7.Text;
        }

        private void Btn_Validade8_Click(object sender, EventArgs e)
        {
            Txt_ValorDaRecarga.Text = Btn_Validade8.Text;
        }

        private void Txt_Operadora_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_ValorDaRecarga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Lbl_Dados_Click(object sender, EventArgs e)
        {

        }

        private void Rad_Claro_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação da Claro

            BackColor = Color.Red;
            Txt_Operadora.Text = "Claro";
            Txt_ValorDaRecarga.Text = "";

            //Botões dos planos das operadoras

            Btn_Validade1.Text = "12 Reais";
            Lbl_Validade1.Text = "30 Dias";

            Btn_Validade2.Text = "15 Reais";
            Lbl_Validade2.Text = "30 Dias";

            Btn_Validade3.Text = "20 Reais";
            Lbl_Validade3.Text = "60 Dias";

            Btn_Validade4.Text = "25 Reais";
            Lbl_Validade4.Text = "60 Dias";

            Btn_Validade5.Text = "30 Reais";
            Lbl_Validade5.Text = "90 Dias";

            Btn_Validade6.Text = "35 Reais";
            Lbl_Validade6.Text = "90 Dias";

            Btn_Validade7.Text = "50 Reais";
            Lbl_Validade7.Text = "120 Dias";

            Btn_Validade8.Text = "100 Reais";
            Lbl_Validade8.Text = "180 Dias";

            // Validando o Formulário 
            Lbl_BemVindo.Enabled = true;
            Lbl_Celular.Enabled = true;
            Lbl_DDD.Enabled = true;
            Lbl_Nome.Enabled = true;
            Lbl_Operadora.Enabled = true;
            Lbl_SelecioneoValorDeRecarga.Enabled = true;
            Lbl_Validade1.Enabled = true;
            Lbl_Validade2.Enabled = true;
            Lbl_Validade3.Enabled = true;
            Lbl_Validade4.Enabled = true;
            Lbl_Validade5.Enabled = true;
            Lbl_Validade6.Enabled = true;
            Lbl_Validade7.Enabled = true;
            Lbl_Validade8.Enabled = true;
            Lbl_Valor.Enabled = true;
            Btn_Validade1.Enabled = true;
            Btn_Validade2.Enabled = true;
            Btn_Validade2.Enabled = true;
            Btn_Validade3.Enabled = true;
            Btn_Validade4.Enabled = true;
            Btn_Validade5.Enabled = true;
            Btn_Validade6.Enabled = true;
            Btn_Validade7.Enabled = true;
            Btn_Validade8.Enabled = true;
            Lbl_Dados.Enabled = true;
            Txt_DDD.Enabled = true;
            Txt_Nome.Enabled = true;
            Txt_Numero.Enabled = true;

            // Alterando a cor das Letras e Grupos
            Lbl_BemVindo.ForeColor = Color.White;
            Lbl_Nome.ForeColor = Color.White;
            Grp_Operadoras.ForeColor = Color.White;
            Lbl_Operadora.ForeColor = Color.White;
            Lbl_DDD.ForeColor = Color.White;
            Lbl_Celular.ForeColor = Color.White;
            Lbl_Valor.ForeColor = Color.White;
            Lbl_SelecioneoValorDeRecarga.ForeColor = Color.White;
            Lbl_Validade1.ForeColor = Color.White;
            Lbl_Validade2.ForeColor = Color.White;
            Lbl_Validade3.ForeColor = Color.White;
            Lbl_Validade4.ForeColor = Color.White;
            Lbl_Validade5.ForeColor = Color.White;
            Lbl_Validade6.ForeColor = Color.White;
            Lbl_Validade7.ForeColor = Color.White;
            Lbl_Validade8.ForeColor = Color.White;

            // Alterando a cor dos botões
            Btn_Validade1.ForeColor = Color.Black;
            Btn_Validade1.FlatAppearance.MouseOverBackColor = Color.White;

            Btn_Validade2.ForeColor = Color.Black;
            Btn_Validade2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade3.ForeColor = Color.Black;
            Btn_Validade3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade4.ForeColor = Color.Black;
            Btn_Validade4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade5.ForeColor = Color.Black;
            Btn_Validade5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade6.ForeColor = Color.Black;
            Btn_Validade6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade7.ForeColor = Color.Black;
            Btn_Validade7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade8.ForeColor = Color.Black;
            Btn_Validade8.FlatAppearance.MouseOverBackColor = Color.White;
        }
    }
}
