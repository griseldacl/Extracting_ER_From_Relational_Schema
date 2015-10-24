namespace ExtractingERFromRelational
{
    partial class AddRelationForm
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
            this.relationNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newAttributeNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newAttributeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setAsPrimaryKeyButton = new System.Windows.Forms.Button();
            this.deleteAttributeButton = new System.Windows.Forms.Button();
            this.addNewAttributeButton = new System.Windows.Forms.Button();
            this.attributesListBox = new System.Windows.Forms.ListBox();
            this.addRelationButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relation Name";
            // 
            // relationNameTextBox
            // 
            this.relationNameTextBox.Location = new System.Drawing.Point(96, 21);
            this.relationNameTextBox.Name = "relationNameTextBox";
            this.relationNameTextBox.Size = new System.Drawing.Size(310, 20);
            this.relationNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Attribute";
            // 
            // newAttributeNameTextBox
            // 
            this.newAttributeNameTextBox.Location = new System.Drawing.Point(96, 55);
            this.newAttributeNameTextBox.Name = "newAttributeNameTextBox";
            this.newAttributeNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.newAttributeNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // newAttributeTypeComboBox
            // 
            this.newAttributeTypeComboBox.FormattingEnabled = true;
            this.newAttributeTypeComboBox.Location = new System.Drawing.Point(285, 55);
            this.newAttributeTypeComboBox.Name = "newAttributeTypeComboBox";
            this.newAttributeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.newAttributeTypeComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Attributes";
            // 
            // setAsPrimaryKeyButton
            // 
            this.setAsPrimaryKeyButton.Location = new System.Drawing.Point(251, 102);
            this.setAsPrimaryKeyButton.Name = "setAsPrimaryKeyButton";
            this.setAsPrimaryKeyButton.Size = new System.Drawing.Size(104, 31);
            this.setAsPrimaryKeyButton.TabIndex = 8;
            this.setAsPrimaryKeyButton.Text = "Set As Primary Key";
            this.setAsPrimaryKeyButton.UseVisualStyleBackColor = true;
            // 
            // deleteAttributeButton
            // 
            this.deleteAttributeButton.Location = new System.Drawing.Point(251, 144);
            this.deleteAttributeButton.Name = "deleteAttributeButton";
            this.deleteAttributeButton.Size = new System.Drawing.Size(104, 31);
            this.deleteAttributeButton.TabIndex = 9;
            this.deleteAttributeButton.Text = "Delete Attribute";
            this.deleteAttributeButton.UseVisualStyleBackColor = true;
            // 
            // addNewAttributeButton
            // 
            this.addNewAttributeButton.Location = new System.Drawing.Point(412, 55);
            this.addNewAttributeButton.Name = "addNewAttributeButton";
            this.addNewAttributeButton.Size = new System.Drawing.Size(75, 23);
            this.addNewAttributeButton.TabIndex = 10;
            this.addNewAttributeButton.Text = "Add";
            this.addNewAttributeButton.UseVisualStyleBackColor = true;
            // 
            // attributesListBox
            // 
            this.attributesListBox.FormattingEnabled = true;
            this.attributesListBox.Location = new System.Drawing.Point(96, 93);
            this.attributesListBox.Name = "attributesListBox";
            this.attributesListBox.Size = new System.Drawing.Size(149, 95);
            this.attributesListBox.TabIndex = 11;
            // 
            // addRelationButton
            // 
            this.addRelationButton.Location = new System.Drawing.Point(189, 217);
            this.addRelationButton.Name = "addRelationButton";
            this.addRelationButton.Size = new System.Drawing.Size(75, 23);
            this.addRelationButton.TabIndex = 12;
            this.addRelationButton.Text = "OK";
            this.addRelationButton.UseVisualStyleBackColor = true;
            this.addRelationButton.Click += new System.EventHandler(this.addRelationButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(270, 217);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 252);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addRelationButton);
            this.Controls.Add(this.attributesListBox);
            this.Controls.Add(this.addNewAttributeButton);
            this.Controls.Add(this.deleteAttributeButton);
            this.Controls.Add(this.setAsPrimaryKeyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newAttributeTypeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newAttributeNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.relationNameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddRelationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Relation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox relationNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newAttributeNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox newAttributeTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setAsPrimaryKeyButton;
        private System.Windows.Forms.Button deleteAttributeButton;
        private System.Windows.Forms.Button addNewAttributeButton;
        private System.Windows.Forms.ListBox attributesListBox;
        private System.Windows.Forms.Button addRelationButton;
        private System.Windows.Forms.Button cancelButton;
    }
}