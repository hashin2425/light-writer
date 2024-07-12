using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace light_writer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // load settings and last input
            checkBox1_AlwaysTop.Checked = Properties.Settings.Default.IsTopMost;
            mainRichTextBox.Text = Properties.Settings.Default.LastText;
        }

        private void updateCounter()
        {
            string currentText = mainRichTextBox.Text;

            // count
            int currentTextCount = currentText.Length;
            int countKuten = currentText.Count(c => c == '。');
            int countTouten = currentText.Count(c => c == '、');
            float currentTextCountPerKuten = (currentTextCount - countKuten) / Math.Max(1, countKuten);
            float currentTextCountPerTouten = (currentTextCount - countKuten - countTouten) / Math.Max(1, countKuten + countTouten);

            // update
            label4_TotalCount.Text = currentTextCount.ToString("N0") + "文字";
            label5_CountPerKuten.Text = "平均" + currentTextCountPerKuten.ToString("N2") + "文字（" + countKuten.ToString("N0") + "文）";
            label6_CountPerTouten.Text = "平均" + currentTextCountPerTouten.ToString("N2") + "文字";
        }

        private void mainRichTextBox_TextChanged(object sender, EventArgs e) { updateCounter(); }
        private void MainFrom_Load(object sender, EventArgs e) { updateCounter(); }
        private void checkBox1_AlwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1_AlwaysTop.Checked;
        }

        // 入力中（つまり変換未確定の状態）でも文字数カウントを実行できるが、変換未確定の状態が解除されてしまう
        private void MainForm_KeyDown(object sender, KeyEventArgs e) { }
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e) { }
        private void mainRichTextBox_KeyDown(object sender, KeyEventArgs e) { }
        private void mainRichTextBox_KeyPress(object sender, KeyPressEventArgs e) { }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.IsTopMost = checkBox1_AlwaysTop.Checked;
            Properties.Settings.Default.LastText = mainRichTextBox.Text;

            Properties.Settings.Default.Save();
        }
    }
}
