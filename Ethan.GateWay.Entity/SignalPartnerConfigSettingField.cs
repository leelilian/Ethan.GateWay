
using System;
namespace Ethan.GateWay.Entity
{
	/// <summary>
	/// SignalPartnerConfigSettingField:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SignalPartnerConfigSettingField
	{
		public SignalPartnerConfigSettingField()
		{}
		#region Model
		/// <summary>
		/// 
		/// </summary>
		public string FieldID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FieldType
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string DefaultValue
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
		public string Description
		{
			set;
			get;
		}
		#endregion Model

	}
}

