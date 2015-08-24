
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalStep:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalStep
	{
		public SignalStep()
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
		public int SignalID
		{
			set;
			get;
		}
		/// <summary>
		/// Stores the sequence of steps required for a signal to run
		/// </summary>
		public int ProcessingOrder
		{
			set;
			get;
		}
		#endregion Model

	}
}

