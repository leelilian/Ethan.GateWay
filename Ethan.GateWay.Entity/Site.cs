
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// Site:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Site
	{
		public Site()
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
		public string WMSCompanyID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string WMSSiteID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinessArea
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string WSURL
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string WSCheckString
		{
			set;
			get;
		}
		#endregion Model

	}
}

