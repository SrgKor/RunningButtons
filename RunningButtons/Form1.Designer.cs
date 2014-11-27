namespace RunningButtons
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.first_btn = new System.Windows.Forms.Button();
            this.second_btn = new System.Windows.Forms.Button();
            this.third_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // first_btn
            // 
            this.first_btn.BackColor = System.Drawing.SystemColors.Control;
            this.first_btn.Location = new System.Drawing.Point(12, 22);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(75, 23);
            this.first_btn.TabIndex = 0;
            this.first_btn.Text = "button1";
            this.first_btn.UseVisualStyleBackColor = false;
            // 
            // second_btn
            // 
            this.second_btn.Location = new System.Drawing.Point(12, 68);
            this.second_btn.Name = "second_btn";
            this.second_btn.Size = new System.Drawing.Size(75, 23);
            this.second_btn.TabIndex = 1;
            this.second_btn.Text = "button2";
            this.second_btn.UseVisualStyleBackColor = true;
            // 
            // third_btn
            // 
            this.third_btn.Location = new System.Drawing.Point(12, 113);
            this.third_btn.Name = "third_btn";
            this.third_btn.Size = new System.Drawing.Size(75, 23);
            this.third_btn.TabIndex = 2;
            this.third_btn.Text = "button3";
            this.third_btn.UseVisualStyleBackColor = true;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(105, 19);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(82, 23);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "Start/Resume";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_button_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Location = new System.Drawing.Point(217, 19);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(75, 23);
            this.pause_btn.TabIndex = 4;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(328, 19);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 5;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.pause_btn);
            this.groupBox1.Controls.Add(this.stop_btn);
            this.groupBox1.Controls.Add(this.start_btn);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(85, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 61);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RunningButtons.Properties.Resources.finishLine;
            this.pictureBox1.Location = new System.Drawing.Point(619, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 114);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RunningButtons.Properties.Resources.finishLine;
            this.pictureBox2.Location = new System.Drawing.Point(87, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 114);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(641, 229);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.third_btn);
            this.Controls.Add(this.second_btn);
            this.Controls.Add(this.first_btn);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Гонка кнопок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Button second_btn;
        private System.Windows.Forms.Button third_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

