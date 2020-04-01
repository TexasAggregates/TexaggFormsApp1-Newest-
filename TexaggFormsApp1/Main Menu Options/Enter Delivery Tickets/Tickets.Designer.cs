namespace TexaggFormsApp1
{
    partial class Tickets
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tKTNOLabel;
            System.Windows.Forms.Label pLANTLabel;
            System.Windows.Forms.Label cUSTOMER_NBRLabel;
            System.Windows.Forms.Label dATELabel;
            System.Windows.Forms.Label mATERIALLabel;
            System.Windows.Forms.Label gROSSLabel;
            System.Windows.Forms.Label tARELabel;
            System.Windows.Forms.Label nETLabel;
            System.Windows.Forms.Label tONSLabel;
            System.Windows.Forms.Label tRUCKLabel;
            System.Windows.Forms.Label dRIVERLabel;
            System.Windows.Forms.Label tRKTYPLabel;
            this.ticlosebutton = new System.Windows.Forms.Button();
            this.tICKETSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEXAGG1DataSet = new TexaggFormsApp1.TEXAGG1DataSet();
            this.tICKETSTableAdapter = new TexaggFormsApp1.TEXAGG1DataSetTableAdapters.TICKETSTableAdapter();
            this.tableAdapterManager = new TexaggFormsApp1.TEXAGG1DataSetTableAdapters.TableAdapterManager();
            this.tKTNOTextBox = new System.Windows.Forms.TextBox();
            this.pLANTTextBox = new System.Windows.Forms.TextBox();
            this.cUSTOMER_NBRComboBox = new System.Windows.Forms.ComboBox();
            this.dATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mATERIALComboBox = new System.Windows.Forms.ComboBox();
            this.gROSSTextBox = new System.Windows.Forms.TextBox();
            this.tARETextBox = new System.Windows.Forms.TextBox();
            this.nETTextBox = new System.Windows.Forms.TextBox();
            this.tONSTextBox = new System.Windows.Forms.TextBox();
            this.tRUCKTextBox = new System.Windows.Forms.TextBox();
            this.dRIVERTextBox = new System.Windows.Forms.TextBox();
            this.tRKTYPTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            tKTNOLabel = new System.Windows.Forms.Label();
            pLANTLabel = new System.Windows.Forms.Label();
            cUSTOMER_NBRLabel = new System.Windows.Forms.Label();
            dATELabel = new System.Windows.Forms.Label();
            mATERIALLabel = new System.Windows.Forms.Label();
            gROSSLabel = new System.Windows.Forms.Label();
            tARELabel = new System.Windows.Forms.Label();
            nETLabel = new System.Windows.Forms.Label();
            tONSLabel = new System.Windows.Forms.Label();
            tRUCKLabel = new System.Windows.Forms.Label();
            dRIVERLabel = new System.Windows.Forms.Label();
            tRKTYPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEXAGG1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tKTNOLabel
            // 
            tKTNOLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tKTNOLabel.AutoSize = true;
            tKTNOLabel.Location = new System.Drawing.Point(248, 112);
            tKTNOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tKTNOLabel.Name = "tKTNOLabel";
            tKTNOLabel.Size = new System.Drawing.Size(72, 17);
            tKTNOLabel.TabIndex = 1;
            tKTNOLabel.Text = "TICKET #:";
            tKTNOLabel.Click += new System.EventHandler(this.tKTNOLabel_Click_1);
            // 
            // pLANTLabel
            // 
            pLANTLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            pLANTLabel.AutoSize = true;
            pLANTLabel.Location = new System.Drawing.Point(248, 144);
            pLANTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pLANTLabel.Name = "pLANTLabel";
            pLANTLabel.Size = new System.Drawing.Size(57, 17);
            pLANTLabel.TabIndex = 3;
            pLANTLabel.Text = "PLANT:";
            // 
            // cUSTOMER_NBRLabel
            // 
            cUSTOMER_NBRLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cUSTOMER_NBRLabel.AutoSize = true;
            cUSTOMER_NBRLabel.Location = new System.Drawing.Point(248, 176);
            cUSTOMER_NBRLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cUSTOMER_NBRLabel.Name = "cUSTOMER_NBRLabel";
            cUSTOMER_NBRLabel.Size = new System.Drawing.Size(102, 17);
            cUSTOMER_NBRLabel.TabIndex = 5;
            cUSTOMER_NBRLabel.Text = "CUSTOMER #:";
            // 
            // dATELabel
            // 
            dATELabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            dATELabel.AutoSize = true;
            dATELabel.Location = new System.Drawing.Point(248, 210);
            dATELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dATELabel.Name = "dATELabel";
            dATELabel.Size = new System.Drawing.Size(49, 17);
            dATELabel.TabIndex = 7;
            dATELabel.Text = "DATE:";
            // 
            // mATERIALLabel
            // 
            mATERIALLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            mATERIALLabel.AutoSize = true;
            mATERIALLabel.Location = new System.Drawing.Point(248, 241);
            mATERIALLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mATERIALLabel.Name = "mATERIALLabel";
            mATERIALLabel.Size = new System.Drawing.Size(80, 17);
            mATERIALLabel.TabIndex = 9;
            mATERIALLabel.Text = "MATERIAL:";
            // 
            // gROSSLabel
            // 
            gROSSLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            gROSSLabel.AutoSize = true;
            gROSSLabel.Location = new System.Drawing.Point(248, 274);
            gROSSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gROSSLabel.Name = "gROSSLabel";
            gROSSLabel.Size = new System.Drawing.Size(62, 17);
            gROSSLabel.TabIndex = 11;
            gROSSLabel.Text = "GROSS:";
            // 
            // tARELabel
            // 
            tARELabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tARELabel.AutoSize = true;
            tARELabel.Location = new System.Drawing.Point(248, 306);
            tARELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tARELabel.Name = "tARELabel";
            tARELabel.Size = new System.Drawing.Size(49, 17);
            tARELabel.TabIndex = 13;
            tARELabel.Text = "TARE:";
            // 
            // nETLabel
            // 
            nETLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nETLabel.AutoSize = true;
            nETLabel.Location = new System.Drawing.Point(248, 338);
            nETLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nETLabel.Name = "nETLabel";
            nETLabel.Size = new System.Drawing.Size(40, 17);
            nETLabel.TabIndex = 15;
            nETLabel.Text = "NET:";
            // 
            // tONSLabel
            // 
            tONSLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tONSLabel.AutoSize = true;
            tONSLabel.Location = new System.Drawing.Point(248, 370);
            tONSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tONSLabel.Name = "tONSLabel";
            tONSLabel.Size = new System.Drawing.Size(51, 17);
            tONSLabel.TabIndex = 17;
            tONSLabel.Text = "TONS:";
            // 
            // tRUCKLabel
            // 
            tRUCKLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tRUCKLabel.AutoSize = true;
            tRUCKLabel.Location = new System.Drawing.Point(248, 402);
            tRUCKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRUCKLabel.Name = "tRUCKLabel";
            tRUCKLabel.Size = new System.Drawing.Size(59, 17);
            tRUCKLabel.TabIndex = 19;
            tRUCKLabel.Text = "TRUCK:";
            // 
            // dRIVERLabel
            // 
            dRIVERLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            dRIVERLabel.AutoSize = true;
            dRIVERLabel.Location = new System.Drawing.Point(248, 434);
            dRIVERLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dRIVERLabel.Name = "dRIVERLabel";
            dRIVERLabel.Size = new System.Drawing.Size(63, 17);
            dRIVERLabel.TabIndex = 21;
            dRIVERLabel.Text = "DRIVER:";
            // 
            // tRKTYPLabel
            // 
            tRKTYPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tRKTYPLabel.AutoSize = true;
            tRKTYPLabel.Location = new System.Drawing.Point(248, 466);
            tRKTYPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRKTYPLabel.Name = "tRKTYPLabel";
            tRKTYPLabel.Size = new System.Drawing.Size(67, 17);
            tRKTYPLabel.TabIndex = 23;
            tRKTYPLabel.Text = "TRKTYP:";
            // 
            // ticlosebutton
            // 
            this.ticlosebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ticlosebutton.Location = new System.Drawing.Point(963, 540);
            this.ticlosebutton.Margin = new System.Windows.Forms.Padding(4);
            this.ticlosebutton.Name = "ticlosebutton";
            this.ticlosebutton.Size = new System.Drawing.Size(100, 28);
            this.ticlosebutton.TabIndex = 0;
            this.ticlosebutton.Text = "Close";
            this.ticlosebutton.UseVisualStyleBackColor = true;
            this.ticlosebutton.Click += new System.EventHandler(this.Ticlosebutton_Click);
            // 
            // tICKETSBindingSource
            // 
            this.tICKETSBindingSource.DataMember = "TICKETS";
            this.tICKETSBindingSource.DataSource = this.tEXAGG1DataSet;
            // 
            // tEXAGG1DataSet
            // 
            this.tEXAGG1DataSet.DataSetName = "TEXAGG1DataSet";
            this.tEXAGG1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tICKETSTableAdapter
            // 
            this.tICKETSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTTableAdapter = null;
            this.tableAdapterManager.MATERIALTableAdapter = null;
            this.tableAdapterManager.TICKETSTableAdapter = this.tICKETSTableAdapter;
            this.tableAdapterManager.TRUCKTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TexaggFormsApp1.TEXAGG1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tKTNOTextBox
            // 
            this.tKTNOTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tKTNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TKTNO", true));
            this.tKTNOTextBox.Location = new System.Drawing.Point(385, 108);
            this.tKTNOTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tKTNOTextBox.Name = "tKTNOTextBox";
            this.tKTNOTextBox.Size = new System.Drawing.Size(265, 22);
            this.tKTNOTextBox.TabIndex = 1;
            // 
            // pLANTTextBox
            // 
            this.pLANTTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pLANTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "PLANT", true));
            this.pLANTTextBox.Location = new System.Drawing.Point(385, 140);
            this.pLANTTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pLANTTextBox.Name = "pLANTTextBox";
            this.pLANTTextBox.Size = new System.Drawing.Size(265, 22);
            this.pLANTTextBox.TabIndex = 2;
            // 
            // cUSTOMER_NBRComboBox
            // 
            this.cUSTOMER_NBRComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cUSTOMER_NBRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "CUSTOMER_NBR", true));
            this.cUSTOMER_NBRComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cUSTOMER_NBRComboBox.FormattingEnabled = true;
            this.cUSTOMER_NBRComboBox.Location = new System.Drawing.Point(385, 172);
            this.cUSTOMER_NBRComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cUSTOMER_NBRComboBox.Name = "cUSTOMER_NBRComboBox";
            this.cUSTOMER_NBRComboBox.Size = new System.Drawing.Size(265, 24);
            this.cUSTOMER_NBRComboBox.TabIndex = 3;
            // 
            // dATEDateTimePicker
            // 
            this.dATEDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tICKETSBindingSource, "DATE", true));
            this.dATEDateTimePicker.Location = new System.Drawing.Point(385, 206);
            this.dATEDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dATEDateTimePicker.Name = "dATEDateTimePicker";
            this.dATEDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dATEDateTimePicker.TabIndex = 4;
            // 
            // mATERIALComboBox
            // 
            this.mATERIALComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mATERIALComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "MATERIAL", true));
            this.mATERIALComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mATERIALComboBox.FormattingEnabled = true;
            this.mATERIALComboBox.Location = new System.Drawing.Point(385, 238);
            this.mATERIALComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.mATERIALComboBox.Name = "mATERIALComboBox";
            this.mATERIALComboBox.Size = new System.Drawing.Size(265, 24);
            this.mATERIALComboBox.TabIndex = 5;
            // 
            // gROSSTextBox
            // 
            this.gROSSTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gROSSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "GROSS", true));
            this.gROSSTextBox.Location = new System.Drawing.Point(385, 271);
            this.gROSSTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gROSSTextBox.Name = "gROSSTextBox";
            this.gROSSTextBox.Size = new System.Drawing.Size(265, 22);
            this.gROSSTextBox.TabIndex = 6;
            // 
            // tARETextBox
            // 
            this.tARETextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tARETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TARE", true));
            this.tARETextBox.Location = new System.Drawing.Point(385, 303);
            this.tARETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tARETextBox.Name = "tARETextBox";
            this.tARETextBox.Size = new System.Drawing.Size(265, 22);
            this.tARETextBox.TabIndex = 7;
            // 
            // nETTextBox
            // 
            this.nETTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "NET", true));
            this.nETTextBox.Location = new System.Drawing.Point(385, 335);
            this.nETTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nETTextBox.Name = "nETTextBox";
            this.nETTextBox.Size = new System.Drawing.Size(265, 22);
            this.nETTextBox.TabIndex = 8;
            // 
            // tONSTextBox
            // 
            this.tONSTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tONSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TONS", true));
            this.tONSTextBox.Location = new System.Drawing.Point(385, 367);
            this.tONSTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tONSTextBox.Name = "tONSTextBox";
            this.tONSTextBox.Size = new System.Drawing.Size(265, 22);
            this.tONSTextBox.TabIndex = 18;
            // 
            // tRUCKTextBox
            // 
            this.tRUCKTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tRUCKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TRUCK", true));
            this.tRUCKTextBox.Location = new System.Drawing.Point(385, 399);
            this.tRUCKTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tRUCKTextBox.Name = "tRUCKTextBox";
            this.tRUCKTextBox.Size = new System.Drawing.Size(265, 22);
            this.tRUCKTextBox.TabIndex = 20;
            // 
            // dRIVERTextBox
            // 
            this.dRIVERTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dRIVERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "DRIVER", true));
            this.dRIVERTextBox.Location = new System.Drawing.Point(385, 431);
            this.dRIVERTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dRIVERTextBox.Name = "dRIVERTextBox";
            this.dRIVERTextBox.Size = new System.Drawing.Size(265, 22);
            this.dRIVERTextBox.TabIndex = 22;
            // 
            // tRKTYPTextBox
            // 
            this.tRKTYPTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tRKTYPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TRKTYP", true));
            this.tRKTYPTextBox.Location = new System.Drawing.Point(385, 463);
            this.tRKTYPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tRKTYPTextBox.Name = "tRKTYPTextBox";
            this.tRKTYPTextBox.Size = new System.Drawing.Size(265, 22);
            this.tRKTYPTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(855, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(tKTNOLabel);
            this.Controls.Add(this.tKTNOTextBox);
            this.Controls.Add(pLANTLabel);
            this.Controls.Add(this.pLANTTextBox);
            this.Controls.Add(cUSTOMER_NBRLabel);
            this.Controls.Add(this.cUSTOMER_NBRComboBox);
            this.Controls.Add(dATELabel);
            this.Controls.Add(this.dATEDateTimePicker);
            this.Controls.Add(mATERIALLabel);
            this.Controls.Add(this.mATERIALComboBox);
            this.Controls.Add(gROSSLabel);
            this.Controls.Add(this.gROSSTextBox);
            this.Controls.Add(tARELabel);
            this.Controls.Add(this.tARETextBox);
            this.Controls.Add(nETLabel);
            this.Controls.Add(this.nETTextBox);
            this.Controls.Add(tONSLabel);
            this.Controls.Add(this.tONSTextBox);
            this.Controls.Add(tRUCKLabel);
            this.Controls.Add(this.tRUCKTextBox);
            this.Controls.Add(dRIVERLabel);
            this.Controls.Add(this.dRIVERTextBox);
            this.Controls.Add(tRKTYPLabel);
            this.Controls.Add(this.tRKTYPTextBox);
            this.Controls.Add(this.ticlosebutton);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tICKETSBindingSource, "TKTNO", true));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TKTNO", true));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tICKETSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEXAGG1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ticlosebutton;
        private TEXAGG1DataSet tEXAGG1DataSet;
        private System.Windows.Forms.BindingSource tICKETSBindingSource;
        private TEXAGG1DataSetTableAdapters.TICKETSTableAdapter tICKETSTableAdapter;
        private TEXAGG1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tKTNOTextBox;
        private System.Windows.Forms.TextBox pLANTTextBox;
        private System.Windows.Forms.ComboBox cUSTOMER_NBRComboBox;
        private System.Windows.Forms.DateTimePicker dATEDateTimePicker;
        private System.Windows.Forms.ComboBox mATERIALComboBox;
        private System.Windows.Forms.TextBox gROSSTextBox;
        private System.Windows.Forms.TextBox tARETextBox;
        private System.Windows.Forms.TextBox nETTextBox;
        private System.Windows.Forms.TextBox tONSTextBox;
        private System.Windows.Forms.TextBox tRUCKTextBox;
        private System.Windows.Forms.TextBox dRIVERTextBox;
        private System.Windows.Forms.TextBox tRKTYPTextBox;
        private System.Windows.Forms.Button button1;
    }
}