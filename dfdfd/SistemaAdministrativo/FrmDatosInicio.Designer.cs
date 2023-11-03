namespace SistemaAdministrativo
{
    partial class FrmDatosInicio
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
            pnlInicio = new Panel();
            lblInicioFrmInicio = new Label();
            pnlDadosAdmi = new Panel();
            btnBuscar = new Button();
            boxHoras = new ComboBox();
            label4 = new Label();
            txtActividad = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            pnlInicio.SuspendLayout();
            pnlDadosAdmi.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(lblInicioFrmInicio);
            pnlInicio.Dock = DockStyle.Top;
            pnlInicio.Location = new Point(0, 0);
            pnlInicio.Margin = new Padding(4, 3, 4, 3);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(919, 37);
            pnlInicio.TabIndex = 2;
            // 
            // lblInicioFrmInicio
            // 
            lblInicioFrmInicio.AutoSize = true;
            lblInicioFrmInicio.Dock = DockStyle.Top;
            lblInicioFrmInicio.FlatStyle = FlatStyle.Flat;
            lblInicioFrmInicio.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInicioFrmInicio.Location = new Point(0, 0);
            lblInicioFrmInicio.Margin = new Padding(4, 0, 4, 0);
            lblInicioFrmInicio.Name = "lblInicioFrmInicio";
            lblInicioFrmInicio.Size = new Size(84, 32);
            lblInicioFrmInicio.TabIndex = 0;
            lblInicioFrmInicio.Text = "-------";
            // 
            // pnlDadosAdmi
            // 
            pnlDadosAdmi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDadosAdmi.Controls.Add(btnBuscar);
            pnlDadosAdmi.Controls.Add(boxHoras);
            pnlDadosAdmi.Controls.Add(label4);
            pnlDadosAdmi.Controls.Add(txtActividad);
            pnlDadosAdmi.Controls.Add(label3);
            pnlDadosAdmi.Controls.Add(dateTimePicker1);
            pnlDadosAdmi.Controls.Add(label2);
            pnlDadosAdmi.Controls.Add(label1);
            pnlDadosAdmi.Location = new Point(0, 43);
            pnlDadosAdmi.Margin = new Padding(4, 3, 4, 3);
            pnlDadosAdmi.Name = "pnlDadosAdmi";
            pnlDadosAdmi.Size = new Size(919, 548);
            pnlDadosAdmi.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.FromArgb(176, 25, 29);
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(375, 393);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(165, 40);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Guardar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            btnBuscar.MouseLeave += btnBuscar_MouseLeave;
            // 
            // boxHoras
            // 
            boxHoras.Anchor = AnchorStyles.None;
            boxHoras.FormattingEnabled = true;
            boxHoras.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            boxHoras.Location = new Point(421, 336);
            boxHoras.Name = "boxHoras";
            boxHoras.Size = new Size(81, 23);
            boxHoras.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(205, 144, 19);
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(272, 285);
            label4.Name = "label4";
            label4.Size = new Size(383, 30);
            label4.TabIndex = 18;
            label4.Text = "Ingrese el numero de horas realizadas";
            // 
            // txtActividad
            // 
            txtActividad.Anchor = AnchorStyles.None;
            txtActividad.Location = new Point(331, 235);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(280, 23);
            txtActividad.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(205, 144, 19);
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(318, 183);
            label3.Name = "label3";
            label3.Size = new Size(304, 30);
            label3.TabIndex = 16;
            label3.Text = "Ingresar la actividad realizada";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(359, 147);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(205, 144, 19);
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(258, 102);
            label2.Name = "label2";
            label2.Size = new Size(416, 30);
            label2.TabIndex = 14;
            label2.Text = "Ingresar la fecha de la actividad realizada";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(176, 25, 29);
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(274, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(381, 45);
            label1.TabIndex = 13;
            label1.Text = "Registrar Horas Sociales";
            // 
            // FrmDatosInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 593);
            Controls.Add(pnlDadosAdmi);
            Controls.Add(pnlInicio);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDatosInicio";
            Text = "FrmDatosInicio";
            pnlInicio.ResumeLayout(false);
            pnlInicio.PerformLayout();
            pnlDadosAdmi.ResumeLayout(false);
            pnlDadosAdmi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInicio;
        private Label lblInicioFrmInicio;
        private Label lblTelefonoAd;
        private Label lblDepartamentoAd;
        private Label lblCorreoAd;
        private Label lblCarnetAd;
        private Label lblApellidoAd;
        private Label lblNombreAd;
        private Panel pnlDadosAdmi;
        private TextBox txtsShowNum;
        private TextBox txtShowDepart;
        private TextBox txtShowGmail;
        private TextBox txtShowCarnet;
        private TextBox txtShowLastName;
        private TextBox txtShowName;
        private ComboBox boxHoras;
        private Label label4;
        private TextBox txtActividad;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Button btnBuscar;
    }
}