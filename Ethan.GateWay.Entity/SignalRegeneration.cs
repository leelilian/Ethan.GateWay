
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalRegeneration:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalRegeneration
	{
		public SignalRegeneration()
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
		public int SignalID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Complete
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateProcessed
		{
			set;
			get;
		}
		#endregion Model

	}
}

