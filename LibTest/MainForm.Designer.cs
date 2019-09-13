namespace LibTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.windowTitle = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_rpc = new System.Windows.Forms.TabPage();
			this.textBox_rpcpassword = new System.Windows.Forms.TextBox();
			this.textBox_rpchost = new System.Windows.Forms.TextBox();
			this.textBox_rpcport = new System.Windows.Forms.TextBox();
			this.textBox_rpcuser = new System.Windows.Forms.TextBox();
			this.btn_save_rpcdata = new System.Windows.Forms.Button();
			this.btn_connect = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tab_nvs = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.btn_chooseFile = new System.Windows.Forms.Button();
			this.btn_writeBase64file = new System.Windows.Forms.Button();
			this.btn_newRandName = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button_exit = new System.Windows.Forms.Button();
			this.button_minimize = new System.Windows.Forms.Button();
			this.dataView_rpc = new System.Data.DataView();
			this.textBox_log = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnlog_clear = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tab_rpc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tab_nvs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView_rpc)).BeginInit();
			this.SuspendLayout();
			// 
			// windowTitle
			// 
			this.windowTitle.BackColor = System.Drawing.Color.Gainsboro;
			this.windowTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.windowTitle.Location = new System.Drawing.Point(0, 0);
			this.windowTitle.Name = "windowTitle";
			this.windowTitle.Size = new System.Drawing.Size(800, 35);
			this.windowTitle.TabIndex = 0;
			this.windowTitle.Text = "MFCoin LibTest";
			this.windowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tab_rpc);
			this.tabControl1.Controls.Add(this.tab_nvs);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 35);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(446, 465);
			this.tabControl1.TabIndex = 2;
			// 
			// tab_rpc
			// 
			this.tab_rpc.Controls.Add(this.textBox_rpcpassword);
			this.tab_rpc.Controls.Add(this.textBox_rpchost);
			this.tab_rpc.Controls.Add(this.textBox_rpcport);
			this.tab_rpc.Controls.Add(this.textBox_rpcuser);
			this.tab_rpc.Controls.Add(this.btn_save_rpcdata);
			this.tab_rpc.Controls.Add(this.btn_connect);
			this.tab_rpc.Controls.Add(this.label5);
			this.tab_rpc.Controls.Add(this.label7);
			this.tab_rpc.Controls.Add(this.label6);
			this.tab_rpc.Controls.Add(this.label4);
			this.tab_rpc.Controls.Add(this.label3);
			this.tab_rpc.Controls.Add(this.dataGridView1);
			this.tab_rpc.Controls.Add(this.label2);
			this.tab_rpc.Controls.Add(this.pictureBox1);
			this.tab_rpc.Location = new System.Drawing.Point(4, 32);
			this.tab_rpc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 34);
			this.tab_rpc.Name = "tab_rpc";
			this.tab_rpc.Padding = new System.Windows.Forms.Padding(3);
			this.tab_rpc.Size = new System.Drawing.Size(438, 429);
			this.tab_rpc.TabIndex = 0;
			this.tab_rpc.Text = "RPC";
			this.tab_rpc.UseVisualStyleBackColor = true;
			// 
			// textBox_rpcpassword
			// 
			this.textBox_rpcpassword.Location = new System.Drawing.Point(102, 116);
			this.textBox_rpcpassword.Name = "textBox_rpcpassword";
			this.textBox_rpcpassword.Size = new System.Drawing.Size(105, 30);
			this.textBox_rpcpassword.TabIndex = 9;
			this.textBox_rpcpassword.Text = "password";
			this.textBox_rpcpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_rpcpassword.UseSystemPasswordChar = true;
			// 
			// textBox_rpchost
			// 
			this.textBox_rpchost.Location = new System.Drawing.Point(315, 116);
			this.textBox_rpchost.Name = "textBox_rpchost";
			this.textBox_rpchost.Size = new System.Drawing.Size(105, 30);
			this.textBox_rpchost.TabIndex = 9;
			this.textBox_rpchost.Text = "localhost";
			this.textBox_rpchost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_rpcport
			// 
			this.textBox_rpcport.Location = new System.Drawing.Point(315, 81);
			this.textBox_rpcport.Name = "textBox_rpcport";
			this.textBox_rpcport.Size = new System.Drawing.Size(105, 30);
			this.textBox_rpcport.TabIndex = 9;
			this.textBox_rpcport.Text = "22823";
			this.textBox_rpcport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_rpcuser
			// 
			this.textBox_rpcuser.Location = new System.Drawing.Point(102, 80);
			this.textBox_rpcuser.Name = "textBox_rpcuser";
			this.textBox_rpcuser.Size = new System.Drawing.Size(105, 30);
			this.textBox_rpcuser.TabIndex = 9;
			this.textBox_rpcuser.Text = "user";
			this.textBox_rpcuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_save_rpcdata
			// 
			this.btn_save_rpcdata.Location = new System.Drawing.Point(222, 164);
			this.btn_save_rpcdata.Name = "btn_save_rpcdata";
			this.btn_save_rpcdata.Size = new System.Drawing.Size(148, 33);
			this.btn_save_rpcdata.TabIndex = 8;
			this.btn_save_rpcdata.Text = "Сохранить";
			this.btn_save_rpcdata.UseVisualStyleBackColor = true;
			// 
			// btn_connect
			// 
			this.btn_connect.Location = new System.Drawing.Point(68, 164);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(148, 33);
			this.btn_connect.TabIndex = 8;
			this.btn_connect.Text = "Подключиться";
			this.btn_connect.UseVisualStyleBackColor = true;
			this.btn_connect.Click += new System.EventHandler(this.Btn_connectClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 29);
			this.label5.TabIndex = 7;
			this.label5.Text = "password";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(213, 117);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 29);
			this.label7.TabIndex = 7;
			this.label7.Text = "host";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(213, 81);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 29);
			this.label6.TabIndex = 7;
			this.label6.Text = "port";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 29);
			this.label4.TabIndex = 7;
			this.label4.Text = "user";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(424, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "Данные после вызова getinfo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 232);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(426, 191);
			this.dataGridView1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(84, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(348, 72);
			this.label2.TabIndex = 4;
			this.label2.Text = "Connect to wallet daemon via json rpc";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 72);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// tab_nvs
			// 
			this.tab_nvs.Controls.Add(this.label8);
			this.tab_nvs.Controls.Add(this.btn_chooseFile);
			this.tab_nvs.Controls.Add(this.btn_writeBase64file);
			this.tab_nvs.Controls.Add(this.btn_newRandName);
			this.tab_nvs.Controls.Add(this.pictureBox2);
			this.tab_nvs.Location = new System.Drawing.Point(4, 32);
			this.tab_nvs.Name = "tab_nvs";
			this.tab_nvs.Padding = new System.Windows.Forms.Padding(3);
			this.tab_nvs.Size = new System.Drawing.Size(438, 429);
			this.tab_nvs.TabIndex = 1;
			this.tab_nvs.Text = "NVS";
			this.tab_nvs.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label8.Location = new System.Drawing.Point(3, 397);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(432, 29);
			this.label8.TabIndex = 11;
			this.label8.Text = "Для записи используется время в 30 дней";
			// 
			// btn_chooseFile
			// 
			this.btn_chooseFile.Location = new System.Drawing.Point(99, 122);
			this.btn_chooseFile.Name = "btn_chooseFile";
			this.btn_chooseFile.Size = new System.Drawing.Size(244, 33);
			this.btn_chooseFile.TabIndex = 10;
			this.btn_chooseFile.Text = "Выбрать файл..";
			this.btn_chooseFile.UseVisualStyleBackColor = true;
			this.btn_chooseFile.Click += new System.EventHandler(this.Btn_chooseFileClick);
			// 
			// btn_writeBase64file
			// 
			this.btn_writeBase64file.Location = new System.Drawing.Point(99, 161);
			this.btn_writeBase64file.Name = "btn_writeBase64file";
			this.btn_writeBase64file.Size = new System.Drawing.Size(244, 33);
			this.btn_writeBase64file.TabIndex = 9;
			this.btn_writeBase64file.Text = "Записать файл как base64";
			this.btn_writeBase64file.UseVisualStyleBackColor = true;
			this.btn_writeBase64file.Click += new System.EventHandler(this.Btn_writeBase64fileClick);
			// 
			// btn_newRandName
			// 
			this.btn_newRandName.Location = new System.Drawing.Point(125, 32);
			this.btn_newRandName.Name = "btn_newRandName";
			this.btn_newRandName.Size = new System.Drawing.Size(266, 33);
			this.btn_newRandName.TabIndex = 9;
			this.btn_newRandName.Text = "Создать случайную запись";
			this.btn_newRandName.UseVisualStyleBackColor = true;
			this.btn_newRandName.Click += new System.EventHandler(this.Btn_newRandNameClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(6, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(72, 72);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// button_exit
			// 
			this.button_exit.FlatAppearance.BorderSize = 0;
			this.button_exit.Location = new System.Drawing.Point(761, 0);
			this.button_exit.Name = "button_exit";
			this.button_exit.Size = new System.Drawing.Size(39, 35);
			this.button_exit.TabIndex = 3;
			this.button_exit.Text = "X";
			this.button_exit.UseVisualStyleBackColor = true;
			this.button_exit.Click += new System.EventHandler(this.Button_exitClick);
			// 
			// button_minimize
			// 
			this.button_minimize.FlatAppearance.BorderSize = 0;
			this.button_minimize.Location = new System.Drawing.Point(716, 0);
			this.button_minimize.Name = "button_minimize";
			this.button_minimize.Size = new System.Drawing.Size(39, 35);
			this.button_minimize.TabIndex = 3;
			this.button_minimize.Text = "_";
			this.button_minimize.UseVisualStyleBackColor = true;
			this.button_minimize.Click += new System.EventHandler(this.Button_minimizeClick);
			// 
			// textBox_log
			// 
			this.textBox_log.BackColor = System.Drawing.Color.White;
			this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_log.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_log.Location = new System.Drawing.Point(452, 67);
			this.textBox_log.Name = "textBox_log";
			this.textBox_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.textBox_log.Size = new System.Drawing.Size(348, 429);
			this.textBox_log.TabIndex = 5;
			this.textBox_log.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(452, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 29);
			this.label1.TabIndex = 6;
			this.label1.Text = "Лог";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnlog_clear
			// 
			this.btnlog_clear.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnlog_clear.Location = new System.Drawing.Point(716, 39);
			this.btnlog_clear.Name = "btnlog_clear";
			this.btnlog_clear.Size = new System.Drawing.Size(84, 25);
			this.btnlog_clear.TabIndex = 7;
			this.btnlog_clear.Text = "clear";
			this.btnlog_clear.UseVisualStyleBackColor = true;
			this.btnlog_clear.Click += new System.EventHandler(this.Btnlog_clearClick);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.btnlog_clear);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_log);
			this.Controls.Add(this.button_minimize);
			this.Controls.Add(this.button_exit);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.windowTitle);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LibTest";
			this.tabControl1.ResumeLayout(false);
			this.tab_rpc.ResumeLayout(false);
			this.tab_rpc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tab_nvs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView_rpc)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btn_writeBase64file;
		private System.Windows.Forms.Button btn_chooseFile;
		private System.Windows.Forms.Button btn_newRandName;
		private System.Windows.Forms.Button btnlog_clear;
		private System.Windows.Forms.Button btn_save_rpcdata;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_rpcport;
		private System.Windows.Forms.TextBox textBox_rpchost;
		private System.Windows.Forms.TextBox textBox_rpcuser;
		private System.Windows.Forms.TextBox textBox_rpcpassword;
		private System.Windows.Forms.Button btn_connect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox textBox_log;
		private System.Data.DataView dataView_rpc;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button_minimize;
		private System.Windows.Forms.Button button_exit;
		private System.Windows.Forms.TabPage tab_nvs;
		private System.Windows.Forms.TabPage tab_rpc;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label windowTitle;
	}
}
