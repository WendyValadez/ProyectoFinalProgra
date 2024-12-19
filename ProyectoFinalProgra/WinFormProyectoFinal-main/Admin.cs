using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;


namespace WinFormProyectoFinal
{
    public partial class Admin : Form
    {
        DateTime date = DateTime.Now;

        private int userId;
        private string userName;


        // string conexion = "server=localhost;port=3306;uid=root;pwd='';database=kingsman;";

        public Admin()
        {
            InitializeComponent();
        }
        //public Admin(int userId, string userName, int ID, int exist, string prod, string img, string img2, string colr, double precio)

        public Admin(int userId, string userName)
        {
            InitializeComponent();


            // Asignar valores a las etiquetas
            id.Text = userId.ToString();      // Muestra el ID en la etiqueta "id"
            nom.Text = userName;             // Muestra el nombre en la etiqueta "nom"

            // Mostrar la fecha actual
            DateTime date = DateTime.Now;
            fecha.Text = date.ToString("dd/MM/yyyy");  // Muestra la fecha en "fecha"

            // Mostrar la hora actual
            hr.Text = date.ToString("HH:mm");       // Muestra la hora en "hr"

        }



        private void Cerarsecion()
        {
            // Mostrar el formulario de inicio de sesión (Form1)
            login loginForm = new login();
            loginForm.Show();

            // Cerrar el formulario actual
            this.Close();


        }
        private void Csesion_Click(object sender, EventArgs e)
        {
            Cerarsecion();
        }
        private void btnRegis_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = conexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("insert into prendas (id, producto, imagen, imagen2, color, precio, Existencias,Descripcion) values ('" + txtID.Text + "', '" + txtProd.Text + "','" + txtImg1.Text + "', '" + txtImg2.Text + "','" + txtColor.Text + "', '" + txtPrecio.Text + "','" + txtExist.Text + "', '" + txtDesc.Text + "'); ");
                comando.ExecuteNonQuery();
                conexionBD.Close();
            }

            catch (Exception r)
            {
                MessageBox.Show(r.Message + r.StackTrace);
            }
            MessageBox.Show("datos registrados correctamente");
            txtID.Text = "";
            txtProd.Text = "";
            txtImg1.Text = "";
            txtImg2.Text = "";
            txtColor.Text = "";
            txtPrecio.Text = "";
            txtExist.Text = "";
            txtDesc.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = conexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;

                // Modifica la consulta SQL para ordenar por la columna Existencias
                comando.CommandText = "SELECT * FROM prendas ORDER BY Existencias ASC;";

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);

                // Mostrar los datos en el DataGridView
                dataGridView1.DataSource = tabla;
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message + b.StackTrace);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            // Verificar si el campo ID está vacío
            if (string.IsNullOrWhiteSpace(txtBuscaID.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID válido para eliminar.");
                return;
            }

            // Mostrar un cuadro de diálogo de confirmación
            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                               "Confirmar eliminación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            // Solo eliminar si el usuario confirma con "Sí"
            if (confirmacion == DialogResult.Yes)
            {
                // Crear la conexión a la base de datos
                MySqlConnection conexionBD = conexion.conex();
                try
                {
                    // Abrir la conexión
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexionBD;

                    // Consulta SQL para eliminar por ID
                    comando.CommandText = "DELETE FROM prendas WHERE id = @id;";

                    // Agregar el parámetro para el ID
                    comando.Parameters.AddWithValue("@id", txtBuscaID.Text);

                    // Ejecutar la consulta
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se eliminó algún registro
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un registro con ese ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión
                    if (conexionBD.State == System.Data.ConnectionState.Open)
                        conexionBD.Close();
                }

                // Limpiar el campo de texto
                txtBuscaID.Text = "";
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.");
            }
        }

        private void chart_Admin_Click(object sender, EventArgs e)
        {
            Cargar_Grafica();
        }
        private void CargarMontoTotal()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;uid=root;pwd='';database=kingsman;"))
                {
                    conexion.Open();

                    // Consulta para sumar los montos
                    string consulta = "SELECT SUM(monto) AS TotalMonto FROM `inicio de sesión` WHERE ID_tipo = 0";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    // Ejecutamos la consulta
                    object resultado = comando.ExecuteScalar();

                    // Depuración
                    MessageBox.Show(resultado != null ? $"Valor obtenido: {resultado}" : "No se obtuvo ningún valor");

                    // Validamos si el resultado es nulo y mostramos en txtMonto
                    if (resultado != DBNull.Value && resultado != null)
                    {
                        double totalMonto = Convert.ToDouble(resultado);
                        MessageBox.Show($"El valor total es: {totalMonto}");
                        totalLabel.Text = totalMonto.ToString("F2"); // Mostrar el resultado con 2 decimales
                    }
                    else
                    {
                        MessageBox.Show("No hay datos que mostrar.");
                        totalLabel.Text = "0.00"; // Mostrar 0 si no hay datos
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Cargar_Grafica()
        {
            double total = 0;
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;uid=root;pwd='';database=kingsman;"))
            {
                conexion.Open();

                string consulta = "SELECT Cuenta, monto FROM `inicio de sesión` WHERE ID_tipo = 0";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                using (MySqlDataReader lector = comando.ExecuteReader())
                {
                    chart_Admin.Series.Clear();
                    Series serie = new Series("Montos por Usuario");
                    serie.ChartType = SeriesChartType.Pie;

                    while (lector.Read())
                    {
                        string nombre = lector["Cuenta"].ToString();
                        double monto = Convert.ToDouble(lector["monto"]);
                        total += monto;
                        DataPoint punto = new DataPoint(0, monto);
                        punto.LegendText = nombre;
                        serie.Points.Add(punto);
                    }

                    chart_Admin.Series.Add(serie);

                    if (chart_Admin.Legends.Count == 0)
                    {
                        chart_Admin.Legends.Add(new Legend("Default"));
                    }
                    chart_Admin.Legends[0].Docking = Docking.Bottom;

                    foreach (var point in serie.Points)
                    {
                        point.IsValueShownAsLabel = false;
                    }
                    totalLabel.Text = $"Total: {total:0.00}";
                }
            }
        }


        private void txtBuscaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }
    }
}
