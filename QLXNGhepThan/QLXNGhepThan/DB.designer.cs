﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLXNGhepThan
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLGhepThan")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDangkyXN(DangkyXN instance);
    partial void UpdateDangkyXN(DangkyXN instance);
    partial void DeleteDangkyXN(DangkyXN instance);
    partial void InsertLoaiXetNghiem(LoaiXetNghiem instance);
    partial void UpdateLoaiXetNghiem(LoaiXetNghiem instance);
    partial void DeleteLoaiXetNghiem(LoaiXetNghiem instance);
    partial void InsertBenhNhan(BenhNhan instance);
    partial void UpdateBenhNhan(BenhNhan instance);
    partial void DeleteBenhNhan(BenhNhan instance);
    partial void InsertHenXN(HenXN instance);
    partial void UpdateHenXN(HenXN instance);
    partial void DeleteHenXN(HenXN instance);
    partial void InsertXetNghiem(XetNghiem instance);
    partial void UpdateXetNghiem(XetNghiem instance);
    partial void DeleteXetNghiem(XetNghiem instance);
    #endregion
		
		public DBDataContext() : 
				base(global::QLXNGhepThan.Properties.Settings.Default.QLGhepThanConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DangkyXN> DangkyXNs
		{
			get
			{
				return this.GetTable<DangkyXN>();
			}
		}
		
		public System.Data.Linq.Table<LoaiXetNghiem> LoaiXetNghiems
		{
			get
			{
				return this.GetTable<LoaiXetNghiem>();
			}
		}
		
		public System.Data.Linq.Table<BenhNhan> BenhNhans
		{
			get
			{
				return this.GetTable<BenhNhan>();
			}
		}
		
		public System.Data.Linq.Table<HenXN> HenXNs
		{
			get
			{
				return this.GetTable<HenXN>();
			}
		}
		
		public System.Data.Linq.Table<XetNghiem> XetNghiems
		{
			get
			{
				return this.GetTable<XetNghiem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangkyXN")]
	public partial class DangkyXN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TenBN;
		
		private string _LoaiXN;
		
		private string _SDT;
		
		private string _NgayXN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenBNChanging(string value);
    partial void OnTenBNChanged();
    partial void OnLoaiXNChanging(string value);
    partial void OnLoaiXNChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnNgayXNChanging(string value);
    partial void OnNgayXNChanged();
    #endregion
		
		public DangkyXN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBN", DbType="NVarChar(50)")]
		public string TenBN
		{
			get
			{
				return this._TenBN;
			}
			set
			{
				if ((this._TenBN != value))
				{
					this.OnTenBNChanging(value);
					this.SendPropertyChanging();
					this._TenBN = value;
					this.SendPropertyChanged("TenBN");
					this.OnTenBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiXN", DbType="NVarChar(50)")]
		public string LoaiXN
		{
			get
			{
				return this._LoaiXN;
			}
			set
			{
				if ((this._LoaiXN != value))
				{
					this.OnLoaiXNChanging(value);
					this.SendPropertyChanging();
					this._LoaiXN = value;
					this.SendPropertyChanged("LoaiXN");
					this.OnLoaiXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(50)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXN", DbType="NVarChar(50)")]
		public string NgayXN
		{
			get
			{
				return this._NgayXN;
			}
			set
			{
				if ((this._NgayXN != value))
				{
					this.OnNgayXNChanging(value);
					this.SendPropertyChanging();
					this._NgayXN = value;
					this.SendPropertyChanged("NgayXN");
					this.OnNgayXNChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiXetNghiem")]
	public partial class LoaiXetNghiem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDLoaiXN;
		
		private string _TenXN;
		
		private System.Nullable<int> _ThoiHan;
		
		private string _Note;
		
		private EntitySet<XetNghiem> _XetNghiems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDLoaiXNChanging(int value);
    partial void OnIDLoaiXNChanged();
    partial void OnTenXNChanging(string value);
    partial void OnTenXNChanged();
    partial void OnThoiHanChanging(System.Nullable<int> value);
    partial void OnThoiHanChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    #endregion
		
		public LoaiXetNghiem()
		{
			this._XetNghiems = new EntitySet<XetNghiem>(new Action<XetNghiem>(this.attach_XetNghiems), new Action<XetNghiem>(this.detach_XetNghiems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLoaiXN", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDLoaiXN
		{
			get
			{
				return this._IDLoaiXN;
			}
			set
			{
				if ((this._IDLoaiXN != value))
				{
					this.OnIDLoaiXNChanging(value);
					this.SendPropertyChanging();
					this._IDLoaiXN = value;
					this.SendPropertyChanged("IDLoaiXN");
					this.OnIDLoaiXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenXN", DbType="NVarChar(50)")]
		public string TenXN
		{
			get
			{
				return this._TenXN;
			}
			set
			{
				if ((this._TenXN != value))
				{
					this.OnTenXNChanging(value);
					this.SendPropertyChanging();
					this._TenXN = value;
					this.SendPropertyChanged("TenXN");
					this.OnTenXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoiHan", DbType="Int")]
		public System.Nullable<int> ThoiHan
		{
			get
			{
				return this._ThoiHan;
			}
			set
			{
				if ((this._ThoiHan != value))
				{
					this.OnThoiHanChanging(value);
					this.SendPropertyChanging();
					this._ThoiHan = value;
					this.SendPropertyChanged("ThoiHan");
					this.OnThoiHanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="NVarChar(50)")]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiXetNghiem_XetNghiem", Storage="_XetNghiems", ThisKey="IDLoaiXN", OtherKey="IDLoaiXN")]
		public EntitySet<XetNghiem> XetNghiems
		{
			get
			{
				return this._XetNghiems;
			}
			set
			{
				this._XetNghiems.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_XetNghiems(XetNghiem entity)
		{
			this.SendPropertyChanging();
			entity.LoaiXetNghiem = this;
		}
		
		private void detach_XetNghiems(XetNghiem entity)
		{
			this.SendPropertyChanging();
			entity.LoaiXetNghiem = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BenhNhan")]
	public partial class BenhNhan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaBN;
		
		private string _TenBN;
		
		private System.Nullable<int> _NamSinh;
		
		private string _GioiTinh;
		
		private string _SDT;
		
		private string _NgayXN;
		
		private EntitySet<HenXN> _HenXNs;
		
		private EntitySet<XetNghiem> _XetNghiems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBNChanging(int value);
    partial void OnMaBNChanged();
    partial void OnTenBNChanging(string value);
    partial void OnTenBNChanged();
    partial void OnNamSinhChanging(System.Nullable<int> value);
    partial void OnNamSinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnNgayXNChanging(string value);
    partial void OnNgayXNChanged();
    #endregion
		
		public BenhNhan()
		{
			this._HenXNs = new EntitySet<HenXN>(new Action<HenXN>(this.attach_HenXNs), new Action<HenXN>(this.detach_HenXNs));
			this._XetNghiems = new EntitySet<XetNghiem>(new Action<XetNghiem>(this.attach_XetNghiems), new Action<XetNghiem>(this.detach_XetNghiems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBN", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaBN
		{
			get
			{
				return this._MaBN;
			}
			set
			{
				if ((this._MaBN != value))
				{
					this.OnMaBNChanging(value);
					this.SendPropertyChanging();
					this._MaBN = value;
					this.SendPropertyChanged("MaBN");
					this.OnMaBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBN", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenBN
		{
			get
			{
				return this._TenBN;
			}
			set
			{
				if ((this._TenBN != value))
				{
					this.OnTenBNChanging(value);
					this.SendPropertyChanging();
					this._TenBN = value;
					this.SendPropertyChanged("TenBN");
					this.OnTenBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamSinh", DbType="Int")]
		public System.Nullable<int> NamSinh
		{
			get
			{
				return this._NamSinh;
			}
			set
			{
				if ((this._NamSinh != value))
				{
					this.OnNamSinhChanging(value);
					this.SendPropertyChanging();
					this._NamSinh = value;
					this.SendPropertyChanged("NamSinh");
					this.OnNamSinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(50)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXN", DbType="NVarChar(50)")]
		public string NgayXN
		{
			get
			{
				return this._NgayXN;
			}
			set
			{
				if ((this._NgayXN != value))
				{
					this.OnNgayXNChanging(value);
					this.SendPropertyChanging();
					this._NgayXN = value;
					this.SendPropertyChanged("NgayXN");
					this.OnNgayXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BenhNhan_HenXN", Storage="_HenXNs", ThisKey="MaBN", OtherKey="MaBN")]
		public EntitySet<HenXN> HenXNs
		{
			get
			{
				return this._HenXNs;
			}
			set
			{
				this._HenXNs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BenhNhan_XetNghiem", Storage="_XetNghiems", ThisKey="MaBN", OtherKey="MaBN")]
		public EntitySet<XetNghiem> XetNghiems
		{
			get
			{
				return this._XetNghiems;
			}
			set
			{
				this._XetNghiems.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HenXNs(HenXN entity)
		{
			this.SendPropertyChanging();
			entity.BenhNhan = this;
		}
		
		private void detach_HenXNs(HenXN entity)
		{
			this.SendPropertyChanging();
			entity.BenhNhan = null;
		}
		
		private void attach_XetNghiems(XetNghiem entity)
		{
			this.SendPropertyChanging();
			entity.BenhNhan = this;
		}
		
		private void detach_XetNghiems(XetNghiem entity)
		{
			this.SendPropertyChanging();
			entity.BenhNhan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HenXN")]
	public partial class HenXN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TenBN;
		
		private string _NgayXN;
		
		private string _LoaiXN;
		
		private System.Nullable<int> _MaBN;
		
		private System.Nullable<int> _IDLoaiXN;
		
		private System.Nullable<int> _ThoiHanXN;
		
		private EntityRef<BenhNhan> _BenhNhan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenBNChanging(string value);
    partial void OnTenBNChanged();
    partial void OnNgayXNChanging(string value);
    partial void OnNgayXNChanged();
    partial void OnLoaiXNChanging(string value);
    partial void OnLoaiXNChanged();
    partial void OnMaBNChanging(System.Nullable<int> value);
    partial void OnMaBNChanged();
    partial void OnIDLoaiXNChanging(System.Nullable<int> value);
    partial void OnIDLoaiXNChanged();
    partial void OnThoiHanXNChanging(System.Nullable<int> value);
    partial void OnThoiHanXNChanged();
    #endregion
		
		public HenXN()
		{
			this._BenhNhan = default(EntityRef<BenhNhan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBN", DbType="NVarChar(50)")]
		public string TenBN
		{
			get
			{
				return this._TenBN;
			}
			set
			{
				if ((this._TenBN != value))
				{
					this.OnTenBNChanging(value);
					this.SendPropertyChanging();
					this._TenBN = value;
					this.SendPropertyChanged("TenBN");
					this.OnTenBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXN", DbType="NVarChar(50)")]
		public string NgayXN
		{
			get
			{
				return this._NgayXN;
			}
			set
			{
				if ((this._NgayXN != value))
				{
					this.OnNgayXNChanging(value);
					this.SendPropertyChanging();
					this._NgayXN = value;
					this.SendPropertyChanged("NgayXN");
					this.OnNgayXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiXN", DbType="NVarChar(50)")]
		public string LoaiXN
		{
			get
			{
				return this._LoaiXN;
			}
			set
			{
				if ((this._LoaiXN != value))
				{
					this.OnLoaiXNChanging(value);
					this.SendPropertyChanging();
					this._LoaiXN = value;
					this.SendPropertyChanged("LoaiXN");
					this.OnLoaiXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBN", DbType="Int")]
		public System.Nullable<int> MaBN
		{
			get
			{
				return this._MaBN;
			}
			set
			{
				if ((this._MaBN != value))
				{
					if (this._BenhNhan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaBNChanging(value);
					this.SendPropertyChanging();
					this._MaBN = value;
					this.SendPropertyChanged("MaBN");
					this.OnMaBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLoaiXN", DbType="Int")]
		public System.Nullable<int> IDLoaiXN
		{
			get
			{
				return this._IDLoaiXN;
			}
			set
			{
				if ((this._IDLoaiXN != value))
				{
					this.OnIDLoaiXNChanging(value);
					this.SendPropertyChanging();
					this._IDLoaiXN = value;
					this.SendPropertyChanged("IDLoaiXN");
					this.OnIDLoaiXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoiHanXN", DbType="Int")]
		public System.Nullable<int> ThoiHanXN
		{
			get
			{
				return this._ThoiHanXN;
			}
			set
			{
				if ((this._ThoiHanXN != value))
				{
					this.OnThoiHanXNChanging(value);
					this.SendPropertyChanging();
					this._ThoiHanXN = value;
					this.SendPropertyChanged("ThoiHanXN");
					this.OnThoiHanXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BenhNhan_HenXN", Storage="_BenhNhan", ThisKey="MaBN", OtherKey="MaBN", IsForeignKey=true)]
		public BenhNhan BenhNhan
		{
			get
			{
				return this._BenhNhan.Entity;
			}
			set
			{
				BenhNhan previousValue = this._BenhNhan.Entity;
				if (((previousValue != value) 
							|| (this._BenhNhan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BenhNhan.Entity = null;
						previousValue.HenXNs.Remove(this);
					}
					this._BenhNhan.Entity = value;
					if ((value != null))
					{
						value.HenXNs.Add(this);
						this._MaBN = value.MaBN;
					}
					else
					{
						this._MaBN = default(Nullable<int>);
					}
					this.SendPropertyChanged("BenhNhan");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.XetNghiem")]
	public partial class XetNghiem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _TenXN;
		
		private string _NgayXN;
		
		private string _KetQua;
		
		private string _Note;
		
		private int _MaBN;
		
		private string _Status;
		
		private System.Nullable<int> _IDLoaiXN;
		
		private System.Nullable<int> _SoLanXN;
		
		private string _Thoihan;
		
		private System.Data.Linq.Binary _Image;
		
		private EntityRef<BenhNhan> _BenhNhan;
		
		private EntityRef<LoaiXetNghiem> _LoaiXetNghiem;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnTenXNChanging(string value);
    partial void OnTenXNChanged();
    partial void OnNgayXNChanging(string value);
    partial void OnNgayXNChanged();
    partial void OnKetQuaChanging(string value);
    partial void OnKetQuaChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    partial void OnMaBNChanging(int value);
    partial void OnMaBNChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnIDLoaiXNChanging(System.Nullable<int> value);
    partial void OnIDLoaiXNChanged();
    partial void OnSoLanXNChanging(System.Nullable<int> value);
    partial void OnSoLanXNChanged();
    partial void OnThoihanChanging(string value);
    partial void OnThoihanChanged();
    partial void OnImageChanging(System.Data.Linq.Binary value);
    partial void OnImageChanged();
    #endregion
		
		public XetNghiem()
		{
			this._BenhNhan = default(EntityRef<BenhNhan>);
			this._LoaiXetNghiem = default(EntityRef<LoaiXetNghiem>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenXN", DbType="NVarChar(50)")]
		public string TenXN
		{
			get
			{
				return this._TenXN;
			}
			set
			{
				if ((this._TenXN != value))
				{
					this.OnTenXNChanging(value);
					this.SendPropertyChanging();
					this._TenXN = value;
					this.SendPropertyChanged("TenXN");
					this.OnTenXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXN", DbType="NVarChar(50)")]
		public string NgayXN
		{
			get
			{
				return this._NgayXN;
			}
			set
			{
				if ((this._NgayXN != value))
				{
					this.OnNgayXNChanging(value);
					this.SendPropertyChanging();
					this._NgayXN = value;
					this.SendPropertyChanged("NgayXN");
					this.OnNgayXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KetQua", DbType="NVarChar(50)")]
		public string KetQua
		{
			get
			{
				return this._KetQua;
			}
			set
			{
				if ((this._KetQua != value))
				{
					this.OnKetQuaChanging(value);
					this.SendPropertyChanging();
					this._KetQua = value;
					this.SendPropertyChanged("KetQua");
					this.OnKetQuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="NVarChar(MAX)")]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBN", DbType="Int NOT NULL")]
		public int MaBN
		{
			get
			{
				return this._MaBN;
			}
			set
			{
				if ((this._MaBN != value))
				{
					if (this._BenhNhan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaBNChanging(value);
					this.SendPropertyChanging();
					this._MaBN = value;
					this.SendPropertyChanged("MaBN");
					this.OnMaBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLoaiXN", DbType="Int")]
		public System.Nullable<int> IDLoaiXN
		{
			get
			{
				return this._IDLoaiXN;
			}
			set
			{
				if ((this._IDLoaiXN != value))
				{
					if (this._LoaiXetNghiem.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDLoaiXNChanging(value);
					this.SendPropertyChanging();
					this._IDLoaiXN = value;
					this.SendPropertyChanged("IDLoaiXN");
					this.OnIDLoaiXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLanXN", DbType="Int")]
		public System.Nullable<int> SoLanXN
		{
			get
			{
				return this._SoLanXN;
			}
			set
			{
				if ((this._SoLanXN != value))
				{
					this.OnSoLanXNChanging(value);
					this.SendPropertyChanging();
					this._SoLanXN = value;
					this.SendPropertyChanged("SoLanXN");
					this.OnSoLanXNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thoihan", DbType="NVarChar(50)")]
		public string Thoihan
		{
			get
			{
				return this._Thoihan;
			}
			set
			{
				if ((this._Thoihan != value))
				{
					this.OnThoihanChanging(value);
					this.SendPropertyChanging();
					this._Thoihan = value;
					this.SendPropertyChanged("Thoihan");
					this.OnThoihanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BenhNhan_XetNghiem", Storage="_BenhNhan", ThisKey="MaBN", OtherKey="MaBN", IsForeignKey=true)]
		public BenhNhan BenhNhan
		{
			get
			{
				return this._BenhNhan.Entity;
			}
			set
			{
				BenhNhan previousValue = this._BenhNhan.Entity;
				if (((previousValue != value) 
							|| (this._BenhNhan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BenhNhan.Entity = null;
						previousValue.XetNghiems.Remove(this);
					}
					this._BenhNhan.Entity = value;
					if ((value != null))
					{
						value.XetNghiems.Add(this);
						this._MaBN = value.MaBN;
					}
					else
					{
						this._MaBN = default(int);
					}
					this.SendPropertyChanged("BenhNhan");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiXetNghiem_XetNghiem", Storage="_LoaiXetNghiem", ThisKey="IDLoaiXN", OtherKey="IDLoaiXN", IsForeignKey=true)]
		public LoaiXetNghiem LoaiXetNghiem
		{
			get
			{
				return this._LoaiXetNghiem.Entity;
			}
			set
			{
				LoaiXetNghiem previousValue = this._LoaiXetNghiem.Entity;
				if (((previousValue != value) 
							|| (this._LoaiXetNghiem.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiXetNghiem.Entity = null;
						previousValue.XetNghiems.Remove(this);
					}
					this._LoaiXetNghiem.Entity = value;
					if ((value != null))
					{
						value.XetNghiems.Add(this);
						this._IDLoaiXN = value.IDLoaiXN;
					}
					else
					{
						this._IDLoaiXN = default(Nullable<int>);
					}
					this.SendPropertyChanged("LoaiXetNghiem");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
