using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProyectoFinal
{
    public partial class Ayuda : Form
    {
        public Ayuda(string filePath)
        {
            InitializeComponent();
            // Cargar el archivo de texto en el TextBox
            try
            {
                string textContent = File.ReadAllText(filePath);
                textBox1.Text = textContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }
    }
}
