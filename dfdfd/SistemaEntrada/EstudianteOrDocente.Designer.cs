namespace Login
{
    partial class EstudianteOrDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudianteOrDocente));
            pictureBox1 = new PictureBox();
            PanelUniversitario = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            PanelDocente = new Panel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelUniversitario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelDocente.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PanelUniversitario
            // 
            PanelUniversitario.Anchor = AnchorStyles.None;
            PanelUniversitario.Controls.Add(label1);
            PanelUniversitario.Controls.Add(pictureBox1);
            PanelUniversitario.Location = new Point(215, 142);
            PanelUniversitario.Margin = new Padding(4, 3, 4, 3);
            PanelUniversitario.Name = "PanelUniversitario";
            PanelUniversitario.Size = new Size(418, 399);
            PanelUniversitario.TabIndex = 2;
            PanelUniversitario.Click += PanelUniversitario_Click;
            PanelUniversitario.MouseEnter += PanelUniversitario_MouseEnter;
            PanelUniversitario.MouseLeave += PanelUniversitario_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(142, 359);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 1;
            label1.Text = "Estudiantes";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(393, 345);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PanelDocente
            // 
            PanelDocente.Anchor = AnchorStyles.None;
            PanelDocente.Controls.Add(label2);
            PanelDocente.Controls.Add(pictureBox2);
            PanelDocente.Location = new Point(677, 142);
            PanelDocente.Margin = new Padding(4, 3, 4, 3);
            PanelDocente.Name = "PanelDocente";
            PanelDocente.Size = new Size(418, 399);
            PanelDocente.TabIndex = 3;
            PanelDocente.Click += PanelDocente_Click;
            PanelDocente.MouseEnter += PanelDocente_MouseEnter;
            PanelDocente.MouseLeave += PanelDocente_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(114, 359);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 22);
            label2.TabIndex = 2;
            label2.Text = "Encargado/Docente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(496, 96);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(311, 31);
            label3.TabIndex = 3;
            label3.Text = "Se desea registrar como:";
            // 
            // EstudianteOrDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1283, 715);
            Controls.Add(label3);
            Controls.Add(PanelDocente);
            Controls.Add(PanelUniversitario);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EstudianteOrDocente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelUniversitario.ResumeLayout(false);
            PanelUniversitario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelDocente.ResumeLayout(false);
            PanelDocente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel PanelUniversitario;
        private Panel PanelDocente;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}