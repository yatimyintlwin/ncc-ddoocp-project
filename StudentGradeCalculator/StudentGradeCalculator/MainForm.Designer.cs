/*
 * Created by SharpDevelop.
 * User: Yati
 * Date: 4/1/2024
 * Time: 7:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StudentGradeCalculator
{
	partial class frmGradeCalculator
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.cmdSubmit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblGrade = new System.Windows.Forms.Label();
			this.txtMark = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdSubmit
			// 
			this.cmdSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSubmit.Location = new System.Drawing.Point(140, 204);
			this.cmdSubmit.Name = "cmdSubmit";
			this.cmdSubmit.Size = new System.Drawing.Size(91, 29);
			this.cmdSubmit.TabIndex = 0;
			this.cmdSubmit.Text = "Submit";
			this.cmdSubmit.UseVisualStyleBackColor = true;
			this.cmdSubmit.Click += new System.EventHandler(this.CmdSubmitClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter a mark between 0 to 50:";
			// 
			// lblGrade
			// 
			this.lblGrade.Location = new System.Drawing.Point(25, 83);
			this.lblGrade.Name = "lblGrade";
			this.lblGrade.Size = new System.Drawing.Size(160, 23);
			this.lblGrade.TabIndex = 2;
			this.lblGrade.Text = "Grade will be displayed here.";
			// 
			// txtMark
			// 
			this.txtMark.Location = new System.Drawing.Point(211, 27);
			this.txtMark.Name = "txtMark";
			this.txtMark.Size = new System.Drawing.Size(128, 20);
			this.txtMark.TabIndex = 3;
			// 
			// frmGradeCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 272);
			this.Controls.Add(this.txtMark);
			this.Controls.Add(this.lblGrade);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdSubmit);
			this.Name = "frmGradeCalculator";
			this.Text = "Grade Calculator";
			this.Load += new System.EventHandler(this.FrmGradeCalculatorLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtMark;
		private System.Windows.Forms.Label lblGrade;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdSubmit;
	}
}
