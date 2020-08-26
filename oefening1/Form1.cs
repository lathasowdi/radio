using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butmijnbutton1_Click(object sender, EventArgs e)
        {
            inactief.Items.Add(mijntextbox1.Text);
            inactief.SelectedIndex = inactief.Items.Count - 1;
        }

        private void mijntextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butmijnbutton1_Click(sender, e);
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            inactief.Items.Add(actief.SelectedItem);
            actief.Items.Remove(actief.SelectedItem);
            inactief.SelectedIndex = inactief.Items.Count - 1;
            changelist(actief, inactief);
        }
        public void changelist(ListBox list1, ListBox list2)
        {
            foreach (var item in list1.SelectedItems)
            {
                list2.Items.Add(item);
            }
            for (int i = list1.SelectedItems.Count - 1; i >= 0; i--)
                list1.Items.Remove(list1.SelectedItems[i]);
        }

        private void but2_Click(object sender, EventArgs e)
        {
            actief.Items.Add(inactief.SelectedItem);
            inactief.Items.Remove(inactief.SelectedItem);
            actief.SelectedIndex = actief.Items.Count - 1;
            changelist(inactief, actief);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

