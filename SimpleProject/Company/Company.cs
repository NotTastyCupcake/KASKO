using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProject.Company
{
    class Company : ICompany
    {
        public static int CompFranc(string textBox)
        {
            if ( Convert.ToInt32(textBox) >= 10000)
            {
                return Convert.ToInt32(textBox);
            }
            else return 10000;
        }
        
        public static double CompFrancB(bool checkBox)
        {
            if (checkBox) { return 1.50; }
            else return 1;
        }

        public static int CompRate(bool checkBox, string textBox)
        {
            int min = 20000;
            if (checkBox) { if (Convert.ToInt32(textBox) >= min) return Convert.ToInt32(textBox); else return min; }
            else return 20000;
        }
    }
}
