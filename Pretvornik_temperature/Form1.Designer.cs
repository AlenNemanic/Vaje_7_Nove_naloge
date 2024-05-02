namespace Pretvornik_temperature
{
    partial class Form1
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
            this.Gumb_pretvori = new System.Windows.Forms.Button();
            this.tekst_celzija = new System.Windows.Forms.TextBox();
            this.tekst_fahrenheit = new System.Windows.Forms.TextBox();
            this.napis_celzija = new System.Windows.Forms.Label();
            this.napis_fahrenheit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gumb_pretvori
            // 
            this.Gumb_pretvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb_pretvori.Location = new System.Drawing.Point(222, 76);
            this.Gumb_pretvori.Name = "Gumb_pretvori";
            this.Gumb_pretvori.Size = new System.Drawing.Size(160, 70);
            this.Gumb_pretvori.TabIndex = 0;
            this.Gumb_pretvori.Text = "Pretvori";
            this.Gumb_pretvori.UseVisualStyleBackColor = true;
            this.Gumb_pretvori.Click += new System.EventHandler(this.Gumb_pretvori_Click);
            // 
            // tekst_celzija
            // 
            this.tekst_celzija.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tekst_celzija.Location = new System.Drawing.Point(12, 94);
            this.tekst_celzija.Multiline = true;
            this.tekst_celzija.Name = "tekst_celzija";
            this.tekst_celzija.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tekst_celzija.Size = new System.Drawing.Size(140, 40);
            this.tekst_celzija.TabIndex = 1;
            this.tekst_celzija.Text = "0";
            this.tekst_celzija.TextChanged += new System.EventHandler(this.tekst_celzija_TextChanged);
            // 
            // tekst_fahrenheit
            // 
            this.tekst_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tekst_fahrenheit.Location = new System.Drawing.Point(388, 93);
            this.tekst_fahrenheit.Multiline = true;
            this.tekst_fahrenheit.Name = "tekst_fahrenheit";
            this.tekst_fahrenheit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tekst_fahrenheit.Size = new System.Drawing.Size(140, 40);
            this.tekst_fahrenheit.TabIndex = 2;
            this.tekst_fahrenheit.Text = "32";
            this.tekst_fahrenheit.TextChanged += new System.EventHandler(this.tekst_fahrenheit_TextChanged);
            // 
            // napis_celzija
            // 
            this.napis_celzija.AutoSize = true;
            this.napis_celzija.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napis_celzija.Location = new System.Drawing.Point(158, 94);
            this.napis_celzija.Name = "napis_celzija";
            this.napis_celzija.Size = new System.Drawing.Size(58, 39);
            this.napis_celzija.TabIndex = 3;
            this.napis_celzija.Text = "°C";
            // 
            // napis_fahrenheit
            // 
            this.napis_fahrenheit.AutoSize = true;
            this.napis_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napis_fahrenheit.Location = new System.Drawing.Point(534, 95);
            this.napis_fahrenheit.Name = "napis_fahrenheit";
            this.napis_fahrenheit.Size = new System.Drawing.Size(39, 39);
            this.napis_fahrenheit.TabIndex = 4;
            this.napis_fahrenheit.Text = "F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.napis_fahrenheit);
            this.Controls.Add(this.napis_celzija);
            this.Controls.Add(this.tekst_fahrenheit);
            this.Controls.Add(this.tekst_celzija);
            this.Controls.Add(this.Gumb_pretvori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gumb_pretvori;
        private System.Windows.Forms.TextBox tekst_celzija;
        private System.Windows.Forms.TextBox tekst_fahrenheit;
        private System.Windows.Forms.Label napis_celzija;
        private System.Windows.Forms.Label napis_fahrenheit;
    }
}

