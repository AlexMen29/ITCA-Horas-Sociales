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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlDetallesInfo = new Panel();
            lblDetalles = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtBuscar = new TextBox();
            label9 = new Label();
            gridDatosAlumnos = new DataGridView();
            pnlDetallesInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDatosAlumnos).BeginInit();
            SuspendLayout();
            // 
            // pnlDetallesInfo
            // 
            pnlDetallesInfo.Controls.Add(lblDetalles);
            pnlDetallesInfo.Dock = DockStyle.Top;
            pnlDetallesInfo.Location = new Point(0, 0);
            pnlDetallesInfo.Margin = new Padding(4, 3, 4, 3);
            pnlDetallesInfo.Name = "pnlDetallesInfo";
            pnlDetallesInfo.Size = new Size(919, 93);
            pnlDetallesInfo.TabIndex = 0;
            // 
            // lblDetalles
            // 
            lblDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDetalles.AutoSize = true;
            lblDetalles.FlatStyle = FlatStyle.Flat;
            lblDetalles.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalles.Location = new Point(153, 18);
            lblDetalles.Margin = new Padding(4, 0, 4, 0);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(682, 72);
            lblDetalles.TabIndex = 0;
            lblDetalles.Text = resources.GetString("lblDetalles.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(gridDatosAlumnos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 93);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 502);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(80, 77);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(121, 32);
            txtBuscar.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(382, 20);
            label9.Name = "label9";
            label9.Size = new Size(246, 25);
            label9.TabIndex = 2;
            label9.Text = "Registro de Horas Sociales";
            // 
            // gridDatosAlumnos
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            gridDatosAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridDatosAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridDatosAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDatosAlumnos.BackgroundColor = Color.White;
            gridDatosAlumnos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridDatosAlumnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridDatosAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridDatosAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridDatosAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            gridDatosAlumnos.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridDatosAlumnos.EnableHeadersVisualStyles = false;
            gridDatosAlumnos.GridColor = Color.Firebrick;
            gridDatosAlumnos.Location = new Point(254, 63);
            gridDatosAlumnos.Margin = new Padding(4, 3, 4, 3);
            gridDatosAlumnos.MultiSelect = false;
            gridDatosAlumnos.Name = "gridDatosAlumnos";
            gridDatosAlumnos.ReadOnly = true;
            gridDatosAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDatosAlumnos.Size = new Size(451, 415);
            gridDatosAlumnos.TabIndex = 1;
            gridDatosAlumnos.CellContentClick += gridDatosAlumnos_CellContentClick;
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
            Load += FrmDetallesAd_Load;
            pnlDetallesInfo.ResumeLayout(false);
            pnlDetallesInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDatosAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDetallesInfo;
        private Label lblDetalles;
        private Panel panel1;
        private DataGridView gridDatosAlumnos;
        private Label label9;
        private PictureBox pictureBox1;
        private TextBox txtBuscar;
    }
}