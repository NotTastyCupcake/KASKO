using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProject.Person
{
    class PersonInfo : IPersonInfo
    {
        public static double PersonAge(string textBoxS)
        {
            int textBox = Convert.ToInt32(textBoxS);
            if (textBox >= 18 && textBox < 25) { return 1.20; }
            else if (textBox >= 25 && textBox < 40) { return 1.10; }
            else { return 1; };
        }
            
        public static double PersonStah(string textBoxS)
        {
            int textBox = Convert.ToInt32(textBoxS);
            if (textBox <= 3) { return 1.20; }
            else if (textBox > 3 && textBox <= 5) { return 1.10; }
            else { return 1; };
        }

        
    }
}
