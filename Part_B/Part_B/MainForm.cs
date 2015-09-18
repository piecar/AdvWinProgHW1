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
        Size dSize;
        Point dLocation;
        public mainForm()
        {
            InitializeComponent();

            this.Size = Properties.Settings.Default.formSize;
            this.Location = Properties.Settings.Default.formPoint;
            this.dSize = this.Size;
            this.dLocation = this.Location;

            this.StartPosition = FormStartPosition.Manual;
        }

        public string PassName { get; set; }

        private void buttonSaveSize_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
        }

        private void buttonSaveLoc_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.formPoint = this.Location;
            Properties.Settings.Default.Save();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Size = dSize;
            this.Location = dLocation;
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.formPoint = this.Location;
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            ModelessForm mf = new ModelessForm();
            initModelessForm(mf);
            mf.Show();
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
                ListViewItem name = new ListViewItem(PassName);
                listNames.Items.Add(name);
            }
        }

        private void MainFrom_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.formPoint = this.Location;
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
        }
    }
}
