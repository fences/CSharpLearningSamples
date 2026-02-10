using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearingDay4_S3
{
    public partial class Sample3 : Form
    {
        public Sample3()
        {
            InitializeComponent();
        }


        // وضعیت‌های سیستم
        bool isSystemRunning = false; // آیا کل سیستم روشن است؟
        bool isFanOn = false;         // آیا فن خنک‌کننده روشن است؟

        int currentTemp = 25;         // دمای فعلی
        int errorSeconds = 0;         // شمارنده زمان خطا
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isSystemRunning == false)
            {
                // روشن کردن سیستم
                isSystemRunning = true;
                btnStartStop.Text = "STOP SYSTEM";
                btnStartStop.BackColor = Color.LightCoral; // قرمز برای توقف

                tmrSimulation.Start(); // شروع فرآیند
                lblStatus.Text = "Status: Heating Process Started...";
            }
            else
            {
                // خاموش کردن سیستم
                isSystemRunning = false;
                btnStartStop.Text = "START SYSTEM";
                btnStartStop.BackColor = Color.LightGreen; // سبز برای شروع

                // توقف تمام تایمرها
                tmrSimulation.Stop();
                tmrDelay.Stop();

                // ریست کردن وضعیت فن
                isFanOn = false;
                lblFanStatus.Text = "FAN: OFF";
                lblFanStatus.BackColor = Color.Gray;
                lblStatus.Text = "Status: System Stopped.";
            }
        }

        // --- تایمر اصلی: شبیه‌سازی دما و لاجیک کنترل ---
        // Interval: 100ms
        private void tmrSimulation_Tick(object sender, EventArgs e)
        {
            // خواندن SetPoint (با جلوگیری از خطا)
            int setPoint;
            if (!int.TryParse(txtSetPoint.Text, out setPoint)) setPoint = 80;

            // ---------------------------------------------
            // بخش 1: شبیه‌سازی فیزیک (گرم شدن و سرد شدن)
            // ---------------------------------------------
            if (isFanOn == true)
            {
                // اگر فن روشن است، دما باید کم شود (سریع‌تر)
                if (currentTemp > 0) currentTemp -= 2;
                lblStatus.Text = "Status: Cooling Down...";
            }
            else
            {
                // اگر فن خاموش است، دما باید زیاد شود (پروسه تولید)
                if (currentTemp < 120) currentTemp += 1;
                lblStatus.Text = "Status: Heating Up...";
            }

            // نمایش در گرافیک
            if (currentTemp < 100)
            {
                prgTemp.Value = currentTemp;
            }
            lblTemp.Text = currentTemp.ToString() + " °C";


            // ---------------------------------------------
            // بخش 2: لاجیک کنترل هوشمند (Logic)
            // ---------------------------------------------

            // الف) بررسی دمای بالا برای فعال کردن تایمر تاخیر
            // شرط: دما بالا باشد AND فن هنوز خاموش باشد
            if (currentTemp > setPoint && isFanOn == false)
            {
                lblTemp.ForeColor = Color.Red; // هشدار بصری

                // تایمر تاخیر را روشن کن (اگر خاموش است)
                if (tmrDelay.Enabled == false)
                {
                    tmrDelay.Start();
                }
            }
            else if (currentTemp <= setPoint && isFanOn == false)
            {
                // شرایط نرمال است و فن خاموش است
                lblTemp.ForeColor = Color.Black;
                tmrDelay.Stop();     // تایمر خطا را متوقف کن
                errorSeconds = 0;    // ثانیه‌ها را صفر کن
                lblTimerLog.Text = "Status: Normal";
            }

            // ب) بررسی شرط خاموش کردن فن (Hysteresis)
            // فن را وقتی خاموش کن که دما 15 درجه زیرِ حد مجاز بیاید
            // این باعث می‌شود فن هی روشن و خاموش نشود (Chattering)
            if (isFanOn == true && currentTemp < (setPoint - 15))
            {
                isFanOn = false;
                lblFanStatus.Text = "FAN: OFF";
                lblFanStatus.BackColor = Color.Gray;
            }
        }


        // --- تایمر دوم: محاسبه زمان تاخیر (On-Delay) ---
        // Interval: 1000ms (1 ثانیه)
        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            errorSeconds++;
            lblTimerLog.Text = "Overheat Warning! " + errorSeconds + "s";

            // اگر 3 ثانیه دما بالا بود -> فن را روشن کن
            if (errorSeconds >= 3)
            {
                // فعال‌سازی فن
                isFanOn = true;

                // تغییر وضعیت گرافیکی
                lblFanStatus.Text = "FAN: ON (COOLING)";
                lblFanStatus.BackColor = Color.Red; // فن روشن شد

                // کار تایمر تاخیر تمام شد، خاموشش کن
                tmrDelay.Stop();
                errorSeconds = 0;
            }
        }



    }
}
