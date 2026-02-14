using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearingDay5_S2
{
    public partial class Sample2 : Form
    {
        public Sample2()
        {
            InitializeComponent();
        }

        // --- متغیرهای سراسری (Global Variables) ---
        // این متغیرها تا زمانی که فرم باز است، مقدارشان حفظ می‌شود.

        // 1. تعریف آرایه با طول ثابت 10 (مثل بافر PLC)
        int[] temps = new int[10];

        // 2. تعریف ایندکس برای اینکه بدانیم خانه چندم را پر می‌کنیم
        int index = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // قدم اول: جلوگیری از خالی بودن تکست‌باکس
                if (txtTemp.Text == "")
                {
                    MessageBox.Show("Please enter a temperature value.");
                    return;
                }

                // قدم دوم: دریافت عدد از کاربر
                int inputTemp = int.Parse(txtTemp.Text);

                // قدم سوم: ذخیره در آرایه (مهمترین بخش)
                // عدد را در خانه شماره 'index' می‌ریزیم
                temps[index] = inputTemp;

                // قدم چهارم: نمایش در لیست‌باکس جهت اطلاع کاربر
                lstLog.Items.Add($"Sample [{index}]: {inputTemp} °C");

                // قدم پنجم: افزایش شمارنده برای داده بعدی
                index++;

                // قدم ششم: آپدیت کردن وضعیت فرم (UI)
                lblStatus.Text = $"Data Stored: {index} / 10";
                prgMemory.Value = index; // پروگرس‌بار جلو می‌رود

                // پاک کردن تکست‌باکس برای عدد بعدی
                txtTemp.Clear();
                txtTemp.Focus();

                // قدم هفتم: بررسی پر شدن حافظه
                if (index == 10)
                {
                    MessageBox.Show("Memory Full! Ready to Calculate.");

                    // بستن ورودی‌ها
                    btnAdd.Enabled = false;
                    txtTemp.Enabled = false;

                    // فعال کردن دکمه محاسبات
                    btnCalculate.Enabled = true;
                    btnCalculate.BackColor = System.Drawing.Color.LightGreen; // تغییر رنگ برای جلب توجه
                }
            }
            catch(Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // متغیرهای کمکی برای محاسبه
            int sum = 0;
            int maxVal = temps[0]; // فرض می‌کنیم اولین عدد بزرگترین است
            int minVal = temps[0]; // فرض می‌کنیم اولین عدد کوچکترین است

            // --- شروع حلقه تحلیل (Loop) ---
            // این حلقه کل آرایه را از خانه 0 تا 9 پیمایش می‌کند
            for (int i = 0; i < temps.Length; i++)
            {
                // 1. جمع زدن برای میانگین
                sum = sum + temps[i];

                // 2. پیدا کردن ماکزیمم
                if (temps[i] > maxVal)
                {
                    maxVal = temps[i]; // رکورد جدید ثبت شد
                }

                // 3. پیدا کردن مینیمم
                if (temps[i] < minVal)
                {
                    minVal = temps[i]; // رکورد جدید ثبت شد
                }
            }
            // --- پایان حلقه ---

            // محاسبه میانگین (تقسیم بر 10.0 برای اعشاری شدن)
            double average = sum / 10.0;

            // نمایش نتایج نهایی
            string report = $"Average Temp: {average} °C\n" +
                            $"Max Temp: {maxVal} °C\n" +
                            $"Min Temp: {minVal} °C";

            lblResult.Text = report;
            MessageBox.Show("Analysis Complete!", "System Info");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // صفر کردن ایندکس
            index = 0;

            // پاک کردن آرایه (اختیاری است چون روی قبلی‌ها بازنویسی می‌شود، اما تمیزتر است)
            Array.Clear(temps, 0, temps.Length);

            // ریست کردن کنترل‌های فرم
            lstLog.Items.Clear();
            lblStatus.Text = "Data Stored: 0 / 10";
            lblResult.Text = "---";
            prgMemory.Value = 0;

            // بازگرداندن دکمه‌ها به حالت اولیه
            btnAdd.Enabled = true;
            txtTemp.Enabled = true;
            btnCalculate.Enabled = false;
            btnCalculate.BackColor = System.Drawing.Color.LightGray;
        }
    }
}
