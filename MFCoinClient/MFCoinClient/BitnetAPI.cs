#region copyright
// COPYRIGHT 2011 Konstantin Ineshin, Irkutsk, Russia.
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
		public void BackupWallet(string a_destination)
	    {
			InvokeMethod("backupwallet", a_destination);
	    }
	
	    public string GetAccount(string a_address)
	    {
			return InvokeMethod("getaccount", a_address)["result"].ToString();
	    }
	    
	    public string GetAccountAddress(string a_account)
		{
			return InvokeMethod("getaccountaddress", a_account)["result"].ToString();
		}
	    
		public IEnumerable<string> GetAddressesByAccount(string a_account)
		{
			return from o in InvokeMethod("getaddressesbyaccount", a_account)["result"]
				select o.ToString();
		}
	
		public float GetBalance()
		{
			return (float)InvokeMethod("getbalance")["result"];
		}
		
		public float GetBalance(string a_account = null, int a_minconf = 1)
		{
			if (a_account == null) {
				return (float)InvokeMethod("getbalance")["result"];
			} else {
				return (float)InvokeMethod("getbalance", a_account, a_minconf)["result"];
			}
		}
		
		public string GetBlockByCount(int a_height)
		{
			return InvokeMethod("getblockbycount", a_height)["result"].ToString();
		}
		
		public JObject GetBlock(string block_hash) {
			return InvokeMethod("getblock", block_hash, true)["result"] as JObject;
		}
		
		public JArray GetBlockTXs(string block_hash) {
			return GetBlock(block_hash)["tx"] as JArray;
		}
		
		public int GetBlockCount()
		{
			return (int)InvokeMethod("getblockcount")["result"];
		}
		
		public string GetBlockHash(int block_number) {
			return (string)InvokeMethod("getblockhash", block_number)["result"];
		}
		
		public int GetBlockNumber()
		{
			return (int)InvokeMethod("getblocknumber")["result"];
		}
		
		public int GetConnectionCount()
		{
			return (int)InvokeMethod("getconnectioncount")["result"];
		}
		
		public float GetDifficulty()
		{
			return (float)InvokeMethod("getdifficulty")["result"];
		}
		
		public bool GetGenerate()
		{
			return (bool)InvokeMethod("getgenerate")["result"];
		}
		
		public float GetHashesPerSec()
		{
			return (float)InvokeMethod("gethashespersec")["result"];
		}
		
		public JObject GetInfo()
		{
			return InvokeMethod("getinfo")["result"] as JObject;
		}
		
		public string GetNewAddress(string a_account)
		{
			return InvokeMethod("getnewaddress", a_account)["result"].ToString();
		}
		
		public float GetReceivedByAccount(string a_account, int a_minconf = 1)
		{
			return (float)InvokeMethod("getreceivedbyaccount", a_account, a_minconf)["result"];
		}
		
		public float GetReceivedByAddress(string a_address, int a_minconf = 1)
		{
			return (float)InvokeMethod("getreceivedbyaddress", a_address, a_minconf)["result"];
		}
		
		public JObject GetTransaction(string a_txid)
		{
			return InvokeMethod("gettransaction", a_txid)["result"] as JObject;
		}
		
		public JObject GetWork()
		{
			return InvokeMethod("getwork")["result"] as JObject;
		}
		
		public bool GetWork(string a_data)
		{
			return (bool)InvokeMethod("getwork", a_data)["result"];
		}
		
		public string Help(string a_command = "")
		{
			return InvokeMethod("help", a_command)["result"].ToString();
		}
		
		public JObject ListAccounts()
		{
			return InvokeMethod("listaccounts")["result"] as JObject;
		}
		
		public JObject ListAccounts(int a_minconf = 1)
		{
			return InvokeMethod("listaccounts", a_minconf)["result"] as JObject;
		}
		
		public JArray ListReceivedByAccount(int a_minconf = 1, bool a_includeEmpty = false)
    	{
			return InvokeMethod("listreceivedbyaccount", a_minconf, a_includeEmpty)["result"] as JArray;
		}
		
		public JArray ListReceivedByAddress(int a_minconf = 1, bool a_includeEmpty = false)
		{
			return InvokeMethod("listreceivedbyaddress", a_minconf, a_includeEmpty)["result"] as JArray;
		}
		
		public JArray ListTransactions(string a_account, int a_count = 10)
		{
			return InvokeMethod("listtransactions", a_account, a_count)["result"] as JArray;
		}
		
		public bool Move(
			string a_fromAccount,
			string a_toAccount,
			float a_amount,
			int a_minconf = 1,
			string a_comment = ""
		)
		{
			return (bool)InvokeMethod(
				"move",
				a_fromAccount,
				a_toAccount,
				a_amount,
				a_minconf,
				a_comment
			)["result"];
		}
		
		public string SendFrom(
			string a_fromAccount,
			string a_toAddress,
			float a_amount,
			int a_minconf = 1,
			string a_comment = "",
			string a_commentTo = ""
		)
		{
			return InvokeMethod(
				"sendfrom", 
				a_fromAccount, 
				a_toAddress, 
				a_amount, 
				a_minconf, 
				a_comment, 
				a_commentTo
			)["result"].ToString();
		}
		
		public JObject ValidateAddress(string a_address)
		{
			return InvokeMethod("validateaddress", a_address)["result"] as JObject;
		}
		
		public string DumpPrivKey(string address) {
			return InvokeMethod("dumpprivkey", address)["result"].ToString();
		}
		
		public void WalletPassphrase(string password, int timeout) {
			InvokeMethod("walletpassphrase", password, timeout);
		}
		
		public string ImportPrivKey(string key, string name, int wait_time, bool rescan) {
			//TODO
			return "";
		}
		
		public string SendToAddress(string a_address, float a_amount, string a_comment, string a_commentTo)
		{
			return InvokeMethod("sendtoaddress", a_address, a_amount, a_comment, a_commentTo)["result"].ToString();
		}
		
		public void SetAccount(string a_address, string a_account)
		{
			InvokeMethod("setaccount", a_address, a_account);
		}
		
		public void SetGenerate(bool a_generate, int a_genproclimit = 1)
		{
			InvokeMethod("setgenerate", a_generate, a_genproclimit);
		}
		
		public void Stop()
		{
			InvokeMethod("stop");
		}
	}
}
