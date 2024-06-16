/*
 * Created by SharpDevelop.
 * User: Yati
 * Date: 4/2/2024
 * Time: 2:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LeapYear
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			txtYear.Clear();
			
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			int num;
			
			if (!int.TryParse(txtYear.Text,out num)) {
				MessageBox.Show("Please enter a number character","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}
	
			num = int.Parse(txtYear.Text);
			
			if((num % 4 == 0 && num % 100 != 0) || (num % 400 == 0)){
				MessageBox.Show("The year is a leap year!","Leap Year",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("The year is not a leap year!","Leap Year",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		
		}
	}
}
