using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearingDay5_S1
{
    public partial class Sample1 : Form
    {
        public Sample1()
        {
            InitializeComponent();
        }

        // ==========================================
        // 1. GLOBAL VARIABLES (حافظه سیستم)
        // ==========================================

        // متغیر مرحله (State Machine):
        // 0 = Stop/Idle (بیکار)
        // 1 = Moving In (ورود بطری به زیر نازل)
        // 2 = Filling (پر کردن بطری)
        // 3 = Moving Out (خروج بطری)
        int _step = 0;

        // پرچم وضعیت اضطراری
        bool _isEmergency = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ==========================================
        // 2. BUTTON EVENTS (دکمه‌ها)
        // ==========================================

        // دکمه شروع چرخه
        private void btnStart_Click(object sender, EventArgs e)
        {
            // ایمنی (Interlock): اگر وضعیت اضطراری فعال است، اجازه استارت نده
            if (_isEmergency == true)
            {
                MessageBox.Show("System is in EMERGENCY mode! Please Reset first.", "Safety Error");
                return; // خروج از متد (کد پایین اجرا نمی‌شود)
            }

            // تنظیم شرایط اولیه
            _step = 1; // رفتن به مرحله اول (حرکت)
            tmrMain.Interval = 100; // سرعت عادی
            tmrMain.Start(); // روشن کردن تایمر

            // آپدیت UI
            lblState.Text = "STATE: MOVING IN...";
            lblState.BackColor = Color.LightYellow;
        }

        // دکمه توقف اضطراری (Emergency Stop)
        private void btnEStop_Click(object sender, EventArgs e)
        {
            // 1. قطع فوری تایمر (مهمترین کار)
            tmrMain.Stop();

            // 2. فعال کردن پرچم ایمنی
            _isEmergency = true;

            // 3. تغییر وضعیت ظاهری برای هشدار
            this.BackColor = Color.Red; // کل فرم قرمز شود
            lblState.Text = "!!! EMERGENCY STOP !!!";
            lblState.ForeColor = Color.White;
            lblState.BackColor = Color.DarkRed;
        }


        // ==========================================
        // 3. TIMER LOGIC (مغز متفکر سیستم)
        // ==========================================
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // استفاده از switch برای مدیریت مراحل (Sequence Control)
            switch (_step)
            {
                case 1: // --- STAGE 1: MOVING IN (ورود بطری) ---
                    // حرکت نوار نقاله
                    if (prgConveyor.Value < 50)
                    {
                        prgConveyor.Value += 2; // سرعت حرکت
                    }
                    else
                    {
                        // شرط گذار (Transition Logic): رسیدن به زیر نازل
                        _step = 2; // برو به مرحله بعد
                        lblState.Text = "STATE: FILLING...";
                        lblState.BackColor = Color.LightBlue;
                    }
                    break;

                case 2: // --- STAGE 2: FILLING (پر کردن) ---
                    // نوار نقاله ثابت می‌ماند، بطری پر می‌شود
                    if (prgBottle.Value < 100)
                    {
                        prgBottle.Value += 2; // سرعت پر شدن
                    }
                    else
                    {
                        // شرط گذار: بطری پر شد
                        _step = 3; // برو به مرحله بعد
                        lblState.Text = "STATE: MOVING OUT...";
                        lblState.BackColor = Color.LightYellow;
                    }
                    break;

                case 3: // --- STAGE 3: MOVING OUT (خروج بطری) ---
                    // ادامه حرکت نوار نقاله از 50 به 100
                    if (prgConveyor.Value < 100)
                    {
                        prgConveyor.Value += 2;
                    }
                    else
                    {
                        // پایان سیکل (Cycle Complete)
                        // آماده‌سازی برای بطری بعدی (Loop)

                        prgConveyor.Value = 0; // نوار ریست شود
                        prgBottle.Value = 0;   // بطری جدید خالی است

                        _step = 1; // بازگشت به مرحله اول
                        lblState.Text = "STATE: MOVING IN (Next Bottle)...";
                    }
                    break;
            }
        }

        // دکمه ریست (برای بازگرداندن سیستم به حالت عادی)
        // *دانشجو باید این دکمه را اضافه کند یا کدش را بداند*
        private void btnReset_Click(object sender, EventArgs e)
        {
            // بازگرداندن متغیرها به حالت پیش‌فرض
            _isEmergency = false;
            _step = 0;

            // صفر کردن نوارها
            prgConveyor.Value = 0;
            prgBottle.Value = 0;

            // بازگرداندن رنگ‌ها به حالت عادی
            this.BackColor = SystemColors.Control;
            lblState.Text = "STATE: READY";
            lblState.ForeColor = Color.Black;
            lblState.BackColor = Color.LightGray;
        }
    }
}
