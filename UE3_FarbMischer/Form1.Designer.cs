namespace UE3_FarbMischer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            panel1 = new Panel();
            label1 = new Label();
            lblRed = new Label();
            trkRed = new TrackBar();
            pan = new Panel();
            trkGreen = new TrackBar();
            lblGreen = new Label();
            label3 = new Label();
            trkBlue = new TrackBar();
            lblBlue = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkBlue).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(184, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(184, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 96);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(184, 36);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(3, 100);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(184, 36);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(3, 58);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(184, 36);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(3, 16);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(184, 36);
            radioButton6.TabIndex = 3;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton5);
            panel1.Location = new Point(216, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 154);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(137, 226);
            label1.Name = "label1";
            label1.Size = new Size(77, 45);
            label1.TabIndex = 7;
            label1.Text = "Red";
            // 
            // lblRed
            // 
            lblRed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRed.ForeColor = Color.Red;
            lblRed.Location = new Point(584, 216);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(79, 64);
            lblRed.TabIndex = 8;
            lblRed.Text = "0";
            lblRed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trkRed
            // 
            trkRed.Location = new Point(234, 226);
            trkRed.Maximum = 255;
            trkRed.Name = "trkRed";
            trkRed.Size = new Size(362, 90);
            trkRed.TabIndex = 9;
            trkRed.Scroll += CalculateColor;
            // 
            // pan
            // 
            pan.BackColor = Color.Black;
            pan.Location = new Point(757, 260);
            pan.Name = "pan";
            pan.Size = new Size(444, 440);
            pan.TabIndex = 10;
            // 
            // trkGreen
            // 
            trkGreen.Location = new Point(234, 302);
            trkGreen.Maximum = 255;
            trkGreen.Name = "trkGreen";
            trkGreen.Size = new Size(362, 90);
            trkGreen.TabIndex = 13;
            trkGreen.Scroll += CalculateColor;
            // 
            // lblGreen
            // 
            lblGreen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGreen.ForeColor = Color.Green;
            lblGreen.Location = new Point(584, 292);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(79, 64);
            lblGreen.TabIndex = 12;
            lblGreen.Text = "0";
            lblGreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(137, 302);
            label3.Name = "label3";
            label3.Size = new Size(109, 45);
            label3.TabIndex = 11;
            label3.Text = "Green";
            // 
            // trkBlue
            // 
            trkBlue.Location = new Point(234, 376);
            trkBlue.Maximum = 255;
            trkBlue.Name = "trkBlue";
            trkBlue.Size = new Size(362, 90);
            trkBlue.TabIndex = 16;
            trkBlue.Scroll += CalculateColor;
            // 
            // lblBlue
            // 
            lblBlue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBlue.ForeColor = Color.Blue;
            lblBlue.Location = new Point(584, 366);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(79, 64);
            lblBlue.TabIndex = 15;
            lblBlue.Text = "0";
            lblBlue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(137, 376);
            label5.Name = "label5";
            label5.Size = new Size(86, 45);
            label5.TabIndex = 14;
            label5.Text = "Blue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 712);
            Controls.Add(trkBlue);
            Controls.Add(lblBlue);
            Controls.Add(label5);
            Controls.Add(trkGreen);
            Controls.Add(lblGreen);
            Controls.Add(label3);
            Controls.Add(pan);
            Controls.Add(trkRed);
            Controls.Add(lblRed);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Panel panel1;
        private Label label1;
        private Label lblRed;
        private TrackBar trkRed;
        private Panel pan;
        private TrackBar trkGreen;
        private Label lblGreen;
        private Label label3;
        private TrackBar trkBlue;
        private Label lblBlue;
        private Label label5;
    }
}
