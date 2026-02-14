using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearingDay5_S3
{
    public partial class Sample3 : Form
    {
        public Sample3()
        {
            InitializeComponent();
        }

        // --- متغیرهای سراسری ---
        // آرایه ۱۰ تایی که نقش نوار نقاله را بازی می‌کند
        int[] belt = new int[10];

        // کلاس تولید اعداد تصادفی (شبیه‌ساز نوسان نازل تزریق)
        Random rnd = new Random();

        // وضعیت موتور نوار نقاله
        bool isRunning = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // تنظیم مقادیر اولیه هنگام باز شدن فرم
            numSetPoint.Value = 245; // مقدار پیش‌فرض حد پایین
            btnStartStop.Text = "START Line";
            btnStartStop.BackColor = Color.LightGreen;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                tmrSim.Enabled = true;
                btnStartStop.Text = "STOP Line";
                btnStartStop.BackColor = Color.Salmon;

                // غیرفعال کردن تنظیمات هنگام روشن بودن دستگاه (ایمنی صنعتی)
                numSetPoint.Enabled = false;

                isRunning = true;
            }
            else
            {
                tmrSim.Enabled = false;
                btnStartStop.Text = "START Line";
                btnStartStop.BackColor = Color.LightGreen;

                // فعال کردن مجدد تنظیمات
                numSetPoint.Enabled = true;

                isRunning = false;
            }
        }

        // --- رویداد تایمر (قلب تپنده پروژه) ---
        // این کد هر ۱ ثانیه (۱۰۰۰ میلی‌ثانیه) اجرا می‌شود
        private void tmrSim_Tick(object sender, EventArgs e)
        {
            // 1. دریافت مقدار تنظیم شده توسط کاربر (Set Point)
            // تبدیل decimal به int چون آرایه ما int است
            int minLimit = (int)numSetPoint.Value;

            // 2. شیفت دادن نوار نقاله به جلو
            for (int i = belt.Length - 1; i > 0; i--)
            {
                belt[i] = belt[i - 1];
            }

            // 3. ورود بطری جدید (بین 235 تا 260 میلی‌لیتر)
            // بازه را کمی بازتر کردم تا شانس خطا بیشتر شود
            int fillAmount = rnd.Next(235, 261);
            belt[0] = fillAmount;

            // 4. آنالیز و نمایش
            string visualTape = "";
            int sum = 0;
            int errorCount = 0;

            for (int i = 0; i < belt.Length; i++)
            {
                sum += belt[i];

                // --- اصلاح مهم: استفاده از SetPoint ---
                // اگر بطری خالی نیست (0) ولی کمتر از حد مجاز کاربر است
                if (belt[i] > 0 && belt[i] < minLimit)
                {
                    errorCount++;
                    // نمایش گرافیکی خطا با علامت تعجب
                    visualTape += $"[{belt[i]}!]  ";
                }
                else
                {
                    // نمایش عادی
                    visualTape += $"[{belt[i]}]  ";
                }
            }

            // نمایش در لیبل
            lblBeltVisual.Text = visualTape;

            // محاسبات آماری
            double average = sum / 10.0;
            lblStats.Text = $"Avg: {average:F1} ml | Errors (<{minLimit}): {errorCount}";

            // تغییر رنگ وضعیت
            if (errorCount >= 3)
            {
                lblStats.ForeColor = Color.Red;
                // فقط وقتی وضعیت بحرانی شد لاگ بزن (برای جلوگیری از شلوغی)
                lstLog.Items.Insert(0, $"CRITICAL: {errorCount} errors detected at {DateTime.Now:HH:mm:ss}");
            }
            else
            {
                lblStats.ForeColor = Color.Green;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. خالی کردن آرایه با استفاده از حلقه
            // تمام خانه‌های آرایه را 0 می‌کنیم
            for (int i = 0; i < belt.Length; i++)
            {
                belt[i] = 0;
            }

            // 2. پاک کردن لاگ‌ها
            lstLog.Items.Clear();

            // 3. ریست کردن نمایشگرها
            lblBeltVisual.Text = "[Empty] [Empty] ...";
            lblStats.Text = "System Cleared. Ready to start.";
            lblStats.ForeColor = Color.Black;

            MessageBox.Show("System Data Reset Successfully!", "Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
