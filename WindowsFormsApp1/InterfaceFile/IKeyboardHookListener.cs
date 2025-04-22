using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /// <summary>
    /// <para>
    ///     Keyboard Hook Listener interface
    /// </para>
    /// <para>
    ///     Written by : Lai Yu Ting
    /// </para>
    /// <para>
    ///     Latest update : 19/9/2020 11:01
    /// </para>
    /// </summary>
    public interface IKeyboardHookListener
    {
        void keyDown();
        void keyUp();
    }
}
