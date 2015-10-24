namespace ZTFH_SE
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
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Open = new System.Windows.Forms.Button();
            this.CB_Info = new System.Windows.Forms.ComboBox();
            this.NUD_Value = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Rupees = new System.Windows.Forms.NumericUpDown();
            this.L_Rupees = new System.Windows.Forms.Label();
            this.GB_Save = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rupees)).BeginInit();
            this.GB_Save.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Save
            // 
            this.B_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Save.Enabled = false;
            this.B_Save.Location = new System.Drawing.Point(268, 88);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(75, 23);
            this.B_Save.TabIndex = 0;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Open
            // 
            this.B_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_Open.Location = new System.Drawing.Point(10, 88);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(75, 23);
            this.B_Open.TabIndex = 1;
            this.B_Open.Text = "Open";
            this.B_Open.UseVisualStyleBackColor = true;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // CB_Info
            // 
            this.CB_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Info.FormattingEnabled = true;
            this.CB_Info.Location = new System.Drawing.Point(79, 18);
            this.CB_Info.Name = "CB_Info";
            this.CB_Info.Size = new System.Drawing.Size(190, 21);
            this.CB_Info.TabIndex = 2;
            this.CB_Info.SelectedIndexChanged += new System.EventHandler(this.changeEntry);
            // 
            // NUD_Value
            // 
            this.NUD_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Value.Location = new System.Drawing.Point(275, 19);
            this.NUD_Value.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_Value.Name = "NUD_Value";
            this.NUD_Value.Size = new System.Drawing.Size(50, 20);
            this.NUD_Value.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Info to Edit:";
            // 
            // NUD_Rupees
            // 
            this.NUD_Rupees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Rupees.Location = new System.Drawing.Point(275, 45);
            this.NUD_Rupees.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NUD_Rupees.Name = "NUD_Rupees";
            this.NUD_Rupees.Size = new System.Drawing.Size(50, 20);
            this.NUD_Rupees.TabIndex = 5;
            // 
            // L_Rupees
            // 
            this.L_Rupees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Rupees.Location = new System.Drawing.Point(15, 45);
            this.L_Rupees.Name = "L_Rupees";
            this.L_Rupees.Size = new System.Drawing.Size(254, 15);
            this.L_Rupees.TabIndex = 6;
            this.L_Rupees.Text = "Rupees:";
            this.L_Rupees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GB_Save
            // 
            this.GB_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Save.Controls.Add(this.NUD_Value);
            this.GB_Save.Controls.Add(this.L_Rupees);
            this.GB_Save.Controls.Add(this.CB_Info);
            this.GB_Save.Controls.Add(this.NUD_Rupees);
            this.GB_Save.Controls.Add(this.label1);
            this.GB_Save.Enabled = false;
            this.GB_Save.Location = new System.Drawing.Point(12, 10);
            this.GB_Save.Name = "GB_Save";
            this.GB_Save.Size = new System.Drawing.Size(331, 72);
            this.GB_Save.TabIndex = 7;
            this.GB_Save.TabStop = false;
            this.GB_Save.Text = "Save Edits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 122);
            this.Controls.Add(this.GB_Save);
            this.Controls.Add(this.B_Open);
            this.Controls.Add(this.B_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZTFH_SE";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rupees)).EndInit();
            this.GB_Save.ResumeLayout(false);
            this.GB_Save.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.ComboBox CB_Info;
        private System.Windows.Forms.NumericUpDown NUD_Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Rupees;
        private System.Windows.Forms.Label L_Rupees;
        private System.Windows.Forms.GroupBox GB_Save;
    }
}

