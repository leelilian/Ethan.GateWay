
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalPartnerConfigSetting:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalPartnerConfigSetting
	{
		public SignalPartnerConfigSetting()
		{}
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public int SignalPartnerID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FieldID
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
		#endregion Model

	}
}

