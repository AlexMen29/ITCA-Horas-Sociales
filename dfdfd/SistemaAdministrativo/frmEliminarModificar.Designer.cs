namespace ProyectoSocial.SistemaAdministrativo
{
    partial class frmEliminarModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarModificar));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            PanelElementosBusqueda = new Panel();
            label7 = new Label();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            pictureBuscar = new PictureBox();
            txtBuscar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            comboFiltra = new ComboBox();
            gridAlumnos = new DataGridView();
            btnFiltrar = new Button();
            gridExAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            PanelElementosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridExAlumnos).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(PanelElementosBusqueda);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(comboFiltra);
            splitContainer1.Panel2.Controls.Add(gridAlumnos);
            splitContainer1.Panel2.Controls.Add(btnFiltrar);
            splitContainer1.Panel2.Controls.Add(gridExAlumnos);
            splitContainer1.Size = new Size(800, 571);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // PanelElementosBusqueda
            // 
            PanelElementosBusqueda.BackColor = Color.Transparent;
            PanelElementosBusqueda.BackgroundImageLayout = ImageLayout.Stretch;
            PanelElementosBusqueda.Controls.Add(label7);
            PanelElementosBusqueda.Controls.Add(btnBuscar);
            PanelElementosBusqueda.Controls.Add(btnLimpiar);
            PanelElementosBusqueda.Controls.Add(pictureBuscar);
            PanelElementosBusqueda.Controls.Add(txtBuscar);
            PanelElementosBusqueda.Location = new Point(22, 55);
            PanelElementosBusqueda.Name = "PanelElementosBusqueda";
            PanelElementosBusqueda.Size = new Size(237, 230);
            PanelElementosBusqueda.TabIndex = 6;
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
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(176, 25, 29);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(7, 102);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(222, 40);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Eliminar";
            btnLimpiar.UseVisualStyleBackColor = false;
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
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 329);
            label3.Name = "label3";
            label3.Size = new Size(228, 43);
            label3.TabIndex = 33;
            label3.Text = "Eliminar estudiantes que han culminado servicio social";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 9);
            label2.Name = "label2";
            label2.Size = new Size(228, 43);
            label2.TabIndex = 32;
            label2.Text = "Dar de baja a estudiantes segun su rendimiento";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 25);
            label1.TabIndex = 31;
            label1.Text = "Listado de Alumnos que se encuentran en proceso";
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(4, 298);
            label12.Name = "label12";
            label12.Size = new Size(382, 25);
            label12.TabIndex = 30;
            label12.Text = "Listado de Alumnos que han culminado sus horas sociales";
            // 
            // comboFiltra
            // 
            comboFiltra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboFiltra.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltra.FormattingEnabled = true;
            comboFiltra.Items.AddRange(new object[] { "MinHoras", "MaxHoras" });
            comboFiltra.Location = new Point(419, 26);
            comboFiltra.Name = "comboFiltra";
            comboFiltra.Size = new Size(101, 23);
            comboFiltra.TabIndex = 26;
            // 
            // gridAlumnos
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            gridAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAlumnos.BackgroundColor = Color.White;
            gridAlumnos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridAlumnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            gridAlumnos.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridAlumnos.EnableHeadersVisualStyles = false;
            gridAlumnos.GridColor = Color.Firebrick;
            gridAlumnos.Location = new Point(4, 25);
            gridAlumnos.Margin = new Padding(4, 3, 4, 3);
            gridAlumnos.MultiSelect = false;
            gridAlumnos.Name = "gridAlumnos";
            gridAlumnos.ReadOnly = true;
            gridAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridAlumnos.Size = new Size(408, 250);
            gridAlumnos.TabIndex = 3;
            gridAlumnos.CellClick += gridAlumnos_CellClick;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.BackColor = Color.FromArgb(176, 25, 29);
            btnFiltrar.ForeColor = SystemColors.ButtonHighlight;
            btnFiltrar.Location = new Point(421, 62);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(99, 40);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // gridExAlumnos
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            gridExAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            gridExAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridExAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridExAlumnos.BackgroundColor = Color.White;
            gridExAlumnos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridExAlumnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridExAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridExAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridExAlumnos.DefaultCellStyle = dataGridViewCellStyle6;
            gridExAlumnos.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridExAlumnos.EnableHeadersVisualStyles = false;
            gridExAlumnos.GridColor = Color.Firebrick;
            gridExAlumnos.Location = new Point(4, 329);
            gridExAlumnos.Margin = new Padding(4, 3, 4, 3);
            gridExAlumnos.MultiSelect = false;
            gridExAlumnos.Name = "gridExAlumnos";
            gridExAlumnos.ReadOnly = true;
            gridExAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridExAlumnos.Size = new Size(493, 186);
            gridExAlumnos.TabIndex = 2;
            // 
            // frmEliminarModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 571);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEliminarModificar";
            Text = "frmEliminarModificar";
            Load += frmEliminarModificar_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            PanelElementosBusqueda.ResumeLayout(false);
            PanelElementosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridExAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView gridAlumnos;
        private DataGridView gridExAlumnos;
        private Label label12;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel PanelElementosBusqueda;
        private Label label7;
        private Button btnBuscar;
        private Button btnLimpiar;
        private PictureBox pictureBuscar;
        private TextBox txtBuscar;
        private ComboBox comboFiltra;
        private Button btnFiltrar;
    }
}