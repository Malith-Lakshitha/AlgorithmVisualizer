using System.Drawing;

namespace AlgorithmVisualizer.Models
{
    public class PathStep
    {
        public Point Node { get; set; }  // which grid cell (row, col)
        public bool IsPath { get; set; } // false = visited (blue), true = final path (yellow)
    }
}