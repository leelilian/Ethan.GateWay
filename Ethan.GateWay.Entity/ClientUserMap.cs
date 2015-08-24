
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// ClientUserMap:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ClientUserMap
	{
		public ClientUserMap()
		{}
		#region Model
		
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ClientID
		{
			set;
			get;
		}
		#endregion Model

	}
}

