using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string geslacht = "";
            string province = "";
            foreach (RadioButton rb in gbProvince.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    province = rb.Text;
                }
            }
            foreach (RadioButton rb in Geslacht.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    geslacht = rb.Text;
                }
            }
            MessageBox.Show(
                    $"NAAM    :{tb1.Text}\n" +
                    $"ADRES   :{tb2.Text}\n" +
                    $"LEEFTIJD:{nud.Value}\n" +
                    $"GESLACHT:{geslacht}\n" +
                    $"PROVINCE:{province}");

        }




    }
    }

