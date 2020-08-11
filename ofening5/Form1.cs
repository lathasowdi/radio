using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ofening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but3_Click_1(object sender, EventArgs e)
        {
            lb1.Items.Add(tb1.Text);
        }

        private void but4_Click_1(object sender, EventArgs e)
        {
            lb1.Items.RemoveAt(lb1.SelectedIndex);
        }

        private void but1_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("oefening5.txt"))
            {
                foreach (var item in lb1.Items)
                {
                    writer.WriteLine(item);
                }
            }

        }
        private void but2_Click_1(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            using (StreamReader reader = new StreamReader("oefening5.txt"))
            {
                while (!reader.EndOfStream)
                {
                    lb1.Items.Add(reader.ReadLine());
                }
            }

        }
    }
}
