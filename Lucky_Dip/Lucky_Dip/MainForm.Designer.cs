/*
 * Created by SharpDevelop.
 * User: Yati
 * Date: 4/2/2024
 * Time: 2:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lucky_Dip
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
			this.lbl2 = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(12, 25);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(185, 23);
			this.lbl1.TabIndex = 0;
			this.lbl1.Text = "Enter a number between 1 and 6:";
			// 
			// lbl2
			// 
			this.lbl2.Location = new System.Drawing.Point(12, 71);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(371, 23);
			this.lbl2.TabIndex = 1;
			this.lbl2.Text = "Prize will be displayed here.";
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(229, 22);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(138, 23);
			this.txtInput.TabIndex = 2;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.Location = new System.Drawing.Point(160, 193);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(95, 38);
			this.btnSubmit.TabIndex = 3;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 260);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Name = "MainForm";
			this.Text = "Lucky Dip";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
	}
}
