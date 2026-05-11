namespace AlgorithmVisualizer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSorting = new System.Windows.Forms.Button();
            this.btnPathfinding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(174, 59);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Algorithm Visualizer";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSorting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorting.FlatAppearance.BorderSize = 0;
            this.btnSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorting.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnSorting.ForeColor = System.Drawing.Color.Transparent;
            this.btnSorting.Location = new System.Drawing.Point(220, 153);
            this.btnSorting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(302, 110);
            this.btnSorting.TabIndex = 2;
            this.btnSorting.Text = "Sorting Visualizer";
            this.btnSorting.UseVisualStyleBackColor = false;
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // btnPathfinding
            // 
            this.btnPathfinding.BackColor = System.Drawing.Color.Red;
            this.btnPathfinding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathfinding.FlatAppearance.BorderSize = 0;
            this.btnPathfinding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathfinding.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnPathfinding.Location = new System.Drawing.Point(220, 312);
            this.btnPathfinding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPathfinding.Name = "btnPathfinding";
            this.btnPathfinding.Size = new System.Drawing.Size(302, 104);
            this.btnPathfinding.TabIndex = 3;
            this.btnPathfinding.Text = "Pathfinding Visualizer";
            this.btnPathfinding.UseVisualStyleBackColor = false;
            this.btnPathfinding.Click += new System.EventHandler(this.btnPathfinding_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 469);
            this.Controls.Add(this.btnPathfinding);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorithm Visualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSorting;
        private System.Windows.Forms.Button btnPathfinding;
    }
}   