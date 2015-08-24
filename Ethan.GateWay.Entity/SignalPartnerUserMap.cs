
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalPartnerUserMap:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalPartnerUserMap
	{
		public SignalPartnerUserMap()
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
		public int UserID
		{
			set;
			get;
		}
		#endregion Model

	}
}

