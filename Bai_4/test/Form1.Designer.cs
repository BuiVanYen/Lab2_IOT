namespace test
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.butConnect = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butLed1_on = new System.Windows.Forms.Button();
            this.butLed2_on = new System.Windows.Forms.Button();
            this.butLed1_off = new System.Windows.Forms.Button();
            this.butLed2_off = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐIỀU KHIỂN LED";
            // 
            // butConnect
            // 
            this.butConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConnect.ForeColor = System.Drawing.Color.Lime;
            this.butConnect.Location = new System.Drawing.Point(189, 312);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(134, 60);
            this.butConnect.TabIndex = 2;
            this.butConnect.Text = "CONNECT";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.Color.Red;
            this.butExit.Location = new System.Drawing.Point(432, 312);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(134, 60);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "EXIT";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butLed1_on
            // 
            this.butLed1_on.BackColor = System.Drawing.Color.Lime;
            this.butLed1_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLed1_on.Location = new System.Drawing.Point(189, 113);
            this.butLed1_on.Name = "butLed1_on";
            this.butLed1_on.Size = new System.Drawing.Size(134, 60);
            this.butLed1_on.TabIndex = 4;
            this.butLed1_on.Text = "LED 1 ON";
            this.butLed1_on.UseVisualStyleBackColor = false;
            this.butLed1_on.Click += new System.EventHandler(this.butLed1_on_Click);
            // 
            // butLed2_on
            // 
            this.butLed2_on.BackColor = System.Drawing.Color.Lime;
            this.butLed2_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLed2_on.Location = new System.Drawing.Point(189, 207);
            this.butLed2_on.Name = "butLed2_on";
            this.butLed2_on.Size = new System.Drawing.Size(134, 60);
            this.butLed2_on.TabIndex = 5;
            this.butLed2_on.Text = "LED 2 ON";
            this.butLed2_on.UseVisualStyleBackColor = false;
            this.butLed2_on.Click += new System.EventHandler(this.butLed2_on_Click);
            // 
            // butLed1_off
            // 
            this.butLed1_off.BackColor = System.Drawing.Color.Red;
            this.butLed1_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLed1_off.Location = new System.Drawing.Point(432, 113);
            this.butLed1_off.Name = "butLed1_off";
            this.butLed1_off.Size = new System.Drawing.Size(134, 60);
            this.butLed1_off.TabIndex = 6;
            this.butLed1_off.Text = "LED 1 OFF";
            this.butLed1_off.UseVisualStyleBackColor = false;
            this.butLed1_off.Click += new System.EventHandler(this.butLed1_off_Click);
            // 
            // butLed2_off
            // 
            this.butLed2_off.BackColor = System.Drawing.Color.Red;
            this.butLed2_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLed2_off.Location = new System.Drawing.Point(432, 207);
            this.butLed2_off.Name = "butLed2_off";
            this.butLed2_off.Size = new System.Drawing.Size(134, 60);
            this.butLed2_off.TabIndex = 7;
            this.butLed2_off.Text = "LED 2 OFF";
            this.butLed2_off.UseVisualStyleBackColor = false;
            this.butLed2_off.Click += new System.EventHandler(this.butLed2_off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butLed2_off);
            this.Controls.Add(this.butLed1_off);
            this.Controls.Add(this.butLed2_on);
            this.Controls.Add(this.butLed1_on);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butLed1_on;
        private System.Windows.Forms.Button butLed2_on;
        private System.Windows.Forms.Button butLed1_off;
        private System.Windows.Forms.Button butLed2_off;
        private System.IO.Ports.SerialPort serCOM;
    }
}

