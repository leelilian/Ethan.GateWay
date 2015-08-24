
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// ConnectionSettingsAS2Details:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ConnectionSettingsAS2Details
	{
		public ConnectionSettingsAS2Details()
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
		public string PartnerIdentifier
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartnerCertificateStore
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartnerCertificateSubjectName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int PartnerMDNReturnType
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCHCertificateStore
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCHCertificateSubjectName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int PCHMDNReturnType
		{
			set;
			get;
		}
		#endregion Model

	}
}

