/*
 * Created by SharpDevelop.
 * User: Yati
 * Date: 4/2/2024
 * Time: 2:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lucky_Dip
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
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			int num;
			string message;
			
			if(!int.TryParse(txtInput.Text, out num)){
				MessageBox.Show("Please enter a number only.", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			num = int.Parse(txtInput.Text);
			
			
			if (num == 1)
				message = "1: You have won a sheet of paper.";
			else if (num == 2)
				message = "2: You have won a car.";
			else if (num == 3)
				message =  "3: You have won a pair of slippers.";
			else if (num == 4)
				message = "4: You have won a litre bottle of water.";
			else if (num == 5)
				message = "5: You have won a 52 inch LCD tv.";
			else if (num == 6)
				message = "6: You have won an umbrella.";
			else{
				MessageBox.Show("Please enter a number between 1 to 6!", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			lbl2.Text = message;
		}
	}
}
