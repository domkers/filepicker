using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DumpPicker
{
    public partial class FormFileName : Form
    {
        /// <summary>
        /// 获取文件列表队列
        /// </summary>
        private Queue<string> dumpFiles = null;
        /// <summary>
        /// 当前程序的目录
        /// </summary>
        private string currentPath = null;
        /// <summary>
        /// 当前显示文件的路径
        /// </summary>
        private string currentShowFileName = null;

        public FormFileName()
        {
            InitializeComponent();
            currentPath = DumpFiles.GetCurrentPath();
            dumpFiles = DumpFiles.GetFiles(currentPath);
        }

        /// <summary>
        /// 调大字号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFontSizeUp_Click(object sender, EventArgs e)
        {
            float size = this.textBoxDumpContent.Font.Size;
            Font font = new Font(this.textBoxDumpContent.Font.Name, size + 1);
            this.textBoxDumpContent.Font = font;
        }

        /// <summary>
        /// 调小字号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFontSizeDown_Click(object sender, EventArgs e)
        {
            float size = this.textBoxDumpContent.Font.Size;
            Font font = new Font(this.textBoxDumpContent.Font.Name, size - 1, FontStyle.Regular);
            this.textBoxDumpContent.Font = font;
        }

        /// <summary>
        /// Fix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFix_Click(object sender, EventArgs e)
        {
            moveFile(currentShowFileName, "fix");
            showNextDumpFile();
        }

        /// <summary>
        /// UnFix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUnFix_Click(object sender, EventArgs e)
        {
            moveFile(currentShowFileName, "unfix");
            showNextDumpFile();
        }

        private void FormFileName_Load(object sender, EventArgs e)
        {
            showNextDumpFile();
            loadNameButtons();
        }

        private void loadNameButtons()
        {
            int y = 31;
            for (int i = 0; i < Config.names.Length; i++)
            {
                Button button = createButton(Config.folder[i], Config.names[i], 32, y);
                groupBoxPicker.Controls.Add(button);
                y += 40;
            }
        }

        /// <summary>
        /// 生成一个button
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Button createButton(string name, string text, int x, int y)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(x, y);
            button.Name = name;
            button.Size = new System.Drawing.Size(75, 23);
            button.TabIndex = 0;
            button.Text = text;
            button.UseVisualStyleBackColor = true;
            button.Click += Button_Click;
            return button;
        }

        /// <summary>
        /// 点击按钮之后进行分配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            moveFile(currentShowFileName, button.Name);
            showNextDumpFile();
        }

        /// <summary>
        /// 加载一个文件
        /// </summary>
        /// <param name="path"></param>
        private void loadDumpFile(string path)
        {
            this.textBoxFileName.Text = path;
            this.currentShowFileName = path;
            this.textBoxDumpContent.Text = DumpFiles.ReadFileContent(path);
        }

        /// <summary>
        /// 讲dump文件移动
        /// </summary>
        /// <param name="dumpFileName">文件名</param>
        /// <param name="destSubPath">当前目录子文件夹</param>
        private void moveFile(string dumpFileName, string destSubPath)
        {
            string dumpFullPath = Path.Combine(this.currentPath, dumpFileName);
            string destSubFullPath = Path.Combine(this.currentPath, destSubPath);
            string destFullPath = Path.Combine(destSubFullPath, Path.GetFileName(dumpFileName));
            if (!Directory.Exists(destSubPath))
            {
                // 如果不存在则创建
                Directory.CreateDirectory(destSubPath);
            }
            if (File.Exists(dumpFileName))
            {
                File.Move(dumpFullPath, destFullPath);
            }
        }

        /// <summary>
        /// 判断队列是否为空
        /// </summary>
        /// <returns></returns>
        private bool isDumpFileEmpty()
        {
            return !(dumpFiles.Count > 0);
        }

        /// <summary>
        /// 获取下一个文件名字
        /// </summary>
        /// <returns>队列为空的时候返回null</returns>
        private string getNextDumpFile()
        {
            if (!isDumpFileEmpty())
            {
                return dumpFiles.Dequeue();
            }
            return null;
        }

        /// <summary>
        /// 显示下一个dump文件信息
        /// </summary>
        private void showNextDumpFile()
        {
            string dumpFileName = getNextDumpFile();
            if (dumpFileName != null)
            {
                // 存在的时候显示
                loadDumpFile(dumpFileName);
            } else
            {
                this.textBoxDumpContent.Text = "";
                MessageBox.Show("dump文件已经被处理完毕");
            }
            this.labelFileCount.Text = string.Format("{0}个文件", dumpFiles.Count);
        }

    }
}
