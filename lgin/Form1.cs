using System;
using System.Drawing;
using System.Windows.Forms;

namespace lgin
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm mnfrm = new MainForm();
			this.Close();
			mnfrm.Show();
		}
	}
}
