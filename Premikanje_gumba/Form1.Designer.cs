namespace Premikanje_gumba
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
            this.Gumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gumb
            // 
            this.Gumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb.Location = new System.Drawing.Point(162, 95);
            this.Gumb.Name = "Gumb";
            this.Gumb.Size = new System.Drawing.Size(160, 70);
            this.Gumb.TabIndex = 1;
            this.Gumb.Text = "Pritisni me!";
            this.Gumb.UseVisualStyleBackColor = true;
            this.Gumb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gumb_MouseDown);
            this.Gumb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Gumb_MouseMove);
            this.Gumb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Gumb_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Gumb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gumb;
    }
}

