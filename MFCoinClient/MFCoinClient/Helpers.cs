#region copyright
// COPYRIGHT 2019 Sagleft, Freeland.
// COPYRIGHT TIMESTAMP StackOverflow sometimes :D
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
		/// <summary>
		/// Вызов метода по JSON-RPC
		/// </summary>
		/// <param name="a_sMethod">вызываемый метод</param>
		/// <param name="a_params">параметры</param>
		/// <returns>возвратит JObject (mixed)</returns>
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
		
		public static T[] PerformQuery<T>(IEnumerable<T> query)
		{
		    T[] array = query.Cast<T>().ToArray();
		    return array;
		}
	}
}
