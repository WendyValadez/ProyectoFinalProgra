namespace WinFormProyectoFinal
{
    partial class Portada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            btnEntrada = new Button();
            btnAyuda = new Button();
            btnCargar = new Button();
            btnReproducir = new Button();
            btnDetener = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEntrada
            // 
            btnEntrada.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrada.Image = Properties.Resources.boton;
            btnEntrada.Location = new Point(648, 700);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(187, 53);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "Entrar";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.BackgroundImage = (Image)resources.GetObject("btnAyuda.BackgroundImage");
            btnAyuda.Location = new Point(-1, 0);
            btnAyuda.Margin = new Padding(4, 5, 4, 5);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(73, 65);
            btnAyuda.TabIndex = 8;
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.Gold;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Location = new Point(1327, 205);
            btnCargar.Margin = new Padding(4, 5, 4, 5);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(107, 42);
            btnCargar.TabIndex = 9;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnReproducir
            // 
            btnReproducir.BackColor = Color.Gold;
            btnReproducir.FlatStyle = FlatStyle.Flat;
            btnReproducir.Location = new Point(1327, 275);
            btnReproducir.Margin = new Padding(4, 5, 4, 5);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(107, 38);
            btnReproducir.TabIndex = 10;
            btnReproducir.Text = "Reproducir";
            btnReproducir.UseVisualStyleBackColor = false;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.Gold;
            btnDetener.FlatStyle = FlatStyle.Flat;
            btnDetener.Location = new Point(1327, 344);
            btnDetener.Margin = new Padding(4, 5, 4, 5);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(107, 38);
            btnDetener.TabIndex = 11;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("DejaVu Sans Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(674, 354);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 12;
            label1.Text = "Programacion II";
            // 
            // Portada
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PortadaFinal;
            ClientSize = new Size(1447, 798);
            Controls.Add(label1);
            Controls.Add(btnDetener);
            Controls.Add(btnReproducir);
            Controls.Add(btnCargar);
            Controls.Add(btnAyuda);
            Controls.Add(btnEntrada);
            Name = "Portada";
            Text = "Portada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrada;
        private Button btnAyuda;
        private Button btnCargar;
        private Button btnReproducir;
        private Button btnDetener;
        private OpenFileDialog openFileDialog1;
        private Label label1;
    }
}