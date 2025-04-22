using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    /// <summary>
    /// <para>
    ///     Script : 蓋亞
    /// </para>
    /// <para>
    ///     Written by : Lai Yu Ting
    /// </para>
    /// <para>
    ///     Latest update : 21/9/2020 17:56
    /// </para>
    /// </summary>
    public partial class Script_2 : DrScript
    {
        //=================================================================================================
        //  script
        //=================================================================================================
        protected override void script()
        {
            while (start)
            {
                dm.KeyDownChar("0");
                dm.KeyUpChar("0");
                dm.KeyDownChar("q");
                dm.KeyDownChar("3");
                dm.KeyUpChar("q");
                dm.KeyUpChar("3");
                dm.KeyDownChar("3");
                dm.RightDown();
                Thread.Sleep(360);
                dm.RightUp();
                dm.KeyUpChar("3");
                Thread.Sleep(280);
            }
        }
        //=================================================================================================



        //=================================================================================================
        //  constructor
        //=================================================================================================
        /// <summary>
        /// 蓋亞 Constructor
        /// </summary>
        public Script_2() : base()
        {
            dm = new CDmSoft();
            InitializeComponent();
            uiInit();
            scriptName = "蓋亞";
        }
        //=================================================================================================



        //=================================================================================================
        //  UI initialize
        //=================================================================================================
        // ui initialization
        private void uiInit()
        {
            // add all hotkey to combobox
            cmbHotkey.DataSource = Enum.GetValues(typeof(MyHotkeysList));
        }
        //=================================================================================================



        //=================================================================================================
        //  UI event
        //=================================================================================================

        private void cmbHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotkey.changeKey((int)cmbHotkey.SelectedItem);
        }

        //=================================================================================================

    }
}
