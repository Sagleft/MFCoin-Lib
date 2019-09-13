#region using
using System;
using MFCoin.Client;
using MFCoin.Client.Enums;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
#endregion

namespace LibTest
{
	public class Logic
	{
		MFCoinClient client;
		Loger loger = null;
		
		public Logic()
		{
			//
		}
		
		public void setLoger(Loger new_loger) {
			this.loger = new_loger;
			//printToLog("установлен Loger");
		}
		
		void printToLog(string info = "empty") {
			if(loger != null) {
				loger.print(info);
			} else {
				Debug.Print(info);
			}
		}
		
		public void connect(
			string rpchost     = "127.0.0.1",
			string rpcuser     = "user",
			string rpcpassword = "password",
			string rpcport     = "22823"
		) {
			this.client = new MFCoinClient("http://" + rpchost + ":" + rpcport);
     		client.Credentials = new NetworkCredential(rpcuser, rpcpassword);
     		//проверка
     		bool can_continue = true;
     		try {
     			client.GetBalance();
     			printToLog("Успешное подключение к кошельку, пробую запросить данные");
     		} catch(Exception ex) {
     			can_continue = false;
     			printToLog("Отловлено исключение: " + ex.Message);
     		}
     		if(can_continue) {
     			//вывод в лог данных из запроса getinfo
     			JObject info_obj = client.GetInfo();
				IEnumerable<JProperty> res_info = info_obj.Properties();
				JProperty[] properties = MFCoinClient.PerformQuery(res_info);
				//TOQ: заменить на вызов метода Jobject2Dict
				for(int i=0; i < properties.Length; i++) {
					string propery_name = properties[i].ToString();
					printToLog(propery_name + ": " + info_obj[propery_name]);
		    	}
     		}
		}
		
		string genRandomString(string Alphabet = "01", int Length = 8)
		{
			Random rnd = new Random();            
			StringBuilder sb = new StringBuilder(Length-1);
			int Position = 0;
		
			for (int i = 0; i < Length; i++)
			{
				Position = rnd.Next(0, Alphabet.Length-1);
				sb.Append(Alphabet[Position]);
			}
		
			return sb.ToString();
		}
		
		string genRandomHEXS(int Length = 8) {
			string Alphabet = "0123456789ABCDEF";
			return genRandomString(Alphabet, Length);
		}
		
		bool isWalletReady() {
			if(client.isWalletLocked()) {
				loger.print("Кошелек заблокирован, не могу работать с NVS");
				return false;
			}
			if(client.isMintOnly()) {
				loger.print("Кошелек разблокирован в режиме mint only, не могу использовать команды");
				return false;
			}
			return true;
		}
		
		public void NVS_createRandomName() {
			if(!isWalletReady()) { return; }
			string entry_name = "test:" + genRandomHEXS(8);
			loger.print("Создаю NVS запись с именем " + entry_name + "..");
			try {
				string txid = client.NVS_NameNew(entry_name, "test entry");
				loger.print("Успешно!");
				loger.print("ID транзакции: " + txid);
			} catch(Exception ex) {
				loger.print("Отловлено исключение: " + ex.Message);
			}
		}
		
		public void NVS_uploadFile(string filepath = "") {
			if(!File.Exists(filepath)) {
				return;
			}
			if(!isWalletReady()) { return; }
			string entry_name = "file:" + genRandomHEXS(8);
			loger.print("Загружаю файл в NVS с именем записи " + entry_name + "..");
			try {
				byte[] data_bytes = File.ReadAllBytes(filepath);
				string data = Convert.ToBase64String(data_bytes);
				//Debug.Print(data);
				
				string txid = client.NVS_NameNew(
					entry_name,
					data,
					30,
					"",
					NVS_ValueType.Base64
				);
				loger.print("Успешно!");
				loger.print("ID транзакции: " + txid);
			} catch(Exception ex) {
				loger.print("Отловлено исключение: " + ex.Message);
			}
		}
	}
}
