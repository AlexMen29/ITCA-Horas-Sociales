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
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            gridEventos = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)gridEventos).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(monthCalendar1);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(gridEventos);
            // 
            // splitContainer1.Panel2
            // 
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
            splitContainer1.SplitterDistance = 409;
            splitContainer1.TabIndex = 24;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(205, 144, 19);
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(86, 12);
            label6.Name = "label6";
            label6.Size = new Size(249, 32);
            label6.TabIndex = 20;
            label6.Text = "Resumen de Eventos";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(176, 25, 29);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(94, 61);
            label5.Name = "label5";
            label5.Size = new Size(241, 25);
            label5.TabIndex = 19;
            label5.Text = "Calendario de Actividades";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.None;
            monthCalendar1.BackColor = SystemColors.HotTrack;
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Location = new Point(12, 107);
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
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(176, 25, 29);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(94, 446);
            label4.Name = "label4";
            label4.Size = new Size(207, 25);
            label4.TabIndex = 18;
            label4.Text = "Eventos programados";
            // 
            // gridEventos
            // 
            gridEventos.AllowUserToAddRows = false;
            gridEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            gridEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridEventos.Anchor = AnchorStyles.None;
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
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(204, 147, 20);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridEventos.DefaultCellStyle = dataGridViewCellStyle3;
            gridEventos.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridEventos.EnableHeadersVisualStyles = false;
            gridEventos.GridColor = Color.Firebrick;
            gridEventos.Location = new Point(10, 487);
            gridEventos.Margin = new Padding(4, 3, 4, 3);
            gridEventos.MultiSelect = false;
            gridEventos.Name = "gridEventos";
            gridEventos.ReadOnly = true;
            gridEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEventos.Size = new Size(388, 136);
            gridEventos.TabIndex = 17;
            gridEventos.CellClick += gridEventos_CellClick_1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(205, 144, 19);
            label10.Location = new Point(30, 318);
            label10.Name = "label10";
            label10.Size = new Size(287, 32);
            label10.TabIndex = 29;
            label10.Text = ".......................................";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(176, 25, 29);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(196, 580);
            button3.Name = "button3";
            button3.Size = new Size(143, 45);
            button3.TabIndex = 37;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataTimeFechaME
            // 
            dataTimeFechaME.Anchor = AnchorStyles.None;
            dataTimeFechaME.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataTimeFechaME.Location = new Point(32, 542);
            dataTimeFechaME.Name = "dataTimeFechaME";
            dataTimeFechaME.Size = new Size(284, 23);
            dataTimeFechaME.TabIndex = 36;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(176, 25, 29);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(30, 580);
            button2.Name = "button2";
            button2.Size = new Size(143, 45);
            button2.TabIndex = 35;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(176, 25, 29);
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(29, 362);
            label7.Name = "label7";
            label7.Size = new Size(238, 25);
            label7.TabIndex = 33;
            label7.Text = "Modificacion/Eliminación";
            // 
            // txtDescripcionME
            // 
            txtDescripcionME.Anchor = AnchorStyles.None;
            txtDescripcionME.Location = new Point(31, 411);
            txtDescripcionME.Multiline = true;
            txtDescripcionME.Name = "txtDescripcionME";
            txtDescripcionME.Size = new Size(285, 88);
            txtDescripcionME.TabIndex = 34;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(32, 518);
            label8.Name = "label8";
            label8.Size = new Size(162, 21);
            label8.TabIndex = 31;
            label8.Text = "Fecha de Actividad: ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 387);
            label9.Name = "label9";
            label9.Size = new Size(165, 21);
            label9.TabIndex = 32;
            label9.Text = "Descripcion Evento: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(29, 197);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(176, 25, 29);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 236);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 28;
            button1.Text = "Guardar Evento";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(176, 25, 29);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(30, 4);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 26;
            label3.Text = "Anunciar Evento";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(28, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 88);
            textBox1.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 173);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 24;
            label1.Text = "Fecha de Actividad: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 42);
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
    }
}