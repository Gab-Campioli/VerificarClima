using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VerificarClima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificarClima_Click(object sender, EventArgs e)
        {
            if (txbTemp.Text == "")
            {
                MessageBox.Show("Digite uma temperatura!!!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double temperatura;

                if (!double.TryParse(txbTemp.Text, out temperatura))
                {
                    MessageBox.Show("Digite apenas números válidos!", "Erro de Formato",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbTemp.Clear();
                    txbTemp.Focus();
                    return;
                }

                if (temperatura < 15)
                {
                    pibResultado.Image = Properties.Resources.floco;
                    lblDia.Text = DateTime.Now.ToString();
                }
                else if (temperatura <= 30)
                {
                    pibResultado.Image = Properties.Resources.nuvemesol;
                    lblDia.Text = DateTime.Now.ToString();
                }
                else if (temperatura > 30)
                {
                    pibResultado.Image = Properties.Resources.solzinho;
                    lblDia.Text = $"Dia: {DateTime.Now}";
                }
            }
        }

        private void txbTemp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btVerificarClima.PerformClick();
            }
        }
    }
}
