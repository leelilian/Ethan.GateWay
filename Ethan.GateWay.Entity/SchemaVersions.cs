
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SchemaVersions:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SchemaVersions
	{
		public SchemaVersions()
		{}
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ScriptName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Applied
		{
			set;
			get;
		}
		#endregion Model

	}
}

