namespace Гранди
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
            this.initialCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondDivision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.moveButton = new System.Windows.Forms.Button();
            this.firstDivision = new System.Windows.Forms.TextBox();
            this.heapNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rulesButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.TextBox();
            this.heapList = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // initialCount
            // 
            this.initialCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initialCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialCount.Location = new System.Drawing.Point(395, 207);
            this.initialCount.Name = "initialCount";
            this.initialCount.Size = new System.Drawing.Size(65, 28);
            this.initialCount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Первый ход:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Начальное количество фишек:";
            // 
            // secondDivision
            // 
            this.secondDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondDivision.Location = new System.Drawing.Point(816, 426);
            this.secondDivision.Name = "secondDivision";
            this.secondDivision.ReadOnly = true;
            this.secondDivision.Size = new System.Drawing.Size(50, 28);
            this.secondDivision.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(790, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "и";
            // 
            // moveButton
            // 
            this.moveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveButton.Location = new System.Drawing.Point(580, 482);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(186, 43);
            this.moveButton.TabIndex = 22;
            this.moveButton.Text = "СДЕЛАТЬ ХОД";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstDivision
            // 
            this.firstDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDivision.Location = new System.Drawing.Point(734, 426);
            this.firstDivision.Name = "firstDivision";
            this.firstDivision.Size = new System.Drawing.Size(50, 28);
            this.firstDivision.TabIndex = 21;
            // 
            // heapNumber
            // 
            this.heapNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heapNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heapNumber.Location = new System.Drawing.Point(721, 390);
            this.heapNumber.Name = "heapNumber";
            this.heapNumber.Size = new System.Drawing.Size(50, 28);
            this.heapNumber.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(591, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Разделить на";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(591, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Номер кучи:";
            // 
            // rulesButton
            // 
            this.rulesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rulesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesButton.Location = new System.Drawing.Point(270, 327);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(190, 43);
            this.rulesButton.TabIndex = 27;
            this.rulesButton.Text = "ПРАВИЛА ИГРЫ";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(776, 482);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 43);
            this.resetButton.TabIndex = 26;
            this.resetButton.Text = "СБРОС";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(112, 327);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 43);
            this.startButton.TabIndex = 25;
            this.startButton.Text = "НАЧАТЬ ИГРУ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // info
            // 
            this.info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(559, 289);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(375, 27);
            this.info.TabIndex = 28;
            // 
            // heapList
            // 
            this.heapList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heapList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heapList.FormattingEnabled = true;
            this.heapList.ItemHeight = 22;
            this.heapList.Location = new System.Drawing.Point(559, 69);
            this.heapList.Name = "heapList";
            this.heapList.Size = new System.Drawing.Size(375, 180);
            this.heapList.TabIndex = 29;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(230, 254);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 22);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Компьютер";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(230, 282);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 22);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Человек";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(648, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ход игрока";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Настройки игры";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(555, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Информация о сделанном ходе";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(555, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Список куч";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 595);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.heapList);
            this.Controls.Add(this.info);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.secondDivision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.firstDivision);
            this.Controls.Add(this.heapNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.initialCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(1017, 642);
            this.Name = "Form1";
            this.Text = "Компьютерная игра Гранди";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox initialCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondDivision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.TextBox firstDivision;
        private System.Windows.Forms.TextBox heapNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.ListBox heapList;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

