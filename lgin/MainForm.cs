
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lgin
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			btn1.Enabled = false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(tb1.Text=="Deku" && tb2.Text=="admin")
			{
				MessageBox.Show("Login Successful");
				Form1 frm1 = new Form1();
				this.Hide();
				frm1.Show();
			}
			
			else
			{
				MessageBox.Show("Invalid Username or Password");				
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}
		void Tb1TextChanged(object sender, EventArgs e)
		{
			if(tb1.Text=="" || tb2.Text=="")
			{
				btn1.Enabled = false;
			}
			else
			{
				btn1.Enabled = true;			
			}
		}
		void Tb2TextChanged(object sender, EventArgs e)
		{
		if(tb1.Text=="" || tb2.Text=="")
			{
				btn1.Enabled = false;
			}
			else
			{
				btn1.Enabled = true;			
			}
		}
	}
}
