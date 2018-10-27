namespace SpotifyTimer
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
            this.time_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.hours_nud = new System.Windows.Forms.NumericUpDown();
            this.minutes_nud = new System.Windows.Forms.NumericUpDown();
            this.seconds_nud = new System.Windows.Forms.NumericUpDown();
            this.processName_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.shutdown_cb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.hours_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seconds_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(31, 34);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(111, 29);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.Text = "00:00:00";
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(12, 173);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(69, 38);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // hours_nud
            // 
            this.hours_nud.Location = new System.Drawing.Point(12, 137);
            this.hours_nud.Name = "hours_nud";
            this.hours_nud.Size = new System.Drawing.Size(43, 20);
            this.hours_nud.TabIndex = 3;
            // 
            // minutes_nud
            // 
            this.minutes_nud.Location = new System.Drawing.Point(60, 137);
            this.minutes_nud.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_nud.Name = "minutes_nud";
            this.minutes_nud.Size = new System.Drawing.Size(54, 20);
            this.minutes_nud.TabIndex = 4;
            // 
            // seconds_nud
            // 
            this.seconds_nud.Location = new System.Drawing.Point(120, 137);
            this.seconds_nud.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.seconds_nud.Name = "seconds_nud";
            this.seconds_nud.Size = new System.Drawing.Size(48, 20);
            this.seconds_nud.TabIndex = 5;
            // 
            // processName_tb
            // 
            this.processName_tb.Location = new System.Drawing.Point(12, 110);
            this.processName_tb.Name = "processName_tb";
            this.processName_tb.Size = new System.Drawing.Size(156, 20);
            this.processName_tb.TabIndex = 6;
            this.processName_tb.Text = "Spotify";
            this.processName_tb.TextChanged += new System.EventHandler(this.processName_tb_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "stop_btn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // shutdown_cb
            // 
            this.shutdown_cb.AutoSize = true;
            this.shutdown_cb.Location = new System.Drawing.Point(12, 223);
            this.shutdown_cb.Name = "shutdown_cb";
            this.shutdown_cb.Size = new System.Drawing.Size(132, 17);
            this.shutdown_cb.TabIndex = 9;
            this.shutdown_cb.Text = "Turn off PC afterwards";
            this.shutdown_cb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 252);
            this.Controls.Add(this.shutdown_cb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.processName_tb);
            this.Controls.Add(this.seconds_nud);
            this.Controls.Add(this.minutes_nud);
            this.Controls.Add(this.hours_nud);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.time_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hours_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seconds_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.NumericUpDown hours_nud;
        private System.Windows.Forms.NumericUpDown minutes_nud;
        private System.Windows.Forms.NumericUpDown seconds_nud;
        private System.Windows.Forms.TextBox processName_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox shutdown_cb;
    }
}

