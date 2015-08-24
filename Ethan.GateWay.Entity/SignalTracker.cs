
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalTracker:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalTracker
	{
		public SignalTracker()
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
		public int SignalID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int HandShakeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string UniqueSignalID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ref1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ref2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ref3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ref1Desc
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ref2Desc
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ref3Desc
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalCurrentStepID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalStatusID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int HandshakeCurrentStepID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int HandshakeStatusID
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
		public string Ref4
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ref4Desc
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool LogArchived
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool AS2MDNReceiptOutstanding
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SendingAttempts
		{
			set;
			get;
		}
		#endregion Model

	}
}

