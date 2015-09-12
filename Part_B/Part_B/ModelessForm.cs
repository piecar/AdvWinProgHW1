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

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(nameBox.Text))
            {
                nameErrorProvider.SetError(nameBox, "Empty. Add a name.");
            }
            else
            {
                nameErrorProvider.Clear();
                if (Apply != null)
                {
                    Console.WriteLine("Apply was done");
                    Apply(this, EventArgs.Empty);
                }
                Console.WriteLine("Apply was NOT done");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Close was done");
            if(nameErrorProvider.GetError(nameBox)=="")
            {
                this.Close();
            }
        }

        private void ModelessForm_PressUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                closeButton_Click(sender, e);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            applyButton_Click(sender, e);
            this.Close();
        }

        // IPassName Implementation
        public String PassName
        {
            get
            {
                return nameBox.Text;
            }
            set
            {
                nameBox.Text = value;
            }
        }

        public event EventHandler Apply;
    }
}
