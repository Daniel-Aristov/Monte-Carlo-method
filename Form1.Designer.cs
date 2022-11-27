namespace teorVer_3
{
    partial class MainWindow
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.CountSteps = new System.Windows.Forms.TextBox();
            this.LowerLimit = new System.Windows.Forms.TextBox();
            this.UpperLimit = new System.Windows.Forms.TextBox();
            this.labelIntegralGiven = new System.Windows.Forms.Label();
            this.labelCountSteps = new System.Windows.Forms.Label();
            this.labelLowerLimit = new System.Windows.Forms.Label();
            this.labelUpperLimit = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.ResultAnalitics = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.ResultMonteKarlo = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnCalculate.Location = new System.Drawing.Point(65, 187);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 36);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panelInput
            // 
            this.panelInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.panelInput.Controls.Add(this.btnClear);
            this.panelInput.Controls.Add(this.CountSteps);
            this.panelInput.Controls.Add(this.btnCalculate);
            this.panelInput.Controls.Add(this.LowerLimit);
            this.panelInput.Controls.Add(this.UpperLimit);
            this.panelInput.Controls.Add(this.labelIntegralGiven);
            this.panelInput.Controls.Add(this.labelCountSteps);
            this.panelInput.Controls.Add(this.labelLowerLimit);
            this.panelInput.Controls.Add(this.labelUpperLimit);
            this.panelInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.panelInput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelInput.Location = new System.Drawing.Point(12, 12);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(462, 247);
            this.panelInput.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.btnClear.Location = new System.Drawing.Point(231, 187);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CountSteps
            // 
            this.CountSteps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.CountSteps.Location = new System.Drawing.Point(301, 128);
            this.CountSteps.Name = "CountSteps";
            this.CountSteps.Size = new System.Drawing.Size(72, 26);
            this.CountSteps.TabIndex = 4;
            this.CountSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountSteps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountSteps_KeyPress);
            // 
            // LowerLimit
            // 
            this.LowerLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.LowerLimit.Location = new System.Drawing.Point(301, 88);
            this.LowerLimit.Name = "LowerLimit";
            this.LowerLimit.Size = new System.Drawing.Size(72, 26);
            this.LowerLimit.TabIndex = 3;
            this.LowerLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowerLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowerLimit_KeyPress);
            // 
            // UpperLimit
            // 
            this.UpperLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.UpperLimit.Location = new System.Drawing.Point(301, 50);
            this.UpperLimit.Name = "UpperLimit";
            this.UpperLimit.Size = new System.Drawing.Size(72, 26);
            this.UpperLimit.TabIndex = 2;
            this.UpperLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpperLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpperLimit_KeyPress);
            // 
            // labelIntegralGiven
            // 
            this.labelIntegralGiven.AutoSize = true;
            this.labelIntegralGiven.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.labelIntegralGiven.Location = new System.Drawing.Point(135, 13);
            this.labelIntegralGiven.Name = "labelIntegralGiven";
            this.labelIntegralGiven.Size = new System.Drawing.Size(222, 21);
            this.labelIntegralGiven.TabIndex = 1;
            this.labelIntegralGiven.Text = "Интеграл: ∫(cos(x)-x))dx";
            // 
            // labelCountSteps
            // 
            this.labelCountSteps.AutoSize = true;
            this.labelCountSteps.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCountSteps.Location = new System.Drawing.Point(61, 131);
            this.labelCountSteps.Name = "labelCountSteps";
            this.labelCountSteps.Size = new System.Drawing.Size(234, 19);
            this.labelCountSteps.TabIndex = 0;
            this.labelCountSteps.Text = "Введите количество шагов:";
            // 
            // labelLowerLimit
            // 
            this.labelLowerLimit.AutoSize = true;
            this.labelLowerLimit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLowerLimit.Location = new System.Drawing.Point(61, 87);
            this.labelLowerLimit.Name = "labelLowerLimit";
            this.labelLowerLimit.Size = new System.Drawing.Size(211, 19);
            this.labelLowerLimit.TabIndex = 0;
            this.labelLowerLimit.Text = "Введите нижний предел:";
            // 
            // labelUpperLimit
            // 
            this.labelUpperLimit.AutoSize = true;
            this.labelUpperLimit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUpperLimit.Location = new System.Drawing.Point(61, 52);
            this.labelUpperLimit.Name = "labelUpperLimit";
            this.labelUpperLimit.Size = new System.Drawing.Size(217, 19);
            this.labelUpperLimit.TabIndex = 0;
            this.labelUpperLimit.Text = "Введите верхний предел:";
            // 
            // panelOutput
            // 
            this.panelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.panelOutput.Controls.Add(this.ResultAnalitics);
            this.panelOutput.Controls.Add(this.labelResults);
            this.panelOutput.Controls.Add(this.ResultMonteKarlo);
            this.panelOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.panelOutput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelOutput.Location = new System.Drawing.Point(12, 277);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(462, 154);
            this.panelOutput.TabIndex = 2;
            // 
            // ResultAnalitics
            // 
            this.ResultAnalitics.AutoSize = true;
            this.ResultAnalitics.Location = new System.Drawing.Point(17, 101);
            this.ResultAnalitics.Name = "ResultAnalitics";
            this.ResultAnalitics.Size = new System.Drawing.Size(190, 19);
            this.ResultAnalitics.TabIndex = 0;
            this.ResultAnalitics.Text = "Аналитический метод:";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.labelResults.Location = new System.Drawing.Point(162, 14);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(116, 21);
            this.labelResults.TabIndex = 0;
            this.labelResults.Text = "Результаты";
            // 
            // ResultMonteKarlo
            // 
            this.ResultMonteKarlo.AutoSize = true;
            this.ResultMonteKarlo.Location = new System.Drawing.Point(17, 58);
            this.ResultMonteKarlo.Name = "ResultMonteKarlo";
            this.ResultMonteKarlo.Size = new System.Drawing.Size(173, 19);
            this.ResultMonteKarlo.TabIndex = 0;
            this.ResultMonteKarlo.Text = "Метод Монте-Карло:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №3. Метод Монте-Карло";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox CountSteps;
        private System.Windows.Forms.TextBox LowerLimit;
        private System.Windows.Forms.TextBox UpperLimit;
        private System.Windows.Forms.Label labelIntegralGiven;
        private System.Windows.Forms.Label labelCountSteps;
        private System.Windows.Forms.Label labelLowerLimit;
        private System.Windows.Forms.Label labelUpperLimit;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Label ResultAnalitics;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label ResultMonteKarlo;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

