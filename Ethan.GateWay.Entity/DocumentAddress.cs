
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// DocumentAddress:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DocumentAddress
	{
		public DocumentAddress()
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
		public int DocumentAddressTypeID
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
		public string Company
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Street1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Street2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string City
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateProvice
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISOCountryID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string CountryName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PostalCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telephone
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set;
			get;
		}
		#endregion Model

	}
}

