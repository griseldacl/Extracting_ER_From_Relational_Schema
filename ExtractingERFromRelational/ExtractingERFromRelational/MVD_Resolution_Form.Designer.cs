namespace ExtractingERFromRelational
{
    partial class MVD_Resolution_Form
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
            this.weakEntitiesListBox = new System.Windows.Forms.ListBox();
            this.moveToMVDButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mvdListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weak Entities";
            // 
            // weakEntitiesListBox
            // 
            this.weakEntitiesListBox.FormattingEnabled = true;
            this.weakEntitiesListBox.Location = new System.Drawing.Point(16, 30);
            this.weakEntitiesListBox.Name = "weakEntitiesListBox";
            this.weakEntitiesListBox.Size = new System.Drawing.Size(120, 147);
            this.weakEntitiesListBox.TabIndex = 1;
            // 
            // moveToMVDButton
            // 
            this.moveToMVDButton.Location = new System.Drawing.Point(161, 92);
            this.moveToMVDButton.Name = "moveToMVDButton";
            this.moveToMVDButton.Size = new System.Drawing.Size(61, 23);
            this.moveToMVDButton.TabIndex = 2;
            this.moveToMVDButton.Text = ">>";
            this.moveToMVDButton.UseVisualStyleBackColor = true;
            this.moveToMVDButton.Click += new System.EventHandler(this.moveToMVD);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Multi Valued Attributes";
            // 
            // mvdListBox
            // 
            this.mvdListBox.FormattingEnabled = true;
            this.mvdListBox.Location = new System.Drawing.Point(248, 30);
            this.mvdListBox.Name = "mvdListBox";
            this.mvdListBox.Size = new System.Drawing.Size(127, 147);
            this.mvdListBox.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(248, 184);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // MVD_Resolution_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 219);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.mvdListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moveToMVDButton);
            this.Controls.Add(this.weakEntitiesListBox);
            this.Controls.Add(this.label1);
            this.Name = "MVD_Resolution_Form";
            this.Text = "MVD_Resolution_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox weakEntitiesListBox;
        private System.Windows.Forms.Button moveToMVDButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox mvdListBox;
        private System.Windows.Forms.Button okButton;
    }
}