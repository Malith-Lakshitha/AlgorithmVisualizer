using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AlgorithmVisualizer.Algorithms;
using AlgorithmVisualizer.Models;

namespace AlgorithmVisualizer
{
    public enum PlacingMode { Start, End, Wall, Erase }

    public partial class PathfindingForm : Form
    {
        private TileType[,] grid;
        private int rows = 20, cols = 20, tileSize = 28;
        private Point startTile = new Point(-1, -1);
        private Point endTile = new Point(-1, -1);
        private PlacingMode placingMode = PlacingMode.Wall;
        private bool mouseIsDown = false;

        private List<PathStep> steps;
        private int currentStep = 0;
        private System.Windows.Forms.Timer animTimer;
        private int animationSpeed = 30;

        public PathfindingForm()
        {
            InitializeComponent();
            SetupTimer();
            InitGrid();
        }

        private void SetupTimer()
        {
            animTimer = new System.Windows.Forms.Timer();
            animTimer.Interval = animationSpeed;
            animTimer.Tick += new EventHandler(AnimTimer_Tick);
        }

        private void InitGrid()
        {
            grid = new TileType[rows, cols];
            startTile = new Point(-1, -1);
            endTile = new Point(-1, -1);
        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            if (grid == null) return;
            Graphics g = e.Graphics;
            g.Clear(Color.FromArgb(12, 12, 20));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Color color = GetTileColor(grid[r, c]);
                    int x = c * tileSize;
                    int y = r * tileSize;
                    using (SolidBrush b = new SolidBrush(color))
                        g.FillRectangle(b, x + 1, y + 1, tileSize - 2, tileSize - 2);
                }
            }

            using (Pen p = new Pen(Color.FromArgb(40, 40, 55)))
            {
                for (int r = 0; r <= rows; r++)
                    g.DrawLine(p, 0, r * tileSize, cols * tileSize, r * tileSize);
                for (int c = 0; c <= cols; c++)
                    g.DrawLine(p, c * tileSize, 0, c * tileSize, rows * tileSize);
            }
        }

        private Color GetTileColor(TileType t)
        {
            switch (t)
            {
                case TileType.Wall: return Color.DimGray;
                case TileType.Start: return Color.LimeGreen;
                case TileType.End: return Color.OrangeRed;
                case TileType.Visited: return Color.LightSkyBlue;
                case TileType.Path: return Color.Yellow;
                default: return Color.FromArgb(40, 40, 55);
            }
        }

        private void panelGrid_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            PlaceTile(e.X, e.Y);
        }

        private void panelGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseIsDown) return;
            PlaceTile(e.X, e.Y);
        }

        private void panelGrid_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void PlaceTile(int mx, int my)
        {
            int col = mx / tileSize;
            int row = my / tileSize;
            if (row < 0 || row >= rows || col < 0 || col >= cols) return;

            switch (placingMode)
            {
                case PlacingMode.Start:
                    if (grid[row, col] == TileType.End) return;
                    if (startTile.X >= 0) grid[startTile.X, startTile.Y] = TileType.Unvisited;
                    startTile = new Point(row, col);
                    grid[row, col] = TileType.Start;
                    break;
                case PlacingMode.End:
                    if (grid[row, col] == TileType.Start) return;
                    if (endTile.X >= 0) grid[endTile.X, endTile.Y] = TileType.Unvisited;
                    endTile = new Point(row, col);
                    grid[row, col] = TileType.End;
                    break;
                case PlacingMode.Wall:
                    if (grid[row, col] == TileType.Unvisited)
                        grid[row, col] = TileType.Wall;
                    break;
                case PlacingMode.Erase:
                    if (grid[row, col] == TileType.Start) startTile = new Point(-1, -1);
                    if (grid[row, col] == TileType.End) endTile = new Point(-1, -1);
                    grid[row, col] = TileType.Unvisited;
                    break;
            }
            panelGrid.Invalidate();
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            if (currentStep >= steps.Count)
            {
                animTimer.Stop();
                bool found = false;
                for (int r = 0; r < rows; r++)
                    for (int c = 0; c < cols; c++)
                        if (grid[r, c] == TileType.Path) found = true;

                lblStatus.Text = found
                    ? "✅ Path found! Yellow = shortest path."
                    : "⚠️ No path found — end is blocked by walls.";

                btnStart.Enabled = btnClear.Enabled = btnSettings.Enabled = true;
                return;
            }

            PathStep step = steps[currentStep];
            if (!step.Node.Equals(startTile) && !step.Node.Equals(endTile))
                grid[step.Node.X, step.Node.Y] = step.IsPath ? TileType.Path : TileType.Visited;

            panelGrid.Invalidate();
            currentStep++;
        }

        private void rbPlaceStart_CheckedChanged(object sender, EventArgs e)
        { if (rbPlaceStart.Checked) placingMode = PlacingMode.Start; }

        private void rbPlaceEnd_CheckedChanged(object sender, EventArgs e)
        { if (rbPlaceEnd.Checked) placingMode = PlacingMode.End; }

        private void rbDrawWall_CheckedChanged(object sender, EventArgs e)
        { if (rbDrawWall.Checked) placingMode = PlacingMode.Wall; }

        private void rbErase_CheckedChanged(object sender, EventArgs e)
        { if (rbErase.Checked) placingMode = PlacingMode.Erase; }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (startTile.X < 0 || endTile.X < 0)
            {
                MessageBox.Show(
                    "Please place both a Start tile and an End tile first!",
                    "Missing Tiles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    if (grid[r, c] == TileType.Visited || grid[r, c] == TileType.Path)
                        grid[r, c] = TileType.Unvisited;

            steps = new BFSPathfinder().GenerateSteps(grid, startTile, endTile, rows, cols);
            currentStep = 0;
            btnStart.Enabled = btnClear.Enabled = btnSettings.Enabled = false;
            lblStatus.Text = "BFS running...";
            animTimer.Interval = animationSpeed;
            animTimer.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            animTimer.Stop();
            InitGrid();
            panelGrid.Invalidate();
            btnStart.Enabled = true;
            lblStatus.Text = "Grid cleared.";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm s = new SettingsForm(
                SettingsMode.Pathfinding, currentSpeed: animationSpeed,
                currentRows: rows, currentCols: cols);

            if (s.ShowDialog() == DialogResult.OK)
            {
                animationSpeed = s.AnimationSpeed;
                rows = s.GridRows;
                cols = s.GridCols;
                tileSize = Math.Max(10, Math.Min(600 / cols, 600 / rows));
                animTimer.Interval = animationSpeed;
                InitGrid();
                panelGrid.Size = new Size(cols * tileSize, rows * tileSize);
                panelGrid.Invalidate();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            animTimer.Stop();
            base.OnFormClosing(e);
        }
    }
}