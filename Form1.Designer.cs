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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CB_Info = new System.Windows.Forms.ComboBox();
            this.NUD_Value = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Rupees = new System.Windows.Forms.NumericUpDown();
            this.L_Rupees = new System.Windows.Forms.Label();
            this.GB_Save = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PlayerName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_GiveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_RemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rupees)).BeginInit();
            this.GB_Save.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Info
            // 
            this.CB_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Info.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Info.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            99,
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
            this.GB_Save.Controls.Add(this.label2);
            this.GB_Save.Controls.Add(this.TB_PlayerName);
            this.GB_Save.Controls.Add(this.NUD_Value);
            this.GB_Save.Controls.Add(this.L_Rupees);
            this.GB_Save.Controls.Add(this.CB_Info);
            this.GB_Save.Controls.Add(this.NUD_Rupees);
            this.GB_Save.Controls.Add(this.label1);
            this.GB_Save.Enabled = false;
            this.GB_Save.Location = new System.Drawing.Point(12, 28);
            this.GB_Save.Name = "GB_Save";
            this.GB_Save.Size = new System.Drawing.Size(331, 72);
            this.GB_Save.TabIndex = 7;
            this.GB_Save.TabStop = false;
            this.GB_Save.Text = "Save Edits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player Name:";
            // 
            // TB_PlayerName
            // 
            this.TB_PlayerName.Location = new System.Drawing.Point(79, 43);
            this.TB_PlayerName.MaxLength = 8;
            this.TB_PlayerName.Name = "TB_PlayerName";
            this.TB_PlayerName.Size = new System.Drawing.Size(100, 20);
            this.TB_PlayerName.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Tools,
            this.Menu_Options});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Open,
            this.Menu_Save,
            this.Menu_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(37, 20);
            this.Menu_File.Text = "File";
            // 
            // Menu_Open
            // 
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Menu_Open.ShowShortcutKeys = false;
            this.Menu_Open.Size = new System.Drawing.Size(152, 22);
            this.Menu_Open.Text = "&Open...";
            this.Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // Menu_Save
            // 
            this.Menu_Save.Enabled = false;
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Menu_Save.ShowShortcutKeys = false;
            this.Menu_Save.Size = new System.Drawing.Size(152, 22);
            this.Menu_Save.Text = "&Save";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Name = "Menu_Exit";
            this.Menu_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Menu_Exit.ShowShortcutKeys = false;
            this.Menu_Exit.Size = new System.Drawing.Size(152, 22);
            this.Menu_Exit.Text = "&Exit";
            this.Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // Menu_Tools
            // 
            this.Menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_GiveAll,
            this.Menu_RemoveAll});
            this.Menu_Tools.Enabled = false;
            this.Menu_Tools.Name = "Menu_Tools";
            this.Menu_Tools.Size = new System.Drawing.Size(48, 20);
            this.Menu_Tools.Text = "Tools";
            // 
            // Menu_GiveAll
            // 
            this.Menu_GiveAll.Name = "Menu_GiveAll";
            this.Menu_GiveAll.Size = new System.Drawing.Size(166, 22);
            this.Menu_GiveAll.Text = "Max All Items";
            this.Menu_GiveAll.Click += new System.EventHandler(this.Menu_GiveAll_Click);
            // 
            // Menu_RemoveAll
            // 
            this.Menu_RemoveAll.Name = "Menu_RemoveAll";
            this.Menu_RemoveAll.Size = new System.Drawing.Size(166, 22);
            this.Menu_RemoveAll.Text = "Remove All Items";
            this.Menu_RemoveAll.Click += new System.EventHandler(this.Menu_RemoveAll_Click);
            // 
            // Menu_Options
            // 
            this.Menu_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_About});
            this.Menu_Options.Name = "Menu_Options";
            this.Menu_Options.Size = new System.Drawing.Size(61, 20);
            this.Menu_Options.Text = "Options";
            // 
            // Menu_About
            // 
            this.Menu_About.Name = "Menu_About";
            this.Menu_About.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.Menu_About.ShowShortcutKeys = false;
            this.Menu_About.Size = new System.Drawing.Size(152, 22);
            this.Menu_About.Text = "A&bout";
            this.Menu_About.Click += new System.EventHandler(this.Menu_About_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 109);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GB_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tri Force Heroes Save Editor";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rupees)).EndInit();
            this.GB_Save.ResumeLayout(false);
            this.GB_Save.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Info;
        private System.Windows.Forms.NumericUpDown NUD_Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Rupees;
        private System.Windows.Forms.Label L_Rupees;
        private System.Windows.Forms.GroupBox GB_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PlayerName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools;
        private System.Windows.Forms.ToolStripMenuItem Menu_GiveAll;
        private System.Windows.Forms.ToolStripMenuItem Menu_RemoveAll;
        private System.Windows.Forms.ToolStripMenuItem Menu_Options;
        private System.Windows.Forms.ToolStripMenuItem Menu_About;
    }
}

