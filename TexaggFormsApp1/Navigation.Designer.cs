using System;

namespace TexaggFormsApp1
{
    partial class Navigation
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
            this.ticketsbutton = new System.Windows.Forms.Button();
            this.customersbutton = new System.Windows.Forms.Button();
            this.materialsbutton = new System.Windows.Forms.Button();
            this.reportsbutton = new System.Windows.Forms.Button();
            this.optionsbutton = new System.Windows.Forms.Button();
            this.texagglogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.texagglogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsbutton
            // 
            this.ticketsbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ticketsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsbutton.Location = new System.Drawing.Point(81, 112);
            this.ticketsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.ticketsbutton.Name = "ticketsbutton";
            this.ticketsbutton.Size = new System.Drawing.Size(868, 54);
            this.ticketsbutton.TabIndex = 0;
            this.ticketsbutton.Text = "Enter Delivery Tickets";
            this.ticketsbutton.UseVisualStyleBackColor = true;
            this.ticketsbutton.Click += new System.EventHandler(this.Ticketsbutton_Click);
            // 
            // customersbutton
            // 
            this.customersbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customersbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersbutton.Location = new System.Drawing.Point(81, 166);
            this.customersbutton.Margin = new System.Windows.Forms.Padding(4);
            this.customersbutton.Name = "customersbutton";
            this.customersbutton.Size = new System.Drawing.Size(868, 54);
            this.customersbutton.TabIndex = 1;
            this.customersbutton.Text = "Enter Customers";
            this.customersbutton.UseVisualStyleBackColor = true;
            this.customersbutton.Click += new System.EventHandler(this.Customersbutton_Click);
            // 
            // materialsbutton
            // 
            this.materialsbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialsbutton.Location = new System.Drawing.Point(81, 220);
            this.materialsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.materialsbutton.Name = "materialsbutton";
            this.materialsbutton.Size = new System.Drawing.Size(868, 54);
            this.materialsbutton.TabIndex = 2;
            this.materialsbutton.Text = "Enter Materials";
            this.materialsbutton.UseVisualStyleBackColor = true;
            this.materialsbutton.Click += new System.EventHandler(this.Materialsbutton_Click);
            // 
            // reportsbutton
            // 
            this.reportsbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsbutton.Location = new System.Drawing.Point(81, 274);
            this.reportsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.reportsbutton.Name = "reportsbutton";
            this.reportsbutton.Size = new System.Drawing.Size(868, 54);
            this.reportsbutton.TabIndex = 3;
            this.reportsbutton.Text = "Reports";
            this.reportsbutton.UseVisualStyleBackColor = true;
            this.reportsbutton.Click += new System.EventHandler(this.Reportsbutton_Click);
            // 
            // optionsbutton
            // 
            this.optionsbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsbutton.Location = new System.Drawing.Point(81, 383);
            this.optionsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.optionsbutton.Name = "optionsbutton";
            this.optionsbutton.Size = new System.Drawing.Size(868, 54);
            this.optionsbutton.TabIndex = 4;
            this.optionsbutton.Text = "Options";
            this.optionsbutton.UseVisualStyleBackColor = true;
            this.optionsbutton.Click += new System.EventHandler(this.Optionsbutton_Click);
            // 
            // texagglogo
            // 
            this.texagglogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.texagglogo.Image = global::TexaggFormsApp1.Properties.Resources.texagglogo021;
            this.texagglogo.InitialImage = global::TexaggFormsApp1.Properties.Resources.texagglogo;
            this.texagglogo.Location = new System.Drawing.Point(332, -16);
            this.texagglogo.Name = "texagglogo";
            this.texagglogo.Size = new System.Drawing.Size(275, 88);
            this.texagglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.texagglogo.TabStop = false;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.texagglogo);
            this.Controls.Add(this.optionsbutton);
            this.Controls.Add(this.customersbutton);
            this.Controls.Add(this.materialsbutton);
            this.Controls.Add(this.reportsbutton);
            this.Controls.Add(this.ticketsbutton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Navigation";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.texagglogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ticketsbutton;
        private System.Windows.Forms.Button customersbutton;
        private System.Windows.Forms.Button materialsbutton;
        private System.Windows.Forms.Button reportsbutton;
        private System.Windows.Forms.Button optionsbutton;
        private System.Windows.Forms.PictureBox texagglogo;
    }
}

