
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalTrackerLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalTrackerLog
	{
		public SignalTrackerLog()
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
		public int SignalTrackerID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalStepID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ApplicationID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Message
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string MessageType
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogData
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

