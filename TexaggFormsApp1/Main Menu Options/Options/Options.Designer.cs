namespace TexaggFormsApp1
{
    partial class Options
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
            this.optclosebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optclosebutton
            // 
            this.optclosebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optclosebutton.Location = new System.Drawing.Point(963, 540);
            this.optclosebutton.Name = "optclosebutton";
            this.optclosebutton.Size = new System.Drawing.Size(100, 28);
            this.optclosebutton.TabIndex = 0;
            this.optclosebutton.Text = "Close";
            this.optclosebutton.UseVisualStyleBackColor = true;
            this.optclosebutton.Click += new System.EventHandler(this.Optclosebutton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(855, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.optclosebutton);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optclosebutton;
        private System.Windows.Forms.Button button1;
    }
}