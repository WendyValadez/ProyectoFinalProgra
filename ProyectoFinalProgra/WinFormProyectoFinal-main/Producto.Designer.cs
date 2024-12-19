namespace WinFormProyectoFinal
{
    partial class Producto
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
            lblProd = new Label();
            lblId = new Label();
            lblExist = new Label();
            lblDescrp = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblPrec = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.BackColor = Color.Cornsilk;
            lblProd.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProd.ForeColor = Color.Orange;
            lblProd.Location = new Point(12, 221);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(114, 24);
            lblProd.TabIndex = 0;
            lblProd.Text = "Producto";
            lblProd.Click += lblProd_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Cornsilk;
            lblId.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.Orange;
            lblId.Location = new Point(398, 221);
            lblId.Name = "lblId";
            lblId.Size = new Size(36, 24);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblExist
            // 
            lblExist.AutoSize = true;
            lblExist.BackColor = Color.Cornsilk;
            lblExist.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExist.ForeColor = Color.Orange;
            lblExist.Location = new Point(12, 496);
            lblExist.Name = "lblExist";
            lblExist.Size = new Size(153, 24);
            lblExist.TabIndex = 2;
            lblExist.Text = "Existencias";
            // 
            // lblDescrp
            // 
            lblDescrp.AutoSize = true;
            lblDescrp.BackColor = Color.Cornsilk;
            lblDescrp.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescrp.ForeColor = Color.Orange;
            lblDescrp.Location = new Point(12, 333);
            lblDescrp.Name = "lblDescrp";
            lblDescrp.Size = new Size(153, 24);
            lblDescrp.TabIndex = 3;
            lblDescrp.Text = "Descripcion";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(561, 251);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 247);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(847, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 247);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lblPrec
            // 
            lblPrec.AutoSize = true;
            lblPrec.BackColor = Color.Cornsilk;
            lblPrec.Font = new Font("DejaVu Sans Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrec.ForeColor = Color.Orange;
            lblPrec.Location = new Point(12, 273);
            lblPrec.Name = "lblPrec";
            lblPrec.Size = new Size(88, 24);
            lblPrec.TabIndex = 8;
            lblPrec.Text = "precio";
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.portadaProducto;
            ClientSize = new Size(1145, 646);
            Controls.Add(lblPrec);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblDescrp);
            Controls.Add(lblExist);
            Controls.Add(lblId);
            Controls.Add(lblProd);
            Name = "Producto";
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProd;
        private Label lblId;
        private Label lblExist;
        private Label lblDescrp;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblPrec;
        private Button btnComprar;
    }
}