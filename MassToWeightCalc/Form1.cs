using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassToWeightCalc
{
	public partial class KilosToNewtons : Form
	{
		public KilosToNewtons()
		{
			InitializeComponent();

			//start with both buttons not enabled
			button1.Enabled = false;
			button2.Enabled = false;
			
		}

		private void massEnterTextox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//only allow numbers input from the user
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
		(e.KeyChar != '.'))
			{
				e.Handled = true;
				MessageBox.Show("Only numbers may be used");
			}
			

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
				MessageBox.Show("Only one decimal may be used");
			}

			//Half works. It will only enable these when 2 digits or more are entered
				//for some reason.
			button1.Enabled = !string.IsNullOrEmpty(massEnterTextbox.Text);
			button2.Enabled = !string.IsNullOrEmpty(massEnterTextbox.Text);			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			massEnterTextbox.Text = "";
			weightConvertTextbox.Text = "";
			button1.Enabled = false;
			button2.Enabled = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{

			double weight = Convert.ToDouble(massEnterTextbox.Text) * 9.8;

			if (weight > 1000)
			{
				weightConvertTextbox.Text = "This is too heavy";
			}

			else if (weight < 10)
			{
				weightConvertTextbox.Text = "This is too light";
			}
			
			else
			{
				string weightN = Convert.ToString(weight);
				weightConvertTextbox.Text = weightN;
			}

			button1.Enabled = true;
			button2.Enabled = false;
		}
	}
}
