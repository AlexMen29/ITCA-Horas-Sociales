namespace ProyectoSocial.Reportes
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            panel1 = new Panel();
            textBox6 = new TextBox();
            label6 = new Label();
            txtGrupoReport = new TextBox();
            txtCorreoReport = new TextBox();
            txtApellidosReport = new TextBox();
            txtNombresReport = new TextBox();
            txtCarnetReport = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGenerarReporte = new Button();
            gridReport = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtGrupoReport);
            panel1.Controls.Add(txtCorreoReport);
            panel1.Controls.Add(txtApellidosReport);
            panel1.Controls.Add(txtNombresReport);
            panel1.Controls.Add(txtCarnetReport);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGenerarReporte);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(91, 298);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 301);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Observación";
            // 
            // txtGrupoReport
            // 
            txtGrupoReport.Location = new Point(94, 240);
            txtGrupoReport.Name = "txtGrupoReport";
            txtGrupoReport.ReadOnly = true;
            txtGrupoReport.Size = new Size(100, 23);
            txtGrupoReport.TabIndex = 10;
            // 
            // txtCorreoReport
            // 
            txtCorreoReport.Location = new Point(94, 204);
            txtCorreoReport.Name = "txtCorreoReport";
            txtCorreoReport.ReadOnly = true;
            txtCorreoReport.Size = new Size(100, 23);
            txtCorreoReport.TabIndex = 9;
            // 
            // txtApellidosReport
            // 
            txtApellidosReport.Location = new Point(94, 157);
            txtApellidosReport.Name = "txtApellidosReport";
            txtApellidosReport.ReadOnly = true;
            txtApellidosReport.Size = new Size(100, 23);
            txtApellidosReport.TabIndex = 8;
            // 
            // txtNombresReport
            // 
            txtNombresReport.Location = new Point(94, 115);
            txtNombresReport.Name = "txtNombresReport";
            txtNombresReport.ReadOnly = true;
            txtNombresReport.Size = new Size(100, 23);
            txtNombresReport.TabIndex = 7;
            // 
            // txtCarnetReport
            // 
            txtCarnetReport.Location = new Point(94, 77);
            txtCarnetReport.Name = "txtCarnetReport";
            txtCarnetReport.ReadOnly = true;
            txtCarnetReport.Size = new Size(100, 23);
            txtCarnetReport.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 240);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 5;
            label5.Text = "Grupo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 204);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 157);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 118);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 77);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Carnet";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.FromArgb(176, 25, 29);
            btnGenerarReporte.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarReporte.Location = new Point(22, 351);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(139, 48);
            btnGenerarReporte.TabIndex = 0;
            btnGenerarReporte.Text = "Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.MouseEnter += btnGenerarReporte_MouseEnter;
            btnGenerarReporte.MouseLeave += btnGenerarReporte_MouseLeave;
            // 
            // gridReport
            // 
            gridReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReport.Dock = DockStyle.Fill;
            gridReport.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridReport.Location = new Point(200, 0);
            gridReport.MultiSelect = false;
            gridReport.Name = "gridReport";
            gridReport.ReadOnly = true;
            gridReport.RowTemplate.Height = 25;
            gridReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridReport.Size = new Size(600, 450);
            gridReport.TabIndex = 1;
            gridReport.CellClick += gridReport_CellClick;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridReport);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReportes";
            Text = "FrmReportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox6;
        private Label label6;
        private TextBox txtGrupoReport;
        private TextBox txtCorreoReport;
        private TextBox txtApellidosReport;
        private TextBox txtNombresReport;
        private TextBox txtCarnetReport;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGenerarReporte;
        private DataGridView gridReport;
    }
}