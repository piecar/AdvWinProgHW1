namespace Part_B
{
    partial class ModelessForm
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
            this.components = new System.ComponentModel.Container();
            this.AddName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AddName
            // 
            this.AddName.AutoSize = true;
            this.AddName.Location = new System.Drawing.Point(22, 15);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(60, 13);
            this.AddName.TabIndex = 0;
            this.AddName.Text = "Add Name:";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(104, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(241, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameBox_PressUp);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(25, 117);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.applyButton.Location = new System.Drawing.Point(149, 117);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(270, 117);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // ModelessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 152);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.AddName);
            this.Name = "ModelessForm";
            this.Text = "ModelessForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModelessForm_PressUp);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
    }
}