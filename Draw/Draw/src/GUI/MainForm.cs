using Draw.src.Processors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();

        public MainForm()
        {
            InitializeComponent();
        }

        private void DrawRectangleSpeedButtonClick_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle();
            viewPort.Invalidate();
        }

        private void viewPort_Paint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }
    }
}
