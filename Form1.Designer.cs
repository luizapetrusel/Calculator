namespace calculator
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
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.btCE = new System.Windows.Forms.Button();
            this.btBS = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt11 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt10 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt12 = new System.Windows.Forms.Button();
            this.bt14 = new System.Windows.Forms.Button();
            this.bt15 = new System.Windows.Forms.Button();
            this.bt13 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt16 = new System.Windows.Forms.Button();
            this.bt17 = new System.Windows.Forms.Button();
            this.bt18 = new System.Windows.Forms.Button();
            this.btEqual = new System.Windows.Forms.Button();
            this.bt20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textDisplay.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay.Location = new System.Drawing.Point(11, 18);
            this.textDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(448, 42);
            this.textDisplay.TabIndex = 0;
            this.textDisplay.Text = "0";
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btCE
            // 
            this.btCE.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btCE.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.Location = new System.Drawing.Point(132, 80);
            this.btCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(89, 54);
            this.btCE.TabIndex = 1;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = false;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btBS
            // 
            this.btBS.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btBS.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBS.Location = new System.Drawing.Point(28, 80);
            this.btBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBS.Name = "btBS";
            this.btBS.Size = new System.Drawing.Size(89, 54);
            this.btBS.TabIndex = 1;
            this.btBS.Text = "⌫";
            this.btBS.UseVisualStyleBackColor = false;
            this.btBS.Click += new System.EventHandler(this.btBS_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btClear.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(239, 80);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(89, 54);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt4.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(349, 80);
            this.bt4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(89, 54);
            this.bt4.TabIndex = 1;
            this.bt4.Text = "±";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt11
            // 
            this.bt11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt11.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt11.Location = new System.Drawing.Point(239, 221);
            this.bt11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt11.Name = "bt11";
            this.bt11.Size = new System.Drawing.Size(89, 54);
            this.bt11.TabIndex = 1;
            this.bt11.Text = "6";
            this.bt11.UseVisualStyleBackColor = false;
            this.bt11.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt5.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(28, 150);
            this.bt5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(89, 54);
            this.bt5.TabIndex = 1;
            this.bt5.Text = "7";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt10
            // 
            this.bt10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt10.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt10.Location = new System.Drawing.Point(132, 221);
            this.bt10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt10.Name = "bt10";
            this.bt10.Size = new System.Drawing.Size(89, 54);
            this.bt10.TabIndex = 1;
            this.bt10.Text = "5";
            this.bt10.UseVisualStyleBackColor = false;
            this.bt10.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt6.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(132, 150);
            this.bt6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(89, 54);
            this.bt6.TabIndex = 1;
            this.bt6.Text = "8";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt9.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(28, 221);
            this.bt9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(89, 54);
            this.bt9.TabIndex = 1;
            this.bt9.Text = "4";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt12
            // 
            this.bt12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt12.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt12.Location = new System.Drawing.Point(349, 221);
            this.bt12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt12.Name = "bt12";
            this.bt12.Size = new System.Drawing.Size(89, 54);
            this.bt12.TabIndex = 1;
            this.bt12.Text = "-";
            this.bt12.UseVisualStyleBackColor = false;
            this.bt12.Click += new System.EventHandler(this.Operational_Function);
            // 
            // bt14
            // 
            this.bt14.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt14.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt14.Location = new System.Drawing.Point(132, 295);
            this.bt14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt14.Name = "bt14";
            this.bt14.Size = new System.Drawing.Size(89, 54);
            this.bt14.TabIndex = 1;
            this.bt14.Text = "2";
            this.bt14.UseVisualStyleBackColor = false;
            this.bt14.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt15
            // 
            this.bt15.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt15.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt15.Location = new System.Drawing.Point(239, 295);
            this.bt15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt15.Name = "bt15";
            this.bt15.Size = new System.Drawing.Size(89, 54);
            this.bt15.TabIndex = 1;
            this.bt15.Text = "3";
            this.bt15.UseVisualStyleBackColor = false;
            this.bt15.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt13
            // 
            this.bt13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt13.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt13.Location = new System.Drawing.Point(28, 295);
            this.bt13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt13.Name = "bt13";
            this.bt13.Size = new System.Drawing.Size(89, 54);
            this.bt13.TabIndex = 1;
            this.bt13.Text = "1";
            this.bt13.UseVisualStyleBackColor = false;
            this.bt13.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt7.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(239, 150);
            this.bt7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(89, 54);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "9";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt8.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(349, 150);
            this.bt8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(89, 54);
            this.bt8.TabIndex = 1;
            this.bt8.Text = "+";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.Operational_Function);
            // 
            // bt16
            // 
            this.bt16.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt16.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt16.Location = new System.Drawing.Point(349, 295);
            this.bt16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt16.Name = "bt16";
            this.bt16.Size = new System.Drawing.Size(89, 54);
            this.bt16.TabIndex = 1;
            this.bt16.Text = "*";
            this.bt16.UseVisualStyleBackColor = false;
            this.bt16.Click += new System.EventHandler(this.Operational_Function);
            // 
            // bt17
            // 
            this.bt17.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt17.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt17.Location = new System.Drawing.Point(28, 370);
            this.bt17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt17.Name = "bt17";
            this.bt17.Size = new System.Drawing.Size(89, 54);
            this.bt17.TabIndex = 1;
            this.bt17.Text = "0";
            this.bt17.UseVisualStyleBackColor = false;
            this.bt17.Click += new System.EventHandler(this.NumericValue);
            // 
            // bt18
            // 
            this.bt18.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt18.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt18.Location = new System.Drawing.Point(132, 370);
            this.bt18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt18.Name = "bt18";
            this.bt18.Size = new System.Drawing.Size(89, 54);
            this.bt18.TabIndex = 1;
            this.bt18.Text = ".";
            this.bt18.UseVisualStyleBackColor = false;
            this.bt18.Click += new System.EventHandler(this.NumericValue);
            // 
            // btEqual
            // 
            this.btEqual.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btEqual.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEqual.Location = new System.Drawing.Point(239, 370);
            this.btEqual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(89, 54);
            this.btEqual.TabIndex = 1;
            this.btEqual.Text = "=";
            this.btEqual.UseVisualStyleBackColor = false;
            this.btEqual.Click += new System.EventHandler(this.btEqual_Click);
            // 
            // bt20
            // 
            this.bt20.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt20.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt20.Location = new System.Drawing.Point(349, 370);
            this.bt20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt20.Name = "bt20";
            this.bt20.Size = new System.Drawing.Size(89, 54);
            this.bt20.TabIndex = 1;
            this.bt20.Text = "/";
            this.bt20.UseVisualStyleBackColor = false;
            this.bt20.Click += new System.EventHandler(this.Operational_Function);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(469, 475);
            this.Controls.Add(this.btBS);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt13);
            this.Controls.Add(this.bt20);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.bt18);
            this.Controls.Add(this.bt17);
            this.Controls.Add(this.bt16);
            this.Controls.Add(this.bt15);
            this.Controls.Add(this.bt14);
            this.Controls.Add(this.bt12);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt10);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt11);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.textDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btBS;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt11;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt10;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt12;
        private System.Windows.Forms.Button bt14;
        private System.Windows.Forms.Button bt15;
        private System.Windows.Forms.Button bt13;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt16;
        private System.Windows.Forms.Button bt17;
        private System.Windows.Forms.Button bt18;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.Button bt20;
    }
}

