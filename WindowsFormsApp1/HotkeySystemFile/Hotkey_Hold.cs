using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /// <summary>
    /// <para>
    ///     Hotkey System : Hotkey : Hold
    /// </para>
    /// <para>
    ///     Written by : Lai Yu Ting
    /// </para>
    /// <para>
    ///     Latest update : 21/9/2020 13:35
    /// </para>
    /// </summary>
    class Hotkey_Hold : Hotkey_Press
    {
        private bool starting = false;

        public Hotkey_Hold(IScript script) : base(script){}

        //=================================================================================================
        //  hook key down callback
        //=================================================================================================
        public override void keyDown()
        {
            script.scriptStart();
        }
        //=================================================================================================



        //=================================================================================================
        //  hook key up callback
        //=================================================================================================
        public override void keyUp()
        {
            if (!starting)
            {
                starting = true;
                
            }
            else
            {
                starting = false;
                script.scriptStop();
            }
        }
        //=================================================================================================

    }
}
