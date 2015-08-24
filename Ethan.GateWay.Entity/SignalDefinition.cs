
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalDefinition:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalDefinition
	{
		public SignalDefinition()
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
		public string Version
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalTypeID
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
		public string XSDSchema
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string XSLTTrans
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImplementationTypeName
		{
			set;
			get;
		}
		#endregion Model

	}
}

