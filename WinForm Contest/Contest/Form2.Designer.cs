namespace Contest
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.glownabutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.onasbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(1053, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contest";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 506);
            this.label2.TabIndex = 1;
            // 
            // glownabutton
            // 
            this.glownabutton.FlatAppearance.BorderSize = 0;
            this.glownabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.glownabutton.Location = new System.Drawing.Point(12, 105);
            this.glownabutton.Name = "glownabutton";
            this.glownabutton.Size = new System.Drawing.Size(225, 52);
            this.glownabutton.TabIndex = 2;
            this.glownabutton.Text = "Strona Główna";
            this.glownabutton.UseVisualStyleBackColor = true;
            this.glownabutton.Click += new System.EventHandler(this.glownabutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Konkursy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Głosowania";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // onasbutton
            // 
            this.onasbutton.Location = new System.Drawing.Point(12, 279);
            this.onasbutton.Name = "onasbutton";
            this.onasbutton.Size = new System.Drawing.Size(225, 52);
            this.onasbutton.TabIndex = 2;
            this.onasbutton.Text = "O nas";
            this.onasbutton.UseVisualStyleBackColor = true;
            this.onasbutton.Click += new System.EventHandler(this.onasbutton_Click); 
  
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(253, 95);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(809, 506);
            this.panel.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 622);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.onasbutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.glownabutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button glownabutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button onasbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel;
    }
}