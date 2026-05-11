namespace AlgorithmVisualizer
{
    partial class SettingsForm
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
            this.lblSpeedTitle = new System.Windows.Forms.Label();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.lblArraySize = new System.Windows.Forms.Label();
            this.numArraySize = new System.Windows.Forms.NumericUpDown();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.lblCols = new System.Windows.Forms.Label();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArraySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpeedTitle
            // 
            this.lblSpeedTitle.AutoSize = true;
            this.lblSpeedTitle.ForeColor = System.Drawing.Color.White;
            this.lblSpeedTitle.Location = new System.Drawing.Point(27, 25);
            this.lblSpeedTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeedTitle.Name = "lblSpeedTitle";
            this.lblSpeedTitle.Size = new System.Drawing.Size(113, 16);
            this.lblSpeedTitle.TabIndex = 0;
            this.lblSpeedTitle.Text = "Animation Speed:";
            // 
            // trkSpeed
            // 
            this.trkSpeed.AllowDrop = true;
            this.trkSpeed.BackColor = System.Drawing.Color.White;
            this.trkSpeed.Location = new System.Drawing.Point(27, 62);
            this.trkSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkSpeed.Maximum = 500;
            this.trkSpeed.Minimum = 10;
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(400, 56);
            this.trkSpeed.TabIndex = 1;
            this.trkSpeed.TickFrequency = 50;
            this.trkSpeed.Value = 100;
            this.trkSpeed.Scroll += new System.EventHandler(this.trkSpeed_Scroll);
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.AutoSize = true;
            this.lblSpeedValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(130)))));
            this.lblSpeedValue.Location = new System.Drawing.Point(27, 123);
            this.lblSpeedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(139, 23);
            this.lblSpeedValue.TabIndex = 2;
            this.lblSpeedValue.Text = "100 ms per step";
            // 
            // lblArraySize
            // 
            this.lblArraySize.AutoSize = true;
            this.lblArraySize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArraySize.ForeColor = System.Drawing.Color.White;
            this.lblArraySize.Location = new System.Drawing.Point(27, 178);
            this.lblArraySize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArraySize.Name = "lblArraySize";
            this.lblArraySize.Size = new System.Drawing.Size(172, 23);
            this.lblArraySize.TabIndex = 3;
            this.lblArraySize.Text = "Array Size (10–100):";
            // 
            // numArraySize
            // 
            this.numArraySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numArraySize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numArraySize.ForeColor = System.Drawing.Color.White;
            this.numArraySize.Location = new System.Drawing.Point(27, 209);
            this.numArraySize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numArraySize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numArraySize.Name = "numArraySize";
            this.numArraySize.Size = new System.Drawing.Size(133, 32);
            this.numArraySize.TabIndex = 4;
            this.numArraySize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridSize.ForeColor = System.Drawing.Color.White;
            this.lblGridSize.Location = new System.Drawing.Point(27, 178);
            this.lblGridSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(87, 23);
            this.lblGridSize.TabIndex = 5;
            this.lblGridSize.Text = "Grid Size:";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(215)))));
            this.lblRows.Location = new System.Drawing.Point(27, 215);
            this.lblRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(113, 23);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Rows (5–25):";
            // 
            // numRows
            // 
            this.numRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.numRows.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRows.ForeColor = System.Drawing.Color.White;
            this.numRows.Location = new System.Drawing.Point(173, 212);
            this.numRows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numRows.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numRows.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(107, 32);
            this.numRows.TabIndex = 7;
            this.numRows.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCols.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(215)))));
            this.lblCols.Location = new System.Drawing.Point(27, 265);
            this.lblCols.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(104, 23);
            this.lblCols.TabIndex = 8;
            this.lblCols.Text = "Cols (5–25):";
            // 
            // numCols
            // 
            this.numCols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.numCols.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCols.ForeColor = System.Drawing.Color.White;
            this.numCols.Location = new System.Drawing.Point(173, 261);
            this.numCols.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCols.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCols.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCols.Name = "numCols";
            this.numCols.Size = new System.Drawing.Size(107, 32);
            this.numCols.TabIndex = 9;
            this.numCols.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(27, 394);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(187, 49);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "✔ Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(233, 394);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 49);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "x   Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(485, 469);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.numCols);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.numRows);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.numArraySize);
            this.Controls.Add(this.lblArraySize);
            this.Controls.Add(this.lblSpeedValue);
            this.Controls.Add(this.trkSpeed);
            this.Controls.Add(this.lblSpeedTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArraySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeedTitle;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.Label lblArraySize;
        private System.Windows.Forms.NumericUpDown numArraySize;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.NumericUpDown numRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.NumericUpDown numCols;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}