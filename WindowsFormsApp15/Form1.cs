using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Formmateri : Form
    {
        public Formmateri()
        {
            InitializeComponent();
        }

        private void radiobuttonmerah_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonmerah.AutoCheck = radiobuttonmerah.Checked;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {

           listboxinput.Items.Add(textboxinput.Text);
        }

        private void listboxinput_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelout.Text = listboxinput.SelectedItems[0].ToString();
        }

        private void labeloutputtt_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxaktif_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonmerah.Checked)
            {
               labelout.ForeColor = Color.Red;
            }
            if (radioButtonbiru.Checked)
            {
               labelout.ForeColor = Color.Blue;
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            Formmateri NewForm = new Formmateri();
            NewForm.Show();
            this.Dispose(false);
        }

        private void Formmateri_Load(object sender, EventArgs e)
        {
           
        }
    }
}
