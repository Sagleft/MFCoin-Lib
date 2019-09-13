#region copyright
// COPYRIGHT 2019 Sagleft, Freeland.
#endregion

#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endregion

namespace MFCoin.Client
{
	public partial class MFCoinClient : IMFCoinClient {
		public int GetAccountsCount() {
	    	//с учетом аккаунтов с пустым именем
	    	JObject accounts_obj = ListAccounts();
	    	int count = accounts_obj.Count;
			return count;
	    }
		
		public JObject GetRawTransaction(string trid) {
	    	return InvokeMethod("getrawtransaction", trid, 1)["result"] as JObject;
	    }
		
		public bool isWalletLocked() {
	    	JObject wallet_info = GetInfo();
			// string unlocked_until_str = wallet_info["unlocked_until"].ToString();
			// int unlocked_time = 0;
			// int.TryParse(unlocked_until_str, out unlocked_time);
			int unlocked_time = (int) wallet_info["unlocked_until"];
	    	if(unlocked_time > 0) {
	    		return false;
	    	} else {
	    		return true;
	    	}
	    }
	    
	    public bool isMintOnly() {
	    	JObject wallet_info = GetInfo();
	    	return (bool) wallet_info["mintonly"];
	    }
		
		//в формате <имя аккаунта, приватный ключ>
	    public Dictionary<string, string> GetAccountsKeys() {
	    	Dictionary<string, string> dict = new Dictionary<string, string>();
	    	string account_name = "";
	    	string account_key  = "";
	    	JObject accounts_obj = ListAccounts();
	    	string write_name = "";
	    	
	    	foreach (var account in accounts_obj)
			{
			    //string name = account.Key;
			    //JToken balance = account.Value;
			    account_name = account.Key;
			    if(account_name != "") {
			    	//перебор адресов по аккаунту
			    	IEnumerable<string> res_string = GetAddressesByAccount(account_name);
			    	string[] accounts_arr = PerformQuery(res_string);
			    	for(int i=0; i < accounts_arr.Length; i++) {
			    		account_key = DumpPrivKey(accounts_arr[i]);
			    		int account_number = i+1;
			    		if(accounts_arr.Length == 1) {
			    			write_name = account_name;
			    		} else {
			    			write_name = account_name + " (" + account_number.ToString() + ")";
			    		}
			    		dict.Add(write_name, account_key);
			    	}
			    	//account_key  = GetAccountAddress(account_name);
			   		//dict.Add(account_name, account_key);
			    }
			}
	    	return dict;
	    }
		
		public Dictionary<string, string> Jobject2Dict(JObject jobject) {
	    	//TODO: починить. на помеченной ниже строке что-то не работает
	    	Dictionary<string, string> dict = new Dictionary<string, string>();
	    	if(jobject == null) {
	    		return dict;
	    	}
	    	IEnumerable<JProperty> ienmb = jobject.Properties();
			JProperty[] properties = MFCoinClient.PerformQuery(ienmb);
			for(int i=0; i < properties.Length; i++) {
				string property_name  = properties[i].ToString();
				string property_value = jobject[property_name].ToString(); //тут
				dict.Add(property_name, property_value);
	    	}
			return dict;
	    }		
	}
}
