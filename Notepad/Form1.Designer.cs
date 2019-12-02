namespace Notepad
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.NotepadText = new System.Windows.Forms.RichTextBox();
            this.TextColor = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.BackColor = new System.Windows.Forms.ColorDialog();
            this.OpenText = new System.Windows.Forms.OpenFileDialog();
            this.SaveText = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.NotpadControl = new Ambiance.Ambiance_TabControl();
            this.File = new System.Windows.Forms.TabPage();
            this.FileSetting = new System.Windows.Forms.ToolStrip();
            this.NewFile = new System.Windows.Forms.ToolStripButton();
            this.OpenFile = new System.Windows.Forms.ToolStripButton();
            this.SaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Print = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Edit = new System.Windows.Forms.TabPage();
            this.EditTools = new System.Windows.Forms.ToolStrip();
            this.Past = new System.Windows.Forms.ToolStripButton();
            this.Cut = new System.Windows.Forms.ToolStripButton();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Selectall = new System.Windows.Forms.ToolStripButton();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.Undo = new System.Windows.Forms.ToolStripButton();
            this.Seartch = new System.Windows.Forms.TabPage();
            this.EditSetting = new System.Windows.Forms.ToolStrip();
            this.Find = new System.Windows.Forms.ToolStripButton();
            this.Researtch = new System.Windows.Forms.ToolStripTextBox();
            this.Resulat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Replace = new System.Windows.Forms.ToolStripTextBox();
            this.TextEdit = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FontColer = new System.Windows.Forms.ToolStripButton();
            this.FontFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BackColer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.WordWrap = new System.Windows.Forms.ToolStripButton();
            this.NotpadControl.SuspendLayout();
            this.File.SuspendLayout();
            this.FileSetting.SuspendLayout();
            this.Edit.SuspendLayout();
            this.EditTools.SuspendLayout();
            this.Seartch.SuspendLayout();
            this.EditSetting.SuspendLayout();
            this.TextEdit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotepadText
            // 
            this.NotepadText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotepadText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotepadText.Location = new System.Drawing.Point(10, 88);
            this.NotepadText.Name = "NotepadText";
            this.NotepadText.Size = new System.Drawing.Size(599, 361);
            this.NotepadText.TabIndex = 1;
            this.NotepadText.Text = "";
            this.NotepadText.TextChanged += new System.EventHandler(this.NotepadText_TextChanged);
            this.NotepadText.DoubleClick += new System.EventHandler(this.NotepadText_DoubleClick);
            // 
            // TextColor
            // 
            this.TextColor.FullOpen = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Tahoma", 10F);
            // 
            // BackColor
            // 
            this.BackColor.Color = System.Drawing.Color.White;
            this.BackColor.FullOpen = true;
            // 
            // OpenText
            // 
            this.OpenText.Title = "Open Text";
            this.OpenText.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenText_FileOk);
            // 
            // SaveText
            // 
            this.SaveText.FileName = "Shemy1.mash";
            this.SaveText.Title = "Save As....";
            this.SaveText.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveText_FileOk);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 361);
            this.label1.TabIndex = 3;
            // 
            // NotpadControl
            // 
            this.NotpadControl.Controls.Add(this.File);
            this.NotpadControl.Controls.Add(this.Edit);
            this.NotpadControl.Controls.Add(this.Seartch);
            this.NotpadControl.Controls.Add(this.TextEdit);
            this.NotpadControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotpadControl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NotpadControl.ItemSize = new System.Drawing.Size(80, 24);
            this.NotpadControl.Location = new System.Drawing.Point(0, 0);
            this.NotpadControl.Name = "NotpadControl";
            this.NotpadControl.SelectedIndex = 0;
            this.NotpadControl.Size = new System.Drawing.Size(609, 88);
            this.NotpadControl.TabIndex = 2;
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.File.Controls.Add(this.FileSetting);
            this.File.Location = new System.Drawing.Point(4, 28);
            this.File.Name = "File";
            this.File.Padding = new System.Windows.Forms.Padding(3);
            this.File.Size = new System.Drawing.Size(601, 56);
            this.File.TabIndex = 0;
            this.File.Text = "File";
            this.File.ToolTipText = "File";
            // 
            // FileSetting
            // 
            this.FileSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileSetting.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.FileSetting.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.FileSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.OpenFile,
            this.SaveAs,
            this.toolStripSeparator1,
            this.NewTab,
            this.toolStripSeparator5,
            this.Print,
            this.toolStripButton2});
            this.FileSetting.Location = new System.Drawing.Point(3, 3);
            this.FileSetting.Name = "FileSetting";
            this.FileSetting.Size = new System.Drawing.Size(595, 50);
            this.FileSetting.TabIndex = 0;
            this.FileSetting.Text = "File";
            // 
            // NewFile
            // 
            this.NewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFile.Image = ((System.Drawing.Image)(resources.GetObject("NewFile.Image")));
            this.NewFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(44, 47);
            this.NewFile.Text = "New File";
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(44, 47);
            this.OpenFile.Text = "Open File";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs.Image")));
            this.SaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(36, 47);
            this.SaveAs.Text = "Save As . . .";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // NewTab
            // 
            this.NewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewTab.Image = ((System.Drawing.Image)(resources.GetObject("NewTab.Image")));
            this.NewTab.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewTab.Name = "NewTab";
            this.NewTab.Size = new System.Drawing.Size(44, 47);
            this.NewTab.Text = "New Window";
            this.NewTab.Click += new System.EventHandler(this.NewTab_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 50);
            // 
            // Print
            // 
            this.Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Print.Image = ((System.Drawing.Image)(resources.GetObject("Print.Image")));
            this.Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(44, 47);
            this.Print.Text = "Print";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 47);
            this.toolStripButton2.Text = "Help";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Edit.Controls.Add(this.EditTools);
            this.Edit.Location = new System.Drawing.Point(4, 28);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(601, 56);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            // 
            // EditTools
            // 
            this.EditTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.EditTools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.EditTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Past,
            this.Cut,
            this.Copy,
            this.toolStripSeparator2,
            this.Selectall,
            this.Delete,
            this.Undo});
            this.EditTools.Location = new System.Drawing.Point(0, 0);
            this.EditTools.Name = "EditTools";
            this.EditTools.Size = new System.Drawing.Size(601, 56);
            this.EditTools.TabIndex = 0;
            this.EditTools.Text = "toolStrip2";
            // 
            // Past
            // 
            this.Past.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Past.Image = ((System.Drawing.Image)(resources.GetObject("Past.Image")));
            this.Past.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Past.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Past.Name = "Past";
            this.Past.Size = new System.Drawing.Size(44, 53);
            this.Past.Text = "Past";
            this.Past.Click += new System.EventHandler(this.Past_Click);
            // 
            // Cut
            // 
            this.Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut.Enabled = false;
            this.Cut.Image = ((System.Drawing.Image)(resources.GetObject("Cut.Image")));
            this.Cut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(44, 53);
            this.Cut.Text = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy.Enabled = false;
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(44, 53);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // Selectall
            // 
            this.Selectall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Selectall.Image = ((System.Drawing.Image)(resources.GetObject("Selectall.Image")));
            this.Selectall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Selectall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Selectall.Name = "Selectall";
            this.Selectall.Size = new System.Drawing.Size(44, 53);
            this.Selectall.Text = "Select All";
            this.Selectall.Click += new System.EventHandler(this.Selectall_Click);
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(44, 53);
            this.Delete.Text = "Clear";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Undo
            // 
            this.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Undo.Image = ((System.Drawing.Image)(resources.GetObject("Undo.Image")));
            this.Undo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(36, 53);
            this.Undo.Text = "Undo";
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Seartch
            // 
            this.Seartch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Seartch.Controls.Add(this.EditSetting);
            this.Seartch.Location = new System.Drawing.Point(4, 28);
            this.Seartch.Name = "Seartch";
            this.Seartch.Padding = new System.Windows.Forms.Padding(3);
            this.Seartch.Size = new System.Drawing.Size(601, 56);
            this.Seartch.TabIndex = 1;
            this.Seartch.Text = "Seartch";
            this.Seartch.ToolTipText = "Edit";
            // 
            // EditSetting
            // 
            this.EditSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditSetting.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.EditSetting.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.EditSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Find,
            this.Researtch,
            this.Resulat,
            this.toolStripButton1,
            this.Replace});
            this.EditSetting.Location = new System.Drawing.Point(3, 3);
            this.EditSetting.Name = "EditSetting";
            this.EditSetting.Size = new System.Drawing.Size(595, 50);
            this.EditSetting.TabIndex = 0;
            this.EditSetting.Text = "toolStrip1";
            // 
            // Find
            // 
            this.Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Find.Image = ((System.Drawing.Image)(resources.GetObject("Find.Image")));
            this.Find.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(44, 47);
            this.Find.Text = "Find";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Researtch
            // 
            this.Researtch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Researtch.Name = "Researtch";
            this.Researtch.Size = new System.Drawing.Size(100, 50);
            this.Researtch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Researtch_KeyUp);
            // 
            // Resulat
            // 
            this.Resulat.Name = "Resulat";
            this.Resulat.Size = new System.Drawing.Size(0, 47);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 47);
            this.toolStripButton1.Text = "Replace";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Replace
            // 
            this.Replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(100, 50);
            this.Replace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Replace_KeyPress);
            // 
            // TextEdit
            // 
            this.TextEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.TextEdit.Controls.Add(this.toolStrip1);
            this.TextEdit.Location = new System.Drawing.Point(4, 28);
            this.TextEdit.Name = "TextEdit";
            this.TextEdit.Size = new System.Drawing.Size(601, 56);
            this.TextEdit.TabIndex = 4;
            this.TextEdit.Text = "Text Edit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontColer,
            this.FontFont,
            this.toolStripSeparator3,
            this.BackColer,
            this.toolStripSeparator4,
            this.WordWrap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(601, 56);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "File";
            // 
            // FontColer
            // 
            this.FontColer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColer.Image = ((System.Drawing.Image)(resources.GetObject("FontColer.Image")));
            this.FontColer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FontColer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColer.Name = "FontColer";
            this.FontColer.Size = new System.Drawing.Size(44, 53);
            this.FontColer.Text = "Coler";
            this.FontColer.Click += new System.EventHandler(this.FontColer_Click);
            // 
            // FontFont
            // 
            this.FontFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontFont.Image = ((System.Drawing.Image)(resources.GetObject("FontFont.Image")));
            this.FontFont.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FontFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontFont.Name = "FontFont";
            this.FontFont.Size = new System.Drawing.Size(44, 53);
            this.FontFont.Text = "Font";
            this.FontFont.Click += new System.EventHandler(this.FontFont_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 56);
            // 
            // BackColer
            // 
            this.BackColer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackColer.Image = ((System.Drawing.Image)(resources.GetObject("BackColer.Image")));
            this.BackColer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BackColer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackColer.Name = "BackColer";
            this.BackColer.Size = new System.Drawing.Size(35, 53);
            this.BackColer.Text = "Back Coler";
            this.BackColer.Click += new System.EventHandler(this.BackColer_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 56);
            // 
            // WordWrap
            // 
            this.WordWrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WordWrap.Image = ((System.Drawing.Image)(resources.GetObject("WordWrap.Image")));
            this.WordWrap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.WordWrap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WordWrap.Name = "WordWrap";
            this.WordWrap.Size = new System.Drawing.Size(44, 53);
            this.WordWrap.Text = "On";
            this.WordWrap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.WordWrap.Click += new System.EventHandler(this.WordWrap_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 449);
            this.Controls.Add(this.NotepadText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotpadControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notepad";
            this.Text = "SHEMY Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.NotpadControl.ResumeLayout(false);
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.FileSetting.ResumeLayout(false);
            this.FileSetting.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.EditTools.ResumeLayout(false);
            this.EditTools.PerformLayout();
            this.Seartch.ResumeLayout(false);
            this.Seartch.PerformLayout();
            this.EditSetting.ResumeLayout(false);
            this.EditSetting.PerformLayout();
            this.TextEdit.ResumeLayout(false);
            this.TextEdit.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotepadText;
        private System.Windows.Forms.ColorDialog TextColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TabPage TextEdit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton FontColer;
        private System.Windows.Forms.ToolStripButton FontFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BackColer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton WordWrap;
        private System.Windows.Forms.TabPage Seartch;
        private System.Windows.Forms.ToolStrip EditSetting;
        private System.Windows.Forms.TabPage File;
        private System.Windows.Forms.ToolStrip FileSetting;
        private System.Windows.Forms.ToolStripButton NewFile;
        private System.Windows.Forms.ToolStripButton OpenFile;
        private System.Windows.Forms.ToolStripButton SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton NewTab;
        private Ambiance.Ambiance_TabControl NotpadControl;
        private System.Windows.Forms.ToolStripButton Find;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Print;
        private System.Windows.Forms.ColorDialog BackColor;
        private System.Windows.Forms.ToolStripTextBox Researtch;
        private System.Windows.Forms.ToolStripLabel Resulat;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox Replace;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.ToolStrip EditTools;
        private System.Windows.Forms.ToolStripButton Past;
        private System.Windows.Forms.ToolStripButton Cut;
        private System.Windows.Forms.ToolStripButton Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Selectall;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.ToolStripButton Undo;
        private System.Windows.Forms.OpenFileDialog OpenText;
        private System.Windows.Forms.SaveFileDialog SaveText;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label1;
    }
}

