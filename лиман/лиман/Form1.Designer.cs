namespace лиман
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Линейный = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCalculateClick = new System.Windows.Forms.Button();
            this.txtBoxX = new System.Windows.Forms.TextBox();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.txtBoxZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.Разветвляющийся = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cRedColor = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonExp = new System.Windows.Forms.RadioButton();
            this.radioButtonSqr = new System.Windows.Forms.RadioButton();
            this.radioButtonCos = new System.Windows.Forms.RadioButton();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Линейный.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Разветвляющийся.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Линейный);
            this.tabControl1.Controls.Add(this.Разветвляющийся);
            this.tabControl1.Location = new System.Drawing.Point(229, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 524);
            this.tabControl1.TabIndex = 22;
            // 
            // Линейный
            // 
            this.Линейный.Controls.Add(this.pictureBox1);
            this.Линейный.Controls.Add(this.buttonCalculateClick);
            this.Линейный.Controls.Add(this.txtBoxX);
            this.Линейный.Controls.Add(this.txtBoxY);
            this.Линейный.Controls.Add(this.txtBoxZ);
            this.Линейный.Controls.Add(this.label1);
            this.Линейный.Controls.Add(this.label2);
            this.Линейный.Controls.Add(this.label3);
            this.Линейный.Controls.Add(this.textBoxResult2);
            this.Линейный.Location = new System.Drawing.Point(4, 25);
            this.Линейный.Margin = new System.Windows.Forms.Padding(4);
            this.Линейный.Name = "Линейный";
            this.Линейный.Padding = new System.Windows.Forms.Padding(4);
            this.Линейный.Size = new System.Drawing.Size(1105, 495);
            this.Линейный.TabIndex = 0;
            this.Линейный.Text = "Линейный";
            this.Линейный.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 79);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonCalculateClick
            // 
            this.buttonCalculateClick.Location = new System.Drawing.Point(387, 287);
            this.buttonCalculateClick.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculateClick.Name = "buttonCalculateClick";
            this.buttonCalculateClick.Size = new System.Drawing.Size(185, 38);
            this.buttonCalculateClick.TabIndex = 0;
            this.buttonCalculateClick.Text = "Вычислить";
            this.buttonCalculateClick.UseVisualStyleBackColor = true;
            this.buttonCalculateClick.Click += new System.EventHandler(this.buttonCalculateClick_Click);
            // 
            // txtBoxX
            // 
            this.txtBoxX.Location = new System.Drawing.Point(227, 153);
            this.txtBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.Size = new System.Drawing.Size(201, 22);
            this.txtBoxX.TabIndex = 2;
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(227, 204);
            this.txtBoxY.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.Size = new System.Drawing.Size(201, 22);
            this.txtBoxY.TabIndex = 3;
            // 
            // txtBoxZ
            // 
            this.txtBoxZ.Location = new System.Drawing.Point(227, 250);
            this.txtBoxZ.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxZ.Name = "txtBoxZ";
            this.txtBoxZ.Size = new System.Drawing.Size(201, 22);
            this.txtBoxZ.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите значение X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите значение Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите значение Z:";
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Location = new System.Drawing.Point(73, 295);
            this.textBoxResult2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult2.Multiline = true;
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.Size = new System.Drawing.Size(292, 148);
            this.textBoxResult2.TabIndex = 8;
            this.textBoxResult2.Text = "Результат:";
            // 
            // Разветвляющийся
            // 
            this.Разветвляющийся.Controls.Add(this.pictureBox2);
            this.Разветвляющийся.Controls.Add(this.cRedColor);
            this.Разветвляющийся.Controls.Add(this.button1);
            this.Разветвляющийся.Controls.Add(this.groupBox1);
            this.Разветвляющийся.Controls.Add(this.textBoxX);
            this.Разветвляющийся.Controls.Add(this.txtResult);
            this.Разветвляющийся.Controls.Add(this.textBoxY);
            this.Разветвляющийся.Controls.Add(this.label4);
            this.Разветвляющийся.Controls.Add(this.label6);
            this.Разветвляющийся.Controls.Add(this.label5);
            this.Разветвляющийся.Location = new System.Drawing.Point(4, 25);
            this.Разветвляющийся.Margin = new System.Windows.Forms.Padding(4);
            this.Разветвляющийся.Name = "Разветвляющийся";
            this.Разветвляющийся.Padding = new System.Windows.Forms.Padding(4);
            this.Разветвляющийся.Size = new System.Drawing.Size(1105, 495);
            this.Разветвляющийся.TabIndex = 1;
            this.Разветвляющийся.Text = "Разветвляющийся";
            this.Разветвляющийся.UseVisualStyleBackColor = true;
            this.Разветвляющийся.Click += new System.EventHandler(this.Разветвляющийся_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(143, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(393, 95);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // cRedColor
            // 
            this.cRedColor.AutoSize = true;
            this.cRedColor.Location = new System.Drawing.Point(144, 422);
            this.cRedColor.Margin = new System.Windows.Forms.Padding(4);
            this.cRedColor.Name = "cRedColor";
            this.cRedColor.Size = new System.Drawing.Size(179, 20);
            this.cRedColor.TabIndex = 20;
            this.cRedColor.Text = "Ответ красным цветом";
            this.cRedColor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonExp);
            this.groupBox1.Controls.Add(this.radioButtonSqr);
            this.groupBox1.Controls.Add(this.radioButtonCos);
            this.groupBox1.Location = new System.Drawing.Point(651, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(263, 162);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор функции:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonExp
            // 
            this.radioButtonExp.AutoSize = true;
            this.radioButtonExp.Location = new System.Drawing.Point(35, 92);
            this.radioButtonExp.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonExp.Name = "radioButtonExp";
            this.radioButtonExp.Size = new System.Drawing.Size(64, 20);
            this.radioButtonExp.TabIndex = 20;
            this.radioButtonExp.TabStop = true;
            this.radioButtonExp.Text = "exp(x)";
            this.radioButtonExp.UseVisualStyleBackColor = true;
            // 
            // radioButtonSqr
            // 
            this.radioButtonSqr.AutoSize = true;
            this.radioButtonSqr.Location = new System.Drawing.Point(35, 64);
            this.radioButtonSqr.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSqr.Name = "radioButtonSqr";
            this.radioButtonSqr.Size = new System.Drawing.Size(47, 20);
            this.radioButtonSqr.TabIndex = 19;
            this.radioButtonSqr.TabStop = true;
            this.radioButtonSqr.Text = "sqr";
            this.radioButtonSqr.UseVisualStyleBackColor = true;
            // 
            // radioButtonCos
            // 
            this.radioButtonCos.AutoSize = true;
            this.radioButtonCos.Location = new System.Drawing.Point(35, 36);
            this.radioButtonCos.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCos.Name = "radioButtonCos";
            this.radioButtonCos.Size = new System.Drawing.Size(64, 20);
            this.radioButtonCos.TabIndex = 18;
            this.radioButtonCos.TabStop = true;
            this.radioButtonCos.Text = "cos(x)";
            this.radioButtonCos.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(298, 186);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(153, 22);
            this.textBoxX.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(143, 287);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(307, 115);
            this.txtResult.TabIndex = 17;
            this.txtResult.Text = "Результат:";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(298, 234);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(153, 22);
            this.textBoxY.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Введите значение X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите значение Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Линейный.ResumeLayout(false);
            this.Линейный.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Разветвляющийся.ResumeLayout(false);
            this.Разветвляющийся.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Линейный;
        private System.Windows.Forms.Button buttonCalculateClick;
        private System.Windows.Forms.TextBox txtBoxX;
        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.TextBox txtBoxZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult2;
        private System.Windows.Forms.TabPage Разветвляющийся;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cRedColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonExp;
        private System.Windows.Forms.RadioButton radioButtonSqr;
        private System.Windows.Forms.RadioButton radioButtonCos;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

