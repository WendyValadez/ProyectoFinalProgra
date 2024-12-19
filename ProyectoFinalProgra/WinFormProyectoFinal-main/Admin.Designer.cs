namespace WinFormProyectoFinal
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            nom = new Label();
            id = new Label();
            fecha = new Label();
            hr = new Label();
            Csesion = new Button();
            label1 = new Label();
            txtProd = new TextBox();
            txtID = new TextBox();
            txtImg1 = new TextBox();
            txtImg2 = new TextBox();
            txtColor = new TextBox();
            txtExist = new TextBox();
            label2 = new Label();
            txtDesc = new TextBox();
            txtBuscaID = new TextBox();
            label3 = new Label();
            btnElim = new Button();
            btnRegis = new Button();
            txtPrecio = new TextBox();
            dataGridView1 = new DataGridView();
            btnMostrar = new Button();
            chart_Admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            totalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).BeginInit();
            SuspendLayout();
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.BackColor = Color.Moccasin;
            nom.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nom.ForeColor = Color.Orange;
            nom.Location = new Point(30, 9);
            nom.Name = "nom";
            nom.Size = new Size(88, 24);
            nom.TabIndex = 0;
            nom.Text = "nombre";
            // 
            // id
            // 
            id.AutoSize = true;
            id.BackColor = Color.Moccasin;
            id.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.ForeColor = Color.Orange;
            id.Location = new Point(320, 9);
            id.Name = "id";
            id.Size = new Size(36, 24);
            id.TabIndex = 3;
            id.Text = "id";
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.BackColor = Color.Moccasin;
            fecha.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fecha.ForeColor = Color.Orange;
            fecha.Location = new Point(936, 762);
            fecha.Name = "fecha";
            fecha.Size = new Size(75, 24);
            fecha.TabIndex = 4;
            fecha.Text = "Fecha";
            fecha.Click += fecha_Click;
            // 
            // hr
            // 
            hr.AutoSize = true;
            hr.BackColor = Color.Moccasin;
            hr.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hr.ForeColor = Color.Orange;
            hr.Location = new Point(1127, 762);
            hr.Name = "hr";
            hr.Size = new Size(62, 24);
            hr.TabIndex = 5;
            hr.Text = "hora";
            // 
            // Csesion
            // 
            Csesion.BackColor = Color.Moccasin;
            Csesion.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Csesion.ForeColor = Color.Orange;
            Csesion.Location = new Point(777, 12);
            Csesion.Name = "Csesion";
            Csesion.Size = new Size(211, 38);
            Csesion.TabIndex = 6;
            Csesion.Text = "cerrar sesion";
            Csesion.UseVisualStyleBackColor = false;
            Csesion.Click += Csesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("DejaVu Sans Mono", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(652, 95);
            label1.Name = "label1";
            label1.Size = new Size(249, 33);
            label1.TabIndex = 7;
            label1.Text = "base de datos";
            // 
            // txtProd
            // 
            txtProd.BackColor = Color.Moccasin;
            txtProd.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProd.Location = new Point(296, 169);
            txtProd.Name = "txtProd";
            txtProd.PlaceholderText = "Producto:";
            txtProd.Size = new Size(245, 31);
            txtProd.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.BackColor = Color.Moccasin;
            txtID.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.Orange;
            txtID.Location = new Point(44, 95);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID:";
            txtID.Size = new Size(245, 31);
            txtID.TabIndex = 9;
            txtID.Tag = "";
            // 
            // txtImg1
            // 
            txtImg1.BackColor = Color.Moccasin;
            txtImg1.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImg1.ForeColor = Color.Orange;
            txtImg1.Location = new Point(296, 95);
            txtImg1.Name = "txtImg1";
            txtImg1.PlaceholderText = "Imagen 1:";
            txtImg1.Size = new Size(245, 31);
            txtImg1.TabIndex = 10;
            // 
            // txtImg2
            // 
            txtImg2.BackColor = Color.Moccasin;
            txtImg2.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImg2.ForeColor = Color.Orange;
            txtImg2.Location = new Point(296, 132);
            txtImg2.Name = "txtImg2";
            txtImg2.PlaceholderText = "Imagen 2:";
            txtImg2.Size = new Size(245, 31);
            txtImg2.TabIndex = 11;
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.Moccasin;
            txtColor.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(44, 169);
            txtColor.MaxLength = 3;
            txtColor.Name = "txtColor";
            txtColor.PlaceholderText = "Color:";
            txtColor.Size = new Size(245, 31);
            txtColor.TabIndex = 12;
            // 
            // txtExist
            // 
            txtExist.BackColor = Color.Moccasin;
            txtExist.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExist.Location = new Point(44, 132);
            txtExist.Name = "txtExist";
            txtExist.PlaceholderText = "Existencias:";
            txtExist.Size = new Size(245, 31);
            txtExist.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Moccasin;
            label2.Font = new Font("DejaVu Sans Mono", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(44, 49);
            label2.Name = "label2";
            label2.Size = new Size(177, 33);
            label2.TabIndex = 14;
            label2.Text = "Registrar";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.Moccasin;
            txtDesc.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(44, 255);
            txtDesc.MaxLength = 200;
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Descripcion:";
            txtDesc.Size = new Size(496, 194);
            txtDesc.TabIndex = 15;
            // 
            // txtBuscaID
            // 
            txtBuscaID.BackColor = Color.Moccasin;
            txtBuscaID.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscaID.Location = new Point(44, 500);
            txtBuscaID.Name = "txtBuscaID";
            txtBuscaID.PlaceholderText = "ID:";
            txtBuscaID.Size = new Size(150, 31);
            txtBuscaID.TabIndex = 16;
            txtBuscaID.TextChanged += txtBuscaID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("DejaVu Sans Mono", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(44, 461);
            label3.Name = "label3";
            label3.Size = new Size(159, 33);
            label3.TabIndex = 17;
            label3.Text = "Eliminar";
            // 
            // btnElim
            // 
            btnElim.BackColor = Color.Moccasin;
            btnElim.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnElim.ForeColor = Color.Orange;
            btnElim.Location = new Point(220, 500);
            btnElim.Name = "btnElim";
            btnElim.Size = new Size(168, 31);
            btnElim.TabIndex = 18;
            btnElim.Text = "Eliminar";
            btnElim.UseVisualStyleBackColor = false;
            btnElim.Click += btnElim_Click;
            // 
            // btnRegis
            // 
            btnRegis.BackColor = Color.Moccasin;
            btnRegis.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegis.ForeColor = Color.Orange;
            btnRegis.Location = new Point(296, 206);
            btnRegis.Name = "btnRegis";
            btnRegis.Size = new Size(245, 31);
            btnRegis.TabIndex = 19;
            btnRegis.Text = "Registrar";
            btnRegis.UseVisualStyleBackColor = false;
            btnRegis.Click += btnRegis_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.Moccasin;
            txtPrecio.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(44, 206);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio:";
            txtPrecio.Size = new Size(245, 31);
            txtPrecio.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.NavajoWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(652, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(788, 556);
            dataGridView1.TabIndex = 22;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Moccasin;
            btnMostrar.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.ForeColor = Color.Orange;
            btnMostrar.Location = new Point(557, 768);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(268, 38);
            btnMostrar.TabIndex = 23;
            btnMostrar.Text = "Mostrar Tabla";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // chart_Admin
            // 
            chartArea1.Name = "ChartArea1";
            chart_Admin.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_Admin.Legends.Add(legend1);
            chart_Admin.Location = new Point(83, 623);
            chart_Admin.Name = "chart_Admin";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_Admin.Series.Add(series1);
            chart_Admin.Size = new Size(457, 183);
            chart_Admin.TabIndex = 24;
            chart_Admin.Text = "chart1";
            chart_Admin.Click += chart_Admin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("DejaVu Sans Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(83, 572);
            label4.Name = "label4";
            label4.Size = new Size(432, 28);
            label4.TabIndex = 25;
            label4.Text = "Grafica de gasto por persona";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(502, 531);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(55, 25);
            totalLabel.TabIndex = 27;
            totalLabel.Text = "mont";
            totalLabel.Click += totalLabel_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PortadaAdmin;
            ClientSize = new Size(1478, 845);
            Controls.Add(totalLabel);
            Controls.Add(label4);
            Controls.Add(chart_Admin);
            Controls.Add(btnMostrar);
            Controls.Add(dataGridView1);
            Controls.Add(txtPrecio);
            Controls.Add(btnRegis);
            Controls.Add(btnElim);
            Controls.Add(label3);
            Controls.Add(txtBuscaID);
            Controls.Add(txtDesc);
            Controls.Add(label2);
            Controls.Add(txtExist);
            Controls.Add(txtColor);
            Controls.Add(txtImg2);
            Controls.Add(txtImg1);
            Controls.Add(txtID);
            Controls.Add(txtProd);
            Controls.Add(label1);
            Controls.Add(Csesion);
            Controls.Add(hr);
            Controls.Add(fecha);
            Controls.Add(id);
            Controls.Add(nom);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nom;
        private Label id;
        private Label fecha;
        private Label hr;
        private Button Csesion;
        private Label label1;
        private TextBox txtProd;
        private TextBox txtID;
        private TextBox txtImg1;
        private TextBox txtImg2;
        private TextBox txtColor;
        private TextBox txtExist;
        private Label label2;
        private TextBox txtDesc;
        private TextBox txtBuscaID;
        private Label label3;
        private Button btnElim;
        private Button btnRegis;
        private TextBox txtPrecio;
        private DataGridView dataGridView1;
        private Button btnMostrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Admin;
        private Label label4;
        private Label totalLabel;
    }
}