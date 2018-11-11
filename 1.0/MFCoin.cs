// COPYRIGHT 2018 Sagleft

using System;
using System.Collections.Generic;

namespace Sagleft {
	/// <summary>
	/// Класс, предоставляющий возможность работы с MFCoin кошельком, транзакциями и адресами
	/// </summary>
	public class MFCoin : MFCoinInterface {
		public readonly bool isConnected = false;
		
		public MFCoin() {
			//
		}
		
		public MFCoin(string host, int port) {
			isConnected = true;
		}
		
		public decimal getbalance() {
			return 0;
		}
	}
}