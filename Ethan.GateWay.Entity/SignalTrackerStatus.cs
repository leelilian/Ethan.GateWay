
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalTrackerStatus:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalTrackerStatus
	{
		public SignalTrackerStatus()
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
		public string Description
		{
			set;
			get;
		}
		#endregion Model

	}
}

