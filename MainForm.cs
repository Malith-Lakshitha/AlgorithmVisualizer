using System;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            SortingForm form = new SortingForm();
            form.Show();
        }

        private void btnPathfinding_Click_1(object sender, EventArgs e)
        {
            PathfindingForm form = new PathfindingForm();
            form.Show();
        }
    }
}