using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rapid_Trigger_Config
{
    public partial class CalibrationForm : Form
    {

        int count = 0;
        int progress = 0;

        public CalibrationForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            progress++;
            progressBar1.Value = progress;
            if (progress >= 10)
            {
                timer1.Stop();
                count = 0;
                this.Close();
            }
        }

        private void CalibrationForm_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progress = 0;

            StartTimer();
        }

        private void StartTimer()
        {
            timer1.Start();
        }
    }
}
