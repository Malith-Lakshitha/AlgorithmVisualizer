namespace AlgorithmVisualizer
{
    partial class PathfindingForm
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
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.rbPlaceStart = new System.Windows.Forms.RadioButton();
            this.rbPlaceEnd = new System.Windows.Forms.RadioButton();
            this.rbDrawWall = new System.Windows.Forms.RadioButton();
            this.rbErase = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(385, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pathfinding Visualizer — BFS";
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.ForeColor = System.Drawing.Color.Black;
            this.panelGrid.Location = new System.Drawing.Point(13, 62);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(901, 522);
            this.panelGrid.TabIndex = 1;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            this.panelGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseDown);
            this.panelGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseMove);
            this.panelGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseUp);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(1019, 165);
            this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(134, 25);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "Mouse Mode:";
            // 
            // rbPlaceStart
            // 
            this.rbPlaceStart.AutoSize = true;
            this.rbPlaceStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlaceStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.rbPlaceStart.Location = new System.Drawing.Point(1047, 242);
            this.rbPlaceStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPlaceStart.Name = "rbPlaceStart";
            this.rbPlaceStart.Size = new System.Drawing.Size(139, 27);
            this.rbPlaceStart.TabIndex = 4;
            this.rbPlaceStart.Text = "Place Start tile";
            this.rbPlaceStart.UseVisualStyleBackColor = true;
            this.rbPlaceStart.CheckedChanged += new System.EventHandler(this.rbPlaceStart_CheckedChanged);
            // 
            // rbPlaceEnd
            // 
            this.rbPlaceEnd.AutoSize = true;
            this.rbPlaceEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlaceEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rbPlaceEnd.Location = new System.Drawing.Point(1047, 293);
            this.rbPlaceEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPlaceEnd.Name = "rbPlaceEnd";
            this.rbPlaceEnd.Size = new System.Drawing.Size(133, 27);
            this.rbPlaceEnd.TabIndex = 5;
            this.rbPlaceEnd.Text = "Place End tile";
            this.rbPlaceEnd.UseVisualStyleBackColor = true;
            this.rbPlaceEnd.CheckedChanged += new System.EventHandler(this.rbPlaceEnd_CheckedChanged);
            // 
            // rbDrawWall
            // 
            this.rbDrawWall.AutoSize = true;
            this.rbDrawWall.Checked = true;
            this.rbDrawWall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawWall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.rbDrawWall.Location = new System.Drawing.Point(1047, 339);
            this.rbDrawWall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDrawWall.Name = "rbDrawWall";
            this.rbDrawWall.Size = new System.Drawing.Size(164, 27);
            this.rbDrawWall.TabIndex = 6;
            this.rbDrawWall.TabStop = true;
            this.rbDrawWall.Text = "Draw Walls (drag)";
            this.rbDrawWall.UseVisualStyleBackColor = true;
            this.rbDrawWall.CheckedChanged += new System.EventHandler(this.rbDrawWall_CheckedChanged);
            // 
            // rbErase
            // 
            this.rbErase.AutoSize = true;
            this.rbErase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbErase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.rbErase.Location = new System.Drawing.Point(1047, 392);
            this.rbErase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbErase.Name = "rbErase";
            this.rbErase.Size = new System.Drawing.Size(106, 27);
            this.rbErase.TabIndex = 7;
            this.rbErase.Text = "Erase tiles";
            this.rbErase.UseVisualStyleBackColor = true;
            this.rbErase.CheckedChanged += new System.EventHandler(this.rbErase_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(46, 632);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(213, 52);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "▶ Start BFS";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(330, 632);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(213, 52);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "↺ Clear Grid";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(599, 632);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(213, 52);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "⚙ Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 825);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(281, 20);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Place Start and End tiles, then draw walls.";
            // 
            // PathfindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1269, 912);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rbErase);
            this.Controls.Add(this.rbDrawWall);
            this.Controls.Add(this.rbPlaceEnd);
            this.Controls.Add(this.rbPlaceStart);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PathfindingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pathfinding Visualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.RadioButton rbPlaceStart;
        private System.Windows.Forms.RadioButton rbPlaceEnd;
        private System.Windows.Forms.RadioButton rbDrawWall;
        private System.Windows.Forms.RadioButton rbErase;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblStatus;
    }
}