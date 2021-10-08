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
    public partial class Form2 : Form
    {
        private int segundos = 0;
        private Boolean found = false;
        private String nombre = null;
        private double precio = 0;
        private int cantidad = 0;
        private String imagen = null;
        public Form2(Boolean found, String nombre, double precio, int cantidad, String imagen)
        {
            InitializeComponent();
            this.found = found;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.imagen = imagen;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 5)
            {
                timer1.Enabled = false;
                if (found)
                {
                    Form4 f4 = new Form4(found, nombre, precio, cantidad, imagen);
                    this.Hide();
                    f4.ShowDialog();
                }
                else
                {
                    Form3 f3 = new Form3();
                    this.Hide();
                    f3.ShowDialog();
                }
            }
        }
    }
}
