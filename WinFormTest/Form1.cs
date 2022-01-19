using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Somma_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tb1.Text);
                int b = Convert.ToInt32(tb2.Text);
                textBox3.Text = Convert.ToString(a + b);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("carattere non valido");
            }
        }
    }
}
