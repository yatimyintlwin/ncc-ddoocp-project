/*
 * Created by SharpDevelop.
 * User: Yati
 * Date: 4/2/2024
 * Time: 2:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LeapYear
{
	partial class MainForm
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
			this.lbl1 = new System.Windows.Forms.Label();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(12, 32);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(158, 23);
			this.lbl1.TabIndex = 0;
			this.lbl1.Text = "Enter a year:";
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(204, 32);
			this.txtYear.Multiline = true;
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(125, 23);
			this.txtYear.TabIndex = 1;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.Location = new System.Drawing.Point(136, 173);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(98, 29);
			this.btnSubmit.TabIndex = 2;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Year will be displayed here.";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 256);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.lbl1);
			this.Name = "MainForm";
			this.Text = "LeapYear";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Label lbl1;
	}
}
