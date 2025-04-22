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
    ///     Script : GS 
    /// </para>
    /// <para>
    ///     Written by : Lai Yu Ting
    /// </para>
    /// <para>
    ///     Latest update : 21/9/2020 17:56
    /// </para>
    /// </summary>
    public partial class Script_1 : DrScript
    {
        //=================================================================================================
        //  script
        //=================================================================================================
        protected override void script()
        {
            while (start)
            {
                dm.KeyDownChar("ctrl");
                dm.KeyUpChar("ctrl");
                Thread.Sleep(242);
            }
        }
        //=================================================================================================



        //=================================================================================================
        //  constructor
        //=================================================================================================
        /// <summary>
        /// GS Constructor
        /// </summary>
        public Script_1():base()
        {
            dm = new CDmSoft();
            InitializeComponent();
            uiInit();
            scriptName = "GS";
        }
        //=================================================================================================



        //=================================================================================================
        //  UI initialize
        //=================================================================================================
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
            keyCode = (int)cmbHotkey.SelectedItem;
            hotkey.changeKey(keyCode);
        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == rdbPress)
            {
                changeHotkeyModePress();
            }
            else if(sender == rdbHold)
            {
                changeHotkeyModeHold();
            }
        }
        //=================================================================================================


    }
}
