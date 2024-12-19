using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Net.Mime.MediaTypeNames;
using static WinFormProyectoFinal.guest;

namespace WinFormProyectoFinal
{
    public partial class guest : Form
    {
        public class Articulos
        {
            public string Nombre { get; set; } // Nombre del producto
            public Double Precio { get; set; } // Precio unitario
            public int Cantidad { get; set; } // Cantidad disponible

            public Articulos()
            {
            }

            public Articulos(string nombre, Double precio, int cantidad)
            {
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }
        }

        DateTime date = DateTime.Now;

        private int userId;
        private string userName;
        private double userMonto;

        // Variable global para el ID del producto
        private int producto;
        private string nombre;
        private double precio;
        private int Cantidad = 1; // Definimos una cantidad predeterminada
        private int stock;
        private List<Articulos> carrito = new List<Articulos>();

        public guest()
        {
            InitializeComponent();
        }
        public guest(int userId, string userName, double userMonto)
        {
            InitializeComponent();

            // Asignar valores a las etiquetas
            id.Text = userId.ToString();      // Muestra el ID en la etiqueta "id"
            nom.Text = userName;             // Muestra el nombre en la etiqueta "nom"
            monto.Text = userMonto.ToString();
            // Mostrar la fecha actual
            DateTime date = DateTime.Now;
            fecha.Text = date.ToString("dd/MM/yy");  // Muestra la fecha en "fecha"

            // Mostrar la hora actual
            hr.Text = date.ToString("HH:mm");       // Muestra la hora en "hr"


            // Configurar el DataGridView
            ConfigurarDataGridView();
        }

        // Método para cerrar sesión
        private void cerrarsecion()
        {
            // Mostrar el formulario de inicio de sesión (Form1)
            Portada port = new Portada();
            port.Show();

            // Cerrar el formulario actual
            this.Close();


        }
        private void Csesion_Click(object sender, EventArgs e)
        {
            cerrarsecion();
        }
        private Form activeForm = null;
        private void abrirFormP(Form childForm)
        {
            // Si ya hay un formulario abierto, ciérralo
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Asigna y muestra el nuevo formulario
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSaco_Click(object sender, EventArgs e)
        {
            producto = 1233;
            abrirFormP(new Producto(producto));
        }


        private void BuscarProducto()
        {
            using (MySqlConnection conexionBD = conexion.conex())
            {
                try
                {
                    conexionBD.Open();

                    string query = "SELECT id, Producto, Existencias, precio " +
                                   "FROM prendas WHERE id = @id";

                    MySqlCommand comando = new MySqlCommand(query, conexionBD);
                    comando.Parameters.AddWithValue("@id", producto);

                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        nombre = reader["Producto"].ToString();
                        precio = Convert.ToDouble(reader["Precio"]);
                        stock = Convert.ToInt32(reader["Existencias"]);

                        if (stock < 0)
                        {
                            MessageBox.Show("producto agotado");
                            nombre = null;
                            precio = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron productos con los criterios especificados.");
                        nombre = null;
                        precio = 0;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private int SolicitarCantidad()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la cantidad deseada:",
                "Cantidad",
                "1"); // Valor predeterminado
            if (int.TryParse(input, out int cantidad) && cantidad > 0)
            {
                return cantidad;
            }
            else
            {
                MessageBox.Show("Cantidad no válida. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return SolicitarCantidad(); // Volver a solicitar si la entrada no es válida
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = SolicitarCantidad();
            BuscarProducto();
            if (cantidad > stock) { MessageBox.Show("La tienda no cuenta con ese numero de este producto"); }
            else
            {
                int index = dgvCarrito.SelectedRows.Count > 0 ? dgvCarrito.SelectedRows[0].Index : -1;
                Articulos prod = new Articulos
                {
                    Nombre = nombre,
                    Precio = precio,
                    Cantidad = cantidad // Asegúrate de que el nombre coincide con la propiedad definida en la clase
                };


                // Verificar si el producto ya existe
                var productoExistente = carrito.Find(p => p.Nombre == prod.Nombre);

                if (productoExistente != null)
                {

                    // Si el producto ya existe, aumentar la cantidad
                    productoExistente.Cantidad += prod.Cantidad;
                }
                else
                {
                    // Si el producto no existe, agregarlo
                    carrito.Add(prod);
                }

                ActualizarVistaCarrito();

                dgvCarrito.ClearSelection();
                if (index != -1)
                {
                    dgvCarrito.Rows[index].Selected = true;
                }
            }

        }
        private void btnBorra_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada en el DataGridView
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int index = dgvCarrito.SelectedRows[0].Index;

                // Confirmar la eliminación con un MessageBox
                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este producto del carrito?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Eliminar el producto de la lista 'carrito'
                    carrito.RemoveAt(index);

                    // Actualizar la vista del carrito
                    ActualizarVistaCarrito();

                    MessageBox.Show("Producto eliminado del carrito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RestarStock()
        {
            using (MySqlConnection conexionBD = conexion.conex())
            {
                try
                {
                    conexionBD.Open();

                    foreach (var producto in carrito)
                    {
                        // Consulta para obtener el stock actual del producto
                        string querySelect = "SELECT Existencias FROM prendas WHERE Producto = @nombre";

                        MySqlCommand comandoSelect = new MySqlCommand(querySelect, conexionBD);
                        comandoSelect.Parameters.AddWithValue("@nombre", producto.Nombre);

                        MySqlDataReader reader = comandoSelect.ExecuteReader();

                        if (reader.Read())
                        {
                            int stockActual = Convert.ToInt32(reader["Existencias"]);
                            reader.Close(); // Cerrar el lector antes de ejecutar otra consulta

                            // Verificar si hay suficiente stock
                            if (stockActual >= producto.Cantidad)
                            {
                                // Actualizar el stock restando la cantidad deseada
                                string queryUpdate = "UPDATE prendas SET Existencias = Existencias - @cantidad WHERE Producto = @nombre";

                                MySqlCommand comandoUpdate = new MySqlCommand(queryUpdate, conexionBD);
                                comandoUpdate.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                                comandoUpdate.Parameters.AddWithValue("@nombre", producto.Nombre);

                                int filasAfectadas = comandoUpdate.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    Console.WriteLine($"Stock actualizado para {producto.Nombre}. Restado: {producto.Cantidad}");
                                }
                                else
                                {
                                    MessageBox.Show($"No se pudo actualizar el stock para {producto.Nombre}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Stock insuficiente para {producto.Nombre}. Disponible: {stockActual}, Necesario: {producto.Cantidad}.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró el producto {producto.Nombre} en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            reader.Close(); // Asegurarse de cerrar el lector si el producto no se encuentra
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }

        private void aumentar()
        {
            using (MySqlConnection conexionBD = conexion.conex())
            {
                try
                {
                    conexionBD.Open();

                    foreach (var producto in carrito)
                    {
                        // Consulta para obtener el stock actual del producto
                        string querySelect = "SELECT Monto FROM `inicio de sesión` WHERE Nombre = @nombre";

                        MySqlCommand comandoSelect = new MySqlCommand(querySelect, conexionBD);
                        comandoSelect.Parameters.AddWithValue("@nombre", producto.Nombre);

                        MySqlDataReader reader = comandoSelect.ExecuteReader();

                        if (reader.Read())
                        {
                            double MontoArt = producto.Precio * producto.Cantidad;
                            reader.Close(); // Cerrar el lector antes de ejecutar otra consulta

                            // Actualizar el stock restando la cantidad deseada
                            string queryUpdate = "UPDATE prendas SET Monto = Monto - @MontoArt WHERE Nombre = @nombre";

                            MySqlCommand comandoUpdate = new MySqlCommand(queryUpdate, conexionBD);
                            comandoUpdate.Parameters.AddWithValue("@MontoArt", MontoArt);
                            comandoUpdate.Parameters.AddWithValue("@nombre", producto.Nombre);

                            int filasAfectadas = comandoUpdate.ExecuteNonQuery(); // Ejecutar la actualización

                            if (filasAfectadas > 0)
                            {
                                monto.Text = reader["Existencias"].ToString();
                            }
                            else
                            {
                                MessageBox.Show($"No se pudo actualizar el monto {userName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show($"No se encontró el producto {producto.Nombre} en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexionBD.Close(); // Asegurarse de cerrar la conexión en el finally
                }
            }
        }


        private void btnComp_Click(object sender, EventArgs e)
        {
            RestarStock();

            aumentar();
            genPdf();
            ReiniciarCarrito();
            ActualizarVistaCarrito();

        }
        private void genPdf()
        {

            try
            {
                // 1. Obtener el monto total de la base de datos
                double totalPagar = ObtenerTotalDesdeBaseDeDatos();

                // 2. Configurar la ruta del archivo PDF
                string rutaPDF = @"C:\Comprobantes\comprobante_pago.pdf";
                if (!Directory.Exists(@"C:\Comprobantes"))
                    Directory.CreateDirectory(@"C:\Comprobantes");

                // 3. Verificar si el archivo está en uso
                if (File.Exists(rutaPDF))
                {
                    // Intentar esperar si el archivo está en uso
                    int intentos = 0;
                    while (IsFileInUse(rutaPDF) && intentos < 5)
                    {
                        System.Threading.Thread.Sleep(500); // Espera de 0.5 segundos
                        intentos++;
                    }

                    if (IsFileInUse(rutaPDF))
                    {
                        MessageBox.Show("El archivo está en uso por otro proceso. Inténtalo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 4. Crear el documento PDF
                using (FileStream fs = new FileStream(rutaPDF, FileMode.Create, FileAccess.Write))
                using (Document documento = new Document(PageSize.A4, 25, 25, 30, 30))
                {
                    PdfWriter.GetInstance(documento, fs);

                    documento.Open();

                    // 5. Agregar el logo de la tienda
                    // Ruta relativa al archivo del logo en la carpeta Resources
                    string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo", "logo.png");

                    // Verificar si el archivo existe antes de agregarlo al documento
                    if (File.Exists(rutaLogo))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                        logo.ScaleAbsolute(300, 100); // Tamaño del logo
                        logo.Alignment = Element.ALIGN_CENTER; // Centrar el logo
                        documento.Add(logo);
                    }
                    else
                    {
                        MessageBox.Show($"El archivo de logo no existe en la ruta especificada: {rutaLogo}");
                    }

                    // 7. Agregar la fecha y detalles
                    Paragraph fecha = new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n\n");
                    fecha.Alignment = Element.ALIGN_RIGHT;
                    documento.Add(fecha);

                    // 8. Agregar título del comprobante
                    Paragraph titulo = new Paragraph("Comprobante de Pago\n\n", FontFactory.GetFont("Arial", 18));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    documento.Add(titulo);

                    // 9. Mostrar productos comprados (ejemplo)
                    double totalProductos = 0;
                    var productos = new List<(string nombre, int cantidad, double precio)>();

                    // Recorrer el carrito y agregar los productos a la lista
                    foreach (var producto in carrito)
                    {
                        double subtotal = producto.Cantidad * producto.Precio;
                        totalProductos += subtotal;

                        productos.Add((producto.Nombre, producto.Cantidad, producto.Precio));
                    }

                    // Crear la tabla para mostrar los productos
                    PdfPTable tablaProductos = new PdfPTable(4);
                    tablaProductos.AddCell("Producto");
                    tablaProductos.AddCell("Cantidad");
                    tablaProductos.AddCell("Precio Unitario");
                    tablaProductos.AddCell("Subtotal");

                    foreach (var producto in productos)
                    {
                        double subtotal = producto.cantidad * producto.precio;


                        tablaProductos.AddCell(producto.nombre);
                        tablaProductos.AddCell(producto.cantidad.ToString());
                        tablaProductos.AddCell($"${producto.precio:0.00}");
                        tablaProductos.AddCell($"${subtotal:0.00}");
                    }

                    // Agregar la fila de total productos
                    tablaProductos.AddCell("Total");
                    tablaProductos.AddCell("");
                    tablaProductos.AddCell("");
                    tablaProductos.AddCell($"${totalProductos:0.00}");


                    documento.Add(tablaProductos);

                    // 10. Calcular e incluir impuesto
                    double impuesto = totalProductos * 0.06;
                    double totalConImpuesto = totalProductos + impuesto;

                    // 11. Mostrar el total y el impuesto
                    Paragraph total = new Paragraph($"Total sin impuesto: ${totalProductos:0.00}\n");
                    total.Alignment = Element.ALIGN_RIGHT;
                    documento.Add(total);
                    Paragraph impuestoTexto = new Paragraph($"Impuesto (6%): ${impuesto:0.00}\n");
                    impuestoTexto.Alignment = Element.ALIGN_RIGHT;
                    documento.Add(impuestoTexto);
                    Paragraph totalFinal = new Paragraph($"Total a pagar: ${totalConImpuesto:0.00}\n\n");
                    totalFinal.Alignment = Element.ALIGN_RIGHT;
                    documento.Add(totalFinal);

                    // 12. Mensaje de agradecimiento
                    Paragraph mensaje = new Paragraph("¡Gracias por tu compra!", FontFactory.GetFont("Arial", 12));
                    mensaje.Alignment = Element.ALIGN_CENTER;
                    documento.Add(mensaje);

                    // 13. Eslogan
                    Paragraph eslogan = new Paragraph("Para un caballero sin rival, ven por tu traje excepcional.", FontFactory.GetFont("Arial", 14));
                    eslogan.Alignment = Element.ALIGN_CENTER; // Centrar el texto
                    documento.Add(eslogan);

                    // 14. Mostrar mensaje de éxito con la ruta fija del comprobante generado
                    MessageBox.Show("El comprobante de pago se ha generado correctamente.\nRuta: C:\\Comprobantes\\comprobante_pago.pdf",
                                    "Comprobante Generado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante de pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsFileInUse(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    return false; // El archivo no está en uso
                }
            }
            catch (IOException)
            {
                return true; // El archivo está en uso
            }
        }


        private double ObtenerTotalDesdeBaseDeDatos()
        {
            double total = 0;

            // Configuración de la conexión a la base de datos MySQL
            string query = "SELECT SUM(precio) FROM prendas"; // Ajusta tu tabla y campo

            using (MySqlConnection conexionBD = conexion.conex()) // Cambié la variable a conexionBD
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                try
                {
                    conexionBD.Open();
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null)
                        total = Convert.ToDouble(resultado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos de la base de datos: " + ex.Message);
                }
            }

            return total;
        }
        private void ActualizarVistaCarrito()
        {
            dgvCarrito.Rows.Clear();
            foreach (var producto in carrito)
            {
                dgvCarrito.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad, producto.Precio * producto.Cantidad);
            }
        }
        private void ReiniciarCarrito()
        {
            carrito.Clear(); // Limpia todos los elementos de la lista
            ActualizarVistaCarrito(); // Refresca la vista en el DataGridView
        }


        private void ConfigurarDataGridView()
        {
            // Limpiar las columnas si ya existen
            dgvCarrito.Columns.Clear();

            // Agregar columnas al DataGridView
            dgvCarrito.Columns.Add("Nombre", "Nombre del Articulos");
            dgvCarrito.Columns.Add("Precio", "Precio Unitario");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("Total", "Total");

            // Configurar formato para las columnas
            dgvCarrito.Columns["Precio"].DefaultCellStyle.Format = "C2"; // Formato de moneda
            dgvCarrito.Columns["Total"].DefaultCellStyle.Format = "C2"; // Formato de moneda

            // Opcional: Configurar propiedades del DataGridView
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al ancho del DataGridView
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección de fila completa
            dgvCarrito.MultiSelect = false; // Solo permitir seleccionar una fila
            dgvCarrito.AllowUserToAddRows = false; // Deshabilitar la fila extra al final
            dgvCarrito.ReadOnly = true; // Hacerlo de solo lectura
        }

        private void btnTrajeCafe_Click(object sender, EventArgs e)
        {
            producto = 1112;
            abrirFormP(new Producto(producto));
        }

        private void btnTrajeGris_Click(object sender, EventArgs e)
        {
            producto = 1113;
            abrirFormP(new Producto(producto));
        }

        private void btnPantalonVestir_Click(object sender, EventArgs e)
        {
            producto = 1234;
            abrirFormP(new Producto(producto));
        }

        private void btnPantalonCasual_Click(object sender, EventArgs e)
        {
            producto = 3456;
            abrirFormP(new Producto(producto));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            producto = 8943;
            abrirFormP(new Producto(producto));
        }
    }





}

