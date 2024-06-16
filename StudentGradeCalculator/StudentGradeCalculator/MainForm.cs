/*
 * Created by SharpDevelop.
 * User: Yati
 * Date: 4/1/2024
 * Time: 7:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudentGradeCalculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmGradeCalculator : Form
	{
		public frmGradeCalculator()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmGradeCalculatorLoad(object sender, EventArgs e)
		{
			lblGrade.Text="";
		}
		
		void CmdSubmitClick(object sender, EventArgs e)
		{
			int mark;
			string message;
			
			//input mark to check validation errornous codition
			
			try
			{
				mark=int.Parse(txtMark.Text);
				
			} catch (Exception ex)
				{
					MessageBox.Show("Incorrect format, please try again");
					return;
					
				}

			
			if( mark >=35 && mark <=50)
				message = "Grade A, Congrats, Excellent Result";
			else if (mark >=30 && mark <=34)
				message = "Grade B, very well done";
			else if (mark >=25 && mark <=29)
				message = "Grade C, well done";
			else if (mark >=20 && mark <=24)
				message = "Grade D, not too bad";
			else if (mark >=0 && mark <=19)
				message = "Grade F, sorry, you need to resit";
			else
				message = "Please enter between 0 to 50";	//out of range
			
			lblGrade.Text = message;
		}
	}
}
