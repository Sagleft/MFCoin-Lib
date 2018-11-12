// COPYRIGHT 2018 Sagleft

using System;
using System.Collections.Generic;
using System.Net;
using Bitnet.Client;

namespace Sagleft.MFCoin {
	/// <summary>
	/// Класс, предоставляющий возможность работы с MFCoin кошельком, транзакциями и адресами
	/// </summary>
	public class MFCoin : MFCoinInterface {
		private bool connected = false;
		private BitnetClient client;
		
		public MFCoin() {
			//
		}
		
		public bool isConnected() {
			return connected;
		}
		
		public MFCoin(string host, int port) {
			client = new BitnetClient(host + ":" + port.ToString());
			//isConnected = true;
		}
		
		public bool rpcauth(string username, string password) {
			try {
				client.Credentials = new NetworkCredential(username, password);
				connected = true;
			} catch(Exception e) {
				connected = false;
			}
			return connected;
		}
		
		public decimal getbalance() {
			return (decimal)client.GetBalance();
		}
	}
}