// COPYRIGHT 2018 Sagleft

using System;
using System.Collections.Generic;

namespace Sagleft.MFCoin
{
	interface MFCoinInterface {
		/// <summary>
	    /// Получить баланс кошелька
	    /// </summary>
		decimal getbalance();
		
		/// <summary>
	    /// true, если получилось подключиться к кошельку по RPC, иначе false
	    /// </summary>
		bool rpcauth(string username, string password);
		
		/// <summary>
	    /// true, если есть действующее подключение к MFCoin кошельку по RPC, иначе false
	    /// </summary>
		bool isConnected();
	}
}
