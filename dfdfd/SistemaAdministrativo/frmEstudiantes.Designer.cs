namespace ProyectoSocial.SistemaAdministrativo
{
    partial class frmEstudiantes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            label9 = new Label();
            gridEstudiantes = new DataGridView();
            LabEstudiantes = new Label();
            label1 = new Label();
            PanelElementosBusqueda = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            txtEliminar = new TextBox();
            btnLimpiar = new Button();
            pictureBuscar = new PictureBox();
            label2 = new Label();
            label7 = new Label();
            btnBuscar = new Button();
            btnBorrar = new Button();
            txtBuscar = new TextBox();
            comboFiltra = new ComboBox();
            btnFiltrar = new Button();
            label3 = new Label();
            logoITCA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gridEstudiantes).BeginInit();
            PanelElementosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoITCA).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(176, 25, 29);
            label9.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(326, 6);
            label9.Name = "label9";
            label9.Size = new Size(267, 45);
            label9.TabIndex = 4;
            label9.Text = "Mis Estudiantes";
            // 
            // gridEstudiantes
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            gridEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridEstudiantes.BackgroundColor = Color.White;
            gridEstudiantes.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridEstudiantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridEstudiantes.DefaultCellStyle = dataGridViewCellStyle3;
            gridEstudiantes.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridEstudiantes.EnableHeadersVisualStyles = false;
            gridEstudiantes.GridColor = Color.Firebrick;
            gridEstudiantes.Location = new Point(227, 54);
            gridEstudiantes.Margin = new Padding(4, 3, 4, 3);
            gridEstudiantes.MultiSelect = false;
            gridEstudiantes.Name = "gridEstudiantes";
            gridEstudiantes.ReadOnly = true;
            gridEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEstudiantes.Size = new Size(451, 390);
            gridEstudiantes.TabIndex = 3;
            gridEstudiantes.CellClick += gridEstudiantes_CellClick;
            gridEstudiantes.CellFormatting += gridEstudiantes_CellFormatting;
            // 
            // LabEstudiantes
            // 
            LabEstudiantes.AutoSize = true;
            LabEstudiantes.BackColor = Color.FromArgb(205, 144, 19);
            LabEstudiantes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabEstudiantes.ForeColor = SystemColors.Control;
            LabEstudiantes.Location = new Point(454, 447);
            LabEstudiantes.Name = "LabEstudiantes";
            LabEstudiantes.Size = new Size(19, 30);
            LabEstudiantes.TabIndex = 9;
            LabEstudiantes.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(176, 25, 29);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(227, 447);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 8;
            label1.Text = "Total de Estudiantes: ";
            // 
            // PanelElementosBusqueda
            // 
            PanelElementosBusqueda.BackColor = Color.Transparent;
            PanelElementosBusqueda.BackgroundImageLayout = ImageLayout.Stretch;
            PanelElementosBusqueda.Controls.Add(label4);
            PanelElementosBusqueda.Controls.Add(pictureBox1);
            PanelElementosBusqueda.Controls.Add(txtEliminar);
            PanelElementosBusqueda.Controls.Add(btnLimpiar);
            PanelElementosBusqueda.Controls.Add(pictureBuscar);
            PanelElementosBusqueda.Controls.Add(label2);
            PanelElementosBusqueda.Controls.Add(label7);
            PanelElementosBusqueda.Controls.Add(btnBuscar);
            PanelElementosBusqueda.Controls.Add(btnBorrar);
            PanelElementosBusqueda.Controls.Add(txtBuscar);
            PanelElementosBusqueda.Location = new Point(12, 54);
            PanelElementosBusqueda.Name = "PanelElementosBusqueda";
            PanelElementosBusqueda.Size = new Size(208, 390);
            PanelElementosBusqueda.TabIndex = 11;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 273);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 33;
            label4.Text = "Eliminacion de Estudiantes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // txtEliminar
            // 
            txtEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEliminar.Location = new Point(66, 306);
            txtEliminar.Multiline = true;
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(105, 27);
            txtEliminar.TabIndex = 31;
            txtEliminar.KeyPress += txtEliminar_KeyPress;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(176, 25, 29);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(81, 161);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 34);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pictureBuscar
            // 
            pictureBuscar.Image = (Image)resources.GetObject("pictureBuscar.Image");
            pictureBuscar.Location = new Point(27, 128);
            pictureBuscar.Name = "pictureBuscar";
            pictureBuscar.Size = new Size(33, 32);
            pictureBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBuscar.TabIndex = 29;
            pictureBuscar.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 77);
            label2.Name = "label2";
            label2.Size = new Size(189, 39);
            label2.TabIndex = 28;
            label2.Text = "A continuación ingrese el carnet de su estudiante:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 7);
            label7.Name = "label7";
            label7.Size = new Size(189, 61);
            label7.TabIndex = 27;
            label7.Text = "¿Desea imprimir hoja de finalización para su estudiante?";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(176, 25, 29);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(27, 193);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(144, 34);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(176, 25, 29);
            btnBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = SystemColors.ButtonHighlight;
            btnBorrar.Location = new Point(27, 339);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(144, 32);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "Eliminar Estudiante";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(66, 128);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(105, 27);
            txtBuscar.TabIndex = 3;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // comboFiltra
            // 
            comboFiltra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboFiltra.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltra.FormattingEnabled = true;
            comboFiltra.Items.AddRange(new object[] { "MinHoras", "MaxHoras" });
            comboFiltra.Location = new Point(728, 112);
            comboFiltra.Name = "comboFiltra";
            comboFiltra.Size = new Size(101, 23);
            comboFiltra.TabIndex = 28;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.BackColor = Color.FromArgb(176, 25, 29);
            btnFiltrar.ForeColor = SystemColors.ButtonHighlight;
            btnFiltrar.Location = new Point(728, 136);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(99, 40);
            btnFiltrar.TabIndex = 27;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(688, 64);
            label3.Name = "label3";
            label3.Size = new Size(189, 39);
            label3.TabIndex = 30;
            label3.Text = "Filtrar estudiantes de mayor numero de horas a menor y viseversa:";
            // 
            // logoITCA
            // 
            logoITCA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            logoITCA.Image = (Image)resources.GetObject("logoITCA.Image");
            logoITCA.Location = new Point(754, 460);
            logoITCA.Name = "logoITCA";
            logoITCA.Size = new Size(137, 50);
            logoITCA.SizeMode = PictureBoxSizeMode.StretchImage;
            logoITCA.TabIndex = 29;
            logoITCA.TabStop = false;
            logoITCA.Click += logoITCA_Click;
            // 
            // frmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 522);
            Controls.Add(label3);
            Controls.Add(logoITCA);
            Controls.Add(comboFiltra);
            Controls.Add(btnFiltrar);
            Controls.Add(PanelElementosBusqueda);
            Controls.Add(LabEstudiantes);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(gridEstudiantes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEstudiantes";
            Text = "frmEstudiantes";
            Load += frmEstudiantes_Load;
            ((System.ComponentModel.ISupportInitialize)gridEstudiantes).EndInit();
            PanelElementosBusqueda.ResumeLayout(false);
            PanelElementosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoITCA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView gridEstudiantes;
        private Label LabEstudiantes;
        private Label label1;
        private Panel PanelElementosBusqueda;
        private Label label7;
        private Button btnBuscar;
        private Button btnBorrar;
        private TextBox txtBuscar;
        private Label label2;
        private PictureBox pictureBuscar;
        private ComboBox comboFiltra;
        private Button btnFiltrar;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox txtEliminar;
        private Button btnLimpiar;
        private PictureBox logoITCA;
    }
}