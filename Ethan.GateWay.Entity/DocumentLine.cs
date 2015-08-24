
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// DocumentLine:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DocumentLine
	{
		public DocumentLine()
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
		public int DocumentHeaderID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int DocumentStatusID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string AXPONo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string AXSONo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientPONo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientSONo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public long AXLineNo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientLineNo
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ItemID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ItemDescription
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Quantity1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Quantity2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Quantity3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal PriceUnit
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string UOM
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reference4
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string CurrencyCode
		{
			set;
			get;
		}
		#endregion Model

	}
}

