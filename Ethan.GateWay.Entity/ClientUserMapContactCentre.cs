
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// ClientUserMapContactCentre:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ClientUserMapContactCentre
	{
		public ClientUserMapContactCentre()
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

