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
            panel1 = new Panel();
            panelDetallesAlumnos = new Panel();
            LabCorreo = new Label();
            LabApellido = new Label();
            LabNombre = new Label();
            label2 = new Label();
            LabTotalHoras = new Label();
            label1 = new Label();
            PanelElementosBusqueda = new Panel();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            pictureBuscar = new PictureBox();
            txtBuscar = new TextBox();
            label9 = new Label();
            gridDatosAlumnos = new DataGridView();
            panel1.SuspendLayout();
            panelDetallesAlumnos.SuspendLayout();
            PanelElementosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDatosAlumnos).BeginInit();
            SuspendLayout();
            // 
            // pnlDetallesInfo
            // 
            pnlDetallesInfo.Dock = DockStyle.Top;
            pnlDetallesInfo.Location = new Point(0, 0);
            pnlDetallesInfo.Margin = new Padding(4, 3, 4, 3);
            pnlDetallesInfo.Name = "pnlDetallesInfo";
            pnlDetallesInfo.Size = new Size(919, 34);
            pnlDetallesInfo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panelDetallesAlumnos);
            panel1.Controls.Add(LabTotalHoras);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PanelElementosBusqueda);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(gridDatosAlumnos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 34);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 561);
            panel1.TabIndex = 2;
            // 
            // panelDetallesAlumnos
            // 
            panelDetallesAlumnos.Controls.Add(LabCorreo);
            panelDetallesAlumnos.Controls.Add(LabApellido);
            panelDetallesAlumnos.Controls.Add(LabNombre);
            panelDetallesAlumnos.Controls.Add(label2);
            panelDetallesAlumnos.Location = new Point(252, 421);
            panelDetallesAlumnos.Name = "panelDetallesAlumnos";
            panelDetallesAlumnos.Size = new Size(455, 131);
            panelDetallesAlumnos.TabIndex = 8;
            // 
            // LabCorreo
            // 
            LabCorreo.AutoSize = true;
            LabCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabCorreo.Location = new Point(3, 84);
            LabCorreo.Name = "LabCorreo";
            LabCorreo.Size = new Size(45, 15);
            LabCorreo.TabIndex = 12;
            LabCorreo.Text = "Correo";
            // 
            // LabApellido
            // 
            LabApellido.AutoSize = true;
            LabApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabApellido.Location = new Point(3, 58);
            LabApellido.Name = "LabApellido";
            LabApellido.Size = new Size(100, 15);
            LabApellido.TabIndex = 11;
            LabApellido.Text = "Najarro Menjivar";
            // 
            // LabNombre
            // 
            LabNombre.AutoSize = true;
            LabNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabNombre.Location = new Point(3, 34);
            LabNombre.Name = "LabNombre";
            LabNombre.Size = new Size(101, 15);
            LabNombre.TabIndex = 10;
            LabNombre.Text = "Omar Alexander ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(176, 25, 29);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 9;
            label2.Text = "Detalles de Alumno";
            // 
            // LabTotalHoras
            // 
            LabTotalHoras.AutoSize = true;
            LabTotalHoras.BackColor = Color.FromArgb(205, 144, 19);
            LabTotalHoras.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabTotalHoras.ForeColor = SystemColors.Control;
            LabTotalHoras.Location = new Point(611, 385);
            LabTotalHoras.Name = "LabTotalHoras";
            LabTotalHoras.Size = new Size(19, 30);
            LabTotalHoras.TabIndex = 7;
            LabTotalHoras.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(176, 25, 29);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(254, 385);
            label1.Name = "label1";
            label1.Size = new Size(351, 30);
            label1.TabIndex = 6;
            label1.Text = "Total de Horas Sociales Realizadas:";
            // 
            // PanelElementosBusqueda
            // 
            PanelElementosBusqueda.BackColor = Color.White;
            PanelElementosBusqueda.BorderStyle = BorderStyle.Fixed3D;
            PanelElementosBusqueda.Controls.Add(btnBuscar);
            PanelElementosBusqueda.Controls.Add(btnLimpiar);
            PanelElementosBusqueda.Controls.Add(pictureBuscar);
            PanelElementosBusqueda.Controls.Add(txtBuscar);
            PanelElementosBusqueda.Location = new Point(12, 63);
            PanelElementosBusqueda.Name = "PanelElementosBusqueda";
            PanelElementosBusqueda.Size = new Size(198, 227);
            PanelElementosBusqueda.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(176, 25, 29);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(18, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(165, 40);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            btnBuscar.MouseLeave += btnBuscar_MouseLeave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(176, 25, 29);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(18, 111);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(165, 40);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseEnter += btnLimpiar_MouseEnter;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            // 
            // pictureBuscar
            // 
            pictureBuscar.Image = (Image)resources.GetObject("pictureBuscar.Image");
            pictureBuscar.Location = new Point(18, 25);
            pictureBuscar.Name = "pictureBuscar";
            pictureBuscar.Size = new Size(38, 34);
            pictureBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBuscar.TabIndex = 4;
            pictureBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(62, 25);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(121, 32);
            txtBuscar.TabIndex = 3;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(176, 25, 29);
            label9.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(268, 15);
            label9.Name = "label9";
            label9.Size = new Size(430, 45);
            label9.TabIndex = 2;
            label9.Text = "Detalles de Horas Sociales";
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
            gridDatosAlumnos.Size = new Size(451, 319);
            gridDatosAlumnos.TabIndex = 1;
            gridDatosAlumnos.CellClick += gridDatosAlumnos_CellClick;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelDetallesAlumnos.ResumeLayout(false);
            panelDetallesAlumnos.PerformLayout();
            PanelElementosBusqueda.ResumeLayout(false);
            PanelElementosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDatosAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDetallesInfo;
        private Panel panel1;
        private DataGridView gridDatosAlumnos;
        private Label label9;
        private PictureBox pictureBuscar;
        private TextBox txtBuscar;
        private Panel PanelElementosBusqueda;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Label LabTotalHoras;
        private Label label1;
        private Panel panelDetallesAlumnos;
        private Label LabApellido;
        private Label LabNombre;
        private Label label2;
        private Label LabCorreo;
    }
}