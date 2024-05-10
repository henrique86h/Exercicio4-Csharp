using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxA.Text) , b = Convert.ToInt32(textBoxB.Text), c = Convert.ToInt32(textBoxC.Text);
            double delta, xl, xll;

            delta = (b * b) - (4 * a * c);
            if (delta >= 0)
            {
                xl = ((-b) + Math.Sqrt(delta)) / (2 * a);
                xll = ((-b) - Math.Sqrt(delta)) / (2 * a);

                MessageBox.Show($"xl = {xl} " + $" xll = {xll}");
                
            }
            else
            {
                MessageBox.Show("Delta é menor que 0");
            }
        }
    }
}
