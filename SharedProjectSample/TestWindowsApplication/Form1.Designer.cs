namespace TestWindowsApplication
{
	partial class TestWindowsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnShowCustomer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnShowCustomer
			// 
			this.btnShowCustomer.Location = new System.Drawing.Point(53, 57);
			this.btnShowCustomer.Name = "btnShowCustomer";
			this.btnShowCustomer.Size = new System.Drawing.Size(137, 23);
			this.btnShowCustomer.TabIndex = 0;
			this.btnShowCustomer.Text = "Show Customer";
			this.btnShowCustomer.UseVisualStyleBackColor = true;
			this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
			// 
			// TestWindowsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 183);
			this.Controls.Add(this.btnShowCustomer);
			this.Name = "TestWindowsForm";
			this.Text = "Test Windows Application";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnShowCustomer;
	}
}

