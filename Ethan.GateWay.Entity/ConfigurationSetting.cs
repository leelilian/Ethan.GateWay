
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// ConfigurationSetting:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ConfigurationSetting
	{
		public ConfigurationSetting()
		{}
		#region Model
	
		/// <summary>
		/// 
		/// </summary>
		public int ConfigurationSettingID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Key
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Value
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool FlagEncrypted
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ServerName
		{
			set;
			get;
		}
		#endregion Model

	}
}

