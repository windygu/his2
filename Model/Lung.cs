﻿using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Lung:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Lung
	{
		public Lung()
		{}
		#region Model
		private int _id;
		private int? _pid=0;
		private int? _period=0;
		private string _fev1;
		private string _fev1pre;
		private string _fvc;
		private string _fvcpre;
		private string _fev1fvc;
		private string _tlc;
		private string _tlvpre;
		private string _rv;
		private string _rvpre;
		private string _rvtlc;
		private DateTime? _checktime;
		private string _file;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 病人ID
		/// </summary>
		public int? PID
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 治疗区间:治疗前基线指标, 治疗后1周, 治疗后1月, 治疗后3月, 治疗后6月, 治疗后1年, 治疗后2年, 治疗后3年, 治疗后4年, 治疗后5年
		/// </summary>
		public int? Period
		{
			set{ _period=value;}
			get{return _period;}
		}
		/// <summary>
		/// FEV1
		/// </summary>
		public string fev1
		{
			set{ _fev1=value;}
			get{return _fev1;}
		}
		/// <summary>
		/// FEV1pre%
		/// </summary>
		public string fev1pre
		{
			set{ _fev1pre=value;}
			get{return _fev1pre;}
		}
		/// <summary>
		/// FVC
		/// </summary>
		public string fvc
		{
			set{ _fvc=value;}
			get{return _fvc;}
		}
		/// <summary>
		/// FVCpre%
		/// </summary>
		public string fvcpre
		{
			set{ _fvcpre=value;}
			get{return _fvcpre;}
		}
		/// <summary>
		/// FEV1/FVC
		/// </summary>
		public string fev1fvc
		{
			set{ _fev1fvc=value;}
			get{return _fev1fvc;}
		}
		/// <summary>
		/// TLC
		/// </summary>
		public string tlc
		{
			set{ _tlc=value;}
			get{return _tlc;}
		}
		/// <summary>
		/// TLVpre%   
		/// </summary>
		public string tlvpre
		{
			set{ _tlvpre=value;}
			get{return _tlvpre;}
		}
		/// <summary>
		/// RV
		/// </summary>
		public string rv
		{
			set{ _rv=value;}
			get{return _rv;}
		}
		/// <summary>
		/// RVpre%
		/// </summary>
		public string rvpre
		{
			set{ _rvpre=value;}
			get{return _rvpre;}
		}
		/// <summary>
		/// RV/TLC
		/// </summary>
		public string rvtlc
		{
			set{ _rvtlc=value;}
			get{return _rvtlc;}
		}
		/// <summary>
		/// 检查时间
		/// </summary>
		public DateTime? CheckTime
		{
			set{ _checktime=value;}
			get{return _checktime;}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string File
		{
			set{ _file=value;}
			get{return _file;}
		}
		#endregion Model

	}
}
