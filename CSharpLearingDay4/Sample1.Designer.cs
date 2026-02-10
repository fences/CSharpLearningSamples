namespace CSharpLearingDay4
{
    partial class Sample1
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
            this.prgLevel = new System.Windows.Forms.ProgressBar();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.chkDrainValve = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrProcess = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgLevel
            // 
            this.prgLevel.Location = new System.Drawing.Point(21, 21);
            this.prgLevel.Name = "prgLevel";
            this.prgLevel.Size = new System.Drawing.Size(734, 170);
            this.prgLevel.TabIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(16, 41);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(137, 48);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // chkDrainValve
            // 
            this.chkDrainValve.AutoSize = true;
            this.chkDrainValve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDrainValve.Location = new System.Drawing.Point(64, 18);
            this.chkDrainValve.Name = "chkDrainValve";
            this.chkDrainValve.Size = new System.Drawing.Size(77, 24);
            this.chkDrainValve.TabIndex = 2;
            this.chkDrainValve.Text = "Drain";
            this.chkDrainValve.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "-";
            // 
            // tmrProcess
            // 
            this.tmrProcess.Tick += new System.EventHandler(this.tmrProcess_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prgLevel);
            this.groupBox1.Location = new System.Drawing.Point(16, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDrainValve);
            this.groupBox3.Location = new System.Drawing.Point(588, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 53);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartStop);
            this.Name = "Form1";
            this.Text = "Sample1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgLevel;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.CheckBox chkDrainValve;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

