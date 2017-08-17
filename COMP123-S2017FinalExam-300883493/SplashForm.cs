using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Linlin Han
 * Date: Aug 17, 2017
 * StudentID: 300883493
 * Description: This is the Splash form class
 * Version: 0.1-Created the Splash form
 */

namespace COMP123_S2017FinalExam_300883493
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickHightestCardForm = new PickHighestCardForm();
            pickHightestCardForm.Show();
            this.Hide();
        }
    }
}
