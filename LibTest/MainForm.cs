using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MFCoin.Client;

namespace LibTest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Logic logic;
		int x, y;
    	bool drag = false;
    	Loger loger;
    	string filepath = "";
		
    	private void dragForm(object sender, MouseEventArgs e) {
			if (drag == false) { x = e.X; y = e.Y; drag = true; }
			if (e.Button.ToString() == "Left") {
				this.Location = new Point(this.Left + e.X - x, this.Top + e.Y - y);
			} else { drag = false; }
	    }
    	
		public MainForm()
		{
			InitializeComponent();
			logic = new Logic();
			loger = new Loger(textBox_log);
			logic.setLoger(loger);
			
			windowTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dragForm);
	        windowTitle.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.dragForm);
		}
		
		void Button_minimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		
		void Button_exitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Btn_connectClick(object sender, EventArgs e)
		{
			logic.connect(
				textBox_rpchost.Text,
				textBox_rpcuser.Text,
				textBox_rpcpassword.Text,
				textBox_rpcport.Text
			);
		}
		
		void Btnlog_clearClick(object sender, EventArgs e)
		{
			textBox_log.Clear();
		}
		
		void Btn_newRandNameClick(object sender, EventArgs e)
		{
			logic.NVS_createRandomName();
		}
		
		void Btn_chooseFileClick(object sender, EventArgs e)
		{
			OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                filepath = OFD.FileName;
                loger.print("Выбран файл: " + filepath);
            }
		}
		
		void Btn_writeBase64fileClick(object sender, EventArgs e)
		{
			if(filepath == "" || !File.Exists(filepath)) {
				loger.print("Файл не выбран");
			} else {
				logic.NVS_uploadFile(filepath);
			}
		}
	}
}
