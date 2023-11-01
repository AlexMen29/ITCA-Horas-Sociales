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
            label9 = new Label();
            gridEstudiantes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(176, 25, 29);
            label9.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(325, 78);
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
            gridEstudiantes.Location = new Point(226, 126);
            gridEstudiantes.Margin = new Padding(4, 3, 4, 3);
            gridEstudiantes.MultiSelect = false;
            gridEstudiantes.Name = "gridEstudiantes";
            gridEstudiantes.ReadOnly = true;
            gridEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEstudiantes.Size = new Size(451, 319);
            gridEstudiantes.TabIndex = 3;
            // 
            // frmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 522);
            Controls.Add(label9);
            Controls.Add(gridEstudiantes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEstudiantes";
            Text = "frmEstudiantes";
            Load += frmEstudiantes_Load;
            ((System.ComponentModel.ISupportInitialize)gridEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView gridEstudiantes;
    }
}