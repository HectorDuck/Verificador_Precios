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
    public partial class Form4 : Form
    {
        private int segundos = 0;
        public Form4(Boolean found, String nombre, double precio, int cantidad, String imagen)
        {
            InitializeComponent();
            label2.Text = "NOMBRE: " + nombre;
            label3.Text = "PRECIO: " + precio;
            label5.Text = "CANTIDAD: " + cantidad;
            pictureBox1.ImageLocation = imagen;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 10)
            {
                timer1.Enabled = false;
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
            }
        }
    }
}
