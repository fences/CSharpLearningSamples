# 🏭 Sequential Bottle Filler Simulation
### شبیه‌ساز دستگاه پرکن اتوماتیک بطری (منطق ترتیبی)

---

## 📄 معرفی پروژه (Introduction)
این پروژه یک نرم‌افزار آموزشی **WinForms** به زبان **C#** است که فرآیند یک خط تولید صنعتی (دستگاه پرکن مایعات) را شبیه‌سازی می‌کند.  
برخلاف پروژه‌های ساده که المان‌ها مستقل عمل می‌کنند، در این پروژه از منطق **Sequential Control (کنترل ترتیبی)** و الگوی طراحی **State Machine (ماشین حالت)** استفاده شده که مشابه منطق برنامه‌نویسی **PLC** در صنعت است.

---

## 🎯 اهداف آموزشی (Learning Objectives)
این پروژه برای درک مفاهیم زیر طراحی شده است:

- **State Machine:** مدیریت مراحل فرآیند با استفاده از متغیر وضعیت (`_step`)  
- **Sequential Logic:** اجرای مرحله‌به‌مرحله (تا مرحله ۱ تمام نشود، مرحله ۲ شروع نمی‌شود)  
- **Safety Interlock:** پیاده‌سازی دکمه توقف اضطراری (Emergency Stop) که تمام فرآیندها را قفل می‌کند  
- **Timer-based Control:** استفاده از تایمر برای مدیریت حرکت نوار نقاله و پر کردن بطری  

---

## ⚙️ سناریوی عملکرد (Workflow)

سیستم در یک حلقه تکرار (Loop) شامل ۳ مرحله اصلی کار می‌کند:

1. **مرحله ۱ (Moving In):** نوار نقاله حرکت می‌کند تا بطری خالی به زیر نازل برسد  
2. **مرحله ۲ (Filling):** نوار نقاله **متوقف** می‌شود و شیر نازل باز می‌شود تا بطری پر شود  
3. **مرحله ۳ (Moving Out):** پس از پر شدن، نوار نقاله مجدداً حرکت می‌کند تا بطری خارج شود  
4. **تکرار:** سیستم ریست شده و آماده ورود بطری جدید می‌شود  

### 🚨 توقف اضطراری (Emergency Stop)
- دکمه ایمنی در هر لحظه قابل فشردن است  
- تایمر متوقف می‌شود  
- سیستم وارد حالت `Emergency` می‌شود  
- تا زمانی که سیستم **Reset** نشود، دکمه Start کار نخواهد کرد (Interlock)  

---

## 🛠 تکنولوژی‌های استفاده شده

- **Language:** C#  
- **Framework:** .NET (Windows Forms)  
- **IDE:** Visual Studio 2022  
- **Key Concepts:** `Switch-Case`, `Timer`, `Interlock`, `Global Variables`  

---

## 💻 بررسی کد (Code Logic)

قلب تپنده پروژه، استفاده از ساختار `switch-case` درون رویداد تایمر است که جایگزین `if`های تو در تو شده و مراحل خط تولید را مدیریت می‌کند.

<pre style="direction: ltr;">
```csharp
// متغیر سراسری برای نگهداری مرحله جاری
int _step = 0; 

private void tmrMain_Tick(object sender, EventArgs e)
{
    switch (_step)
    {
        case 1: // مرحله حرکت ورودی (Moving In)
            if (prgConveyor.Value < 50)
                prgConveyor.Value += 2; // نوار نقاله حرکت می‌کند
            else
                _step = 2; // انتقال به مرحله بعد
            break;

        case 2: // مرحله پر کردن (Filling - نوار ایستاده است)
            if (prgBottle.Value < 100)
                prgBottle.Value += 2; // بطری پر می‌شود
            else
                _step = 3; // انتقال به مرحله بعد
            break;

        case 3: // مرحله خروج (Moving Out)
            if (prgConveyor.Value < 100)
                prgConveyor.Value += 2; // بطری حرکت می‌کند و خارج می‌شود
            else
            {
                // ریست برای بطری بعدی
                prgConveyor.Value = 0;
                prgBottle.Value = 0;
                _step = 1;
            }
            break;
    }
}
