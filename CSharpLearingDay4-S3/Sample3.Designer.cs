namespace CSharpLearingDay4_S3
{
    partial class Sample3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.txtSetPoint = new System.Windows.Forms.TextBox();
            this.prgTemp = new System.Windows.Forms.ProgressBar();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblFanStatus = new System.Windows.Forms.Label();
            this.lblTimerLog = new System.Windows.Forms.Label();
            this.tmrSimulation = new System.Windows.Forms.Timer(this.components);
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(27, 23);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(132, 41);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtSetPoint
            // 
            this.txtSetPoint.Location = new System.Drawing.Point(468, 32);
            this.txtSetPoint.Name = "txtSetPoint";
            this.txtSetPoint.Size = new System.Drawing.Size(100, 22);
            this.txtSetPoint.TabIndex = 1;
            this.txtSetPoint.Text = "80";
            // 
            // prgTemp
            // 
            this.prgTemp.Location = new System.Drawing.Point(27, 202);
            this.prgTemp.Name = "prgTemp";
            this.prgTemp.Size = new System.Drawing.Size(541, 50);
            this.prgTemp.TabIndex = 2;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(164, 99);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(16, 20);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "-";
            // 
            // lblFanStatus
            // 
            this.lblFanStatus.AutoSize = true;
            this.lblFanStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFanStatus.Location = new System.Drawing.Point(164, 131);
            this.lblFanStatus.Name = "lblFanStatus";
            this.lblFanStatus.Size = new System.Drawing.Size(16, 20);
            this.lblFanStatus.TabIndex = 4;
            this.lblFanStatus.Text = "-";
            // 
            // lblTimerLog
            // 
            this.lblTimerLog.AutoSize = true;
            this.lblTimerLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerLog.Location = new System.Drawing.Point(164, 161);
            this.lblTimerLog.Name = "lblTimerLog";
            this.lblTimerLog.Size = new System.Drawing.Size(16, 20);
            this.lblTimerLog.TabIndex = 5;
            this.lblTimerLog.Text = "-";
            // 
            // tmrSimulation
            // 
            this.tmrSimulation.Tick += new System.EventHandler(this.tmrSimulation_Tick);
            // 
            // tmrDelay
            // 
            this.tmrDelay.Interval = 1000;
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Point Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Timer Log:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 267);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "-";
            // 
            // Sample3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 296);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimerLog);
            this.Controls.Add(this.lblFanStatus);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.prgTemp);
            this.Controls.Add(this.txtSetPoint);
            this.Controls.Add(this.btnStartStop);
            this.Name = "Sample3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TextBox txtSetPoint;
        private System.Windows.Forms.ProgressBar prgTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblFanStatus;
        private System.Windows.Forms.Label lblTimerLog;
        private System.Windows.Forms.Timer tmrSimulation;
        private System.Windows.Forms.Timer tmrDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
    }
}

