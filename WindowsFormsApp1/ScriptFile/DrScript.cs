using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// <para>
    ///     Script : Template
    /// </para>
    /// <para>
    ///     Written by : Lai Yu Ting
    /// </para>
    /// <para>
    ///     Latest update : 21/9/2020 13:56
    /// </para>
    /// </summary>
    public class DrScript : UserControl, IScript
    {
        //=================================================================================================
        //  variable
        //=================================================================================================
        protected CDmSoft dm;
        protected Thread scriptThread;
        protected Hotkey_Press hotkey;
        protected int keyCode = 0;
        protected bool start = false;
        public string scriptName { get; protected set; } = "ScriptName";
        //=================================================================================================



        //=================================================================================================
        //  constructor
        //=================================================================================================
        public DrScript()
        {
            init();
        }
        //=================================================================================================



        //=================================================================================================
        //  hotkey initialize
        //=================================================================================================
        private void init()
        {
            //dm = new CDmSoft();
            hotkey = new Hotkey_Press(this);
        }
        //=================================================================================================



        //=================================================================================================
        //  change hotkey mode : press
        //=================================================================================================
        protected void changeHotkeyModePress()
        {
            hotkey.stop();
            hotkey = new Hotkey_Press(this);
            hotkey.changeKey(keyCode);
        }
        //=================================================================================================



        //=================================================================================================
        //  change hotkey mode : hold
        //=================================================================================================
        protected void changeHotkeyModeHold()
        {
            hotkey.stop();
            hotkey = new Hotkey_Hold(this);
            hotkey.changeKey(keyCode);
        }
        //=================================================================================================



        //=================================================================================================
        //  script thread start
        //=================================================================================================
        public void scriptStart()
        {
            if (scriptThread == null || scriptThread.ThreadState == System.Threading.ThreadState.Unstarted)
            {
                scriptThread = new Thread(script);
                scriptThread.Start();
                start = true;
            }
        }
        //=================================================================================================



        //=================================================================================================
        //  script thread stop
        //=================================================================================================
        public void scriptStop()
        {
            if (scriptThread != null && scriptThread.ThreadState != System.Threading.ThreadState.Unstarted)
            {
                start = false;
                scriptThread = null;
            }
        }
        //=================================================================================================



        //=================================================================================================
        //  script thread
        //=================================================================================================
        protected virtual void script()
        {
            while (start)
            {
                // Template
                //dm.KeyDownChar("ctrl");
                //dm.KeyUpChar("ctrl");
                //Thread.Sleep(242);
            }
        }
        //=================================================================================================



        //=================================================================================================
        // not use
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Script
            // 
            this.Name = "Script";
            this.ResumeLayout(false);
        }
        //=================================================================================================

    }
}
