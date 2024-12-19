using MySql.Data.MySqlClient;
using Mysqlx.Cursor;


namespace WinFormProyectoFinal
{
    public partial class login : Form
    {
        string conexion = "server=localhost;port=3306;uid=root;pwd='';database=kingsman;";

        public login()
        {
            InitializeComponent();
        }
        public void Login()
        {
            string query = "SELECT * FROM `inicio de sesión` WHERE Cuenta = @Cuenta AND Contraseña = @Contraseña";
            MySqlConnection databaseConnection = new MySqlConnection(conexion);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            // Uso de parámetros para evitar inyección SQL
            commandDatabase.Parameters.AddWithValue("@Cuenta", txtUsua.Text);
            commandDatabase.Parameters.AddWithValue("@Contraseña", txtContra.Text);

            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Bienvenid@");
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("ID");
                        int tipo = reader.GetInt32("ID_tipo");
                        string nombre = reader.GetString("Nombre");
                        double monto = reader.GetDouble("Monto");
                        if (tipo == 0)
                        {
                            guest inv = new guest(id, nombre, monto);
                            inv.Show();
                        }
                        else
                        {
                            Admin admn = new Admin(id, nombre);
                            admn.Show();
                        }

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cerrarsecion()
        {
            // Mostrar el formulario de inicio de sesión (Form1)
            Portada port = new Portada();
            port.Show();

            // Cerrar el formulario actual
            this.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {

            Login();
        }

        private void clsSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
