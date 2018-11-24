using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sagleft.MFCoin;

namespace LibTest {
	public partial class MainForm : Form {
		MFCoin mfcoin_client;
		bool is_connected = false;
		
		public MainForm() {
			InitializeComponent();
		}
		
		void show_msg(string info) {
			MessageBox.Show(info, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void write_log(string info) {
			log_w.Text += "\r > "+info;
		}
		
		public void clear_log() {
			log_w.Text = "";
		}
		
		void Button_authClick(object sender, EventArgs e) {
			int port;
			decimal balance = 0;
			string host = "http://"+rpc_host.Text;
			
			write_log("Пытаюсь подключиться...");
			if(Int32.TryParse(rpc_port.Text, out port)) {
				try {
					mfcoin_client = new MFCoin(host, port);
					is_connected = mfcoin_client.rpcauth(rpc_user.Text, rpc_password.Text);
					balance = mfcoin_client.getbalance();
					
					if(!(balance >= 0)) {
						write_log("Что-то пошло не так. Не вышло получить доступ по RPC");
					} else {
						write_log("Подключение прошло успешно");
					}
				} catch(Exception exc) {
					write_log("Выловлена ошибка: "+exc.Message);
					is_connected = false;
				}
			} else {
				write_log("Не могу разобрать что вы там ввели в качестве порта");
			}
			pic_isConnected.Visible = is_connected;
		}
		
		void Button_clearlogClick(object sender, EventArgs e) {
			clear_log();
		}
		
		void Button_get_fullBalanceClick(object sender, EventArgs e) {
			decimal wallet_balance;
			try {
				wallet_balance = mfcoin_client.getbalance();
				write_log("Суммарный баланс: "+wallet_balance.ToString());
			} catch(Exception exc) {
				write_log("Выловлена ошибка: "+exc.Message);
			}
		}
		
		void Button_get_balanceConf(object sender, EventArgs e) {
			decimal wallet_balance;
			try {
				wallet_balance = mfcoin_client.getbalance((int)getbalance_conf_num.Value);
				write_log("Суммарный баланс: "+wallet_balance.ToString());
			} catch(Exception exc) {
				write_log("Выловлена ошибка: "+exc.Message);
			}
		}
	}
}
