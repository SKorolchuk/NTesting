namespace NTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.ThemeList = new System.Windows.Forms.ListBox();
            this.Group = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.ThemeInfo = new System.Windows.Forms.TabControl();
            this.Section = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Description = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Selectbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.statisticViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ThemeInfo.SuspendLayout();
            this.Section.SuspendLayout();
            this.Description.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addThemeToolStripMenuItem,
            this.removeThemeToolStripMenuItem,
            this.updateListToolStripMenuItem,
            this.statisticViewerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // addThemeToolStripMenuItem
            // 
            this.addThemeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addThemeToolStripMenuItem.Name = "addThemeToolStripMenuItem";
            this.addThemeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addThemeToolStripMenuItem.Text = "Add Theme...";
            this.addThemeToolStripMenuItem.Click += new System.EventHandler(this.AddThemeToolStripMenuItemClick);
            // 
            // removeThemeToolStripMenuItem
            // 
            this.removeThemeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.removeThemeToolStripMenuItem.Name = "removeThemeToolStripMenuItem";
            this.removeThemeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.removeThemeToolStripMenuItem.Text = "Remove Selected Theme...";
            this.removeThemeToolStripMenuItem.Click += new System.EventHandler(this.RemoveThemeToolStripMenuItemClick);
            // 
            // updateListToolStripMenuItem
            // 
            this.updateListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateListToolStripMenuItem.Name = "updateListToolStripMenuItem";
            this.updateListToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.updateListToolStripMenuItem.Text = "Update List...";
            this.updateListToolStripMenuItem.Click += new System.EventHandler(this.UpdateListToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(202, 31);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(266, 20);
            this.FirstName.TabIndex = 0;
            // 
            // ThemeList
            // 
            this.ThemeList.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeList.FormattingEnabled = true;
            this.ThemeList.ItemHeight = 22;
            this.ThemeList.Location = new System.Drawing.Point(31, 150);
            this.ThemeList.Name = "ThemeList";
            this.ThemeList.Size = new System.Drawing.Size(354, 180);
            this.ThemeList.TabIndex = 3;
            this.ThemeList.SelectedIndexChanged += new System.EventHandler(this.ThemeListSelectedIndexChanged);
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(202, 83);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(68, 20);
            this.Group.TabIndex = 2;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(202, 57);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(266, 20);
            this.LastName.TabIndex = 1;
            // 
            // ThemeInfo
            // 
            this.ThemeInfo.Controls.Add(this.Section);
            this.ThemeInfo.Controls.Add(this.Description);
            this.ThemeInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeInfo.Location = new System.Drawing.Point(391, 124);
            this.ThemeInfo.Name = "ThemeInfo";
            this.ThemeInfo.SelectedIndex = 0;
            this.ThemeInfo.Size = new System.Drawing.Size(186, 206);
            this.ThemeInfo.TabIndex = 6;
            // 
            // Section
            // 
            this.Section.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Section.Controls.Add(this.richTextBox1);
            this.Section.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Section.Location = new System.Drawing.Point(4, 29);
            this.Section.Name = "Section";
            this.Section.Padding = new System.Windows.Forms.Padding(3);
            this.Section.Size = new System.Drawing.Size(178, 173);
            this.Section.TabIndex = 0;
            this.Section.Text = "Section";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(166, 161);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Description.Controls.Add(this.richTextBox2);
            this.Description.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(4, 29);
            this.Description.Name = "Description";
            this.Description.Padding = new System.Windows.Forms.Padding(3);
            this.Description.Size = new System.Drawing.Size(178, 173);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Location = new System.Drawing.Point(6, 6);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(166, 161);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(110, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(113, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(143, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(198, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Theme List";
            // 
            // Selectbtn
            // 
            this.Selectbtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Selectbtn.Location = new System.Drawing.Point(297, 338);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(88, 36);
            this.Selectbtn.TabIndex = 4;
            this.Selectbtn.Text = "Select";
            this.Selectbtn.UseVisualStyleBackColor = true;
            this.Selectbtn.Click += new System.EventHandler(this.SelectbtnClick);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exitbtn.Location = new System.Drawing.Point(395, 338);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(88, 36);
            this.Exitbtn.TabIndex = 7;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
            // 
            // statisticViewerToolStripMenuItem
            // 
            this.statisticViewerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statisticViewerToolStripMenuItem.Name = "statisticViewerToolStripMenuItem";
            this.statisticViewerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.statisticViewerToolStripMenuItem.Text = "Statistic Viewer";
            this.statisticViewerToolStripMenuItem.Click += new System.EventHandler(this.StatisticViewerToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(589, 384);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Selectbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemeInfo);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.ThemeList);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "NTest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ThemeInfo.ResumeLayout(false);
            this.Section.ResumeLayout(false);
            this.Description.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.ListBox ThemeList;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TabControl ThemeInfo;
        private System.Windows.Forms.TabPage Section;
        private System.Windows.Forms.TabPage Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripMenuItem statisticViewerToolStripMenuItem;

    }
}

