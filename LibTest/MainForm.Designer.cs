/*
 * Сделано в SharpDevelop.
 * Пользователь: SystemShock
 * Дата: 11.11.2018
 * Время: 16:22
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.wallet_password = new System.Windows.Forms.TextBox();
			this.wallet_isEncrypted = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pic_isConnected = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rpc_port = new System.Windows.Forms.TextBox();
			this.rpc_host = new System.Windows.Forms.TextBox();
			this.rpc_password = new System.Windows.Forms.TextBox();
			this.rpc_user = new System.Windows.Forms.TextBox();
			this.button_auth = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.Баланс = new System.Windows.Forms.GroupBox();
			this.numeric_blanace_confirms = new System.Windows.Forms.NumericUpDown();
			this.checkbox_use_confirmations = new System.Windows.Forms.CheckBox();
			this.account_name = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button_get_fullBalance = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button_clearlog = new System.Windows.Forms.Button();
			this.log_w = new System.Windows.Forms.RichTextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_isConnected)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.Баланс.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_blanace_confirms)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(562, 561);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(554, 535);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "RPC";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(157, 463);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(203, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "https://github.com/Sagleft/MFCoin-Lib";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(157, 444);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 19);
			this.label5.TabIndex = 3;
			this.label5.Text = "Copyright 2018 Sagleft";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(157, 425);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "MFCoinLib Test by Sagleft";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 385);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.Controls.Add(this.wallet_password);
			this.groupBox2.Controls.Add(this.wallet_isEncrypted);
			this.groupBox2.Location = new System.Drawing.Point(252, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(292, 191);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Защита";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(133, 22);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// wallet_password
			// 
			this.wallet_password.Location = new System.Drawing.Point(21, 84);
			this.wallet_password.Name = "wallet_password";
			this.wallet_password.Size = new System.Drawing.Size(257, 20);
			this.wallet_password.TabIndex = 1;
			// 
			// wallet_isEncrypted
			// 
			this.wallet_isEncrypted.AutoSize = true;
			this.wallet_isEncrypted.Location = new System.Drawing.Point(21, 61);
			this.wallet_isEncrypted.Name = "wallet_isEncrypted";
			this.wallet_isEncrypted.Size = new System.Drawing.Size(257, 17);
			this.wallet_isEncrypted.TabIndex = 0;
			this.wallet_isEncrypted.Text = "Кошелек зашифрован, использовать пароль:";
			this.wallet_isEncrypted.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pic_isConnected);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.rpc_port);
			this.groupBox1.Controls.Add(this.rpc_host);
			this.groupBox1.Controls.Add(this.rpc_password);
			this.groupBox1.Controls.Add(this.rpc_user);
			this.groupBox1.Controls.Add(this.button_auth);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(238, 195);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Подключение к кошельку";
			// 
			// pic_isConnected
			// 
			this.pic_isConnected.Image = ((System.Drawing.Image)(resources.GetObject("pic_isConnected.Image")));
			this.pic_isConnected.Location = new System.Drawing.Point(82, 147);
			this.pic_isConnected.Name = "pic_isConnected";
			this.pic_isConnected.Size = new System.Drawing.Size(16, 16);
			this.pic_isConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pic_isConnected.TabIndex = 4;
			this.pic_isConnected.TabStop = false;
			this.pic_isConnected.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(15, 23);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(73, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "пароль";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(86, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "порт";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "хост";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "имя пользователя";
			// 
			// rpc_port
			// 
			this.rpc_port.Location = new System.Drawing.Point(122, 64);
			this.rpc_port.Name = "rpc_port";
			this.rpc_port.Size = new System.Drawing.Size(100, 20);
			this.rpc_port.TabIndex = 1;
			this.rpc_port.Text = "22823";
			this.rpc_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rpc_host
			// 
			this.rpc_host.Location = new System.Drawing.Point(122, 38);
			this.rpc_host.Name = "rpc_host";
			this.rpc_host.Size = new System.Drawing.Size(100, 20);
			this.rpc_host.TabIndex = 1;
			this.rpc_host.Text = "127.0.0.1";
			this.rpc_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rpc_password
			// 
			this.rpc_password.Location = new System.Drawing.Point(122, 114);
			this.rpc_password.Name = "rpc_password";
			this.rpc_password.Size = new System.Drawing.Size(100, 20);
			this.rpc_password.TabIndex = 1;
			this.rpc_password.Text = "passqt";
			this.rpc_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rpc_user
			// 
			this.rpc_user.Location = new System.Drawing.Point(122, 88);
			this.rpc_user.Name = "rpc_user";
			this.rpc_user.Size = new System.Drawing.Size(100, 20);
			this.rpc_user.TabIndex = 1;
			this.rpc_user.Text = "admin";
			this.rpc_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_auth
			// 
			this.button_auth.Location = new System.Drawing.Point(104, 144);
			this.button_auth.Name = "button_auth";
			this.button_auth.Size = new System.Drawing.Size(118, 23);
			this.button_auth.TabIndex = 0;
			this.button_auth.Text = "Подключиться";
			this.button_auth.UseVisualStyleBackColor = true;
			this.button_auth.Click += new System.EventHandler(this.Button_authClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.Баланс);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(554, 535);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Данные";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Баланс
			// 
			this.Баланс.Controls.Add(this.numeric_blanace_confirms);
			this.Баланс.Controls.Add(this.checkbox_use_confirmations);
			this.Баланс.Controls.Add(this.account_name);
			this.Баланс.Controls.Add(this.button1);
			this.Баланс.Controls.Add(this.button_get_fullBalance);
			this.Баланс.Location = new System.Drawing.Point(8, 6);
			this.Баланс.Name = "Баланс";
			this.Баланс.Size = new System.Drawing.Size(540, 136);
			this.Баланс.TabIndex = 0;
			this.Баланс.TabStop = false;
			this.Баланс.Text = "Баланс";
			// 
			// numeric_blanace_confirms
			// 
			this.numeric_blanace_confirms.Location = new System.Drawing.Point(336, 103);
			this.numeric_blanace_confirms.Maximum = new decimal(new int[] {
									9999999,
									0,
									0,
									0});
			this.numeric_blanace_confirms.Name = "numeric_blanace_confirms";
			this.numeric_blanace_confirms.Size = new System.Drawing.Size(198, 20);
			this.numeric_blanace_confirms.TabIndex = 4;
			// 
			// checkbox_use_confirmations
			// 
			this.checkbox_use_confirmations.Location = new System.Drawing.Point(336, 74);
			this.checkbox_use_confirmations.Name = "checkbox_use_confirmations";
			this.checkbox_use_confirmations.Size = new System.Drawing.Size(198, 24);
			this.checkbox_use_confirmations.TabIndex = 3;
			this.checkbox_use_confirmations.Text = "С учетом подтверждений";
			this.checkbox_use_confirmations.UseVisualStyleBackColor = true;
			// 
			// account_name
			// 
			this.account_name.Location = new System.Drawing.Point(336, 48);
			this.account_name.Name = "account_name";
			this.account_name.Size = new System.Drawing.Size(198, 20);
			this.account_name.TabIndex = 2;
			this.account_name.Text = "account";
			this.account_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(336, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(198, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Запросить баланс по аккаунту";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.getbalance_by_accountClick);
			// 
			// button_get_fullBalance
			// 
			this.button_get_fullBalance.Location = new System.Drawing.Point(61, 62);
			this.button_get_fullBalance.Name = "button_get_fullBalance";
			this.button_get_fullBalance.Size = new System.Drawing.Size(198, 23);
			this.button_get_fullBalance.TabIndex = 0;
			this.button_get_fullBalance.Text = "Запросить суммарный баланс";
			this.button_get_fullBalance.UseVisualStyleBackColor = true;
			this.button_get_fullBalance.Click += new System.EventHandler(this.Button_get_fullBalanceClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(564, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(220, 561);
			this.panel1.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button_clearlog);
			this.groupBox3.Controls.Add(this.log_w);
			this.groupBox3.Location = new System.Drawing.Point(4, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(204, 542);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Лог";
			// 
			// button_clearlog
			// 
			this.button_clearlog.Location = new System.Drawing.Point(6, 500);
			this.button_clearlog.Name = "button_clearlog";
			this.button_clearlog.Size = new System.Drawing.Size(192, 36);
			this.button_clearlog.TabIndex = 1;
			this.button_clearlog.Text = "Очистить лог";
			this.button_clearlog.UseVisualStyleBackColor = true;
			this.button_clearlog.Click += new System.EventHandler(this.Button_clearlogClick);
			// 
			// log_w
			// 
			this.log_w.Location = new System.Drawing.Point(6, 19);
			this.log_w.Name = "log_w";
			this.log_w.Size = new System.Drawing.Size(192, 471);
			this.log_w.TabIndex = 0;
			this.log_w.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "MFCoinLib Test";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_isConnected)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.Баланс.ResumeLayout(false);
			this.Баланс.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_blanace_confirms)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox checkbox_use_confirmations;
		private System.Windows.Forms.NumericUpDown numeric_blanace_confirms;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox account_name;
		private System.Windows.Forms.Button button_get_fullBalance;
		private System.Windows.Forms.GroupBox Баланс;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pic_isConnected;
		private System.Windows.Forms.RichTextBox log_w;
		private System.Windows.Forms.Button button_clearlog;
		private System.Windows.Forms.TextBox rpc_port;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox rpc_host;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox wallet_isEncrypted;
		private System.Windows.Forms.TextBox wallet_password;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button_auth;
		private System.Windows.Forms.TextBox rpc_user;
		private System.Windows.Forms.TextBox rpc_password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
