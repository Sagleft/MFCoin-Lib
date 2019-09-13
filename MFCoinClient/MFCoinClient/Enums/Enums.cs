using System;
using System.ComponentModel;
using System.Collections.Generic;
using MFCoin.Client.Enums;

namespace MFCoin.Client.Enums
{
	public enum NVS_ValueType : int {
		[Description("")]
		Unicode = 0, //by default
		
		[Description("hex")]
		HEX,
		
		[Description("base64")]
		Base64,
		
		[Description("filepath")]
		FilePath
	}
}
