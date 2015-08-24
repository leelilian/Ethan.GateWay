
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// ConnectionSettings:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ConnectionSettings
	{
		public ConnectionSettings()
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
		public int ConnectionTypeID
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
		public string Description
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Username
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Folder
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckString
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SenderID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ConnectionSettingsAS2DetailsID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ConnectionSettingsEmailTemplateID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool FTPPassiveConnection
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SFTPAuthenticationType
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SFTPAuthenticationKey
		{
			set;
			get;
		}
		#endregion Model

	}
}

