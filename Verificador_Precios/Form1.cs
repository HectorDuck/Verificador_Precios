using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class Form1 : Form
    {
        private String codigo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //MessageBox.Show("vamos a buscar el producto "+codigo);
                try
                {
                    MySqlConnection servidor;
                    servidor = new MySqlConnection("server = 127.0.0.1; user = root; database = verificador_de_precios; SSL Mode = None; ");
                    servidor.Open();
                    string query = "SELECT producto_nombre, producto_precio, producto_cantidad, producto_imagen FROM productos WHERE producto_codigo =" + codigo + ";";
                    MySqlCommand consulta;
                    consulta = new MySqlCommand(query, servidor);
                    MySqlDataReader resultado = consulta.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        resultado.Read();
                        Form2 f2 = new Form2(true, resultado.GetString(0), resultado.GetDouble(1), resultado.GetInt32(2), resultado.GetString(3));
                        this.Hide();
                        f2.ShowDialog();
                    }
                    else
                    {
                        Form2 f2 = new Form2(false, null, 0, 0, null);
                        this.Hide();
                        f2.ShowDialog();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString(), "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }
        }
    }
}