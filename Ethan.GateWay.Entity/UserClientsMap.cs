
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class UserClientsMap
	{
		public UserClientsMap()
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

