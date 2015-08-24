
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// DocumentLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DocumentLog
	{
		public DocumentLog()
		{}
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public int DocumentHeaderID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int DocumentLineID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateStamp
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string User
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Message
		{
			set;
			get;
		}
		#endregion Model

	}
}

