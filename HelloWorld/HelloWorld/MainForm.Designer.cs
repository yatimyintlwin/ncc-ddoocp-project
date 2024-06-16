/*
 * Created by SharpDevelop.
 * User: Yati
 * Date: 3/19/2024
 * Time: 3:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HelloWorld
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
			this.btnHelloWorld = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnHelloWorld
			// 
			this.btnHelloWorld.Location = new System.Drawing.Point(129, 107);
			this.btnHelloWorld.Name = "btnHelloWorld";
			this.btnHelloWorld.Size = new System.Drawing.Size(130, 43);
			this.btnHelloWorld.TabIndex = 0;
			this.btnHelloWorld.Text = "HelloWorld";
			this.btnHelloWorld.UseVisualStyleBackColor = true;
			this.btnHelloWorld.Click += new System.EventHandler(this.BtnHelloWorldClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(408, 305);
			this.Controls.Add(this.btnHelloWorld);
			this.Name = "MainForm";
			this.Text = "HelloWorld";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnHelloWorld;
	}
}
