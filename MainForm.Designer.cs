namespace light_writer
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4_TotalCount = new System.Windows.Forms.Label();
            this.label5_CountPerKuten = new System.Windows.Forms.Label();
            this.label6_CountPerTouten = new System.Windows.Forms.Label();
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1_AlwaysTop = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4_TotalCount
            // 
            this.label4_TotalCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.label4_TotalCount, "label4_TotalCount");
            this.label4_TotalCount.Name = "label4_TotalCount";
            // 
            // label5_CountPerKuten
            // 
            resources.ApplyResources(this.label5_CountPerKuten, "label5_CountPerKuten");
            this.label5_CountPerKuten.Name = "label5_CountPerKuten";
            // 
            // label6_CountPerTouten
            // 
            resources.ApplyResources(this.label6_CountPerTouten, "label6_CountPerTouten");
            this.label6_CountPerTouten.Name = "label6_CountPerTouten";
            // 
            // mainRichTextBox
            // 
            resources.ApplyResources(this.mainRichTextBox, "mainRichTextBox");
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.TextChanged += new System.EventHandler(this.mainRichTextBox_TextChanged);
            this.mainRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainRichTextBox_KeyDown);
            this.mainRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainRichTextBox_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6_CountPerTouten, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4_TotalCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5_CountPerKuten, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1_AlwaysTop, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mainRichTextBox, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // checkBox1_AlwaysTop
            // 
            resources.ApplyResources(this.checkBox1_AlwaysTop, "checkBox1_AlwaysTop");
            this.checkBox1_AlwaysTop.Name = "checkBox1_AlwaysTop";
            this.checkBox1_AlwaysTop.UseVisualStyleBackColor = true;
            this.checkBox1_AlwaysTop.CheckedChanged += new System.EventHandler(this.checkBox1_AlwaysTop_CheckedChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4_TotalCount;
        private System.Windows.Forms.Label label5_CountPerKuten;
        private System.Windows.Forms.Label label6_CountPerTouten;
        private System.Windows.Forms.RichTextBox mainRichTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox1_AlwaysTop;
    }
}

