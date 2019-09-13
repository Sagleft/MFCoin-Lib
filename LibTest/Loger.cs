using System;
using System.Windows.Forms;

namespace LibTest
{
	public class Loger
	{
		protected RichTextBox label;
		public Loger(RichTextBox loger_label)
		{
			this.label = loger_label;
		}
		
		public void print(string info = "empty") {
			this.label.Text += Environment.NewLine + " > " + info;
		}
	}
}
