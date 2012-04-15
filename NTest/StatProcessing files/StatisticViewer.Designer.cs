namespace NTest.StatProcessing_files
{
    partial class StatisticViewer
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
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.InfoText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultListBox
            // 
            this.ResultListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResultListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 20;
            this.ResultListBox.Location = new System.Drawing.Point(12, 43);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(453, 320);
            this.ResultListBox.TabIndex = 0;
            this.ResultListBox.SelectedIndexChanged += new System.EventHandler(this.ResultListBoxSelectedIndexChanged);
            // 
            // InfoText
            // 
            this.InfoText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoText.Location = new System.Drawing.Point(485, 43);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(327, 306);
            this.InfoText.TabIndex = 1;
            this.InfoText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(153, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Completed Test List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(583, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Info About Result";
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBTN.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveBTN.Location = new System.Drawing.Point(332, 365);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(133, 42);
            this.RemoveBTN.TabIndex = 4;
            this.RemoveBTN.Text = "Remove";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBtnClick);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBTN.Location = new System.Drawing.Point(679, 355);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(148, 60);
            this.ExitBTN.TabIndex = 5;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // StatisticViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(824, 413);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.ResultListBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StatisticViewer";
            this.ShowIcon = false;
            this.Text = "Statistics Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.RichTextBox InfoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Button ExitBTN;
    }
}