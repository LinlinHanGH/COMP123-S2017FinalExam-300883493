using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Linlin Han
 * Date: Aug 17, 2017
 * StudentID: 300883493
 * Description: This is the driver class
 * Version: 0.2-Start the SplashForm first instead of PickHighestCardForm
 */

namespace COMP123_S2017FinalExam_300883493
{
    public static class Program
    {
        //create Reference to Forms
        public static PickHighestCardForm pickHighestCardForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pickHighestCardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
