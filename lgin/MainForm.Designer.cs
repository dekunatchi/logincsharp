/*
 * Created by SharpDevelop.
 * User: Student
 * Date: 3/7/2019
 * Time: 4:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace lgin
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.TextBox tb1;
		private System.Windows.Forms.TextBox tb2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.tb1 = new System.Windows.Forms.TextBox();
			this.tb2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(114, 303);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(99, 55);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "Login";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(319, 303);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(99, 55);
			this.btn2.TabIndex = 1;
			this.btn2.Text = "Close";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.Button2Click);
			// 
			// tb1
			// 
			this.tb1.Location = new System.Drawing.Point(72, 36);
			this.tb1.Multiline = true;
			this.tb1.Name = "tb1";
			this.tb1.Size = new System.Drawing.Size(346, 60);
			this.tb1.TabIndex = 2;
			this.tb1.TextChanged += new System.EventHandler(this.Tb1TextChanged);
			// 
			// tb2
			// 
			this.tb2.Location = new System.Drawing.Point(72, 148);
			this.tb2.Multiline = true;
			this.tb2.Name = "tb2";
			this.tb2.PasswordChar = '•';
			this.tb2.Size = new System.Drawing.Size(346, 60);
			this.tb2.TabIndex = 3;
			this.tb2.TextChanged += new System.EventHandler(this.Tb2TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(72, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "USN";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(72, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "PASSWORD";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 442);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb2);
			this.Controls.Add(this.tb1);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Name = "MainForm";
			this.Text = "lgin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
