
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// Client_Site:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Client_Site
	{
		public Client_Site()
		{}
		#region Model
		
		/// <summary>
		/// 
		/// </summary>
		public int ClientID
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
		public string ExternalCode
		{
      set;
      get;
		}
		#endregion Model

	}
}

