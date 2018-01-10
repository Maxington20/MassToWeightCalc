namespace MassToWeightCalc
{
	partial class KilosToNewtons
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KilosToNewtons));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.massEnterTextbox = new System.Windows.Forms.TextBox();
			this.weightConvertTextbox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(296, 302);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(324, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(343, 63);
			this.label1.TabIndex = 1;
			this.label1.Text = "This program allows you to type in a mass \r\nin kilograms and converts it into a w" +
    "eight \r\nin newtons";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// massEnterTextbox
			// 
			this.massEnterTextbox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.massEnterTextbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.massEnterTextbox.Location = new System.Drawing.Point(328, 173);
			this.massEnterTextbox.Name = "massEnterTextbox";
			this.massEnterTextbox.Size = new System.Drawing.Size(135, 29);
			this.massEnterTextbox.TabIndex = 2;
			this.massEnterTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.massEnterTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.massEnterTextox_KeyPress);
			// 
			// weightConvertTextbox
			// 
			this.weightConvertTextbox.Cursor = System.Windows.Forms.Cursors.No;
			this.weightConvertTextbox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weightConvertTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.weightConvertTextbox.Location = new System.Drawing.Point(532, 173);
			this.weightConvertTextbox.Name = "weightConvertTextbox";
			this.weightConvertTextbox.ReadOnly = true;
			this.weightConvertTextbox.Size = new System.Drawing.Size(135, 29);
			this.weightConvertTextbox.TabIndex = 3;
			this.weightConvertTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(328, 251);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 35);
			this.button1.TabIndex = 4;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.RoyalBlue;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(532, 251);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 35);
			this.button2.TabIndex = 5;
			this.button2.Text = "Convert";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// KilosToNewtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(693, 326);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.weightConvertTextbox);
			this.Controls.Add(this.massEnterTextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KilosToNewtons";
			this.Text = "Kilograms to Newtons";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox massEnterTextbox;
		private System.Windows.Forms.TextBox weightConvertTextbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

