// COPYRIGHT 2011 Konstantin Ineshin, Irkutsk, Russia.
// COPYRIGHT 2019 Sagleft, Freeland.

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

namespace MFCoin.Client
{
  public class MFCoinClient : IMFCoinClient
  {
    public MFCoinClient()
    {
    	//
    }

    public MFCoinClient(string sUri)
    {
      Url = new Uri(sUri);
    }

    public Uri Url;

    public ICredentials Credentials;

    public JObject InvokeMethod(string a_sMethod, params object[] a_params)
    {
      HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(Url);
      webRequest.Credentials = Credentials;

      webRequest.ContentType = "application/json-rpc";
      webRequest.Method = "POST";

      JObject joe = new JObject();
      joe["jsonrpc"] = "1.0";
      joe["id"] = "1";
      joe["method"] = a_sMethod;

      if (a_params != null) {
        if (a_params.Length > 0) {
          JArray props = new JArray();
          foreach (var p in a_params) {
            props.Add(p);
          }
          joe.Add(new JProperty("params", props));
        }
      }

      string s = JsonConvert.SerializeObject(joe);
      // serialize json for the request
      byte[] byteArray = Encoding.UTF8.GetBytes(s);
      webRequest.ContentLength = byteArray.Length;

      using (Stream dataStream = webRequest.GetRequestStream()) {
        dataStream.Write(byteArray, 0, byteArray.Length);
      }

      using (WebResponse webResponse = webRequest.GetResponse()) {
        using (Stream str = webResponse.GetResponseStream()) {
          using (StreamReader sr = new StreamReader(str)) {
            return JsonConvert.DeserializeObject<JObject>(sr.ReadToEnd());
          }
        }
      }
    }

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
      }
      return (float)InvokeMethod("getbalance", a_account, a_minconf)["result"];
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
    
    public JObject GetRawTransaction(string trid) {
    	return InvokeMethod("getrawtransaction", trid, 1)["result"] as JObject;
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
    
    public int GetAccountsCount() {
    	//с учетом аккаунтов с пустым именем
    	JObject accounts_obj = ListAccounts();
    	int count = accounts_obj.Count;
		return count;
    }
    
    public static T[] PerformQuery<T>(IEnumerable<T> query)
	{
	    T[] array = query.Cast<T>().ToArray();
	    return array;
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
    
    public string DumpPrivKey(string address) {
    	return InvokeMethod("dumpprivkey", address)["result"].ToString();
    }
    
    public void WalletPassphrase(string password, int timeout) {
    	InvokeMethod("walletpassphrase", password, timeout);
    }
    
    public string ImportPrivKey(string key, string name, int wait_time, bool rescan) {
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

    public JObject ValidateAddress(string a_address)
    {
      return InvokeMethod("validateaddress", a_address)["result"] as JObject;
    }
  }
}
