namespace SistemaAdministrativo
{
    partial class FrmDetallesAd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallesAd));
            pnlDetallesInfo = new Panel();
            btnInfoDetaAlumAd = new Button();
            lblDetalles = new Label();
            panel1 = new Panel();
            gridDatosAlumnos = new DataGridView();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlDetallesInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDatosAlumnos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDetallesInfo
            // 
            pnlDetallesInfo.Controls.Add(btnInfoDetaAlumAd);
            pnlDetallesInfo.Controls.Add(lblDetalles);
            pnlDetallesInfo.Dock = DockStyle.Top;
            pnlDetallesInfo.Location = new Point(0, 0);
            pnlDetallesInfo.Margin = new Padding(4, 3, 4, 3);
            pnlDetallesInfo.Name = "pnlDetallesInfo";
            pnlDetallesInfo.Size = new Size(919, 93);
            pnlDetallesInfo.TabIndex = 0;
            // 
            // btnInfoDetaAlumAd
            // 
            btnInfoDetaAlumAd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInfoDetaAlumAd.BackColor = Color.Maroon;
            btnInfoDetaAlumAd.Image = (Image)resources.GetObject("btnInfoDetaAlumAd.Image");
            btnInfoDetaAlumAd.Location = new Point(804, 2);
            btnInfoDetaAlumAd.Margin = new Padding(4, 3, 4, 3);
            btnInfoDetaAlumAd.Name = "btnInfoDetaAlumAd";
            btnInfoDetaAlumAd.Size = new Size(115, 88);
            btnInfoDetaAlumAd.TabIndex = 1;
            btnInfoDetaAlumAd.UseVisualStyleBackColor = false;
            // 
            // lblDetalles
            // 
            lblDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDetalles.AutoSize = true;
            lblDetalles.FlatStyle = FlatStyle.Flat;
            lblDetalles.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalles.Location = new Point(0, 2);
            lblDetalles.Margin = new Padding(4, 0, 4, 0);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(682, 72);
            lblDetalles.TabIndex = 0;
            lblDetalles.Text = resources.GetString("lblDetalles.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(gridDatosAlumnos);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 93);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 502);
            panel1.TabIndex = 2;
            // 
            // gridDatosAlumnos
            // 
            gridDatosAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridDatosAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatosAlumnos.Location = new Point(243, 76);
            gridDatosAlumnos.Margin = new Padding(4, 3, 4, 3);
            gridDatosAlumnos.Name = "gridDatosAlumnos";
            gridDatosAlumnos.Size = new Size(668, 415);
            gridDatosAlumnos.TabIndex = 1;
            gridDatosAlumnos.CellContentClick += gridDatosAlumnos_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 502);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(68, 377);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 13);
            label8.TabIndex = 9;
            label8.Text = "ENCARGADO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(93, 315);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 13);
            label7.TabIndex = 8;
            label7.Text = "AÑO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(78, 287);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 13);
            label6.TabIndex = 7;
            label6.Text = "ESCUELA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(72, 255);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 13);
            label5.TabIndex = 6;
            label5.Text = "APELLIDOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 225);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 5;
            label4.Text = "NOMBRES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 350);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 13);
            label3.TabIndex = 4;
            label3.Text = "CORREO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 13);
            label2.TabIndex = 3;
            label2.Text = "CARNET";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 158);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 13);
            label1.TabIndex = 2;
            label1.Text = "DETALLES DE ALUMNOS";
            // 
            // FrmDetallesAd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(919, 595);
            Controls.Add(panel1);
            Controls.Add(pnlDetallesInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDetallesAd";
            Text = "FrmDetallesAd";
            pnlDetallesInfo.ResumeLayout(false);
            pnlDetallesInfo.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDatosAlumnos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDetallesInfo;
        private Label lblDetalles;
        private Button btnInfoDetaAlumAd;
        private Panel panel1;
        private DataGridView gridDatosAlumnos;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
    }
}