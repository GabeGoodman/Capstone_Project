namespace VideoCameraViewer01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.connectBtn = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbConnect = new System.Windows.Forms.RadioButton();
            this.rbDisconnect = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(10, 230);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(440, 64);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(117, 58);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(317, 130);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(117, 58);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(563, 130);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(117, 58);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(440, 194);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(117, 58);
            this.btnBackward.TabIndex = 5;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(440, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 48);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(317, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbConnect
            // 
            this.rbConnect.AutoSize = true;
            this.rbConnect.Location = new System.Drawing.Point(317, 13);
            this.rbConnect.Name = "rbConnect";
            this.rbConnect.Size = new System.Drawing.Size(65, 17);
            this.rbConnect.TabIndex = 8;
            this.rbConnect.TabStop = true;
            this.rbConnect.Text = "Connect";
            this.rbConnect.UseVisualStyleBackColor = true;
            this.rbConnect.CheckedChanged += new System.EventHandler(this.rbConnect_CheckedChanged);
            // 
            // rbDisconnect
            // 
            this.rbDisconnect.AutoSize = true;
            this.rbDisconnect.Location = new System.Drawing.Point(575, 20);
            this.rbDisconnect.Name = "rbDisconnect";
            this.rbDisconnect.Size = new System.Drawing.Size(79, 17);
            this.rbDisconnect.TabIndex = 9;
            this.rbDisconnect.TabStop = true;
            this.rbDisconnect.Text = "Disconnect";
            this.rbDisconnect.UseVisualStyleBackColor = true;
            this.rbDisconnect.CheckedChanged += new System.EventHandler(this.rbDisconnect_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 264);
            this.Controls.Add(this.rbDisconnect);
            this.Controls.Add(this.rbConnect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Camera\'s Live Image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbConnect;
        private System.Windows.Forms.RadioButton rbDisconnect;
    }
}