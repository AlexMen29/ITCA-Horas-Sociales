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
            LabHorasRestantes = new Label();
            label3 = new Label();
            panelDetallesAlumnos = new Panel();
            LabUltimoServicio = new Label();
            LabActivoDesde = new Label();
            label10 = new Label();
            label8 = new Label();
            LabCarnet = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label112 = new Label();
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
            panel1.Controls.Add(LabHorasRestantes);
            panel1.Controls.Add(label3);
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
            panel1.Size = new Size(919, 658);
            panel1.TabIndex = 2;
            // 
            // LabHorasRestantes
            // 
            LabHorasRestantes.AutoSize = true;
            LabHorasRestantes.BackColor = Color.FromArgb(205, 144, 19);
            LabHorasRestantes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabHorasRestantes.ForeColor = SystemColors.Control;
            LabHorasRestantes.Location = new Point(814, 397);
            LabHorasRestantes.Name = "LabHorasRestantes";
            LabHorasRestantes.Size = new Size(0, 18);
            LabHorasRestantes.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(176, 25, 29);
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(674, 397);
            label3.Name = "label3";
            label3.Size = new Size(134, 18);
            label3.TabIndex = 22;
            label3.Text = "Horas restantes:";
            // 
            // panelDetallesAlumnos
            // 
            panelDetallesAlumnos.Controls.Add(LabUltimoServicio);
            panelDetallesAlumnos.Controls.Add(LabActivoDesde);
            panelDetallesAlumnos.Controls.Add(label10);
            panelDetallesAlumnos.Controls.Add(label8);
            panelDetallesAlumnos.Controls.Add(LabCarnet);
            panelDetallesAlumnos.Controls.Add(label6);
            panelDetallesAlumnos.Controls.Add(label5);
            panelDetallesAlumnos.Controls.Add(label4);
            panelDetallesAlumnos.Controls.Add(label112);
            panelDetallesAlumnos.Controls.Add(LabCorreo);
            panelDetallesAlumnos.Controls.Add(LabApellido);
            panelDetallesAlumnos.Controls.Add(LabNombre);
            panelDetallesAlumnos.Controls.Add(label2);
            panelDetallesAlumnos.Location = new Point(252, 421);
            panelDetallesAlumnos.Name = "panelDetallesAlumnos";
            panelDetallesAlumnos.Size = new Size(511, 225);
            panelDetallesAlumnos.TabIndex = 8;
            // 
            // LabUltimoServicio
            // 
            LabUltimoServicio.AutoSize = true;
            LabUltimoServicio.BackColor = Color.FromArgb(205, 144, 19);
            LabUltimoServicio.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabUltimoServicio.ForeColor = Color.White;
            LabUltimoServicio.Location = new Point(260, 187);
            LabUltimoServicio.Name = "LabUltimoServicio";
            LabUltimoServicio.Size = new Size(0, 18);
            LabUltimoServicio.TabIndex = 21;
            // 
            // LabActivoDesde
            // 
            LabActivoDesde.AutoSize = true;
            LabActivoDesde.BackColor = Color.FromArgb(205, 144, 19);
            LabActivoDesde.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabActivoDesde.ForeColor = Color.White;
            LabActivoDesde.Location = new Point(260, 158);
            LabActivoDesde.Name = "LabActivoDesde";
            LabActivoDesde.Size = new Size(0, 18);
            LabActivoDesde.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(176, 25, 29);
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(16, 187);
            label10.Name = "label10";
            label10.Size = new Size(205, 18);
            label10.TabIndex = 19;
            label10.Text = "Ultima Vez de Servicio Social:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(176, 25, 29);
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(16, 158);
            label8.Name = "label8";
            label8.Size = new Size(96, 18);
            label8.TabIndex = 18;
            label8.Text = "Activo desde:";
            // 
            // LabCarnet
            // 
            LabCarnet.AutoSize = true;
            LabCarnet.BackColor = Color.FromArgb(205, 144, 19);
            LabCarnet.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabCarnet.ForeColor = Color.White;
            LabCarnet.Location = new Point(260, 100);
            LabCarnet.Name = "LabCarnet";
            LabCarnet.Size = new Size(0, 18);
            LabCarnet.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(176, 25, 29);
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 133);
            label6.Name = "label6";
            label6.Size = new Size(60, 18);
            label6.TabIndex = 16;
            label6.Text = "Corrreo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(176, 25, 29);
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 105);
            label5.Name = "label5";
            label5.Size = new Size(71, 18);
            label5.TabIndex = 15;
            label5.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(176, 25, 29);
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 77);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 14;
            label4.Text = "Nombre:";
            // 
            // label112
            // 
            label112.AutoSize = true;
            label112.BackColor = Color.FromArgb(176, 25, 29);
            label112.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label112.ForeColor = Color.White;
            label112.Location = new Point(16, 44);
            label112.Name = "label112";
            label112.Size = new Size(56, 18);
            label112.TabIndex = 13;
            label112.Text = "Carnet:";
            // 
            // LabCorreo
            // 
            LabCorreo.AutoSize = true;
            LabCorreo.BackColor = Color.FromArgb(205, 144, 19);
            LabCorreo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabCorreo.ForeColor = Color.White;
            LabCorreo.Location = new Point(260, 72);
            LabCorreo.Name = "LabCorreo";
            LabCorreo.Size = new Size(0, 18);
            LabCorreo.TabIndex = 12;
            // 
            // LabApellido
            // 
            LabApellido.AutoSize = true;
            LabApellido.BackColor = Color.FromArgb(205, 144, 19);
            LabApellido.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabApellido.ForeColor = Color.White;
            LabApellido.Location = new Point(260, 44);
            LabApellido.Name = "LabApellido";
            LabApellido.Size = new Size(0, 18);
            LabApellido.TabIndex = 11;
            // 
            // LabNombre
            // 
            LabNombre.AutoSize = true;
            LabNombre.BackColor = Color.FromArgb(205, 144, 19);
            LabNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabNombre.ForeColor = Color.White;
            LabNombre.Location = new Point(260, 133);
            LabNombre.Name = "LabNombre";
            LabNombre.Size = new Size(0, 18);
            LabNombre.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(176, 25, 29);
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 18);
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
            PanelElementosBusqueda.BackColor = Color.FromArgb(205, 144, 19);
            PanelElementosBusqueda.BorderStyle = BorderStyle.Fixed3D;
            PanelElementosBusqueda.Controls.Add(btnBuscar);
            PanelElementosBusqueda.Controls.Add(btnLimpiar);
            PanelElementosBusqueda.Controls.Add(pictureBuscar);
            PanelElementosBusqueda.Controls.Add(txtBuscar);
            PanelElementosBusqueda.Location = new Point(12, 63);
            PanelElementosBusqueda.Name = "PanelElementosBusqueda";
            PanelElementosBusqueda.Size = new Size(198, 181);
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
            ClientSize = new Size(919, 692);
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
        private Label label8;
        private Label LabCarnet;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label112;
        private Label LabUltimoServicio;
        private Label LabActivoDesde;
        private Label label10;
        private Label LabHorasRestantes;
        private Label label3;
    }
}