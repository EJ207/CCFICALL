namespace VistaButton
{
    partial class VistaButton
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VistaButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "VistaButton";
            this.Size = new System.Drawing.Size(75, 23);
            this.MouseLeave += new System.EventHandler(this.VistaButton_MouseLeave);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VistaButton_Paint);
            this.Leave += new System.EventHandler(this.VistaButton_Leave);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VistaButton_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VistaButton_MouseDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VistaButton_KeyPress);
            this.Enter += new System.EventHandler(this.VistaButton_Enter);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VistaButton_MouseUp);
            this.MouseEnter += new System.EventHandler(this.VistaButton_MouseEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VistaButton_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
