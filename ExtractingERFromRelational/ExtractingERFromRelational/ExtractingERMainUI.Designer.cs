namespace ExtractingERFromRelational
{
    partial class ExtractingERMainUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.relationsDataGrid = new System.Windows.Forms.DataGridView();
            this.reverseEngineer = new System.Windows.Forms.Button();
            this.stage_2_ForeignKey_button = new System.Windows.Forms.Button();
            this.stage_3_Weak_Entities_Button = new System.Windows.Forms.Button();
            this.stage_4_Relations_Button = new System.Windows.Forms.Button();
            this.functionalDependencies = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.relationsDataGrid);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 205);
            this.panel1.TabIndex = 1;
            // 
            // relationsDataGrid
            // 
            this.relationsDataGrid.AllowUserToAddRows = false;
            this.relationsDataGrid.AllowUserToDeleteRows = false;
            this.relationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relationsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relationsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.relationsDataGrid.Name = "relationsDataGrid";
            this.relationsDataGrid.ReadOnly = true;
            this.relationsDataGrid.Size = new System.Drawing.Size(715, 205);
            this.relationsDataGrid.TabIndex = 0;
            // 
            // reverseEngineer
            // 
            this.reverseEngineer.Location = new System.Drawing.Point(12, 22);
            this.reverseEngineer.Name = "reverseEngineer";
            this.reverseEngineer.Size = new System.Drawing.Size(162, 23);
            this.reverseEngineer.TabIndex = 5;
            this.reverseEngineer.Text = "Stage-1 Entity Identification";
            this.reverseEngineer.UseVisualStyleBackColor = true;
            this.reverseEngineer.Click += new System.EventHandler(this.stage_1_Entities_Identification_Click);
            // 
            // stage_2_ForeignKey_button
            // 
            this.stage_2_ForeignKey_button.Location = new System.Drawing.Point(180, 22);
            this.stage_2_ForeignKey_button.Name = "stage_2_ForeignKey_button";
            this.stage_2_ForeignKey_button.Size = new System.Drawing.Size(117, 23);
            this.stage_2_ForeignKey_button.TabIndex = 6;
            this.stage_2_ForeignKey_button.Text = "Stage-2 Foreign Key";
            this.stage_2_ForeignKey_button.UseVisualStyleBackColor = true;
            this.stage_2_ForeignKey_button.Click += new System.EventHandler(this.stage_2_ForeignKey_button_Click);
            // 
            // stage_3_Weak_Entities_Button
            // 
            this.stage_3_Weak_Entities_Button.Location = new System.Drawing.Point(303, 22);
            this.stage_3_Weak_Entities_Button.Name = "stage_3_Weak_Entities_Button";
            this.stage_3_Weak_Entities_Button.Size = new System.Drawing.Size(127, 23);
            this.stage_3_Weak_Entities_Button.TabIndex = 7;
            this.stage_3_Weak_Entities_Button.Text = "Stage-3 Weak Entites";
            this.stage_3_Weak_Entities_Button.UseVisualStyleBackColor = true;
            this.stage_3_Weak_Entities_Button.Click += new System.EventHandler(this.stage_3_Weak_Entities_Button_Click);
            // 
            // stage_4_Relations_Button
            // 
            this.stage_4_Relations_Button.Location = new System.Drawing.Point(436, 22);
            this.stage_4_Relations_Button.Name = "stage_4_Relations_Button";
            this.stage_4_Relations_Button.Size = new System.Drawing.Size(127, 23);
            this.stage_4_Relations_Button.TabIndex = 8;
            this.stage_4_Relations_Button.Text = "Stage-4 Relations";
            this.stage_4_Relations_Button.UseVisualStyleBackColor = true;
            this.stage_4_Relations_Button.Click += new System.EventHandler(this.stage_4_Relations_Button_Click);
            // 
            // functionalDependencies
            // 
            this.functionalDependencies.Location = new System.Drawing.Point(587, 21);
            this.functionalDependencies.Name = "functionalDependencies";
            this.functionalDependencies.Size = new System.Drawing.Size(140, 23);
            this.functionalDependencies.TabIndex = 9;
            this.functionalDependencies.Text = "Functional Dependencies";
            this.functionalDependencies.UseVisualStyleBackColor = true;
            this.functionalDependencies.Click += new System.EventHandler(this.functionalDependencies_Click);
            // 
            // ExtractingERMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 266);
            this.Controls.Add(this.functionalDependencies);
            this.Controls.Add(this.stage_4_Relations_Button);
            this.Controls.Add(this.stage_3_Weak_Entities_Button);
            this.Controls.Add(this.stage_2_ForeignKey_button);
            this.Controls.Add(this.reverseEngineer);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ExtractingERMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ER-To-Relational-Model";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relationsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView relationsDataGrid;
        private System.Windows.Forms.Button reverseEngineer;
        private System.Windows.Forms.Button stage_2_ForeignKey_button;
        private System.Windows.Forms.Button stage_3_Weak_Entities_Button;
        private System.Windows.Forms.Button stage_4_Relations_Button;
        private System.Windows.Forms.Button functionalDependencies;
    }
}

