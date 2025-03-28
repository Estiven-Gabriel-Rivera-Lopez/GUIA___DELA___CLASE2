namespace GUIA___DELA___CLASE2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInstruccion = new Label();
            txtNumero = new TextBox();
            btnAdivinar = new Button();
            lblResultado = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruccion.Location = new Point(12, 19);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(329, 46);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Adivina el Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(408, 36);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(258, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnAdivinar
            // 
            btnAdivinar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdivinar.Location = new Point(532, 100);
            btnAdivinar.Name = "btnAdivinar";
            btnAdivinar.Size = new Size(113, 63);
            btnAdivinar.TabIndex = 2;
            btnAdivinar.Text = "Adivinar";
            btnAdivinar.UseVisualStyleBackColor = true;
            btnAdivinar.Click += btnAdivinar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(12, 116);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(136, 31);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultados:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_03_27_185431;
            ClientSize = new Size(741, 608);
            Controls.Add(lblResultado);
            Controls.Add(btnAdivinar);
            Controls.Add(txtNumero);
            Controls.Add(lblInstruccion);
            Name = "Form1";
            Text = "Adivina el Numero:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruccion;
        private TextBox txtNumero;
        private Button btnAdivinar;
        private Label lblResultado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
