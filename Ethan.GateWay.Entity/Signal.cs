
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// Signal:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Signal
	{
		public Signal()
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
		public string Name
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
		public string Model
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalTypeID
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
		public int SenderDisplaySignalPartnerID
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
		public int ReceiverDisplaySignalPartnerID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalHeaderID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ConnectionID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Inbound
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string XSDSchema
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string XSLTTrans
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string AXCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string AXCompany
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SendingOn
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool HasHandshake
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileNameMask
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SenderEmailList
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiverEmailList
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool GenericSending
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int MaxSendingRetry
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImplementationTypeName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int NoOfEntriesPerSignal
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalProcessingModeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalDefinitionID
		{
			set;
			get;
		}
		#endregion Model

	}
}

