namespace ExtractingERFromRelational
{
    partial class FunctionalDep
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
            this.listBoxAttr = new System.Windows.Forms.ListBox();
            this.buttonAddLHS = new System.Windows.Forms.Button();
            this.listBoxLHS = new System.Windows.Forms.ListBox();
            this.listBoxRHS = new System.Windows.Forms.ListBox();
            this.buttonAddRHS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddFD = new System.Windows.Forms.Button();
            this.listBoxFDs = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attributes";
            // 
            // listBoxAttr
            // 
            this.listBoxAttr.FormattingEnabled = true;
            this.listBoxAttr.Location = new System.Drawing.Point(10, 32);
            this.listBoxAttr.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAttr.Name = "listBoxAttr";
            this.listBoxAttr.Size = new System.Drawing.Size(146, 251);
            this.listBoxAttr.TabIndex = 1;
            // 
            // buttonAddLHS
            // 
            this.buttonAddLHS.Location = new System.Drawing.Point(165, 83);
            this.buttonAddLHS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddLHS.Name = "buttonAddLHS";
            this.buttonAddLHS.Size = new System.Drawing.Size(62, 38);
            this.buttonAddLHS.TabIndex = 2;
            this.buttonAddLHS.Text = ">>";
            this.buttonAddLHS.UseVisualStyleBackColor = true;
            this.buttonAddLHS.Click += new System.EventHandler(this.buttonAddLHS_Click);
            // 
            // listBoxLHS
            // 
            this.listBoxLHS.FormattingEnabled = true;
            this.listBoxLHS.Location = new System.Drawing.Point(243, 45);
            this.listBoxLHS.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLHS.Name = "listBoxLHS";
            this.listBoxLHS.Size = new System.Drawing.Size(126, 95);
            this.listBoxLHS.TabIndex = 3;
            // 
            // listBoxRHS
            // 
            this.listBoxRHS.FormattingEnabled = true;
            this.listBoxRHS.Location = new System.Drawing.Point(243, 177);
            this.listBoxRHS.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxRHS.Name = "listBoxRHS";
            this.listBoxRHS.Size = new System.Drawing.Size(126, 95);
            this.listBoxRHS.TabIndex = 5;
            // 
            // buttonAddRHS
            // 
            this.buttonAddRHS.Location = new System.Drawing.Point(167, 210);
            this.buttonAddRHS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRHS.Name = "buttonAddRHS";
            this.buttonAddRHS.Size = new System.Drawing.Size(61, 38);
            this.buttonAddRHS.TabIndex = 4;
            this.buttonAddRHS.Text = ">>";
            this.buttonAddRHS.UseVisualStyleBackColor = true;
            this.buttonAddRHS.Click += new System.EventHandler(this.buttonAddRHS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LHS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RHS";
            // 
            // buttonAddFD
            // 
            this.buttonAddFD.Location = new System.Drawing.Point(399, 137);
            this.buttonAddFD.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddFD.Name = "buttonAddFD";
            this.buttonAddFD.Size = new System.Drawing.Size(80, 38);
            this.buttonAddFD.TabIndex = 8;
            this.buttonAddFD.Text = "Add FD >";
            this.buttonAddFD.UseVisualStyleBackColor = true;
            this.buttonAddFD.Click += new System.EventHandler(this.buttonAddFD_Click);
            // 
            // listBoxFDs
            // 
            this.listBoxFDs.FormattingEnabled = true;
            this.listBoxFDs.HorizontalScrollbar = true;
            this.listBoxFDs.Location = new System.Drawing.Point(497, 32);
            this.listBoxFDs.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFDs.Name = "listBoxFDs";
            this.listBoxFDs.Size = new System.Drawing.Size(267, 251);
            this.listBoxFDs.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Functional Dependencies";
            // 
            // FunctionalDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 293);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxFDs);
            this.Controls.Add(this.buttonAddFD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxRHS);
            this.Controls.Add(this.buttonAddRHS);
            this.Controls.Add(this.listBoxLHS);
            this.Controls.Add(this.buttonAddLHS);
            this.Controls.Add(this.listBoxAttr);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FunctionalDep";
            this.Text = "FunctionalDep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAttr;
        private System.Windows.Forms.Button buttonAddLHS;
        private System.Windows.Forms.ListBox listBoxLHS;
        private System.Windows.Forms.ListBox listBoxRHS;
        private System.Windows.Forms.Button buttonAddRHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddFD;
        private System.Windows.Forms.ListBox listBoxFDs;
        private System.Windows.Forms.Label label4;
    }
}