
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalHeader:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalHeader
	{
		public SignalHeader()
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
		public int SignalTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SignalPartnerID
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
		public string PartnerID1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ID1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ControlNumber1
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartnerID2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ID2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ControlNumber2
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartnerID3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ID3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ControlNumber3
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Qualifier
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Indicator
		{
			set;
			get;
		}
		#endregion Model

	}
}

