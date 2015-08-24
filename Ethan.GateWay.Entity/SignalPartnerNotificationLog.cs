
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalPartnerNotificationLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalPartnerNotificationLog
	{
		public SignalPartnerNotificationLog()
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
		public DateTime DateCreated
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SenderSignalPartnerID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReceiverSignalPartnerID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SignalName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SignalSubmissionDate
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
		public bool SendToSender
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SendToReceiver
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateSentToSender
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateSentToReceiver
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Group
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
		public bool Complete
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PurchaseOrderNumber
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeliveryOrderNumber
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SalesOrderNumber
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string LineItemNumber
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartNumber
		{
			set;
			get;
		}
		#endregion Model

	}
}

