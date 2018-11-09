using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

////////////////////////////////////////////////////
// This is the code for a 32bit calculator capable//
// of the usual calculations, has a small memory  //
// and can work with percentages and Euros        //
//                                                //
// Written by Jessica Luk-Maduro                  //
////////////////////////////////////////////////////

namespace Calculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // check later if var still best choice
            //var UserNumber = Console.ReadLine();
            //UserNumber = new string[];
            ValidifyNumber();

            string ValidInputNumbers = ValidNumber.ToString();
        }

        private static void ValidifyNumber(UserNumber)
        {
            if (UserNumber >= Int32.MinValue && Int32.MaxValue)
            {
                UserNumber = ValidNumber;
            }

            else
            {
                Console.WriteLine("You have used an invalid number." +
                    "Please try again with (a) different value(s) between" +
                    "-2.147.483.647 and 2.147.483.647");
            }
        }

        // private static void Subtract(ValidInputNumbers)
        {
            while (ValidInputNumbers >=  )
	        {

	        }
        }
    }
}
