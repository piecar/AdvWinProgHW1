namespace Part_B
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSaveLoc = new System.Windows.Forms.Button();
            this.buttonSaveSize = new System.Windows.Forms.Button();
            this.buttonName = new System.Windows.Forms.Button();
            this.listNames = new System.Windows.Forms.ListView();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonReset);
            this.groupBoxButtons.Controls.Add(this.buttonSaveLoc);
            this.groupBoxButtons.Controls.Add(this.buttonSaveSize);
            this.groupBoxButtons.Controls.Add(this.buttonName);
            this.groupBoxButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxButtons.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(284, 100);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Button Box";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonReset.Location = new System.Drawing.Point(143, 55);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(141, 45);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSaveLoc
            // 
            this.buttonSaveLoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSaveLoc.Location = new System.Drawing.Point(0, 55);
            this.buttonSaveLoc.Name = "buttonSaveLoc";
            this.buttonSaveLoc.Size = new System.Drawing.Size(137, 45);
            this.buttonSaveLoc.TabIndex = 2;
            this.buttonSaveLoc.Text = "Save Location";
            this.buttonSaveLoc.UseVisualStyleBackColor = true;
            this.buttonSaveLoc.Click += new System.EventHandler(this.buttonSaveLoc_Click);
            // 
            // buttonSaveSize
            // 
            this.buttonSaveSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSaveSize.Location = new System.Drawing.Point(143, 12);
            this.buttonSaveSize.Name = "buttonSaveSize";
            this.buttonSaveSize.Size = new System.Drawing.Size(141, 46);
            this.buttonSaveSize.TabIndex = 1;
            this.buttonSaveSize.Text = "Save Size";
            this.buttonSaveSize.UseVisualStyleBackColor = true;
            this.buttonSaveSize.Click += new System.EventHandler(this.buttonSaveSize_Click);
            // 
            // buttonName
            // 
            this.buttonName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonName.Location = new System.Drawing.Point(0, 12);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(137, 46);
            this.buttonName.TabIndex = 0;
            this.buttonName.Text = "Add Name";
            this.buttonName.UseVisualStyleBackColor = true;
            this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
            // 
            // listNames
            // 
            this.listNames.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNames.Location = new System.Drawing.Point(0, 100);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(284, 161);
            this.listNames.TabIndex = 1;
            this.listNames.UseCompatibleStateImageBehavior = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listNames);
            this.Controls.Add(this.groupBoxButtons);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrom_Closing);
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSaveLoc;
        private System.Windows.Forms.Button buttonSaveSize;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.ListView listNames;
    }
}

