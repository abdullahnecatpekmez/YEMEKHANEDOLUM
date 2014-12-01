﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.34014
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yemekhane_Dolum
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Online Dolum")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMENU(MENU instance);
    partial void UpdateMENU(MENU instance);
    partial void DeleteMENU(MENU instance);
    partial void InsertOGUN(OGUN instance);
    partial void UpdateOGUN(OGUN instance);
    partial void DeleteOGUN(OGUN instance);
    partial void InsertYEMEK(YEMEK instance);
    partial void UpdateYEMEK(YEMEK instance);
    partial void DeleteYEMEK(YEMEK instance);
    partial void InsertYEMEKALAN(YEMEKALAN instance);
    partial void UpdateYEMEKALAN(YEMEKALAN instance);
    partial void DeleteYEMEKALAN(YEMEKALAN instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::Yemekhane_Dolum.Properties.Settings.Default.Online_DolumConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MENU> MENU
		{
			get
			{
				return this.GetTable<MENU>();
			}
		}
		
		public System.Data.Linq.Table<OGUN> OGUN
		{
			get
			{
				return this.GetTable<OGUN>();
			}
		}
		
		public System.Data.Linq.Table<YEMEK> YEMEK
		{
			get
			{
				return this.GetTable<YEMEK>();
			}
		}
		
		public System.Data.Linq.Table<YEMEKALAN> YEMEKALAN
		{
			get
			{
				return this.GetTable<YEMEKALAN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MENU")]
	public partial class MENU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ogunNO;
		
		private int _yemekNO;
		
		private EntityRef<OGUN> _OGUN;
		
		private EntityRef<YEMEK> _YEMEK;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnogunNOChanging(int value);
    partial void OnogunNOChanged();
    partial void OnyemekNOChanging(int value);
    partial void OnyemekNOChanged();
    #endregion
		
		public MENU()
		{
			this._OGUN = default(EntityRef<OGUN>);
			this._YEMEK = default(EntityRef<YEMEK>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ogunNO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ogunNO
		{
			get
			{
				return this._ogunNO;
			}
			set
			{
				if ((this._ogunNO != value))
				{
					if (this._OGUN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnogunNOChanging(value);
					this.SendPropertyChanging();
					this._ogunNO = value;
					this.SendPropertyChanged("ogunNO");
					this.OnogunNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yemekNO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int yemekNO
		{
			get
			{
				return this._yemekNO;
			}
			set
			{
				if ((this._yemekNO != value))
				{
					if (this._YEMEK.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnyemekNOChanging(value);
					this.SendPropertyChanging();
					this._yemekNO = value;
					this.SendPropertyChanged("yemekNO");
					this.OnyemekNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OGUN_MENU", Storage="_OGUN", ThisKey="ogunNO", OtherKey="ogunNO", IsForeignKey=true)]
		public OGUN OGUN
		{
			get
			{
				return this._OGUN.Entity;
			}
			set
			{
				OGUN previousValue = this._OGUN.Entity;
				if (((previousValue != value) 
							|| (this._OGUN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._OGUN.Entity = null;
						previousValue.MENU.Remove(this);
					}
					this._OGUN.Entity = value;
					if ((value != null))
					{
						value.MENU.Add(this);
						this._ogunNO = value.ogunNO;
					}
					else
					{
						this._ogunNO = default(int);
					}
					this.SendPropertyChanged("OGUN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="YEMEK_MENU", Storage="_YEMEK", ThisKey="yemekNO", OtherKey="yemekNO", IsForeignKey=true)]
		public YEMEK YEMEK
		{
			get
			{
				return this._YEMEK.Entity;
			}
			set
			{
				YEMEK previousValue = this._YEMEK.Entity;
				if (((previousValue != value) 
							|| (this._YEMEK.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._YEMEK.Entity = null;
						previousValue.MENU.Remove(this);
					}
					this._YEMEK.Entity = value;
					if ((value != null))
					{
						value.MENU.Add(this);
						this._yemekNO = value.yemekNO;
					}
					else
					{
						this._yemekNO = default(int);
					}
					this.SendPropertyChanged("YEMEK");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OGUN")]
	public partial class OGUN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ogunNO;
		
		private System.Nullable<System.DateTime> _tarih;
		
		private System.Nullable<int> _ogunTuru;
		
		private EntitySet<MENU> _MENU;
		
		private EntitySet<YEMEKALAN> _YEMEKALAN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnogunNOChanging(int value);
    partial void OnogunNOChanged();
    partial void OntarihChanging(System.Nullable<System.DateTime> value);
    partial void OntarihChanged();
    partial void OnogunTuruChanging(System.Nullable<int> value);
    partial void OnogunTuruChanged();
    #endregion
		
		public OGUN()
		{
			this._MENU = new EntitySet<MENU>(new Action<MENU>(this.attach_MENU), new Action<MENU>(this.detach_MENU));
			this._YEMEKALAN = new EntitySet<YEMEKALAN>(new Action<YEMEKALAN>(this.attach_YEMEKALAN), new Action<YEMEKALAN>(this.detach_YEMEKALAN));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ogunNO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ogunNO
		{
			get
			{
				return this._ogunNO;
			}
			set
			{
				if ((this._ogunNO != value))
				{
					this.OnogunNOChanging(value);
					this.SendPropertyChanging();
					this._ogunNO = value;
					this.SendPropertyChanged("ogunNO");
					this.OnogunNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tarih", DbType="Date")]
		public System.Nullable<System.DateTime> tarih
		{
			get
			{
				return this._tarih;
			}
			set
			{
				if ((this._tarih != value))
				{
					this.OntarihChanging(value);
					this.SendPropertyChanging();
					this._tarih = value;
					this.SendPropertyChanged("tarih");
					this.OntarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ogunTuru", DbType="Int")]
		public System.Nullable<int> ogunTuru
		{
			get
			{
				return this._ogunTuru;
			}
			set
			{
				if ((this._ogunTuru != value))
				{
					this.OnogunTuruChanging(value);
					this.SendPropertyChanging();
					this._ogunTuru = value;
					this.SendPropertyChanged("ogunTuru");
					this.OnogunTuruChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OGUN_MENU", Storage="_MENU", ThisKey="ogunNO", OtherKey="ogunNO")]
		public EntitySet<MENU> MENU
		{
			get
			{
				return this._MENU;
			}
			set
			{
				this._MENU.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OGUN_YEMEKALAN", Storage="_YEMEKALAN", ThisKey="ogunNO", OtherKey="ogunNO")]
		public EntitySet<YEMEKALAN> YEMEKALAN
		{
			get
			{
				return this._YEMEKALAN;
			}
			set
			{
				this._YEMEKALAN.Assign(value);
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
		
		private void attach_MENU(MENU entity)
		{
			this.SendPropertyChanging();
			entity.OGUN = this;
		}
		
		private void detach_MENU(MENU entity)
		{
			this.SendPropertyChanging();
			entity.OGUN = null;
		}
		
		private void attach_YEMEKALAN(YEMEKALAN entity)
		{
			this.SendPropertyChanging();
			entity.OGUN = this;
		}
		
		private void detach_YEMEKALAN(YEMEKALAN entity)
		{
			this.SendPropertyChanging();
			entity.OGUN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.YEMEK")]
	public partial class YEMEK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _yemekNO;
		
		private string _yemekAdi;
		
		private System.Nullable<int> _ogunTur;
		
		private EntitySet<MENU> _MENU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnyemekNOChanging(int value);
    partial void OnyemekNOChanged();
    partial void OnyemekAdiChanging(string value);
    partial void OnyemekAdiChanged();
    partial void OnogunTurChanging(System.Nullable<int> value);
    partial void OnogunTurChanged();
    #endregion
		
		public YEMEK()
		{
			this._MENU = new EntitySet<MENU>(new Action<MENU>(this.attach_MENU), new Action<MENU>(this.detach_MENU));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yemekNO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int yemekNO
		{
			get
			{
				return this._yemekNO;
			}
			set
			{
				if ((this._yemekNO != value))
				{
					this.OnyemekNOChanging(value);
					this.SendPropertyChanging();
					this._yemekNO = value;
					this.SendPropertyChanged("yemekNO");
					this.OnyemekNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yemekAdi", DbType="VarChar(25)")]
		public string yemekAdi
		{
			get
			{
				return this._yemekAdi;
			}
			set
			{
				if ((this._yemekAdi != value))
				{
					this.OnyemekAdiChanging(value);
					this.SendPropertyChanging();
					this._yemekAdi = value;
					this.SendPropertyChanged("yemekAdi");
					this.OnyemekAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ogunTur", DbType="Int")]
		public System.Nullable<int> ogunTur
		{
			get
			{
				return this._ogunTur;
			}
			set
			{
				if ((this._ogunTur != value))
				{
					this.OnogunTurChanging(value);
					this.SendPropertyChanging();
					this._ogunTur = value;
					this.SendPropertyChanged("ogunTur");
					this.OnogunTurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="YEMEK_MENU", Storage="_MENU", ThisKey="yemekNO", OtherKey="yemekNO")]
		public EntitySet<MENU> MENU
		{
			get
			{
				return this._MENU;
			}
			set
			{
				this._MENU.Assign(value);
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
		
		private void attach_MENU(MENU entity)
		{
			this.SendPropertyChanging();
			entity.YEMEK = this;
		}
		
		private void detach_MENU(MENU entity)
		{
			this.SendPropertyChanging();
			entity.YEMEK = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.YEMEKALAN")]
	public partial class YEMEKALAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ogrNo;
		
		private System.Nullable<int> _ogunNO;
		
		private EntityRef<OGUN> _OGUN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnogrNoChanging(int value);
    partial void OnogrNoChanged();
    partial void OnogunNOChanging(System.Nullable<int> value);
    partial void OnogunNOChanged();
    #endregion
		
		public YEMEKALAN()
		{
			this._OGUN = default(EntityRef<OGUN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ogrNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ogrNo
		{
			get
			{
				return this._ogrNo;
			}
			set
			{
				if ((this._ogrNo != value))
				{
					this.OnogrNoChanging(value);
					this.SendPropertyChanging();
					this._ogrNo = value;
					this.SendPropertyChanged("ogrNo");
					this.OnogrNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ogunNO", DbType="Int")]
		public System.Nullable<int> ogunNO
		{
			get
			{
				return this._ogunNO;
			}
			set
			{
				if ((this._ogunNO != value))
				{
					if (this._OGUN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnogunNOChanging(value);
					this.SendPropertyChanging();
					this._ogunNO = value;
					this.SendPropertyChanged("ogunNO");
					this.OnogunNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OGUN_YEMEKALAN", Storage="_OGUN", ThisKey="ogunNO", OtherKey="ogunNO", IsForeignKey=true)]
		public OGUN OGUN
		{
			get
			{
				return this._OGUN.Entity;
			}
			set
			{
				OGUN previousValue = this._OGUN.Entity;
				if (((previousValue != value) 
							|| (this._OGUN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._OGUN.Entity = null;
						previousValue.YEMEKALAN.Remove(this);
					}
					this._OGUN.Entity = value;
					if ((value != null))
					{
						value.YEMEKALAN.Add(this);
						this._ogunNO = value.ogunNO;
					}
					else
					{
						this._ogunNO = default(Nullable<int>);
					}
					this.SendPropertyChanged("OGUN");
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
