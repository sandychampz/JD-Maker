using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JD_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qualifydocAU = "HEHEHHEHEHE";
            string newword = suburb.Text;
            string newreg = region.Text;
            string currentText = sample.Text;
            string profession = profession1.Text;
            string billtype = bill.Text;
            string xxx1 = XX1.Text;
            string xxx2 = XX2.Text;

            string contact1 = "";
            string qualification = "";
            if (profession == "General Practitioner")
            {
                contact1 = "gprecruitment@medfuture.com.au\r\nCheny +61 420 468 717 and Sayeda +61 3 7065 4322";
                qualification = qualifydocAU;

            }
            else if (profession == "Physiotherapist")
            {
                contact1 = "gprecruitment@medfuture.com.au\r\nCheny +61 420 468 717 and Sayeda +61 3 7065 4322";
                qualification = "Physio Shit";

            }
            else
            {
                MessageBox.Show("ERROR" + profession);
                return;
            }






            Dictionary<string, string> replacements = new Dictionary<string, string>
    {
        { "111", newword },
        { "112", newreg },
        { "Professionx",profession},
        { "xbillings",billtype },
        { "ContactDETAILS",contact1 },
        {"X1",xxx1 },
        {"X2",xxx2 },
        {"QUALIFICATION DATA",qualification },
            };

            foreach (var replacement in replacements)
            {
                currentText = currentText.Replace(replacement.Key, replacement.Value);
            }

            sample.Text = currentText;
        }
    }
}
