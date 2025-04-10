using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace trading_simulator
{
    public class Class1
    {
        public static bool launched = false;
        public static void Launch()
        {

            if (launched == false)
            {
                // zdroj: https://stackoverflow.com/questions/2618830/show-a-form-from-another-form
                var form = new WindowsFormsApp1.TradingSimulator();
                form.Show();
                launched = true;
                
            }
            else if (launched  == true){
               
            }


        }
    }
}
