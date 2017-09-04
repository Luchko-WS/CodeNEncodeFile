using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CodeNEncodeFile
{
    public partial class Form1 : Form
    {
        Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenSourceFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.Filter = "Усі файли|*.*";
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "Вибір файлу...";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxSourceFileName.Text = openFileDialog.FileName;
                    this.souceFileName = openFileDialog.SafeFileName;
                }
            }
        }

        private void buttonSelectTargetFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrouserDialog = new FolderBrowserDialog())
            {
                if (folderBrouserDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxTargetPath.Text = folderBrouserDialog.SelectedPath;
                    this.targetFolder = folderBrouserDialog.SelectedPath;
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (this.buttonRun.Text == "Запуск")
            {
                if (this.textBoxSourceFileName.Text == this.targetFolder + "\\" + this.souceFileName)
                {
                    MessageBox.Show("Шлях вихідного і результуючого файлу збігаються!\nЗмініть шлях результуючого файлу.",
                        "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (this.radioButtonCodeFile.Checked)
                {
                    if (String.IsNullOrWhiteSpace(textBoxSourceFileName.Text) || String.IsNullOrWhiteSpace(textBoxTargetPath.Text))
                    {
                        MessageBox.Show("Не заповнені усі поля.");
                        return;
                    }

                    var rndObj = new Random();
                    for (var i = 0; i < 4; i++)
                    {
                        this.keys[i] = (byte)rndObj.Next(0, 255);
                    }
                }
                else
                {
                    try
                    {
                        this.keys[0] = Convert.ToByte(numericUpDownKey1.Value);
                        this.keys[1] = Convert.ToByte(numericUpDownKey2.Value);
                        this.keys[2] = Convert.ToByte(numericUpDownKey3.Value);
                        this.keys[3] = Convert.ToByte(numericUpDownKey4.Value);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Невірний формат ключа (він має бути в медах від 0 до 255).");
                        return;
                    }
                }

                thread = new Thread(new ThreadStart(coding));
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                thread.Abort();
                this.buttonRun.Text = "Запуск";
                this.buttonSelectTargetFolder.Enabled = true;
                this.buttonSelectSourceFile.Enabled = true;
                this.radioButtonCodeFile.Enabled = true;
                this.radioButtonEncodeFile.Enabled = true;
                this.progressBar.Value = 0;
            }
        }

        private void coding()
        {
            this.buttonRun.Text = "Стоп";
            this.buttonSelectTargetFolder.Enabled = false;
            this.buttonSelectSourceFile.Enabled = false;
            this.radioButtonCodeFile.Enabled = false;
            this.radioButtonEncodeFile.Enabled = false;

            byte[] token = new byte[1];

            try
            {
                using (var fsSource = new FileStream(this.textBoxSourceFileName.Text, FileMode.Open))
                {
                    using (var fsTarget = new FileStream(this.targetFolder + "\\" + this.souceFileName, FileMode.Create))
                    {
                        for (var i = 0L; i < fsSource.Length; i++)
                        {
                            fsSource.Read(token, 0, 1);

                            for (var j = 0; j < 4; j++)
                                token[0] = Convert.ToByte(token[0] ^ keys[j]);

                            fsTarget.Write(token, 0, 1);
                            this.progressBar.Value = Convert.ToInt32(100 * i / fsSource.Length);
                        }

                        this.progressBar.Value = 0;
                        fsSource.Close();
                        fsTarget.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка при зчитуванні чи створенні файлу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonRun.Text = "Запуск";
                this.buttonSelectTargetFolder.Enabled = true;
                this.buttonSelectSourceFile.Enabled = true;
                this.radioButtonCodeFile.Enabled = true;
                this.radioButtonEncodeFile.Enabled = true;

                if(File.Exists(this.targetFolder + "\\" + this.souceFileName))
                {
                    File.Delete(this.targetFolder + "\\" + this.souceFileName);
                }
            }

            if(this.radioButtonCodeFile.Checked)
            {
                var keyForm = new KeyForm();
                keyForm.textBoxKey.Text = keys[0] + " " + keys[1] + " " + keys[2] + " " + keys[3];
                keyForm.ShowDialog();
            }

            this.buttonRun.Text = "Запуск";
            this.buttonSelectTargetFolder.Enabled = true;
            this.buttonSelectSourceFile.Enabled = true;
            this.radioButtonCodeFile.Enabled = true;
            this.radioButtonEncodeFile.Enabled = true;

        }

        private void radioButtonCodeFile_CheckedChanged(object sender, EventArgs e)
        {
            this.numericUpDownKey1.Enabled = false;
            this.numericUpDownKey2.Enabled = false;
            this.numericUpDownKey3.Enabled = false;
            this.numericUpDownKey4.Enabled = false;
        }

        private void radioButtonEncodeFile_CheckedChanged(object sender, EventArgs e)
        {
            this.numericUpDownKey1.Enabled = true;
            this.numericUpDownKey2.Enabled = true;
            this.numericUpDownKey3.Enabled = true;
            this.numericUpDownKey4.Enabled = true;
        }
    }
}
