using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearingDay4_S2
{
    public partial class Sample2 : Form
    {
        public Sample2()
        {
            InitializeComponent();
        }
        bool _startStatus = false;
        int _productCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // انتخاب سرعت پیشفرض
            cmbSpeed.SelectedIndex = 0;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {

            if (_startStatus == false)
            {
                //بررسی تنظیم سرعت نقاله
                if (cmbSpeed.Text == "Fast")
                {
                    tmrMain.Interval = 50;
                }
                else
                {
                    tmrMain.Interval = 300;
                }
                _startStatus = true;
                tmrMain.Start();
                btnStartStop.Text = "Stop";
            }
            else
            {
                _startStatus = false;
                tmrMain.Stop();
                btnStartStop.Text = "Start";
            }


        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // حرکت نوار نقاله
            if (prgConveyor.Value < 100)
            {
                prgConveyor.Value += 2; // حرکت به جلو
            }
            else
            {
                // رسیدن به انتهای خط
                prgConveyor.Value = 0; // ریست کردن نوار برای جعبه بعدی

                // بررسی سنسور کیفیت
                if (chkQualitySensor.Checked == true)
                {
                    _productCount = _productCount + 1;
                    lblCount.Text = _productCount.ToString();
                    lblStatus.Text = "Accepted Item!";
                }
                else
                {
                    // محصول خراب بود، شمارش نمی‌شود
                    lblStatus.Text = "Rejected Item!";
                }
            }
        }
    }
}
