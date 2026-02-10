using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearingDay4
{
    public partial class Sample1 : Form
    {
        public Sample1()
        {
            InitializeComponent();
        }

        bool _startStatus = false;

        private void tmrProcess_Tick(object sender, EventArgs e)
        {
            // اگر شیر تخلیه باز است (Drain Mode)
            if (chkDrainValve.Checked == true)
            {
                // چک کن منفی نشود (محافظت)
                if (prgLevel.Value > 0)
                {
                    prgLevel.Value -= 1; // کاهش سطح
                    lblStatus.Text = "Status: Draining...";
                }
                else
                {
                    lblStatus.Text = "Status: Empty Tank";
                    tmrProcess.Stop(); // توقف پمپ
                    _startStatus = false;
                    btnStartStop.Text = "Start";
                }
            }
            else // شیر تخلیه بسته است (Filling Mode)
            {
                // چک کن سرریز نشود (محافظت)
                if (prgLevel.Value < 100)
                {
                    prgLevel.Value += 1; // افزایش سطح
                    lblStatus.Text = "Status: Filling...";
                }
                else
                {
                    lblStatus.Text = "ALARM: TANK FULL!";
                    lblStatus.ForeColor = Color.Red;
                    tmrProcess.Stop(); // توقف اضطراری
                    _startStatus = false;
                    btnStartStop.Text = "Start";
                }
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_startStatus == false)
            {
                _startStatus = true;
                tmrProcess.Start();
                btnStartStop.Text = "Stop";
            }
            else
            {
                _startStatus = false;
                tmrProcess.Stop();
                btnStartStop.Text = "Start";
            }
        }
    }
}
