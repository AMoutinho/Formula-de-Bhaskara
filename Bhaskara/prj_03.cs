using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class prj_03 : Form
    {
        public prj_03()
        {
            InitializeComponent();
        }
        #region Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            #region Declaração de Variaveis
            double a = 0, b = 0, c = 0, delta =0;
            try
            {
               
                a = double.Parse(tbA.Text);
                b = double.Parse(tbB.Text);
                c = double.Parse(tbC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite os 3 valores.");
            }
            #endregion
            #region Teste Lógico
            if (a != 0)
            {
                
                delta = Math.Pow(b, 2) - (4 * a * c);

                if (delta >= 0)
                {
                    tbR1.Text = ((-b + Math.Sqrt(delta)) / (2 * a)).ToString("#.##");
                    tbR2.Text = ((-b - Math.Sqrt(delta)) / (2 * a)).ToString("#.##");
                    tbR3.Text = delta.ToString("#.##");
                }
                else
                {
                    MessageBox.Show("Delta não pode ser negativo. \n Δ = " + delta, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("\"a\" não pode ser 0");
            }
        }
            #endregion
            #region KeyPress
        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != 8) && (e.KeyChar != 45))
            {
                
                e.Handled = true;
            }
        }

        private void tbB_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != 8) && (e.KeyChar != 45))
            {
                
                e.Handled = true;
            }
        }

        private void tbC_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != 8) && (e.KeyChar != 45))
            {
                
                e.Handled = true;
            }
        #endregion
        }
#endregion
        #region Limpar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tbA.Text = ("");
            tbB.Text = ("");
            tbC.Text = ("");
            tbR1.Text = ("");
            tbR2.Text = ("");  
        }
        #endregion
        #region Sair
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}