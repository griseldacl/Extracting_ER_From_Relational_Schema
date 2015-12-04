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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addRelationButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.relationsDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.startTransformationButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRelationButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(527, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addRelationButton
            // 
            this.addRelationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addRelationButton.Image = global::ExtractingERFromRelational.Properties.Resources.Add_Icon;
            this.addRelationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRelationButton.Name = "addRelationButton";
            this.addRelationButton.Size = new System.Drawing.Size(24, 24);
            this.addRelationButton.Text = "Add Relation";
            this.addRelationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addRelationButton.Click += new System.EventHandler(this.addRelationButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.relationsDataGrid);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 169);
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
            this.relationsDataGrid.Size = new System.Drawing.Size(499, 169);
            this.relationsDataGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "FK_TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startTransformationButton
            // 
            this.startTransformationButton.Location = new System.Drawing.Point(175, 4);
            this.startTransformationButton.Name = "startTransformationButton";
            this.startTransformationButton.Size = new System.Drawing.Size(141, 23);
            this.startTransformationButton.TabIndex = 4;
            this.startTransformationButton.Text = "Start Transformation";
            this.startTransformationButton.UseVisualStyleBackColor = true;
            this.startTransformationButton.Click += new System.EventHandler(this.startTransformationButton_Click);
            // 
            // ExtractingERMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 253);
            this.Controls.Add(this.startTransformationButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "ExtractingERMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ER-To-Relational-Model";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relationsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addRelationButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView relationsDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startTransformationButton;
    }
}

