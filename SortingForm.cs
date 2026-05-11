using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AlgorithmVisualizer.Algorithms;
using AlgorithmVisualizer.Models;

namespace AlgorithmVisualizer
{
    public partial class SortingForm : Form
    {
        // ---- State variables ----
        private int[] array;
        private int arraySize = 50;
        private int animationSpeed = 100;
        private int comparisons = 0;
        private int currentStep = 0;
        private List<SortStep> steps;
        private System.Windows.Forms.Timer animTimer;

        // ---- Highlight state for painting ----
        private int compareA = -1, compareB = -1;
        private int swapA = -1, swapB = -1;
        private HashSet<int> sortedIndices = new HashSet<int>();

        public SortingForm()
        {
            InitializeComponent();  // loads your Designer controls
            SetupTimer();
            GenerateArray();        // generate array on startup
        }

        // ============================================
        // TIMER SETUP
        // ============================================
        private void SetupTimer()
        {
            animTimer = new System.Windows.Forms.Timer();
            animTimer.Interval = animationSpeed;
            animTimer.Tick += AnimTimer_Tick;
        }

        // ============================================
        // GENERATE RANDOM ARRAY
        // ============================================
        private void GenerateArray()
        {
            Random rnd = new Random();
            array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
                array[i] = rnd.Next(5, 100);

            // Reset all highlights
            sortedIndices.Clear();
            compareA = compareB = swapA = swapB = -1;
            comparisons = 0;

            lblComparisons.Text = "Comparisons: 0";
            lblStatus.Text = "New array generated — press Start.";
            panelBars.Invalidate(); // trigger repaint
        }

        // ============================================
        // PAINT EVENT — draws the bars
        // Double-click panelBars in Designer Events to create this
        // ============================================
        private void panelBars_Paint(object sender, PaintEventArgs e)
        {
            if (array == null) return;

            Graphics g = e.Graphics;
            g.Clear(Color.FromArgb(12, 12, 20));

            float barWidth = (float)panelBars.Width / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                Color barColor = GetBarColor(i);
                float barHeight = (float)array[i] / 100f * (panelBars.Height - 5);
                float x = i * barWidth;
                float y = panelBars.Height - barHeight;

                using (SolidBrush brush = new SolidBrush(barColor))
                    g.FillRectangle(brush, x + 1, y, Math.Max(1, barWidth - 2), barHeight);
            }
        }

        private Color GetBarColor(int i)
        {
            if (sortedIndices.Contains(i)) return Color.LimeGreen;
            if (i == compareA || i == compareB) return Color.OrangeRed;
            if (i == swapA || i == swapB) return Color.Orange;
            return Color.SteelBlue;
        }

        // ============================================
        // TIMER TICK — one animation step per tick
        // ============================================
        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            if (currentStep >= steps.Count)
            {
                // Animation finished
                animTimer.Stop();
                for (int i = 0; i < array.Length; i++)
                    sortedIndices.Add(i);
                compareA = compareB = swapA = swapB = -1;
                panelBars.Invalidate();

                lblStatus.Text = "✅ Sorting complete! Comparisons: " + comparisons;
                btnStart.Enabled = false;
                btnReset.Enabled = true;
                btnGenerate.Enabled = true;
                btnSettings.Enabled = true;
                return;
            }

            SortStep step = steps[currentStep];
            array = step.ArrayState;
            compareA = step.CompareA;
            compareB = step.CompareB;
            swapA = step.SwapA;
            swapB = step.SwapB;
            sortedIndices = new HashSet<int>(step.SortedIndices);

            if (step.IsComparison)
            {
                comparisons++;
                lblComparisons.Text = "Comparisons: " + comparisons;
            }

            panelBars.Invalidate();
            currentStep++;
        }

        // ============================================
        // BUTTON CLICK EVENTS
        // Double-click each button in Designer to create these
        // ============================================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            animTimer.Stop();
            GenerateArray();
            btnStart.Enabled = true;
            btnReset.Enabled = false;
            btnSettings.Enabled = true;
            btnGenerate.Enabled = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(
                SettingsMode.Sorting,
                currentArraySize: arraySize,
                currentSpeed: animationSpeed);

            if (settings.ShowDialog() == DialogResult.OK)
            {
                arraySize = settings.ArraySize;
                animationSpeed = settings.AnimationSpeed;
                animTimer.Interval = animationSpeed;
                GenerateArray();
                lblStatus.Text = $"Settings applied: {arraySize} elements, {animationSpeed}ms speed";
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            animTimer.Stop();
            GenerateArray();
            btnStart.Enabled = true;
            btnReset.Enabled = false;
            btnGenerate.Enabled = true;
            btnSettings.Enabled = true;
            lblStatus.Text = "Reset — press Start to sort again.";
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (array == null) return;

            currentStep = 0;
            comparisons = 0;
            sortedIndices.Clear();

            // Generate steps for selected algorithm
            string algo = cmbAlgorithm.SelectedItem?.ToString() ?? "Insertion Sort";

            if (algo == "Insertion Sort")
            {
                steps = new InsertionSort().GenerateSteps(array);
                lblStatus.Text = "Running Insertion Sort...";
            }
            else
            {
                steps = new QuickSort().GenerateSteps(array);
                lblStatus.Text = "Running Quick Sort...";
            }

            btnStart.Enabled = false;
            btnGenerate.Enabled = false;
            btnSettings.Enabled = false;
            btnReset.Enabled = true;

            animTimer.Interval = animationSpeed;
            animTimer.Start();
        }

        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            animTimer.Stop();
            base.OnFormClosing(e);
        }
    }
}