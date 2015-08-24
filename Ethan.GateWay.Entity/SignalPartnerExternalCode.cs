
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalPartnerExternalCode:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalPartnerExternalCode
	{
		public SignalPartnerExternalCode()
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
		public int UsedBySignalPartnerID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExternalCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalPartnerID
		{
			set;
			get;
		}
		#endregion Model

	}
}

