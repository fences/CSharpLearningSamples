namespace CSharpLearingDay4_S2
{
    partial class Sample2
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
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.prgConveyor = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkQualitySensor = new System.Windows.Forms.CheckBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Items.AddRange(new object[] {
            "Fast",
            "Slow"});
            this.cmbSpeed.Location = new System.Drawing.Point(534, 26);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(254, 24);
            this.cmbSpeed.TabIndex = 0;
            // 
            // prgConveyor
            // 
            this.prgConveyor.Location = new System.Drawing.Point(12, 137);
            this.prgConveyor.Name = "prgConveyor";
            this.prgConveyor.Size = new System.Drawing.Size(776, 47);
            this.prgConveyor.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(582, 191);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "-";
            // 
            // chkQualitySensor
            // 
            this.chkQualitySensor.AutoSize = true;
            this.chkQualitySensor.Location = new System.Drawing.Point(602, 111);
            this.chkQualitySensor.Name = "chkQualitySensor";
            this.chkQualitySensor.Size = new System.Drawing.Size(116, 20);
            this.chkQualitySensor.TabIndex = 3;
            this.chkQualitySensor.Text = "Quality Sensor";
            this.chkQualitySensor.UseVisualStyleBackColor = true;
            // 
            // tmrMain
            // 
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timer Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(12, 26);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(141, 44);
            this.btnStartStop.TabIndex = 6;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Counter:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(179, 191);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 20);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 220);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkQualitySensor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.prgConveyor);
            this.Controls.Add(this.cmbSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.ProgressBar prgConveyor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkQualitySensor;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
    }
}

