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
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
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
            PanelElementosBusqueda = new Panel();
            label11 = new Label();
            label7 = new Label();
            comboFiltra = new ComboBox();
            btnFiltrar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            pictureBuscar = new PictureBox();
            txtBuscar = new TextBox();
            label13 = new Label();
            btnEstado = new Button();
            label12 = new Label();
            label3 = new Label();
            LabHorasRestantes = new Label();
            LabTotalHoras = new Label();
            label1 = new Label();
            label9 = new Label();
            gridDatosAlumnos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelDetallesAlumnos.SuspendLayout();
            PanelElementosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDatosAlumnos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 692);
            panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(panelDetallesAlumnos);
            splitContainer1.Panel1.Controls.Add(PanelElementosBusqueda);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(btnEstado);
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(LabHorasRestantes);
            splitContainer1.Panel2.Controls.Add(LabTotalHoras);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(gridDatosAlumnos);
            splitContainer1.Size = new Size(919, 692);
            splitContainer1.SplitterDistance = 259;
            splitContainer1.TabIndex = 24;
            // 
            // panelDetallesAlumnos
            // 
            panelDetallesAlumnos.AutoScroll = true;
            panelDetallesAlumnos.BackColor = Color.Transparent;
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
            panelDetallesAlumnos.Location = new Point(5, 318);
            panelDetallesAlumnos.Name = "panelDetallesAlumnos";
            panelDetallesAlumnos.Size = new Size(227, 379);
            panelDetallesAlumnos.TabIndex = 9;
            panelDetallesAlumnos.Paint += panelDetallesAlumnos_Paint;
            // 
            // LabUltimoServicio
            // 
            LabUltimoServicio.AutoSize = true;
            LabUltimoServicio.BackColor = Color.Transparent;
            LabUltimoServicio.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabUltimoServicio.ForeColor = Color.Black;
            LabUltimoServicio.Location = new Point(20, 360);
            LabUltimoServicio.Name = "LabUltimoServicio";
            LabUltimoServicio.Size = new Size(0, 18);
            LabUltimoServicio.TabIndex = 21;
            // 
            // LabActivoDesde
            // 
            LabActivoDesde.AutoSize = true;
            LabActivoDesde.BackColor = Color.Transparent;
            LabActivoDesde.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabActivoDesde.ForeColor = Color.Black;
            LabActivoDesde.Location = new Point(20, 301);
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
            label10.Location = new Point(16, 333);
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
            label8.Location = new Point(16, 283);
            label8.Name = "label8";
            label8.Size = new Size(96, 18);
            label8.TabIndex = 18;
            label8.Text = "Activo desde:";
            // 
            // LabCarnet
            // 
            LabCarnet.AutoSize = true;
            LabCarnet.BackColor = Color.Transparent;
            LabCarnet.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabCarnet.ForeColor = Color.Black;
            LabCarnet.Location = new Point(20, 69);
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
            label6.Location = new Point(16, 218);
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
            label5.Location = new Point(16, 161);
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
            label4.Location = new Point(16, 100);
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
            LabCorreo.BackColor = Color.Transparent;
            LabCorreo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabCorreo.ForeColor = Color.Black;
            LabCorreo.Location = new Point(22, 248);
            LabCorreo.Name = "LabCorreo";
            LabCorreo.Size = new Size(0, 18);
            LabCorreo.TabIndex = 12;
            // 
            // LabApellido
            // 
            LabApellido.AutoSize = true;
            LabApellido.BackColor = Color.Transparent;
            LabApellido.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabApellido.ForeColor = Color.Black;
            LabApellido.Location = new Point(22, 186);
            LabApellido.Name = "LabApellido";
            LabApellido.Size = new Size(0, 18);
            LabApellido.TabIndex = 11;
            // 
            // LabNombre
            // 
            LabNombre.AutoSize = true;
            LabNombre.BackColor = Color.Transparent;
            LabNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabNombre.ForeColor = Color.Black;
            LabNombre.Location = new Point(20, 126);
            LabNombre.Name = "LabNombre";
            LabNombre.Size = new Size(0, 18);
            LabNombre.TabIndex = 10;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 44);
            label2.TabIndex = 9;
            label2.Text = "Detalles de estudiante selecciónado";
            // 
            // PanelElementosBusqueda
            // 
            PanelElementosBusqueda.BackColor = Color.Transparent;
            PanelElementosBusqueda.BackgroundImageLayout = ImageLayout.Stretch;
            PanelElementosBusqueda.Controls.Add(label11);
            PanelElementosBusqueda.Controls.Add(label7);
            PanelElementosBusqueda.Controls.Add(comboFiltra);
            PanelElementosBusqueda.Controls.Add(btnFiltrar);
            PanelElementosBusqueda.Controls.Add(btnBuscar);
            PanelElementosBusqueda.Controls.Add(btnLimpiar);
            PanelElementosBusqueda.Controls.Add(pictureBuscar);
            PanelElementosBusqueda.Controls.Add(txtBuscar);
            PanelElementosBusqueda.Location = new Point(3, 89);
            PanelElementosBusqueda.Name = "PanelElementosBusqueda";
            PanelElementosBusqueda.Size = new Size(237, 230);
            PanelElementosBusqueda.TabIndex = 5;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(4, 89);
            label11.Name = "label11";
            label11.Size = new Size(225, 42);
            label11.TabIndex = 28;
            label11.Text = "¿Filtro? puede filtrar segun la fecha en que se ingreso la actividad";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 7);
            label7.Name = "label7";
            label7.Size = new Size(226, 42);
            label7.TabIndex = 27;
            label7.Text = "A continuación ingrese o seleccióne el carnet a buscar:";
            // 
            // comboFiltra
            // 
            comboFiltra.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltra.FormattingEnabled = true;
            comboFiltra.Items.AddRange(new object[] { "Descendente", "Ascendente", "Ninguno" });
            comboFiltra.Location = new Point(43, 144);
            comboFiltra.Name = "comboFiltra";
            comboFiltra.Size = new Size(101, 23);
            comboFiltra.TabIndex = 26;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(176, 25, 29);
            btnFiltrar.ForeColor = SystemColors.ButtonHighlight;
            btnFiltrar.Location = new Point(149, 134);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(81, 40);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            btnFiltrar.MouseEnter += btnFiltrar_MouseEnter;
            btnFiltrar.MouseLeave += btnFiltrar_MouseLeave;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(176, 25, 29);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(152, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(77, 34);
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
            btnLimpiar.Location = new Point(7, 180);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(222, 40);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Borrar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseEnter += btnLimpiar_MouseEnter;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            // 
            // pictureBuscar
            // 
            pictureBuscar.Image = (Image)resources.GetObject("pictureBuscar.Image");
            pictureBuscar.Location = new Point(7, 52);
            pictureBuscar.Name = "pictureBuscar";
            pictureBuscar.Size = new Size(33, 32);
            pictureBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBuscar.TabIndex = 4;
            pictureBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(46, 52);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(101, 32);
            txtBuscar.TabIndex = 3;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(69, 536);
            label13.Name = "label13";
            label13.Size = new Size(57, 23);
            label13.TabIndex = 31;
            label13.Text = "Estado:";
            // 
            // btnEstado
            // 
            btnEstado.BackColor = Color.Yellow;
            btnEstado.Location = new Point(127, 531);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(100, 26);
            btnEstado.TabIndex = 30;
            btnEstado.Text = "¿?";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += button1_Click;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(70, 61);
            label12.Name = "label12";
            label12.Size = new Size(302, 25);
            label12.TabIndex = 29;
            label12.Text = "Seleccióne un registro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(176, 25, 29);
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(489, 504);
            label3.Name = "label3";
            label3.Size = new Size(134, 18);
            label3.TabIndex = 25;
            label3.Text = "Horas restantes:";
            // 
            // LabHorasRestantes
            // 
            LabHorasRestantes.AutoSize = true;
            LabHorasRestantes.BackColor = Color.FromArgb(205, 144, 19);
            LabHorasRestantes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabHorasRestantes.ForeColor = SystemColors.Control;
            LabHorasRestantes.Location = new Point(629, 501);
            LabHorasRestantes.Name = "LabHorasRestantes";
            LabHorasRestantes.Size = new Size(0, 18);
            LabHorasRestantes.TabIndex = 23;
            // 
            // LabTotalHoras
            // 
            LabTotalHoras.AutoSize = true;
            LabTotalHoras.BackColor = Color.FromArgb(205, 144, 19);
            LabTotalHoras.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabTotalHoras.ForeColor = SystemColors.Control;
            LabTotalHoras.Location = new Point(426, 492);
            LabTotalHoras.Name = "LabTotalHoras";
            LabTotalHoras.Size = new Size(19, 30);
            LabTotalHoras.TabIndex = 24;
            LabTotalHoras.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(176, 25, 29);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(69, 492);
            label1.Name = "label1";
            label1.Size = new Size(351, 30);
            label1.TabIndex = 23;
            label1.Text = "Total de Horas Sociales Realizadas:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(176, 25, 29);
            label9.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(110, 9);
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
            gridDatosAlumnos.Location = new Point(70, 89);
            gridDatosAlumnos.Margin = new Padding(4, 3, 4, 3);
            gridDatosAlumnos.MultiSelect = false;
            gridDatosAlumnos.Name = "gridDatosAlumnos";
            gridDatosAlumnos.ReadOnly = true;
            gridDatosAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDatosAlumnos.Size = new Size(520, 386);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDetallesAd";
            Text = "FrmDetallesAd";
            Load += FrmDetallesAd_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelDetallesAlumnos.ResumeLayout(false);
            panelDetallesAlumnos.PerformLayout();
            PanelElementosBusqueda.ResumeLayout(false);
            PanelElementosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDatosAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panelDetallesAlumnos;
        private Label LabUltimoServicio;
        private Label LabActivoDesde;
        private Label label10;
        private Label label8;
        private Label LabCarnet;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label112;
        private Label LabCorreo;
        private Label LabApellido;
        private Label LabNombre;
        private Label label2;
        private Panel PanelElementosBusqueda;
        private Button btnBuscar;
        private Button btnLimpiar;
        private PictureBox pictureBuscar;
        private TextBox txtBuscar;
        private Label label3;
        private Label LabTotalHoras;
        private Label label1;
        private Label label9;
        private DataGridView gridDatosAlumnos;
        private Label LabHorasRestantes;
        private ComboBox comboFiltra;
        private Button btnFiltrar;
        private Label label7;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnEstado;
    }
}