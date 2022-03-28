using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Week4LabGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ValidationBtn_Click(object sender, EventArgs e)
        {
            string phoneNum = txtName.Text;
            string MatchPhonePattern = @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$";
            Regex rx = new Regex(MatchPhonePattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match match = rx.Match(phoneNum);
            if (match.Success)
                lblDisplay.Text = "Valid number";
            else
                lblDisplay.Text = "not valid";

        }

        private void SSNValBtn_Click(object sender, EventArgs e)
        {
            string phoneNum = ssnName.Text;
            string MatchSocialPattern = @"^\d{3}-\d{2}-\d{4}$";
            Regex rx = new Regex(MatchSocialPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match match = rx.Match(phoneNum);
            if (match.Success)
                lblDisplay.Text = "Valid number";
            else
                lblDisplay.Text = "not valid";
        }
    }
}
