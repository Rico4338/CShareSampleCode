namespace ThreadSleepTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_ThreadSleep = new System.Windows.Forms.Button();
            this.lbl_ThreadSleep = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_NonBlock = new System.Windows.Forms.Label();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.btn_notBlock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_TenSleep = new System.Windows.Forms.Button();
            this.btn_TenNotBlock = new System.Windows.Forms.Button();
            this.lbl_TenSleep = new System.Windows.Forms.Label();
            this.lbl_TenNotBlock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ThreadSleep
            // 
            this.btn_ThreadSleep.Location = new System.Drawing.Point(32, 153);
            this.btn_ThreadSleep.Name = "btn_ThreadSleep";
            this.btn_ThreadSleep.Size = new System.Drawing.Size(75, 23);
            this.btn_ThreadSleep.TabIndex = 0;
            this.btn_ThreadSleep.Text = "Thread.Sleep";
            this.btn_ThreadSleep.UseVisualStyleBackColor = true;
            this.btn_ThreadSleep.Click += new System.EventHandler(this.btn_ThreadSleep_Click);
            // 
            // lbl_ThreadSleep
            // 
            this.lbl_ThreadSleep.AutoSize = true;
            this.lbl_ThreadSleep.Location = new System.Drawing.Point(30, 49);
            this.lbl_ThreadSleep.Name = "lbl_ThreadSleep";
            this.lbl_ThreadSleep.Size = new System.Drawing.Size(0, 12);
            this.lbl_ThreadSleep.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_NonBlock
            // 
            this.lbl_NonBlock.AutoSize = true;
            this.lbl_NonBlock.Location = new System.Drawing.Point(97, 49);
            this.lbl_NonBlock.Name = "lbl_NonBlock";
            this.lbl_NonBlock.Size = new System.Drawing.Size(0, 12);
            this.lbl_NonBlock.TabIndex = 2;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Location = new System.Drawing.Point(160, 49);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(0, 12);
            this.lbl_Timer.TabIndex = 3;
            // 
            // btn_notBlock
            // 
            this.btn_notBlock.Location = new System.Drawing.Point(32, 194);
            this.btn_notBlock.Name = "btn_notBlock";
            this.btn_notBlock.Size = new System.Drawing.Size(75, 23);
            this.btn_notBlock.TabIndex = 4;
            this.btn_notBlock.Text = "NotBlock";
            this.btn_notBlock.UseVisualStyleBackColor = true;
            this.btn_notBlock.Click += new System.EventHandler(this.btn_notBlock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "NonBlock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thread.Sleep";
            // 
            // btn_TenSleep
            // 
            this.btn_TenSleep.Location = new System.Drawing.Point(152, 153);
            this.btn_TenSleep.Name = "btn_TenSleep";
            this.btn_TenSleep.Size = new System.Drawing.Size(75, 23);
            this.btn_TenSleep.TabIndex = 8;
            this.btn_TenSleep.Text = "TenSleep";
            this.btn_TenSleep.UseVisualStyleBackColor = true;
            this.btn_TenSleep.Click += new System.EventHandler(this.btn_TenSleep_Click);
            // 
            // btn_TenNotBlock
            // 
            this.btn_TenNotBlock.Location = new System.Drawing.Point(152, 194);
            this.btn_TenNotBlock.Name = "btn_TenNotBlock";
            this.btn_TenNotBlock.Size = new System.Drawing.Size(75, 23);
            this.btn_TenNotBlock.TabIndex = 9;
            this.btn_TenNotBlock.Text = "TenNotBlock";
            this.btn_TenNotBlock.UseVisualStyleBackColor = true;
            this.btn_TenNotBlock.Click += new System.EventHandler(this.btn_TenNotBlock_Click);
            // 
            // lbl_TenSleep
            // 
            this.lbl_TenSleep.AutoSize = true;
            this.lbl_TenSleep.Location = new System.Drawing.Point(30, 106);
            this.lbl_TenSleep.Name = "lbl_TenSleep";
            this.lbl_TenSleep.Size = new System.Drawing.Size(0, 12);
            this.lbl_TenSleep.TabIndex = 10;
            // 
            // lbl_TenNotBlock
            // 
            this.lbl_TenNotBlock.AutoSize = true;
            this.lbl_TenNotBlock.Location = new System.Drawing.Point(137, 106);
            this.lbl_TenNotBlock.Name = "lbl_TenNotBlock";
            this.lbl_TenNotBlock.Size = new System.Drawing.Size(0, 12);
            this.lbl_TenNotBlock.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_TenNotBlock);
            this.Controls.Add(this.lbl_TenSleep);
            this.Controls.Add(this.btn_TenNotBlock);
            this.Controls.Add(this.btn_TenSleep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_notBlock);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.lbl_NonBlock);
            this.Controls.Add(this.lbl_ThreadSleep);
            this.Controls.Add(this.btn_ThreadSleep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ThreadSleep;
        private System.Windows.Forms.Label lbl_ThreadSleep;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_NonBlock;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Button btn_notBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TenSleep;
        private System.Windows.Forms.Button btn_TenNotBlock;
        private System.Windows.Forms.Label lbl_TenSleep;
        private System.Windows.Forms.Label lbl_TenNotBlock;
    }
}

