
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// ConnectionSettingsEmailTemplate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ConnectionSettingsEmailTemplate
	{
		public ConnectionSettingsEmailTemplate()
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
		public string Description
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToAddr
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCAddr
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string BCCAddr
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FromAddr
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FromName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Subject
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Body
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsHtml
		{
			set;
			get;
		}
		#endregion Model

	}
}

