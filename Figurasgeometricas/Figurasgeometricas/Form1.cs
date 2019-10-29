using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figurasgeometricas.Clases;
using System.Globalization;
namespace Figurasgeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcRomb_Click(object sender, EventArgs e)
        {
            Romboide romboide = new Romboide();
            romboide.base_ = Convert.ToDouble(txtBaseRomb.Text);
            romboide.altura = Convert.ToDouble(txtAltRomb.Text);

            romboide.Area = romboide.calcularArea(romboide.base_, romboide.altura);

            txtResultRomb.Text = Convert.ToString(romboide.Area);


        }

        private void txtBaseRomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back
                            || (e.KeyChar == 'm' || e.KeyChar == 'M')
                            || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator))
                        || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                            && txt.Text.Contains('.'))
                        || ((e.KeyChar == 'm' || e.KeyChar == 'M')
                            && txt.Text.ToUpper().Contains('M'));
        }

        private void txtAltRomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back
                            || (e.KeyChar == 'm' || e.KeyChar == 'M')
                            || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator))
                        || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                            && txt.Text.Contains('.'))
                        || ((e.KeyChar == 'm' || e.KeyChar == 'M')
                            && txt.Text.ToUpper().Contains('M'));
        }
    }
}
