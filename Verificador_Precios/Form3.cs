using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificador_Precios
{
    public partial class Form3 : Form
    {
        private int segundos = 0;
        public Form3()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 5)
            {
                timer1.Enabled = false;
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
            }
        }
    }
}
