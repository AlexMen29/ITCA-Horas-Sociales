namespace ProyectoSocial.Otros
{
    partial class frmCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            splitContainer1 = new SplitContainer();
            gridEventos = new DataGridView();
            label11 = new Label();
            label6 = new Label();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            label12 = new Label();
            panelModificarEliminar = new Panel();
            dateTimeME = new DateTimePicker();
            label9 = new Label();
            txtDescripcionME = new TextBox();
            pictureBox2 = new PictureBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            dateTimeGuardar = new DateTimePicker();
            btnGuardar = new Button();
            label3 = new Label();
            txtMensaje = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEventos).BeginInit();
            panelModificarEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.ForeColor = SystemColors.ActiveCaptionText;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gridEventos);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(monthCalendar1);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(panelModificarEliminar);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(dateTimeGuardar);
            splitContainer1.Panel2.Controls.Add(btnGuardar);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(txtMensaje);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(903, 653);
            splitContainer1.SplitterDistance = 474;
            splitContainer1.TabIndex = 24;
            // 
            // gridEventos
            // 
            gridEventos.AllowUserToAddRows = false;
            gridEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            gridEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridEventos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridEventos.BackgroundColor = Color.White;
            gridEventos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridEventos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridEventos.DefaultCellStyle = dataGridViewCellStyle3;
            gridEventos.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridEventos.EnableHeadersVisualStyles = false;
            gridEventos.GridColor = Color.Firebrick;
            gridEventos.Location = new Point(3, 364);
            gridEventos.Margin = new Padding(4, 3, 4, 3);
            gridEventos.MultiSelect = false;
            gridEventos.Name = "gridEventos";
            gridEventos.ReadOnly = true;
            gridEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEventos.Size = new Size(468, 229);
            gridEventos.TabIndex = 17;
            gridEventos.CellClick += gridEventos_CellClick_1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(72, 336);
            label11.Name = "label11";
            label11.Size = new Size(391, 17);
            label11.TabIndex = 38;
            label11.Text = "Si desea Modificar o Eliminar, por favor seleccione un registro";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(205, 144, 19);
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(119, 12);
            label6.Name = "label6";
            label6.Size = new Size(249, 32);
            label6.TabIndex = 20;
            label6.Text = "Resumen de Eventos";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(176, 25, 29);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(127, 61);
            label5.Name = "label5";
            label5.Size = new Size(241, 25);
            label5.TabIndex = 19;
            label5.Text = "Calendario de Actividades";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top;
            monthCalendar1.BackColor = SystemColors.HotTrack;
            monthCalendar1.Location = new Point(120, 96);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 16;
            monthCalendar1.TitleBackColor = Color.Gold;
            monthCalendar1.TitleForeColor = Color.DarkRed;
            monthCalendar1.TrailingForeColor = SystemColors.HotTrack;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(176, 25, 29);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(144, 288);
            label4.Name = "label4";
            label4.Size = new Size(207, 25);
            label4.TabIndex = 18;
            label4.Text = "Eventos programados";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(176, 25, 29);
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 40;
            // 
            // panelModificarEliminar
            // 
            panelModificarEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelModificarEliminar.Controls.Add(dateTimeME);
            panelModificarEliminar.Controls.Add(label9);
            panelModificarEliminar.Controls.Add(txtDescripcionME);
            panelModificarEliminar.Controls.Add(pictureBox2);
            panelModificarEliminar.Controls.Add(btnModificar);
            panelModificarEliminar.Controls.Add(btnEliminar);
            panelModificarEliminar.Controls.Add(label7);
            panelModificarEliminar.Location = new Point(16, 368);
            panelModificarEliminar.Name = "panelModificarEliminar";
            panelModificarEliminar.Size = new Size(400, 280);
            panelModificarEliminar.TabIndex = 39;
            panelModificarEliminar.Visible = false;
            // 
            // dateTimeME
            // 
            dateTimeME.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeME.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeME.Location = new Point(8, 164);
            dateTimeME.Name = "dateTimeME";
            dateTimeME.Size = new Size(264, 23);
            dateTimeME.TabIndex = 41;
            dateTimeME.Value = new DateTime(2023, 11, 14, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 30);
            label9.Name = "label9";
            label9.Size = new Size(165, 21);
            label9.TabIndex = 32;
            label9.Text = "Descripcion Evento: ";
            // 
            // txtDescripcionME
            // 
            txtDescripcionME.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcionME.Location = new Point(8, 54);
            txtDescripcionME.Multiline = true;
            txtDescripcionME.Name = "txtDescripcionME";
            txtDescripcionME.Size = new Size(264, 104);
            txtDescripcionME.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(287, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(176, 25, 29);
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(8, 200);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 45);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(176, 25, 29);
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(168, 200);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 45);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(176, 25, 29);
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(8, 5);
            label7.Name = "label7";
            label7.Size = new Size(238, 25);
            label7.TabIndex = 33;
            label7.Text = "Modificacion/Eliminación";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(205, 144, 19);
            label10.Location = new Point(8, 336);
            label10.Name = "label10";
            label10.Size = new Size(413, 32);
            label10.TabIndex = 29;
            label10.Text = ".........................................................";
            // 
            // dateTimeGuardar
            // 
            dateTimeGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeGuardar.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeGuardar.Location = new Point(4, 226);
            dateTimeGuardar.Name = "dateTimeGuardar";
            dateTimeGuardar.Size = new Size(284, 23);
            dateTimeGuardar.TabIndex = 30;
            dateTimeGuardar.Value = new DateTime(2023, 11, 14, 0, 0, 0, 0);
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(176, 25, 29);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(149, 265);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 45);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar Evento";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(176, 25, 29);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(5, 33);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 26;
            label3.Text = "Nuevo Evento";
            // 
            // txtMensaje
            // 
            txtMensaje.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMensaje.Location = new Point(3, 95);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(285, 105);
            txtMensaje.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 202);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 24;
            label1.Text = "Fecha de Actividad: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(165, 21);
            label2.TabIndex = 25;
            label2.Text = "Descripcion Evento: ";
            // 
            // frmCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 653);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCalendario";
            Text = "frmCalendario";
            Load += frmCalendario_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridEventos).EndInit();
            panelModificarEliminar.ResumeLayout(false);
            panelModificarEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private SplitContainer splitContainer1;
        private Label label6;
        private Label label5;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private DataGridView gridEventos;
        private Label label10;
        private Button btnEliminar;
        private Button btnModificar;
        private Label label7;
        private TextBox txtDescripcionME;
        private Label label9;
        private DateTimePicker dateTimeGuardar;
        private Button btnGuardar;
        private Label label3;
        private TextBox txtMensaje;
        private Label label1;
        private Label label2;
        private Label label11;
        private Panel panelModificarEliminar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label12;
        private DateTimePicker dateTimeME;
    }
}