﻿
namespace Operadora_recarga_de_celular
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grp_Operadoras = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Rad_Vivo = new System.Windows.Forms.RadioButton();
            this.Rad_Claro = new System.Windows.Forms.RadioButton();
            this.Rad_Tim = new System.Windows.Forms.RadioButton();
            this.Rad_Oi = new System.Windows.Forms.RadioButton();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Operadora = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_DDD = new System.Windows.Forms.Label();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_SelecioneoValorDeRecarga = new System.Windows.Forms.Label();
            this.Txt_Operadora = new System.Windows.Forms.TextBox();
            this.Txt_DDD = new System.Windows.Forms.TextBox();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Txt_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Validade1 = new System.Windows.Forms.Button();
            this.Lbl_Validade1 = new System.Windows.Forms.Label();
            this.Btn_Validade2 = new System.Windows.Forms.Button();
            this.Btn_Validade3 = new System.Windows.Forms.Button();
            this.Btn_Validade4 = new System.Windows.Forms.Button();
            this.Lbl_Validade2 = new System.Windows.Forms.Label();
            this.Lbl_Validade3 = new System.Windows.Forms.Label();
            this.Lbl_Validade4 = new System.Windows.Forms.Label();
            this.Btn_Validade5 = new System.Windows.Forms.Button();
            this.Btn_Validade6 = new System.Windows.Forms.Button();
            this.Btn_Validade7 = new System.Windows.Forms.Button();
            this.Btn_Validade8 = new System.Windows.Forms.Button();
            this.Lbl_Validade5 = new System.Windows.Forms.Label();
            this.Lbl_Validade7 = new System.Windows.Forms.Label();
            this.Lbl_Validade6 = new System.Windows.Forms.Label();
            this.Lbl_Validade8 = new System.Windows.Forms.Label();
            this.Grp_Operadoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_Operadoras
            // 
            this.Grp_Operadoras.Controls.Add(this.Rad_Oi);
            this.Grp_Operadoras.Controls.Add(this.Rad_Tim);
            this.Grp_Operadoras.Controls.Add(this.Rad_Claro);
            this.Grp_Operadoras.Controls.Add(this.Rad_Vivo);
            this.Grp_Operadoras.Location = new System.Drawing.Point(12, 74);
            this.Grp_Operadoras.Name = "Grp_Operadoras";
            this.Grp_Operadoras.Size = new System.Drawing.Size(134, 178);
            this.Grp_Operadoras.TabIndex = 0;
            this.Grp_Operadoras.TabStop = false;
            this.Grp_Operadoras.Text = "Operadoras";
            // 
            // Rad_Vivo
            // 
            this.Rad_Vivo.AutoSize = true;
            this.Rad_Vivo.Location = new System.Drawing.Point(6, 32);
            this.Rad_Vivo.Name = "Rad_Vivo";
            this.Rad_Vivo.Size = new System.Drawing.Size(46, 17);
            this.Rad_Vivo.TabIndex = 1;
            this.Rad_Vivo.TabStop = true;
            this.Rad_Vivo.Text = "Vivo";
            this.Rad_Vivo.UseVisualStyleBackColor = true;
            // 
            // Rad_Claro
            // 
            this.Rad_Claro.AutoSize = true;
            this.Rad_Claro.Location = new System.Drawing.Point(6, 68);
            this.Rad_Claro.Name = "Rad_Claro";
            this.Rad_Claro.Size = new System.Drawing.Size(49, 17);
            this.Rad_Claro.TabIndex = 2;
            this.Rad_Claro.TabStop = true;
            this.Rad_Claro.Text = "Claro";
            this.Rad_Claro.UseVisualStyleBackColor = true;
            // 
            // Rad_Tim
            // 
            this.Rad_Tim.AutoSize = true;
            this.Rad_Tim.Location = new System.Drawing.Point(6, 107);
            this.Rad_Tim.Name = "Rad_Tim";
            this.Rad_Tim.Size = new System.Drawing.Size(42, 17);
            this.Rad_Tim.TabIndex = 2;
            this.Rad_Tim.TabStop = true;
            this.Rad_Tim.Text = "Tim";
            this.Rad_Tim.UseVisualStyleBackColor = true;
            // 
            // Rad_Oi
            // 
            this.Rad_Oi.AutoSize = true;
            this.Rad_Oi.Location = new System.Drawing.Point(6, 141);
            this.Rad_Oi.Name = "Rad_Oi";
            this.Rad_Oi.Size = new System.Drawing.Size(35, 17);
            this.Rad_Oi.TabIndex = 2;
            this.Rad_Oi.TabStop = true;
            this.Rad_Oi.Text = "Oi";
            this.Rad_Oi.UseVisualStyleBackColor = true;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(276, 74);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nome.TabIndex = 2;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Lbl_Operadora
            // 
            this.Lbl_Operadora.AutoSize = true;
            this.Lbl_Operadora.Location = new System.Drawing.Point(276, 122);
            this.Lbl_Operadora.Name = "Lbl_Operadora";
            this.Lbl_Operadora.Size = new System.Drawing.Size(119, 13);
            this.Lbl_Operadora.TabIndex = 3;
            this.Lbl_Operadora.Text = "Operadora Selecionada";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(279, 90);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(424, 20);
            this.Txt_Nome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seja Bem Vindo(a):";
            // 
            // Lbl_DDD
            // 
            this.Lbl_DDD.AutoSize = true;
            this.Lbl_DDD.Location = new System.Drawing.Point(276, 165);
            this.Lbl_DDD.Name = "Lbl_DDD";
            this.Lbl_DDD.Size = new System.Drawing.Size(31, 13);
            this.Lbl_DDD.TabIndex = 6;
            this.Lbl_DDD.Text = "DDD";
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Location = new System.Drawing.Point(396, 165);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(94, 13);
            this.Lbl_Numero.TabIndex = 7;
            this.Lbl_Numero.Text = "Número do Celular";
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(595, 165);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(92, 13);
            this.Lbl_Valor.TabIndex = 8;
            this.Lbl_Valor.Text = "Valor Da Recarga";
            // 
            // Lbl_SelecioneoValorDeRecarga
            // 
            this.Lbl_SelecioneoValorDeRecarga.AutoSize = true;
            this.Lbl_SelecioneoValorDeRecarga.Location = new System.Drawing.Point(422, 215);
            this.Lbl_SelecioneoValorDeRecarga.Name = "Lbl_SelecioneoValorDeRecarga";
            this.Lbl_SelecioneoValorDeRecarga.Size = new System.Drawing.Size(153, 13);
            this.Lbl_SelecioneoValorDeRecarga.TabIndex = 9;
            this.Lbl_SelecioneoValorDeRecarga.Text = "Selecione O Valor De Recarga";
            // 
            // Txt_Operadora
            // 
            this.Txt_Operadora.Location = new System.Drawing.Point(279, 142);
            this.Txt_Operadora.Name = "Txt_Operadora";
            this.Txt_Operadora.Size = new System.Drawing.Size(116, 20);
            this.Txt_Operadora.TabIndex = 10;
            // 
            // Txt_DDD
            // 
            this.Txt_DDD.Location = new System.Drawing.Point(279, 185);
            this.Txt_DDD.Name = "Txt_DDD";
            this.Txt_DDD.Size = new System.Drawing.Size(32, 20);
            this.Txt_DDD.TabIndex = 11;
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(399, 185);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero.TabIndex = 12;
            // 
            // Txt_
            // 
            this.Txt_.Location = new System.Drawing.Point(598, 185);
            this.Txt_.Name = "Txt_";
            this.Txt_.Size = new System.Drawing.Size(100, 20);
            this.Txt_.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dados Da Recarga";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Validade1
            // 
            this.Btn_Validade1.Enabled = false;
            this.Btn_Validade1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validade1.Location = new System.Drawing.Point(360, 231);
            this.Btn_Validade1.Name = "Btn_Validade1";
            this.Btn_Validade1.Size = new System.Drawing.Size(75, 67);
            this.Btn_Validade1.TabIndex = 15;
            this.Btn_Validade1.Text = "R$";
            this.Btn_Validade1.UseVisualStyleBackColor = true;
            // 
            // Lbl_Validade1
            // 
            this.Lbl_Validade1.AutoSize = true;
            this.Lbl_Validade1.Location = new System.Drawing.Point(374, 301);
            this.Lbl_Validade1.Name = "Lbl_Validade1";
            this.Lbl_Validade1.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade1.TabIndex = 16;
            this.Lbl_Validade1.Text = "Validade";
            // 
            // Btn_Validade2
            // 
            this.Btn_Validade2.Enabled = false;
            this.Btn_Validade2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validade2.Location = new System.Drawing.Point(452, 231);
            this.Btn_Validade2.Name = "Btn_Validade2";
            this.Btn_Validade2.Size = new System.Drawing.Size(75, 67);
            this.Btn_Validade2.TabIndex = 17;
            this.Btn_Validade2.Text = "R$";
            this.Btn_Validade2.UseVisualStyleBackColor = true;
            // 
            // Btn_Validade3
            // 
            this.Btn_Validade3.Enabled = false;
            this.Btn_Validade3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validade3.Location = new System.Drawing.Point(547, 231);
            this.Btn_Validade3.Name = "Btn_Validade3";
            this.Btn_Validade3.Size = new System.Drawing.Size(75, 67);
            this.Btn_Validade3.TabIndex = 18;
            this.Btn_Validade3.Text = "R$";
            this.Btn_Validade3.UseVisualStyleBackColor = true;
            // 
            // Btn_Validade4
            // 
            this.Btn_Validade4.Enabled = false;
            this.Btn_Validade4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validade4.Location = new System.Drawing.Point(641, 231);
            this.Btn_Validade4.Name = "Btn_Validade4";
            this.Btn_Validade4.Size = new System.Drawing.Size(75, 67);
            this.Btn_Validade4.TabIndex = 19;
            this.Btn_Validade4.Text = "R$";
            this.Btn_Validade4.UseVisualStyleBackColor = true;
            // 
            // Lbl_Validade2
            // 
            this.Lbl_Validade2.AutoSize = true;
            this.Lbl_Validade2.Location = new System.Drawing.Point(467, 301);
            this.Lbl_Validade2.Name = "Lbl_Validade2";
            this.Lbl_Validade2.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade2.TabIndex = 20;
            this.Lbl_Validade2.Text = "Validade";
            // 
            // Lbl_Validade3
            // 
            this.Lbl_Validade3.AutoSize = true;
            this.Lbl_Validade3.Location = new System.Drawing.Point(558, 301);
            this.Lbl_Validade3.Name = "Lbl_Validade3";
            this.Lbl_Validade3.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade3.TabIndex = 21;
            this.Lbl_Validade3.Text = "Validade";
            // 
            // Lbl_Validade4
            // 
            this.Lbl_Validade4.AutoSize = true;
            this.Lbl_Validade4.Location = new System.Drawing.Point(655, 301);
            this.Lbl_Validade4.Name = "Lbl_Validade4";
            this.Lbl_Validade4.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade4.TabIndex = 22;
            this.Lbl_Validade4.Text = "Validade";
            // 
            // Btn_Validade5
            // 
            this.Btn_Validade5.Enabled = false;
            this.Btn_Validade5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validade5.Location = new System.Drawing.Point(360, 317);
            this.Btn_Validade5.Name = "Btn_Validade5";
            this.Btn_Validade5.Size = new System.Drawing.Size(75, 67);
            this.Btn_Validade5.TabIndex = 23;
            this.Btn_Validade5.Text = "R$";
            this.Btn_Validade5.UseVisualStyleBackColor = true;
            // 
            // Btn_Validade6
            // 
            this.Btn_Validade6.Enabled = false;
            this.Btn_Validade6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validade6.Location = new System.Drawing.Point(452, 317);
            this.Btn_Validade6.Name = "Btn_Validade6";
            this.Btn_Validade6.Size = new System.Drawing.Size(75, 67);
            this.Btn_Validade6.TabIndex = 24;
            this.Btn_Validade6.Text = "R$";
            this.Btn_Validade6.UseVisualStyleBackColor = true;
            // 
            // Btn_Validade7
            // 
            this.Btn_Validade7.Enabled = false;
            this.Btn_Validade7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validade7.Location = new System.Drawing.Point(547, 317);
            this.Btn_Validade7.Name = "Btn_Validade7";
            this.Btn_Validade7.Size = new System.Drawing.Size(75, 67);
            this.Btn_Validade7.TabIndex = 25;
            this.Btn_Validade7.Text = "R$";
            this.Btn_Validade7.UseVisualStyleBackColor = true;
            // 
            // Btn_Validade8
            // 
            this.Btn_Validade8.Enabled = false;
            this.Btn_Validade8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validade8.Location = new System.Drawing.Point(641, 317);
            this.Btn_Validade8.Name = "Btn_Validade8";
            this.Btn_Validade8.Size = new System.Drawing.Size(75, 67);
            this.Btn_Validade8.TabIndex = 26;
            this.Btn_Validade8.Text = "R$";
            this.Btn_Validade8.UseVisualStyleBackColor = true;
            // 
            // Lbl_Validade5
            // 
            this.Lbl_Validade5.AutoSize = true;
            this.Lbl_Validade5.Location = new System.Drawing.Point(374, 387);
            this.Lbl_Validade5.Name = "Lbl_Validade5";
            this.Lbl_Validade5.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade5.TabIndex = 27;
            this.Lbl_Validade5.Text = "Validade";
            // 
            // Lbl_Validade7
            // 
            this.Lbl_Validade7.AutoSize = true;
            this.Lbl_Validade7.Location = new System.Drawing.Point(558, 387);
            this.Lbl_Validade7.Name = "Lbl_Validade7";
            this.Lbl_Validade7.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade7.TabIndex = 28;
            this.Lbl_Validade7.Text = "Validade";
            // 
            // Lbl_Validade6
            // 
            this.Lbl_Validade6.AutoSize = true;
            this.Lbl_Validade6.Location = new System.Drawing.Point(467, 387);
            this.Lbl_Validade6.Name = "Lbl_Validade6";
            this.Lbl_Validade6.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade6.TabIndex = 29;
            this.Lbl_Validade6.Text = "Validade";
            // 
            // Lbl_Validade8
            // 
            this.Lbl_Validade8.AutoSize = true;
            this.Lbl_Validade8.Location = new System.Drawing.Point(655, 387);
            this.Lbl_Validade8.Name = "Lbl_Validade8";
            this.Lbl_Validade8.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Validade8.TabIndex = 30;
            this.Lbl_Validade8.Text = "Validade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Validade8);
            this.Controls.Add(this.Lbl_Validade6);
            this.Controls.Add(this.Lbl_Validade7);
            this.Controls.Add(this.Lbl_Validade5);
            this.Controls.Add(this.Btn_Validade8);
            this.Controls.Add(this.Btn_Validade7);
            this.Controls.Add(this.Btn_Validade6);
            this.Controls.Add(this.Btn_Validade5);
            this.Controls.Add(this.Lbl_Validade4);
            this.Controls.Add(this.Lbl_Validade3);
            this.Controls.Add(this.Lbl_Validade2);
            this.Controls.Add(this.Btn_Validade4);
            this.Controls.Add(this.Btn_Validade3);
            this.Controls.Add(this.Btn_Validade2);
            this.Controls.Add(this.Lbl_Validade1);
            this.Controls.Add(this.Btn_Validade1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_);
            this.Controls.Add(this.Txt_Numero);
            this.Controls.Add(this.Txt_DDD);
            this.Controls.Add(this.Txt_Operadora);
            this.Controls.Add(this.Lbl_SelecioneoValorDeRecarga);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Lbl_Numero);
            this.Controls.Add(this.Lbl_DDD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Operadora);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Grp_Operadoras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Grp_Operadoras.ResumeLayout(false);
            this.Grp_Operadoras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Operadoras;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton Rad_Oi;
        private System.Windows.Forms.RadioButton Rad_Tim;
        private System.Windows.Forms.RadioButton Rad_Claro;
        private System.Windows.Forms.RadioButton Rad_Vivo;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Operadora;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_DDD;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_SelecioneoValorDeRecarga;
        private System.Windows.Forms.TextBox Txt_Operadora;
        private System.Windows.Forms.TextBox Txt_DDD;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.TextBox Txt_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Validade1;
        private System.Windows.Forms.Label Lbl_Validade1;
        private System.Windows.Forms.Button Btn_Validade2;
        private System.Windows.Forms.Button Btn_Validade3;
        private System.Windows.Forms.Button Btn_Validade4;
        private System.Windows.Forms.Label Lbl_Validade2;
        private System.Windows.Forms.Label Lbl_Validade3;
        private System.Windows.Forms.Label Lbl_Validade4;
        private System.Windows.Forms.Button Btn_Validade5;
        private System.Windows.Forms.Button Btn_Validade6;
        private System.Windows.Forms.Button Btn_Validade7;
        private System.Windows.Forms.Button Btn_Validade8;
        private System.Windows.Forms.Label Lbl_Validade5;
        private System.Windows.Forms.Label Lbl_Validade7;
        private System.Windows.Forms.Label Lbl_Validade6;
        private System.Windows.Forms.Label Lbl_Validade8;
    }
}

