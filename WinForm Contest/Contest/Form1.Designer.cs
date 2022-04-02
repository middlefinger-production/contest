namespace Contest
{
    partial class Contest
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.logbutton = new System.Windows.Forms.Button();
            this.logtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logbutton
            // 
            this.logbutton.Location = new System.Drawing.Point(265, 326);
            this.logbutton.Name = "logbutton";
            this.logbutton.Size = new System.Drawing.Size(241, 90);
            this.logbutton.TabIndex = 1;
            this.logbutton.Text = "button2";
            this.logbutton.UseVisualStyleBackColor = true;
            // 
            // logtxt
            // 
            this.logtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logtxt.Location = new System.Drawing.Point(265, 86);
            this.logtxt.Name = "logtxt";
            this.logtxt.Size = new System.Drawing.Size(241, 31);
            this.logtxt.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passtxt.Location = new System.Drawing.Point(265, 198);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(241, 31);
            this.passtxt.TabIndex = 3;
            // 
            // Contest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.logbutton);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "Contest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Contest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logbutton;
        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.TextBox passtxt;
    }
}

