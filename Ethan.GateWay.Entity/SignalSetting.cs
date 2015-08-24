
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalSetting:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalSetting
	{
		public SignalSetting()
		{}
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalID
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
		#endregion Model

	}
}

