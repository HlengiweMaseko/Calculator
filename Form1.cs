using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CALCULATOR : Form
    {
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Exit the program
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);

            //Calculate
            int Sum = num1 + num2 + num3;
            int average = (num1 + num2 + num3) / 3;
            
            //String Output
            string Msg = "RESULT";

            //Output
            MessageBox.Show("The Sum is: " + Sum + "\nThe Average is: " + average, Msg );

        }
    }
}
