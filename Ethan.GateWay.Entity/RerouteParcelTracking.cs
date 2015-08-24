
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// RerouteParcelTracking:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RerouteParcelTracking
	{
		public RerouteParcelTracking()
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
		public string TrackingNo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string RerouteTrackingNo
		{
			set;
			get;
		}
		#endregion Model

	}
}

