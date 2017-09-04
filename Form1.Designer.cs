namespace CodeNEncodeFile
{
    partial class Form1
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
            this.numericUpDownKey1 = new System.Windows.Forms.NumericUpDown();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSourceFileName = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSelectSourceFile = new System.Windows.Forms.Button();
            this.numericUpDownKey2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKey4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKey3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTargetPath = new System.Windows.Forms.TextBox();
            this.buttonSelectTargetFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonEncodeFile = new System.Windows.Forms.RadioButton();
            this.radioButtonCodeFile = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownKey1
            // 
            this.numericUpDownKey1.Enabled = false;
            this.numericUpDownKey1.Location = new System.Drawing.Point(99, 134);
            this.numericUpDownKey1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKey1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownKey1.Name = "numericUpDownKey1";
            this.numericUpDownKey1.Size = new System.Drawing.Size(89, 22);
            this.numericUpDownKey1.TabIndex = 5;
            this.numericUpDownKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(403, 165);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(127, 28);
            this.buttonRun.TabIndex = 11;
            this.buttonRun.Text = "Запуск";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вихідний файл:";
            // 
            // textBoxSourceFileName
            // 
            this.textBoxSourceFileName.Location = new System.Drawing.Point(136, 12);
            this.textBoxSourceFileName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceFileName.Name = "textBoxSourceFileName";
            this.textBoxSourceFileName.ReadOnly = true;
            this.textBoxSourceFileName.Size = new System.Drawing.Size(351, 22);
            this.textBoxSourceFileName.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 165);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(382, 28);
            this.progressBar.TabIndex = 4;
            // 
            // buttonSelectSourceFile
            // 
            this.buttonSelectSourceFile.Location = new System.Drawing.Point(495, 9);
            this.buttonSelectSourceFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectSourceFile.Name = "buttonSelectSourceFile";
            this.buttonSelectSourceFile.Size = new System.Drawing.Size(36, 28);
            this.buttonSelectSourceFile.TabIndex = 2;
            this.buttonSelectSourceFile.Text = "...";
            this.buttonSelectSourceFile.UseVisualStyleBackColor = true;
            this.buttonSelectSourceFile.Click += new System.EventHandler(this.buttonOpenSourceFile_Click);
            // 
            // numericUpDownKey2
            // 
            this.numericUpDownKey2.Enabled = false;
            this.numericUpDownKey2.Location = new System.Drawing.Point(195, 134);
            this.numericUpDownKey2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKey2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownKey2.Name = "numericUpDownKey2";
            this.numericUpDownKey2.Size = new System.Drawing.Size(89, 22);
            this.numericUpDownKey2.TabIndex = 6;
            this.numericUpDownKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownKey4
            // 
            this.numericUpDownKey4.Enabled = false;
            this.numericUpDownKey4.Location = new System.Drawing.Point(387, 134);
            this.numericUpDownKey4.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKey4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownKey4.Name = "numericUpDownKey4";
            this.numericUpDownKey4.Size = new System.Drawing.Size(89, 22);
            this.numericUpDownKey4.TabIndex = 8;
            this.numericUpDownKey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownKey3
            // 
            this.numericUpDownKey3.Enabled = false;
            this.numericUpDownKey3.Location = new System.Drawing.Point(291, 134);
            this.numericUpDownKey3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKey3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownKey3.Name = "numericUpDownKey3";
            this.numericUpDownKey3.Size = new System.Drawing.Size(89, 22);
            this.numericUpDownKey3.TabIndex = 7;
            this.numericUpDownKey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Шлях для збереження:";
            // 
            // textBoxTargetPath
            // 
            this.textBoxTargetPath.Location = new System.Drawing.Point(182, 47);
            this.textBoxTargetPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTargetPath.Name = "textBoxTargetPath";
            this.textBoxTargetPath.ReadOnly = true;
            this.textBoxTargetPath.Size = new System.Drawing.Size(305, 22);
            this.textBoxTargetPath.TabIndex = 3;
            // 
            // buttonSelectTargetFolder
            // 
            this.buttonSelectTargetFolder.Location = new System.Drawing.Point(494, 43);
            this.buttonSelectTargetFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectTargetFolder.Name = "buttonSelectTargetFolder";
            this.buttonSelectTargetFolder.Size = new System.Drawing.Size(36, 28);
            this.buttonSelectTargetFolder.TabIndex = 4;
            this.buttonSelectTargetFolder.Text = "...";
            this.buttonSelectTargetFolder.UseVisualStyleBackColor = true;
            this.buttonSelectTargetFolder.Click += new System.EventHandler(this.buttonSelectTargetFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ключі:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEncodeFile);
            this.groupBox1.Controls.Add(this.radioButtonCodeFile);
            this.groupBox1.Location = new System.Drawing.Point(13, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 46);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // radioButtonEncodeFile
            // 
            this.radioButtonEncodeFile.AutoSize = true;
            this.radioButtonEncodeFile.Location = new System.Drawing.Point(266, 19);
            this.radioButtonEncodeFile.Name = "radioButtonEncodeFile";
            this.radioButtonEncodeFile.Size = new System.Drawing.Size(166, 21);
            this.radioButtonEncodeFile.TabIndex = 1;
            this.radioButtonEncodeFile.Text = "розшифрувати файл";
            this.radioButtonEncodeFile.UseVisualStyleBackColor = true;
            this.radioButtonEncodeFile.CheckedChanged += new System.EventHandler(this.radioButtonEncodeFile_CheckedChanged);
            // 
            // radioButtonCodeFile
            // 
            this.radioButtonCodeFile.AutoSize = true;
            this.radioButtonCodeFile.Checked = true;
            this.radioButtonCodeFile.Location = new System.Drawing.Point(67, 19);
            this.radioButtonCodeFile.Name = "radioButtonCodeFile";
            this.radioButtonCodeFile.Size = new System.Drawing.Size(158, 21);
            this.radioButtonCodeFile.TabIndex = 0;
            this.radioButtonCodeFile.TabStop = true;
            this.radioButtonCodeFile.Text = "зашифрувати файл";
            this.radioButtonCodeFile.UseVisualStyleBackColor = true;
            this.radioButtonCodeFile.CheckedChanged += new System.EventHandler(this.radioButtonCodeFile_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 210);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSelectTargetFolder);
            this.Controls.Add(this.buttonSelectSourceFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxTargetPath);
            this.Controls.Add(this.textBoxSourceFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.numericUpDownKey4);
            this.Controls.Add(this.numericUpDownKey2);
            this.Controls.Add(this.numericUpDownKey3);
            this.Controls.Add(this.numericUpDownKey1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрування файлу";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownKey1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSourceFileName;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonSelectSourceFile;
        private System.Windows.Forms.NumericUpDown numericUpDownKey2;
        private System.Windows.Forms.NumericUpDown numericUpDownKey4;
        private System.Windows.Forms.NumericUpDown numericUpDownKey3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTargetPath;
        private System.Windows.Forms.Button buttonSelectTargetFolder;
        private string souceFileName;
        private string targetFolder;
        private byte[] keys = new byte[4];
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonEncodeFile;
        private System.Windows.Forms.RadioButton radioButtonCodeFile;
    }
}

