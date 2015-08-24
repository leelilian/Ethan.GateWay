
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// Application:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Application
	{
		public Application()
		{}
		#region Model
	
		/// <summary>
		/// 
		/// </summary>
    public int ID
    {
      get;
      set;
    }
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
      get;
      set;
		}
		#endregion Model

	}
}

