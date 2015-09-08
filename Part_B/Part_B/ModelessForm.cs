using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_B
{
    public partial class ModelessForm : Form
    {
        public ModelessForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void nameBox_PressUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            }
        }

        private void ModelessForm_PressUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            }

        }
    }
}
