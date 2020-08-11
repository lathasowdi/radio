using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Notitieboekje notitieboekje = new Notitieboekje();
        private void button1_Click(object sender, EventArgs e)
        {
            lb1.Items.Add($"Notitie {lb1.Items.Count + 1}");

             notitieboekje.Aanmaken(tb1.Text );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notitieboekje.MijnNotities.RemoveAt(lb1.SelectedIndex);
            lb1.Items.Remove(lb1.SelectedItem);
            for (int i = 0; i < lb1.Items.Count; i++)
            {
                lb1.Items[i] = $"Notitie {i + 1}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           tb1.Text = notitieboekje.NotitieBijschrijven(lb1.SelectedIndex, tb1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in ActiveForm.Controls.OfType<Button>())
            {
                item.Enabled = false;
            }
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex > -1)
            {
                tb1.Text = notitieboekje.BekijkNotitie(lb1.SelectedIndex);
            }
        }

        //private void btnLamineren_Click(object sender, EventArgs e)
        //{
        //    //methode 1 
        //    //btnBijschrijven.Enabled = false;
        //    //btnUitscheuren.Enabled = false;
        //    //btnToevoegen.Enabled = false;
        //    //btnLamineren.Enabled = false;
        //    // methode 2
        //    //foreach (Control c in Controls)
        //    //{
        //    //    Button b = c as Button;
        //    //    if (b != null)
        //    //    {
        //    //        b.Enabled = false;
        //    //    }
        //    //}
        //    //methode 3 (benjamin gevonden)
        //    foreach (var item in ActiveForm.Controls.OfType<Button>())
        //    {
        //        item.Enabled = false;
        //    }
        //}
        
    }
}
