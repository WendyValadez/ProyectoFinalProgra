using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormProyectoFinal
{
    public partial class Producto : Form
    {
        private int producto;

        private string imagen;
        private string imagen2;// Arreglo de imágenes
                               // Índice actual


        public Producto(int producto)
        {
            InitializeComponent();

            // Asignar valores a las variables locales
            this.producto = producto;


            // Inicializar el arreglo y el índice



            // Realizar la búsqueda al abrir el formulario
            BuscarProducto();
        }

        private void BuscarProducto()
        {
            MySqlConnection conexionBD = conexion.conex();

            try
            {
                conexionBD.Open();

                string query = "SELECT id, Producto, Descripcion, color, Existencias, Imagen, Imagen2,precio " +
                               "FROM prendas " +
                               "WHERE id = @id";

                MySqlCommand comando = new MySqlCommand(query, conexionBD);

                comando.Parameters.AddWithValue("@id", producto);


                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    lblId.Text = reader["id"].ToString();
                    lblProd.Text = reader["Producto"].ToString();
                    lblDescrp.Text = reader["Descripcion"].ToString();
                    lblExist.Text = reader["Existencias"].ToString();
                    lblPrec.Text = reader["Precio"].ToString();

                    // Ruta a la carpeta productos


                    // Inicializar arreglo de imágenes
                    imagen = reader["Imagen"].ToString();
                    imagen2 = reader["Imagen2"].ToString(); // Reiniciar el índice actual




                    if (!string.IsNullOrEmpty(imagen))
                    {
                        MostrarImagenActual();
                    }
                    else
                    {
                        pictureBox1.Image = null; // Si no hay imágenes, limpiar el PictureBox

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron productos con los criterios especificados.");
                    lblId.Text = "";
                    lblProd.Text = "";
                    lblDescrp.Text = "";
                    lblExist.Text = "";
                    pictureBox1.Image = null;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }



        private void MostrarImagenActual()
        {
            try
            {
                
                string imagePath = Path.Combine(Application.StartupPath, "productos", imagen);

                string imagePath2 = Path.Combine(Application.StartupPath, "productos", imagen2);
                // Validar si el archivo existe antes de mostrarlo
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox2.Image = Image.FromFile(imagePath2);
                }
                else
                {
                    MessageBox.Show("No se encontró la imagen en la ruta: " + imagePath);
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar la imagen: " + ex.Message);
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnCol1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            
        }

        private void lblProd_Click(object sender, EventArgs e)
        {

        }
    }
}
