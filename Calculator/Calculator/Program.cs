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

            
        }
    }
}
