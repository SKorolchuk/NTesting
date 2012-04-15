namespace NTest.TestProcessing_files
{
    partial class ProcessingTestForm
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
            this.TimeLabel = new System.Windows.Forms.Label();
            this.VariantList = new System.Windows.Forms.ListBox();
            this.QuestionText = new System.Windows.Forms.RichTextBox();
            this.AnswerText = new System.Windows.Forms.RichTextBox();
            this.TrueSelector = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(21, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elapsed Time:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Enabled = false;
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLabel.Location = new System.Drawing.Point(102, 325);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(30, 13);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Time";
            // 
            // VariantList
            // 
            this.VariantList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VariantList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VariantList.Enabled = false;
            this.VariantList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariantList.ForeColor = System.Drawing.SystemColors.Info;
            this.VariantList.FormattingEnabled = true;
            this.VariantList.ItemHeight = 20;
            this.VariantList.Location = new System.Drawing.Point(24, 90);
            this.VariantList.Name = "VariantList";
            this.VariantList.Size = new System.Drawing.Size(190, 220);
            this.VariantList.TabIndex = 3;
            this.VariantList.SelectedIndexChanged += new System.EventHandler(this.VariantListSelectedIndexChanged);
            // 
            // QuestionText
            // 
            this.QuestionText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QuestionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionText.Enabled = false;
            this.QuestionText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionText.ForeColor = System.Drawing.SystemColors.Window;
            this.QuestionText.Location = new System.Drawing.Point(24, 42);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(571, 42);
            this.QuestionText.TabIndex = 4;
            this.QuestionText.Text = "";
            // 
            // AnswerText
            // 
            this.AnswerText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AnswerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerText.Enabled = false;
            this.AnswerText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerText.ForeColor = System.Drawing.SystemColors.Window;
            this.AnswerText.Location = new System.Drawing.Point(221, 117);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(374, 167);
            this.AnswerText.TabIndex = 5;
            this.AnswerText.Text = "";
            // 
            // TrueSelector
            // 
            this.TrueSelector.AutoSize = true;
            this.TrueSelector.Enabled = false;
            this.TrueSelector.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrueSelector.Location = new System.Drawing.Point(221, 292);
            this.TrueSelector.Name = "TrueSelector";
            this.TrueSelector.Size = new System.Drawing.Size(143, 20);
            this.TrueSelector.TabIndex = 6;
            this.TrueSelector.Text = "Select Answer as True...";
            this.TrueSelector.UseVisualStyleBackColor = true;
            this.TrueSelector.CheckedChanged += new System.EventHandler(this.TrueSelectorCheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(220, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected variant is";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(500, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // ProcessingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(621, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrueSelector);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.VariantList);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessingTestForm";
            this.ShowIcon = false;
            this.Text = "NTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.ListBox VariantList;
        private System.Windows.Forms.RichTextBox QuestionText;
        private System.Windows.Forms.RichTextBox AnswerText;
        private System.Windows.Forms.CheckBox TrueSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}