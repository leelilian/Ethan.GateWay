
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// Step:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Step
	{
		public Step()
		{}
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set;
			get;
		}
		#endregion Model

	}
}

