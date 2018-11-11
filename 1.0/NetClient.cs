// COPYRIGHT 2011 Konstantin Ineshin
// COPYRIGHT 2018 Sagleft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bitnet.Client
{
  public class BitnetClient : IBitnetClient
  {
    public BitnetClient()
    { 
    }

    public BitnetClient(string a_sUri)
    {
      Url = new Uri(a_sUri);
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

    public float GetBalance(string a_account, int a_minconf)
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

    public int GetBlockCount()
    {
      return (int)InvokeMethod("getblockcount")["result"];
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

    public bool GetGenerate() {
      return (bool)InvokeMethod("getgenerate")["result"];
    }

    public float GetHashesPerSec() {
      return (float)InvokeMethod("gethashespersec")["result"];
    }

    public JObject GetInfo() {
      return InvokeMethod("getinfo")["result"] as JObject;
    }
    
    public JObject ListUnspent(int minConf, int maxConf, string addr) {
    	return InvokeMethod("listunspent", minConf, maxConf) as JObject;
    	//, "'["+'"'+addr+'"'+"]'"
    }

    public string GetNewAddress(string a_account) {
      return InvokeMethod("getnewaddress", a_account)["result"].ToString();
    }
    
    public string SignRawTransaction(string hex_str) {
    	return InvokeMethod("signrawtransaction", hex_str)["result"]["hex"].ToString();
    }
    
    public string SendRawTransaction(string hex_str) {
    	return InvokeMethod("sendrawtransaction", hex_str).ToString();
    }
    
    public bool ValidateAddress(string address) {
    	JObject result = InvokeMethod("validateaddress", address);
		if(result["result"]["isvalid"].ToString().ToLower() == "true") {
			return true;
		} else {
			return false;
		}
    }
    
    public string CreateRawTransaction(JContainer tr_arr, JContainer tr_addr) {
    	JObject hash_result = new JObject();
    	
    	HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(Url);
		webRequest.Credentials = Credentials;
		
		webRequest.ContentType = "application/json-rpc";
		webRequest.Method = "POST";
		
		JObject joe = new JObject();
		joe["jsonrpc"] = "1.0";
		joe["id"] = "1";
		joe["method"] = "createrawtransaction";
		
		JArray props = new JArray();
		props.Add(tr_arr);
		props.Add(tr_addr);
		joe.Add(new JProperty("params", props));
		
		string s = JsonConvert.SerializeObject(joe);
		
		byte[] byteArray = Encoding.UTF8.GetBytes(s);
		webRequest.ContentLength = byteArray.Length;
		
		using (Stream dataStream = webRequest.GetRequestStream()) {
			dataStream.Write(byteArray, 0, byteArray.Length);
		}
		
		using (WebResponse webResponse = webRequest.GetResponse()) {
			using (Stream str = webResponse.GetResponseStream()) {
			  using (StreamReader sr = new StreamReader(str)) {
					hash_result = JsonConvert.DeserializeObject<JObject>(sr.ReadToEnd());
			  }
			}
		}
		return hash_result["result"].ToString();
    }
    
    public string WalletPassphrase(string password, int timeout)
    {
      return InvokeMethod("walletpassphrase", password, timeout).ToString();
    }

    public float GetReceivedByAccount(string a_account, int a_minconf)
    {
      return (float)InvokeMethod("getreceivedbyaccount", a_account, a_minconf)["result"];
    }

    public float GetReceivedByAddress(string a_address, int a_minconf)
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

    public string Help(string a_command)
    {
      return InvokeMethod("help", a_command)["result"].ToString();
    }

    public JObject ListAccounts(int a_minconf)
    {
      return InvokeMethod("listaccounts", a_minconf)["result"] as JObject;
    }

    public JArray ListReceivedByAccount(int a_minconf, bool a_includeEmpty)
    {
      return InvokeMethod("listreceivedbyaccount", a_minconf, a_includeEmpty)["result"] as JArray;
    }

    public JArray ListReceivedByAddress(int a_minconf, bool a_includeEmpty)
    {
      return InvokeMethod("listreceivedbyaddress", a_minconf, a_includeEmpty)["result"] as JArray;
    }

    public JArray ListTransactions(string a_account, int a_count)
    {
      return InvokeMethod("listtransactions", a_account, a_count)["result"] as JArray;
    }

    public bool Move(
      string a_fromAccount, 
      string a_toAccount, 
      float a_amount, 
      int a_minconf, 
      string a_comment
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
      int a_minconf, 
      string a_comment, 
      string a_commentTo
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

    public string SendToAddress(string a_address, float a_amount, string a_comment, string a_commentTo)
    {
      return InvokeMethod("sendtoaddress", a_address, a_amount, a_comment, a_commentTo)["result"].ToString();
    }

    public void SetAccount(string a_address, string a_account)
    {
      InvokeMethod("setaccount", a_address, a_account);
    }

    public void SetGenerate(bool a_generate, int a_genproclimit)
    {
      InvokeMethod("setgenerate", a_generate, a_genproclimit);
    }

    public void Stop()
    {
      InvokeMethod("stop");
    }
  }
}
