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
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attributes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxAttr
            // 
            this.listBoxAttr.FormattingEnabled = true;
            this.listBoxAttr.ItemHeight = 16;
            this.listBoxAttr.Location = new System.Drawing.Point(14, 40);
            this.listBoxAttr.Name = "listBoxAttr";
            this.listBoxAttr.Size = new System.Drawing.Size(143, 308);
            this.listBoxAttr.TabIndex = 1;
            // 
            // buttonAddLHS
            // 
            this.buttonAddLHS.Location = new System.Drawing.Point(184, 100);
            this.buttonAddLHS.Name = "buttonAddLHS";
            this.buttonAddLHS.Size = new System.Drawing.Size(82, 47);
            this.buttonAddLHS.TabIndex = 2;
            this.buttonAddLHS.Text = ">>";
            this.buttonAddLHS.UseVisualStyleBackColor = true;
            // 
            // listBoxLHS
            // 
            this.listBoxLHS.FormattingEnabled = true;
            this.listBoxLHS.ItemHeight = 16;
            this.listBoxLHS.Location = new System.Drawing.Point(299, 58);
            this.listBoxLHS.Name = "listBoxLHS";
            this.listBoxLHS.Size = new System.Drawing.Size(166, 116);
            this.listBoxLHS.TabIndex = 3;
            // 
            // listBoxRHS
            // 
            this.listBoxRHS.FormattingEnabled = true;
            this.listBoxRHS.ItemHeight = 16;
            this.listBoxRHS.Location = new System.Drawing.Point(300, 219);
            this.listBoxRHS.Name = "listBoxRHS";
            this.listBoxRHS.Size = new System.Drawing.Size(166, 116);
            this.listBoxRHS.TabIndex = 5;
            // 
            // buttonAddRHS
            // 
            this.buttonAddRHS.Location = new System.Drawing.Point(185, 254);
            this.buttonAddRHS.Name = "buttonAddRHS";
            this.buttonAddRHS.Size = new System.Drawing.Size(81, 47);
            this.buttonAddRHS.TabIndex = 4;
            this.buttonAddRHS.Text = ">>";
            this.buttonAddRHS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "LHS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "RHS";
            // 
            // buttonAddFD
            // 
            this.buttonAddFD.Location = new System.Drawing.Point(495, 169);
            this.buttonAddFD.Name = "buttonAddFD";
            this.buttonAddFD.Size = new System.Drawing.Size(106, 47);
            this.buttonAddFD.TabIndex = 8;
            this.buttonAddFD.Text = "Add FD >";
            this.buttonAddFD.UseVisualStyleBackColor = true;
            // 
            // listBoxFDs
            // 
            this.listBoxFDs.FormattingEnabled = true;
            this.listBoxFDs.ItemHeight = 16;
            this.listBoxFDs.Location = new System.Drawing.Point(624, 40);
            this.listBoxFDs.Name = "listBoxFDs";
            this.listBoxFDs.Size = new System.Drawing.Size(320, 308);
            this.listBoxFDs.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Functional Dependencies";
            // 
            // FunctionalDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 361);
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