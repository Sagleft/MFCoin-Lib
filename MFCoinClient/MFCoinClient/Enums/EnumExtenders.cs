using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace MFCoin.Client.Enums
{
	/// <summary>
	/// Класс для расширения Enums
	/// </summary>
	public static class EnumExtenders {
		/// <summary>
		/// получить описание Enum
		/// </summary>
		/// <param name="enumerate">Enum для обработки</param>
		/// <returns>вернет описание Enum</returns>
		public static string GetDescription(this Enum enumerate) {
			var type = enumerate.GetType();
			var fieldInfo = type.GetField(enumerate.ToString());
			var attributes = (DescriptionAttribute[]) fieldInfo.GetCustomAttributes(typeof (DescriptionAttribute), false);
			return (attributes.Length > 0) ? attributes[0].Description : enumerate.ToString();
		}
		
		public static string[] Descriptions(this Enum enumerate) {
			var values = Enum.GetValues(enumerate.GetType());
			var descriptions = new string[ values.Length ];
			
			int i = 0;
			foreach (var enumVal in values) {
				descriptions[i] = ((Enum) enumVal).GetDescription();
				i++;
			}
			
			return descriptions;
		}
	}
}
