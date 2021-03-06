﻿
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// DocumentStatus:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DocumentStatus
	{
		public DocumentStatus()
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
		public string Description
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Deleted
		{
			set;
			get;
		}
		#endregion Model

	}
}

