namespace SpyS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Info_1 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.URLText = new System.Windows.Forms.TextBox();
            this.ElementText = new System.Windows.Forms.TextBox();
            this.IntervalText = new System.Windows.Forms.TextBox();
            this.Checker = new System.Windows.Forms.Timer(this.components);
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Note = new System.Windows.Forms.NotifyIcon(this.components);
            this.RefreshBox = new System.Windows.Forms.CheckBox();
            this.RingCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Info_1
            // 
            this.Info_1.AutoSize = true;
            this.Info_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_1.Location = new System.Drawing.Point(68, 28);
            this.Info_1.Name = "Info_1";
            this.Info_1.Size = new System.Drawing.Size(139, 33);
            this.Info_1.TabIndex = 0;
            this.Info_1.Text = "NO-INFO";
            this.Info_1.TextChanged += new System.EventHandler(this.Info_1_TextChanged);
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Button.Location = new System.Drawing.Point(172, 90);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(100, 46);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Info_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 83);
            this.panel1.TabIndex = 2;
            // 
            // Stop_Button
            // 
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop_Button.Location = new System.Drawing.Point(172, 136);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(100, 46);
            this.Stop_Button.TabIndex = 3;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // URLText
            // 
            this.URLText.Location = new System.Drawing.Point(12, 12);
            this.URLText.Name = "URLText";
            this.URLText.Size = new System.Drawing.Size(260, 20);
            this.URLText.TabIndex = 4;
            this.URLText.Text = "URL";
            // 
            // ElementText
            // 
            this.ElementText.Location = new System.Drawing.Point(12, 38);
            this.ElementText.Name = "ElementText";
            this.ElementText.Size = new System.Drawing.Size(260, 20);
            this.ElementText.TabIndex = 5;
            this.ElementText.Text = "Element Selector";
            // 
            // IntervalText
            // 
            this.IntervalText.Location = new System.Drawing.Point(12, 64);
            this.IntervalText.Name = "IntervalText";
            this.IntervalText.Size = new System.Drawing.Size(55, 20);
            this.IntervalText.TabIndex = 6;
            this.IntervalText.Text = "Interval";
            // 
            // Checker
            // 
            this.Checker.Tick += new System.EventHandler(this.Checker_Tick);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitBtn.Location = new System.Drawing.Point(220, 64);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(52, 20);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Note
            // 
            this.Note.Text = "SELL & BUY!!!";
            // 
            // RefreshBox
            // 
            this.RefreshBox.AutoSize = true;
            this.RefreshBox.Location = new System.Drawing.Point(74, 66);
            this.RefreshBox.Name = "RefreshBox";
            this.RefreshBox.Size = new System.Drawing.Size(63, 17);
            this.RefreshBox.TabIndex = 9;
            this.RefreshBox.Text = "Refresh";
            this.RefreshBox.UseVisualStyleBackColor = true;
            // 
            // RingCheck
            // 
            this.RingCheck.AutoSize = true;
            this.RingCheck.Location = new System.Drawing.Point(143, 66);
            this.RingCheck.Name = "RingCheck";
            this.RingCheck.Size = new System.Drawing.Size(48, 17);
            this.RingCheck.TabIndex = 10;
            this.RingCheck.Text = "Ring";
            this.RingCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpyS.Properties.Resources.Img_1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RingCheck);
            this.Controls.Add(this.RefreshBox);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.IntervalText);
            this.Controls.Add(this.ElementText);
            this.Controls.Add(this.URLText);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Start_Button);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SpyS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info_1;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.TextBox URLText;
        private System.Windows.Forms.TextBox ElementText;
        private System.Windows.Forms.Timer Checker;
        private System.Windows.Forms.TextBox IntervalText;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.NotifyIcon Note;
        private System.Windows.Forms.CheckBox RefreshBox;
        private System.Windows.Forms.CheckBox RingCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

