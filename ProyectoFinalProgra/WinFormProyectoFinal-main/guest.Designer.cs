
namespace WinFormProyectoFinal
{
    partial class guest
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
            nom = new Label();
            fecha = new Label();
            id = new Label();
            hr = new Label();
            Csesion = new Button();
            panel1 = new Panel();
            button6 = new Button();
            btnPantalonCasual = new Button();
            btnPantalonVestir = new Button();
            btnTrajeGris = new Button();
            btnTrajeCafe = new Button();
            btnSaco = new Button();
            panel2 = new Panel();
            monto = new Label();
            panel3 = new Panel();
            dgvCarrito = new DataGridView();
            btnBorra = new Button();
            button1 = new Button();
            btnComp = new Button();
            panelForm = new Panel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.Dock = DockStyle.Top;
            nom.Font = new Font("DejaVu Sans Mono", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nom.ForeColor = Color.Orange;
            nom.Location = new Point(0, 25);
            nom.Name = "nom";
            nom.Size = new Size(96, 25);
            nom.TabIndex = 0;
            nom.Text = "nombre";
            // 
            // fecha
            // 
            fecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            fecha.AutoSize = true;
            fecha.Font = new Font("DejaVu Sans Mono", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fecha.ForeColor = Color.Orange;
            fecha.Location = new Point(0, 69);
            fecha.Name = "fecha";
            fecha.Size = new Size(82, 25);
            fecha.TabIndex = 1;
            fecha.Text = "fecha";
            fecha.TextAlign = ContentAlignment.TopRight;
            fecha.Click += fecha_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.BackColor = Color.Cornsilk;
            id.Dock = DockStyle.Top;
            id.Font = new Font("DejaVu Sans Mono", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.ForeColor = Color.Orange;
            id.Location = new Point(0, 0);
            id.Name = "id";
            id.Size = new Size(40, 25);
            id.TabIndex = 2;
            id.Text = "id";
            id.Click += id_Click;
            // 
            // hr
            // 
            hr.AutoSize = true;
            hr.Dock = DockStyle.Bottom;
            hr.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hr.ForeColor = Color.Orange;
            hr.Location = new Point(0, 184);
            hr.Name = "hr";
            hr.Size = new Size(62, 24);
            hr.TabIndex = 3;
            hr.Text = "hora";
            // 
            // Csesion
            // 
            Csesion.AccessibleRole = AccessibleRole.IpAddress;
            Csesion.BackColor = Color.Moccasin;
            Csesion.BackgroundImageLayout = ImageLayout.Center;
            Csesion.Dock = DockStyle.Bottom;
            Csesion.FlatAppearance.BorderSize = 0;
            Csesion.FlatAppearance.MouseDownBackColor = Color.Gold;
            Csesion.FlatAppearance.MouseOverBackColor = Color.Gold;
            Csesion.FlatStyle = FlatStyle.Flat;
            Csesion.Font = new Font("DejaVu Sans Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Csesion.ForeColor = Color.Orange;
            Csesion.Location = new Point(0, 114);
            Csesion.Name = "Csesion";
            Csesion.Size = new Size(295, 70);
            Csesion.TabIndex = 4;
            Csesion.Text = "cerrar sesion";
            Csesion.UseVisualStyleBackColor = false;
            Csesion.Click += Csesion_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnPantalonCasual);
            panel1.Controls.Add(btnPantalonVestir);
            panel1.Controls.Add(btnTrajeGris);
            panel1.Controls.Add(btnTrajeCafe);
            panel1.Controls.Add(btnSaco);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 777);
            panel1.TabIndex = 5;
            // 
            // button6
            // 
            button6.BackColor = Color.Moccasin;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Gold;
            button6.FlatAppearance.MouseOverBackColor = Color.Gold;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Orange;
            button6.Location = new Point(0, 487);
            button6.Name = "button6";
            button6.Size = new Size(295, 54);
            button6.TabIndex = 6;
            button6.Text = "Zapatos Oxford";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnPantalonCasual
            // 
            btnPantalonCasual.BackColor = Color.Moccasin;
            btnPantalonCasual.Dock = DockStyle.Top;
            btnPantalonCasual.FlatAppearance.BorderSize = 0;
            btnPantalonCasual.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnPantalonCasual.FlatAppearance.MouseOverBackColor = Color.Gold;
            btnPantalonCasual.FlatStyle = FlatStyle.Popup;
            btnPantalonCasual.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPantalonCasual.ForeColor = Color.Orange;
            btnPantalonCasual.Location = new Point(0, 433);
            btnPantalonCasual.Name = "btnPantalonCasual";
            btnPantalonCasual.Size = new Size(295, 54);
            btnPantalonCasual.TabIndex = 5;
            btnPantalonCasual.Text = "Pantalon casual";
            btnPantalonCasual.TextAlign = ContentAlignment.MiddleLeft;
            btnPantalonCasual.UseVisualStyleBackColor = false;
            btnPantalonCasual.Click += btnPantalonCasual_Click;
            // 
            // btnPantalonVestir
            // 
            btnPantalonVestir.BackColor = Color.Moccasin;
            btnPantalonVestir.Dock = DockStyle.Top;
            btnPantalonVestir.FlatAppearance.BorderSize = 0;
            btnPantalonVestir.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnPantalonVestir.FlatAppearance.MouseOverBackColor = Color.Gold;
            btnPantalonVestir.FlatStyle = FlatStyle.Popup;
            btnPantalonVestir.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPantalonVestir.ForeColor = Color.Orange;
            btnPantalonVestir.Location = new Point(0, 379);
            btnPantalonVestir.Name = "btnPantalonVestir";
            btnPantalonVestir.Size = new Size(295, 54);
            btnPantalonVestir.TabIndex = 4;
            btnPantalonVestir.Text = "Pantalon de vestir";
            btnPantalonVestir.TextAlign = ContentAlignment.MiddleLeft;
            btnPantalonVestir.UseVisualStyleBackColor = false;
            btnPantalonVestir.Click += btnPantalonVestir_Click;
            // 
            // btnTrajeGris
            // 
            btnTrajeGris.BackColor = Color.Moccasin;
            btnTrajeGris.Dock = DockStyle.Top;
            btnTrajeGris.FlatAppearance.BorderSize = 0;
            btnTrajeGris.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnTrajeGris.FlatAppearance.MouseOverBackColor = Color.Gold;
            btnTrajeGris.FlatStyle = FlatStyle.Popup;
            btnTrajeGris.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrajeGris.ForeColor = Color.Orange;
            btnTrajeGris.Location = new Point(0, 325);
            btnTrajeGris.Name = "btnTrajeGris";
            btnTrajeGris.Size = new Size(295, 54);
            btnTrajeGris.TabIndex = 3;
            btnTrajeGris.Text = "Traje de Hombre Gris";
            btnTrajeGris.TextAlign = ContentAlignment.MiddleLeft;
            btnTrajeGris.UseVisualStyleBackColor = false;
            btnTrajeGris.Click += btnTrajeGris_Click;
            // 
            // btnTrajeCafe
            // 
            btnTrajeCafe.BackColor = Color.Moccasin;
            btnTrajeCafe.Dock = DockStyle.Top;
            btnTrajeCafe.FlatAppearance.BorderSize = 0;
            btnTrajeCafe.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnTrajeCafe.FlatAppearance.MouseOverBackColor = Color.Gold;
            btnTrajeCafe.FlatStyle = FlatStyle.Popup;
            btnTrajeCafe.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrajeCafe.ForeColor = Color.Orange;
            btnTrajeCafe.Location = new Point(0, 262);
            btnTrajeCafe.Name = "btnTrajeCafe";
            btnTrajeCafe.Size = new Size(295, 63);
            btnTrajeCafe.TabIndex = 2;
            btnTrajeCafe.Text = "Traje de Hombre Cafe";
            btnTrajeCafe.TextAlign = ContentAlignment.MiddleLeft;
            btnTrajeCafe.UseVisualStyleBackColor = false;
            btnTrajeCafe.Click += btnTrajeCafe_Click;
            // 
            // btnSaco
            // 
            btnSaco.BackColor = Color.Moccasin;
            btnSaco.Dock = DockStyle.Top;
            btnSaco.FlatAppearance.BorderSize = 0;
            btnSaco.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnSaco.FlatAppearance.MouseOverBackColor = Color.Gold;
            btnSaco.FlatStyle = FlatStyle.Flat;
            btnSaco.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaco.ForeColor = Color.Orange;
            btnSaco.Location = new Point(0, 208);
            btnSaco.Name = "btnSaco";
            btnSaco.Size = new Size(295, 54);
            btnSaco.TabIndex = 1;
            btnSaco.Text = "Saco de vestir";
            btnSaco.TextAlign = ContentAlignment.MiddleLeft;
            btnSaco.UseVisualStyleBackColor = false;
            btnSaco.Click += btnSaco_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cornsilk;
            panel2.Controls.Add(monto);
            panel2.Controls.Add(Csesion);
            panel2.Controls.Add(hr);
            panel2.Controls.Add(nom);
            panel2.Controls.Add(fecha);
            panel2.Controls.Add(id);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 208);
            panel2.TabIndex = 0;
            // 
            // monto
            // 
            monto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            monto.AutoSize = true;
            monto.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monto.ForeColor = Color.Orange;
            monto.ImageAlign = ContentAlignment.MiddleRight;
            monto.Location = new Point(164, 184);
            monto.Name = "monto";
            monto.Size = new Size(75, 24);
            monto.TabIndex = 5;
            monto.Text = "monto";
            monto.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(dgvCarrito);
            panel3.Controls.Add(btnBorra);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnComp);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(295, 637);
            panel3.Name = "panel3";
            panel3.Size = new Size(1203, 140);
            panel3.TabIndex = 6;
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = Color.Cornsilk;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Dock = DockStyle.Fill;
            dgvCarrito.Location = new Point(0, 0);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(804, 140);
            dgvCarrito.TabIndex = 3;
            // 
            // btnBorra
            // 
            btnBorra.BackColor = Color.Moccasin;
            btnBorra.Dock = DockStyle.Right;
            btnBorra.Font = new Font("DejaVu Sans Mono", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorra.ForeColor = Color.Orange;
            btnBorra.Location = new Point(804, 0);
            btnBorra.Name = "btnBorra";
            btnBorra.Size = new Size(133, 140);
            btnBorra.TabIndex = 2;
            btnBorra.Text = "Borrar";
            btnBorra.UseVisualStyleBackColor = false;
            btnBorra.Click += btnBorra_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Dock = DockStyle.Right;
            button1.Font = new Font("DejaVu Sans Mono", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(937, 0);
            button1.Name = "button1";
            button1.Size = new Size(133, 140);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnComp
            // 
            btnComp.BackColor = Color.Moccasin;
            btnComp.Dock = DockStyle.Right;
            btnComp.Font = new Font("DejaVu Sans Mono", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComp.ForeColor = Color.Orange;
            btnComp.Location = new Point(1070, 0);
            btnComp.Name = "btnComp";
            btnComp.Size = new Size(133, 140);
            btnComp.TabIndex = 0;
            btnComp.Text = "Comprar";
            btnComp.UseVisualStyleBackColor = false;
            btnComp.Click += btnComp_Click;
            // 
            // panelForm
            // 
            panelForm.BackColor = SystemColors.ActiveCaptionText;
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(295, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1203, 637);
            panelForm.TabIndex = 7;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // guest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 777);
            Controls.Add(panelForm);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "guest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        private void NewMethod()
        {
            Csesion.Click += this.Csesion_Click;
        }

        

        private void fecha_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void id_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label nom;
        private Label fecha;
        private Label id;
        private Label hr;
        private Button Csesion;
        private Panel panel1;
        private Panel panel2;
        private Button btnSaco;
        private Panel panel3;
        private Panel panelForm;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label monto;
        private Button btnComp;
        private Button btnBorra;
        private Button button1;
        private DataGridView dgvCarrito;
        private Button button6;
        private Button btnPantalonCasual;
        private Button btnPantalonVestir;
        private Button btnTrajeGris;
        private Button btnTrajeCafe;
    }
}