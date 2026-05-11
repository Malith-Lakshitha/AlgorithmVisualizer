using System;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public enum SettingsMode { Sorting, Pathfinding }

    public partial class SettingsForm : Form
    {
        public int ArraySize { get; private set; }
        public int AnimationSpeed { get; private set; }
        public int GridRows { get; private set; }
        public int GridCols { get; private set; }

        private SettingsMode mode;

        public SettingsForm(SettingsMode mode,
            int currentArraySize = 50,
            int currentSpeed = 100,
            int currentRows = 20,
            int currentCols = 20)
        {
            this.mode = mode;
            ArraySize = currentArraySize;
            AnimationSpeed = currentSpeed;
            GridRows = currentRows;
            GridCols = currentCols;

            InitializeComponent();

            // Load current values into controls
            trkSpeed.Value = Math.Min(500, Math.Max(10, currentSpeed));
            lblSpeedValue.Text = currentSpeed + " ms per step";
            numArraySize.Value = currentArraySize;
            numRows.Value = currentRows;
            numCols.Value = currentCols;

            // Show only relevant controls based on mode
            ShowControlsForMode();
        }

        private void ShowControlsForMode()
        {
            if (mode == SettingsMode.Sorting)
            {
                // Show sorting controls, hide pathfinding controls
                lblArraySize.Visible = true;
                numArraySize.Visible = true;
                lblGridSize.Visible = false;
                lblRows.Visible = false;
                numRows.Visible = false;
                lblCols.Visible = false;
                numCols.Visible = false;
            }
            else
            {
                // Show pathfinding controls, hide sorting controls
                lblArraySize.Visible = false;
                numArraySize.Visible = false;
                lblGridSize.Visible = true;
                lblRows.Visible = true;
                numRows.Visible = true;
                lblCols.Visible = true;
                numCols.Visible = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            AnimationSpeed = trkSpeed.Value;

            if (mode == SettingsMode.Sorting)
                ArraySize = (int)numArraySize.Value;
            else
            {
                GridRows = (int)numRows.Value;
                GridCols = (int)numCols.Value;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void trkSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeedValue.Text = trkSpeed.Value + " ms per step";
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}