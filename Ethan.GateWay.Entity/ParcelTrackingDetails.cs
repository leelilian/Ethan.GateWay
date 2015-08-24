
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// ParcelTrackingDetails:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ParcelTrackingDetails
	{
		public ParcelTrackingDetails()
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
		public int TrackingID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalTrackerID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Location
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string StatusCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Time
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TimeStamp
		{
			set;
			get;
		}
		#endregion Model

	}
}

