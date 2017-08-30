namespace test0829_RefOut {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.ValTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ParamsTextBox1 = new System.Windows.Forms.TextBox();
            this.ParamsValTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ParamsTextBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ParamsTextBox3 = new System.Windows.Forms.TextBox();
            this.Btn3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ValTextBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(187, 207);
            this.Btn1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(88, 42);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "+";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(376, 49);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(143, 74);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "多個相加";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // ValTextBox
            // 
            this.ValTextBox.Location = new System.Drawing.Point(359, 207);
            this.ValTextBox.Name = "ValTextBox";
            this.ValTextBox.Size = new System.Drawing.Size(100, 36);
            this.ValTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Params Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "params plus:";
            // 
            // ParamsTextBox1
            // 
            this.ParamsTextBox1.Location = new System.Drawing.Point(57, 66);
            this.ParamsTextBox1.Name = "ParamsTextBox1";
            this.ParamsTextBox1.Size = new System.Drawing.Size(46, 36);
            this.ParamsTextBox1.TabIndex = 7;
            // 
            // ParamsValTextBox
            // 
            this.ParamsValTextBox.Location = new System.Drawing.Point(261, 133);
            this.ParamsValTextBox.Name = "ParamsValTextBox";
            this.ParamsValTextBox.Size = new System.Drawing.Size(86, 36);
            this.ParamsValTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "x=10 y= 20.555:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aws:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "x:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "y:";
            // 
            // ParamsTextBox2
            // 
            this.ParamsTextBox2.Location = new System.Drawing.Point(143, 66);
            this.ParamsTextBox2.Name = "ParamsTextBox2";
            this.ParamsTextBox2.Size = new System.Drawing.Size(69, 36);
            this.ParamsTextBox2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "z:";
            // 
            // ParamsTextBox3
            // 
            this.ParamsTextBox3.Location = new System.Drawing.Point(261, 66);
            this.ParamsTextBox3.Name = "ParamsTextBox3";
            this.ParamsTextBox3.Size = new System.Drawing.Size(86, 36);
            this.ParamsTextBox3.TabIndex = 15;
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(187, 316);
            this.Btn3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(88, 42);
            this.Btn3.TabIndex = 16;
            this.Btn3.Text = "+";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "x=10 y= 20.555:";
            // 
            // ValTextBox2
            // 
            this.ValTextBox2.Location = new System.Drawing.Point(359, 316);
            this.ValTextBox2.Name = "ValTextBox2";
            this.ValTextBox2.Size = new System.Drawing.Size(100, 36);
            this.ValTextBox2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Aws:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 522);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValTextBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.ParamsTextBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ParamsTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ParamsValTextBox);
            this.Controls.Add(this.ParamsTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValTextBox);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.TextBox ValTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParamsTextBox1;
        private System.Windows.Forms.TextBox ParamsValTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ParamsTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ParamsTextBox3;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ValTextBox2;
        private System.Windows.Forms.Label label9;
    }
}

