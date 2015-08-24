
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalPartner:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalPartner
	{
		public SignalPartner()
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
		public string Code
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
		public string Type
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string IncomingCheckString
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string IncomingWebServiceURL
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string IncomingSenderID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartnerEmailList
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool NotificationEmailsOn
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool NotificationEmailsSendPerSignal
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool NotificationEmailsSendWhenBlank
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string DefaultAXCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string DefaultAXCompany
		{
			set;
			get;
		}
		#endregion Model

	}
}

