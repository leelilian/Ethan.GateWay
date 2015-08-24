
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalTrackerDetails:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalTrackerDetails
	{
		public SignalTrackerDetails()
		{}
		#region Model
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
		public string ReferenceNo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReferenceDescription
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateStamp
		{
			set;
			get;
		}
		#endregion Model

	}
}

