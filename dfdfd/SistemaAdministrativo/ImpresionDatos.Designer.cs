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
            pnlImprimir = new Panel();
            label1 = new Label();
            btnImprimir = new Button();
            pnlHojaImprimir = new FlowLayoutPanel();
            pnlImprimir.SuspendLayout();
            SuspendLayout();
            // 
            // pnlImprimir
            // 
            pnlImprimir.BackgroundImage = (Image)resources.GetObject("pnlImprimir.BackgroundImage");
            pnlImprimir.Controls.Add(label1);
            pnlImprimir.Controls.Add(btnImprimir);
            pnlImprimir.Dock = DockStyle.Right;
            pnlImprimir.Location = new Point(585, 0);
            pnlImprimir.Margin = new Padding(4, 3, 4, 3);
            pnlImprimir.Name = "pnlImprimir";
            pnlImprimir.Size = new Size(411, 654);
            pnlImprimir.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 208);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(337, 54);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a la última acción como Administrador. \r\nAquí encontrará la forma de imprimir la boleta\r\nde Hora Social de cada estudiante. ";
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnImprimir.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(100, 407);
            btnImprimir.Margin = new Padding(4, 3, 4, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(223, 87);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "        Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pnlHojaImprimir
            // 
            pnlHojaImprimir.Dock = DockStyle.Fill;
            pnlHojaImprimir.Location = new Point(0, 0);
            pnlHojaImprimir.Margin = new Padding(4, 3, 4, 3);
            pnlHojaImprimir.Name = "pnlHojaImprimir";
            pnlHojaImprimir.Size = new Size(585, 654);
            pnlHojaImprimir.TabIndex = 1;
            // 
            // ImpresionDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 654);
            Controls.Add(pnlHojaImprimir);
            Controls.Add(pnlImprimir);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ImpresionDatos";
            Text = "Impresion de Datos";
            pnlImprimir.ResumeLayout(false);
            pnlImprimir.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlImprimir;
        private Button btnImprimir;
        private FlowLayoutPanel pnlHojaImprimir;
        private Label label1;
    }
}