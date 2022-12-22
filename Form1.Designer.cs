namespace examen_algoritmo_CERON_ENRIQUEZ_NOE_FERNANDO
{
    partial class Palabras
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PuntosActuales = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Frase = new System.Windows.Forms.TextBox();
            this.listPa = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Evaluar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puntos";
            // 
            // PuntosActuales
            // 
            this.PuntosActuales.FormattingEnabled = true;
            this.PuntosActuales.ItemHeight = 15;
            this.PuntosActuales.Location = new System.Drawing.Point(124, 12);
            this.PuntosActuales.Name = "PuntosActuales";
            this.PuntosActuales.Size = new System.Drawing.Size(185, 274);
            this.PuntosActuales.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingresa tu frase";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Probar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frase
            // 
            this.Frase.Location = new System.Drawing.Point(452, 12);
            this.Frase.Multiline = true;
            this.Frase.Name = "Frase";
            this.Frase.Size = new System.Drawing.Size(202, 124);
            this.Frase.TabIndex = 10;
            this.Frase.TextChanged += new System.EventHandler(this.Frase_TextChanged);
            // 
            // listPa
            // 
            this.listPa.FormattingEnabled = true;
            this.listPa.ItemHeight = 15;
            this.listPa.Location = new System.Drawing.Point(452, 177);
            this.listPa.Name = "listPa";
            this.listPa.Size = new System.Drawing.Size(202, 109);
            this.listPa.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(452, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Palabras Repetidas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Palabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPa);
            this.Controls.Add(this.Frase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PuntosActuales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Palabras";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregar;
        private Label label3;
        private ListBox PuntosActuales;
        private Label label1;
        private Button button1;
        private TextBox Frase;
        private ListBox listPa;
        private Label label2;
    }
}