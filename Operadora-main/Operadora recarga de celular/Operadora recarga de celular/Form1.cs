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

            Btn_Validade1.ForeColor = Color.White;
            Btn_Validade1.FlatAppearance.MouseOverBackColor = Color.White;
            
            Btn_Validade2.ForeColor = Color.White;
            Btn_Validade2.FlatAppearance.MouseOverBackColor = Color.LightPink;
            Btn_Validade3.ForeColor = Color.White;
            Btn_Validade3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade4.ForeColor = Color.White;
            Btn_Validade4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade5.ForeColor = Color.White;
            Btn_Validade5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade6.ForeColor = Color.White;
            Btn_Validade6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade7.ForeColor = Color.White;
            Btn_Validade7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Validade8.ForeColor = Color.White;
            Btn_Validade8.FlatAppearance.MouseOverBackColor = Color.White;

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
            


        }
    }
}
