using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    /// <summary>
    /// <para>
    ///     Dr Script Main Form
    /// </para>
    /// <para>
    ///     Written by : Lai Yu Ting
    /// </para>
    /// <para>
    ///     Latest update : 22/9/2020 1:08
    /// </para>
    /// </summary>
    public partial class MainForm : Form
    {
        List<DrScript> scripts = new List<DrScript>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            scripts.Add(new Script_1());
            scripts.Add(new Script_2());
            scripts.Add(new Script_1());
            scripts.Add(new Script_2());
            scripts.Add(new Script_1());
            scripts.Add(new Script_2());
            scripts.Add(new Script_1());
            scripts.Add(new Script_2());
            scripts.Add(new Script_1());
            scripts.Add(new Script_2());
            scripts.Add(new Script_1());
            scripts.Add(new Script_2());
            scripts.Add(new Script_1());
            scripts.Add(new Script_2());
            autoScriptUI();
        }

        // not perfect
        private void autoScriptUI()
        {
            tabControl1.Controls.Clear();
            double height = tabControl1.Height - 50;
            double sumHeight = 10.0;
            TabPage tabPage = new TabPage();
            int pageNum = 1;
            tabPage.Text = "Page" + pageNum++;
            foreach (DrScript script in scripts)
            {
                GroupBox groupBox = setGroupBox(script);
                if ((sumHeight + script.Height + 50) > height)
                {
                    tabControl1.TabPages.Add(tabPage);
                    tabPage = new TabPage();
                    tabPage.Text = "Page" + pageNum++;
                    sumHeight = 10;
                    groupBox.Top = (int)sumHeight;
                    tabPage.Controls.Add(groupBox);
                }
                else
                {
                    tabPage.Controls.Add(groupBox);
                    groupBox.Top = (int)sumHeight;
                }
                sumHeight += groupBox.Height + 40;
            }
            tabControl1.TabPages.Add(tabPage);
            MinimumSize = new Size(scripts.Max(s => s.Size.Width) + 100, 550);
        }

        private GroupBox setGroupBox(DrScript script)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Controls.Add(script);
            script.Top = 40;
            script.Left = 10;
            groupBox.Text = script.scriptName;
            groupBox.Height = script.Height + script.Top + 10;
            groupBox.Left = 10;
            groupBox.Width = Width - 40;
            return groupBox;
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            autoScriptUI();
        }


    }
}
