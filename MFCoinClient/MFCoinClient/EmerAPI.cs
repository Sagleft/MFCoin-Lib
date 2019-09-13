#region copyright
// COPYRIGHT 2014 Emercoin Devs.
// COPYRIGHT 2019 Sagleft, Freeland.
#endregion

#region using
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using MFCoin.Client.Enums;
#endregion

namespace MFCoin.Client
{
	public partial class MFCoinClient : IMFCoinClient {
		#region NVS
		public string NVS_NameNew(
			string entry_name         = "dpo:test",
			string entry_value        = "value",
			int register_days         = 30,
			string to_address         = "", //empty - transcation to yourself
			NVS_ValueType value_type  = NVS_ValueType.Unicode
		) {
			string value_typeStr = value_type.GetDescription();
			//TODO: обработку ошибок
			string result = InvokeMethod(
				"name_new",
				entry_name,
				entry_value,
				register_days,
				to_address,
				value_typeStr
			)["result"].ToString();
			return result;
		}
		#endregion
	}
}
