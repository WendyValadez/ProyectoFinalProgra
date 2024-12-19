using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinFormProyectoFinal
{
    public partial class Portada : Form
    {
        private string ruta = ""; //para el audio
        public Portada()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.ShowDialog();


        }

        private void clsSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

            // Crear un cuadro de diálogo para seleccionar el archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtrar solo archivos de texto
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            // Si el usuario selecciona un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Crear una instancia de Form2 y mostrar el archivo
                Ayuda form2 = new Ayuda(filePath);
                form2.ShowDialog();
            }
        }
        //boton de cargar el audio
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;

            }
        }
        //boton reproducir
        private void btnReproducir_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = ruta;
            player.Load();
            player.Play();
        }
        //boton detener Audio
        private void btnDetener_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = ruta;
            player.Stop();
        }
    }
}
