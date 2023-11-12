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
            panel3 = new Panel();
            txtGrupoReport = new TextBox();
            txtCorreoReport = new TextBox();
            txtApellidoReport = new TextBox();
            txtNombreReport = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtObserReport = new TextBox();
            txtCarnetReport = new TextBox();
            btnGenerarReporte = new Button();
            label2 = new Label();
            label1 = new Label();
            gridReport = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridReport).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(txtGrupoReport);
            panel3.Controls.Add(txtCorreoReport);
            panel3.Controls.Add(txtApellidoReport);
            panel3.Controls.Add(txtNombreReport);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtObserReport);
            panel3.Controls.Add(txtCarnetReport);
            panel3.Controls.Add(btnGenerarReporte);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 482);
            panel3.TabIndex = 2;
            // 
            // txtGrupoReport
            // 
            txtGrupoReport.Location = new Point(128, 223);
            txtGrupoReport.Name = "txtGrupoReport";
            txtGrupoReport.ReadOnly = true;
            txtGrupoReport.Size = new Size(178, 23);
            txtGrupoReport.TabIndex = 12;
            // 
            // txtCorreoReport
            // 
            txtCorreoReport.Location = new Point(128, 180);
            txtCorreoReport.Name = "txtCorreoReport";
            txtCorreoReport.ReadOnly = true;
            txtCorreoReport.Size = new Size(178, 23);
            txtCorreoReport.TabIndex = 11;
            // 
            // txtApellidoReport
            // 
            txtApellidoReport.Location = new Point(128, 129);
            txtApellidoReport.Name = "txtApellidoReport";
            txtApellidoReport.ReadOnly = true;
            txtApellidoReport.Size = new Size(178, 23);
            txtApellidoReport.TabIndex = 10;
            // 
            // txtNombreReport
            // 
            txtNombreReport.Location = new Point(128, 76);
            txtNombreReport.Name = "txtNombreReport";
            txtNombreReport.ReadOnly = true;
            txtNombreReport.Size = new Size(178, 23);
            txtNombreReport.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(28, 221);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 8;
            label6.Text = "Grupo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 178);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 7;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 131);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 6;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 78);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // txtObserReport
            // 
            txtObserReport.Location = new Point(128, 275);
            txtObserReport.Multiline = true;
            txtObserReport.Name = "txtObserReport";
            txtObserReport.Size = new Size(178, 31);
            txtObserReport.TabIndex = 4;
            // 
            // txtCarnetReport
            // 
            txtCarnetReport.Location = new Point(128, 35);
            txtCarnetReport.Name = "txtCarnetReport";
            txtCarnetReport.ReadOnly = true;
            txtCarnetReport.Size = new Size(178, 23);
            txtCarnetReport.TabIndex = 3;
            txtCarnetReport.TextChanged += txtCarnetReport_TextChanged;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.FromArgb(176, 25, 29);
            btnGenerarReporte.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarReporte.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarReporte.Location = new Point(68, 396);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(149, 41);
            btnGenerarReporte.TabIndex = 2;
            btnGenerarReporte.Text = " Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.MouseEnter += btnGenerarReporte_MouseEnter;
            btnGenerarReporte.MouseLeave += btnGenerarReporte_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 275);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 1;
            label2.Text = "Observación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Carnet";
            // 
            // gridReport
            // 
            gridReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReport.Dock = DockStyle.Fill;
            gridReport.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridReport.Location = new Point(312, 0);
            gridReport.MultiSelect = false;
            gridReport.Name = "gridReport";
            gridReport.ReadOnly = true;
            gridReport.RowTemplate.Height = 25;
            gridReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridReport.Size = new Size(519, 482);
            gridReport.TabIndex = 3;
            gridReport.CellClick += gridReport_CellClick;
            gridReport.RowEnter += gridReport_RowEnter;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 482);
            Controls.Add(gridReport);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReportes";
            Text = "Reportes";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private TextBox txtObserReport;
        private TextBox txtCarnetReport;
        private Button btnGenerarReporte;
        private Label label2;
        private Label label1;
        private DataGridView gridReport;
        private TextBox txtGrupoReport;
        private TextBox txtCorreoReport;
        private TextBox txtApellidoReport;
        private TextBox txtNombreReport;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}