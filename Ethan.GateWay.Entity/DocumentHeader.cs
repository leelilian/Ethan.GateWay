
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// DocumentHeader:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DocumentHeader
	{
		public DocumentHeader()
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
		public int DocumentTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int DocumentStatusID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalID
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
		public int SignalTrackerID
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
		public string ClientSONo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string AXPONo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string AXSONo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientPONo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference4
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string CurrencyCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Weight
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeightUOM
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeightQualifier
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Amount1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Amount2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Amount3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Comment1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Comment2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Comment3
		{
			set;
			get;
		}
		#endregion Model

	}
}

