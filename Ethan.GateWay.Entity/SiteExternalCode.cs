
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SiteExternalCode:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SiteExternalCode
	{
		public SiteExternalCode()
		{}
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public string ExternalCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SiteID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Client
		{
			set;
			get;
		}
		#endregion Model

	}
}

