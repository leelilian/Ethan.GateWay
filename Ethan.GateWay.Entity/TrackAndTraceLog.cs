
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class TrackAndTraceLog
	{
		public TrackAndTraceLog()
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
		public int SignalPartnerID
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

