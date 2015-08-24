
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// ParcelTracking:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ParcelTracking
	{
		public ParcelTracking()
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
		public string TrackingNumber
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Carrier
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Service
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipToAddress1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipToAddress2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipToAddress3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipToCity
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipToStateCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipToPostalCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShipToCountryCode
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateShipped
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EstimatedDeliveryDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateDelivered
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Weight
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
		public string Signature
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastestStatus
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime StatusDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TimeStamp
		{
			set;
			get;
		}
		#endregion Model

	}
}

