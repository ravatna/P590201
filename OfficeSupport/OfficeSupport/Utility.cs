using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OfficeSupport
{
    static class Utility
    {
        static public void FocusTo(KeyPressEventArgs e, TextBox f) {
            if (e.KeyChar == 13) {
                f.Focus();
            }
        }

        static public void FocusTo(KeyPressEventArgs e, RadioButton f)
        {
            if (e.KeyChar == 13)
            {
                f.Focus();
            }
        }

        static public void FocusTo(KeyPressEventArgs e, CheckBox f)
        {
            if (e.KeyChar == 13)
            {
                f.Focus();
            }
        }

        static public void FocusTo(KeyPressEventArgs e, Button f)
        {
            if (e.KeyChar == 13)
            {
                f.Focus();
            }
        }

        static public void FocusTo(Keys k, TextBox f)
        {
            if (k == Keys.Enter)
            {
                f.Focus();
            }
        }

        static public void FocusTo(Keys k, RadioButton f)
        {
            if (k == Keys.Enter)
            {
                f.Focus();
            }
        }

        static public void FocusTo(Keys k, CheckBox f)
        {
            if (k == Keys.Enter)
            {
                f.Focus();
            }
        }

        static public void FocusTo(Keys k, Button f)
        {
            if (k == Keys.Enter)
            {
                f.Focus();
            }
        }

        static public int getInt(String sender, int i)
        {
            int _v = i;
            try
            {
                _v = int.Parse(sender);
            }
            catch (Exception e) { }
            return (int)_v;
        }

        static public double getDouble(String sender, double d)
        {
            double _v = d;
            try
            {
                _v = int.Parse(sender);
            }
            catch (Exception e) { }
            return (double)_v;
        }


       

        /// <summary>
        /// ส่ง สองค่าเข้าไป ให้ได้ ค่าที่ต้องการออกมาถ้าไม่ใช้ ให้คืนค่า error ออกมา
        /// </summary>
        /// <param name="compare"></param>
        /// <param name="with"></param>
        /// <param name="to"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        static public String transform(String compare,String with,String toBe,String error) {
            String _v = error;
            if (compare == with)
            {
                _v = toBe;
            }


            return _v;
        }
    }
}
