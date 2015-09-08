using System;
using System.Drawing;
using System.Windows.Forms;

public class myForm : Form
{
	Panel HeyPanel;
	Panel YoPanel;
	Label lHey;
	Label lYo;
	TextBox myBox;
	Button pushButton;
	
	public myForm(String title, String inName)
	{		
		this.SuspendLayout();
		
		//Form
		this.Size = new System.Drawing.Size(500, 700);
		this.Text = title;
		this.Height = 500;
		this.Width = 700;
		
		//HeyPanel
		HeyPanel = new Panel();
		HeyPanel.Dock = DockStyle.Bottom;
		HeyPanel.BackColor = Color.Red;
		HeyPanel.Name = "HeyPanel";
		this.Controls.Add(HeyPanel);
		
		//Hey Label
		lHey = new Label();
		lHey.Name = "HeyPanel";
		lHey.Text = inName;
		HeyPanel.Controls.Add(lHey);
		
		//YoPanel
		YoPanel = new Panel();
		YoPanel.BackColor = Color.Blue;
		YoPanel.Dock = DockStyle.Fill;
		this.Controls.Add(YoPanel);
		
		//Yo Label
		lYo = new Label();
		lYo.Name = "To Label";
		lYo.Text = "Comment: ";
		lYo.Top = 35;
		lYo.Left = 30;
		lYo.AutoSize = true;
		YoPanel.Controls.Add(lYo);
		
		//myBox
		myBox = new TextBox();
		myBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		myBox.Location = new Point(100, 30);
		myBox.Size = new Size(60, 20);
		YoPanel.Controls.Add(myBox);
		
		//pushButton
		pushButton = new Button();
		pushButton.Name = "pushButton";
		pushButton.Text = "Push the Button";
		pushButton.Anchor = AnchorStyles.Right;
		pushButton.Location = new Point(75, 150);
		pushButton.AutoSize = true;
        pushButton.Click += new EventHandler(pushButton_Click);
		YoPanel.Controls.Add(pushButton);
		
		this.ResumeLayout();
	}
	
	public myForm()
    : this("No Name Form", "No Name Panel"){
		
	}
	
	void pushButton_Click(object sender, EventArgs e)
        {
			MessageBox.Show(myBox.Text);
        }
}

class RunningThis
{
	static void Main(string[] args) 
	{
		if(args.Length == 0)
		{	
			Form form = new myForm();
			Application.Run(form);	
		}
		else
		{
			Form form = new myForm(args[0], args[1]);	
			Application.Run(form);			
		}
	}
}
