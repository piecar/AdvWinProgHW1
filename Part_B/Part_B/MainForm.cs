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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            this.Size = Properties.Settings.Default.formSize;
            this.Location = Properties.Settings.Default.formPoint;
        }

        public string PassName { get; set; }

        private void buttonSaveSize_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
        }

        private void buttonSaveLoc_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.formPoint = this.Location;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            this.Location = Properties.Settings.Default.formPoint;
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            ModelessForm mf = new ModelessForm();
            initModelessForm(mf);
            mf.Show();

            ListViewItem name = new ListViewItem(PassName);
            listNames.Items.Add(name);
        }

        private void initModelessForm(ModelessForm mf)
        {
            mf.Apply += new EventHandler(nameForm_Apply);
        }

        private void nameForm_Apply(object sender, EventArgs e)
        {
            IPassName nameForm = sender as IPassName;
            if(nameForm != null)
            {
                this.PassName = nameForm.passName;
            }
        }


    }
}
