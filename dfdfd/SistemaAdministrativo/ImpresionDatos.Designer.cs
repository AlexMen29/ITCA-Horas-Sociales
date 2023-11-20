namespace SistemaAdministrativo
{
    partial class ImpresionDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpresionDatos));
            splitContainer1 = new SplitContainer();
            PanelOcultar = new Panel();
            btnBorrar = new Button();
            label1 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            PicturiEspera = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            PanelOcultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicturiEspera).BeginInit();
            SuspendLayout();
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
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(PanelOcultar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(PicturiEspera);
            splitContainer1.Size = new Size(996, 654);
            splitContainer1.SplitterDistance = 151;
            splitContainer1.TabIndex = 10;
            // 
            // PanelOcultar
            // 
            PanelOcultar.Controls.Add(btnBorrar);
            PanelOcultar.Controls.Add(label1);
            PanelOcultar.Controls.Add(txtBuscar);
            PanelOcultar.Controls.Add(btnBuscar);
            PanelOcultar.Location = new Point(8, 124);
            PanelOcultar.Name = "PanelOcultar";
            PanelOcultar.Size = new Size(136, 271);
            PanelOcultar.TabIndex = 10;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(176, 25, 29);
            btnBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = SystemColors.ButtonHighlight;
            btnBorrar.Location = new Point(21, 189);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(105, 34);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 98);
            label1.TabIndex = 1;
            label1.Text = "Ingresa el carnet del estudiante que deseas obtener su hoja social";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(25, 111);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(101, 33);
            txtBuscar.TabIndex = 8;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(176, 25, 29);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(21, 149);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 34);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // PicturiEspera
            // 
            PicturiEspera.Anchor = AnchorStyles.None;
            PicturiEspera.Image = (Image)resources.GetObject("PicturiEspera.Image");
            PicturiEspera.Location = new Point(121, 227);
            PicturiEspera.Name = "PicturiEspera";
            PicturiEspera.Size = new Size(639, 142);
            PicturiEspera.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturiEspera.TabIndex = 0;
            PicturiEspera.TabStop = false;
            // 
            // ImpresionDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 654);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ImpresionDatos";
            Text = "Impresion de Datos";
            Load += ImpresionDatos_Load_1;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            PanelOcultar.ResumeLayout(false);
            PanelOcultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicturiEspera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private PictureBox PicturiEspera;
        private Button btnBorrar;
        private Panel PanelOcultar;
    }
}