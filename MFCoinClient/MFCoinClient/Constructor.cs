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
  public partial class MFCoinClient : IMFCoinClient
  {
    public MFCoinClient()
    {
    	//construct with credentials?
    }
	
    public MFCoinClient(string sUri)
    {
      Url = new Uri(sUri);
    }

    public Uri Url;
    public ICredentials Credentials;
  }
}
