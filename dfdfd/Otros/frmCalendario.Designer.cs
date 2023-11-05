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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            gridEventos = new DataGridView();
            label11 = new Label();
            label6 = new Label();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            button3 = new Button();
            dataTimeFechaME = new DateTimePicker();
            button2 = new Button();
            label7 = new Label();
            txtDescripcionME = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEventos).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(monthCalendar1);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(dataTimeFechaME);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(txtDescripcionME);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(dateTimePicker1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(903, 653);
            splitContainer1.SplitterDistance = 474;
            splitContainer1.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(gridEventos);
            panel1.Location = new Point(3, 484);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 169);
            panel1.TabIndex = 39;
            // 
            // gridEventos
            // 
            gridEventos.AllowUserToAddRows = false;
            gridEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            gridEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            gridEventos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridEventos.BackgroundColor = Color.White;
            gridEventos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridEventos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(176, 25, 29);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridEventos.DefaultCellStyle = dataGridViewCellStyle6;
            gridEventos.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridEventos.EnableHeadersVisualStyles = false;
            gridEventos.GridColor = Color.Firebrick;
            gridEventos.Location = new Point(0, 0);
            gridEventos.Margin = new Padding(4, 3, 4, 3);
            gridEventos.MultiSelect = false;
            gridEventos.Name = "gridEventos";
            gridEventos.ReadOnly = true;
            gridEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEventos.Size = new Size(468, 169);
            gridEventos.TabIndex = 17;
            gridEventos.CellClick += gridEventos_CellClick_1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(79, 454);
            label11.Name = "label11";
            label11.Size = new Size(311, 17);
            label11.TabIndex = 38;
            label11.Text = "Si desea Modificar, por favor seleccione un registro";
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
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Location = new Point(45, 107);
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
            label4.Location = new Point(127, 429);
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
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(297, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 159);
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
            label10.Location = new Point(5, 347);
            label10.Name = "label10";
            label10.Size = new Size(287, 32);
            label10.TabIndex = 29;
            label10.Text = ".......................................";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(176, 25, 29);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(171, 609);
            button3.Name = "button3";
            button3.Size = new Size(143, 45);
            button3.TabIndex = 37;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataTimeFechaME
            // 
            dataTimeFechaME.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataTimeFechaME.Location = new Point(7, 571);
            dataTimeFechaME.Name = "dataTimeFechaME";
            dataTimeFechaME.Size = new Size(284, 23);
            dataTimeFechaME.TabIndex = 36;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(176, 25, 29);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(5, 609);
            button2.Name = "button2";
            button2.Size = new Size(143, 45);
            button2.TabIndex = 35;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(176, 25, 29);
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(4, 391);
            label7.Name = "label7";
            label7.Size = new Size(238, 25);
            label7.TabIndex = 33;
            label7.Text = "Modificacion/Eliminación";
            // 
            // txtDescripcionME
            // 
            txtDescripcionME.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcionME.Location = new Point(6, 440);
            txtDescripcionME.Multiline = true;
            txtDescripcionME.Name = "txtDescripcionME";
            txtDescripcionME.Size = new Size(285, 104);
            txtDescripcionME.TabIndex = 34;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(7, 547);
            label8.Name = "label8";
            label8.Size = new Size(162, 21);
            label8.TabIndex = 31;
            label8.Text = "Fecha de Actividad: ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 416);
            label9.Name = "label9";
            label9.Size = new Size(165, 21);
            label9.TabIndex = 32;
            label9.Text = "Descripcion Evento: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(4, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(176, 25, 29);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(149, 265);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 28;
            button1.Text = "Guardar Evento";
            button1.UseVisualStyleBackColor = false;
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
            label3.Size = new Size(159, 25);
            label3.TabIndex = 26;
            label3.Text = "Anunciar Evento";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 95);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 104);
            textBox1.TabIndex = 27;
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridEventos).EndInit();
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
        private Button button3;
        private DateTimePicker dataTimeFechaME;
        private Button button2;
        private Label label7;
        private TextBox txtDescripcionME;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label11;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label12;
    }
}