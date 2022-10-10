using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;

namespace WitcherDebug
{
    public static class Selo
    {
        public static bool SetStyleRefl(Control c, ControlStyles style, bool value)
        {
            var result = false;
            var type = typeof(Control);
            var method = type.GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance);
            if (method != null && c != null)
            {
                method.Invoke(c, new object[] { style, value });
                result = true;
            }
            return result;
        }
    }
}
