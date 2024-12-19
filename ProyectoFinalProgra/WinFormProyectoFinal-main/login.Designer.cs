namespace WinFormProyectoFinal
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtUsua = new TextBox();
            txtContra = new TextBox();
            btnEntrada = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.boton;
            button1.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(545, 527);
            button1.Name = "button1";
            button1.Size = new Size(187, 54);
            button1.TabIndex = 0;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtUsua
            // 
            txtUsua.Font = new Font("Candara", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsua.ForeColor = SystemColors.WindowFrame;
            txtUsua.Location = new Point(545, 401);
            txtUsua.Name = "txtUsua";
            txtUsua.PlaceholderText = "Usuario:";
            txtUsua.Size = new Size(402, 42);
            txtUsua.TabIndex = 3;
            txtUsua.Tag = "";
            txtUsua.TextAlign = HorizontalAlignment.Center;
            txtUsua.TextChanged += textBox1_TextChanged;
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Candara", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContra.Location = new Point(545, 455);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.PlaceholderText = "Contraseña:";
            txtContra.Size = new Size(402, 42);
            txtContra.TabIndex = 4;
            txtContra.TextAlign = HorizontalAlignment.Center;
            txtContra.TextChanged += textBox2_TextChanged;
            // 
            // btnEntrada
            // 
            btnEntrada.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrada.Image = Properties.Resources.boton;
            btnEntrada.Location = new Point(760, 527);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(187, 54);
            btnEntrada.TabIndex = 5;
            btnEntrada.Text = "Entrar";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PortadaFinal2;
            ClientSize = new Size(1478, 817);
            Controls.Add(btnEntrada);
            Controls.Add(txtContra);
            Controls.Add(txtUsua);
            Controls.Add(button1);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtUsua;
        private TextBox txtContra;
        private Button btnEntrada;
    }
}
