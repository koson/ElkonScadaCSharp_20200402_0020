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

namespace ElkonScada
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ElkonScadaReceteler")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertReceteler(Receteler instance);
    partial void UpdateReceteler(Receteler instance);
    partial void DeleteReceteler(Receteler instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ElkonScada.Properties.Settings.Default.ElkonScadaRecetelerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Receteler> Recetelers
		{
			get
			{
				return this.GetTable<Receteler>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Receteler")]
	public partial class Receteler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SiraNo;
		
		private string _ReceteAdi;
		
		private string _ReceteAciklama;
		
		private System.Nullable<double> _ReceteAgrega1;
		
		private System.Nullable<double> _ReceteAgrega2;
		
		private System.Nullable<double> _ReceteAgrega3;
		
		private System.Nullable<double> _ReceteAgrega4;
		
		private System.Nullable<double> _ReceteAgrega5;
		
		private System.Nullable<double> _ReceteAgrega6;
		
		private System.Nullable<double> _ReceteCimento1;
		
		private System.Nullable<double> _ReceteCimento2;
		
		private System.Nullable<double> _ReceteCimento3;
		
		private System.Nullable<double> _ReceteCimento4;
		
		private System.Nullable<double> _ReceteCimento5;
		
		private System.Nullable<double> _ReceteCimento6;
		
		private System.Nullable<double> _ReceteSu1;
		
		private System.Nullable<double> _ReceteSu2;
		
		private System.Nullable<double> _ReceteSu3;
		
		private System.Nullable<double> _ReceteSu4;
		
		private System.Nullable<double> _ReceteSu5;
		
		private System.Nullable<double> _ReceteSu6;
		
		private System.Nullable<double> _ReceteKatki1;
		
		private System.Nullable<double> _ReceteKatki2;
		
		private System.Nullable<double> _ReceteKatki3;
		
		private System.Nullable<double> _ReceteKatki4;
		
		private System.Nullable<double> _ReceteKatki5;
		
		private System.Nullable<double> _ReceteKatki6;
		
		private System.Nullable<int> _ReceteCimentoGecikmeSuresi;
		
		private System.Nullable<int> _ReceteKatkıGecikmeSuresi;
		
		private System.Nullable<int> _ReceteSuGecikmeSuresi;
		
		private System.Nullable<int> _ReceteMikserBosaltmaSuresi;
		
		private System.Nullable<int> _ReceteMikserKaristirmaSuresi;
		
		private System.Nullable<int> _ReceteMikserKapakAcmaSuresi;
		
		private string _ReceteDurum;
		
		private string _ReceteDayanimSinifi;
		
		private string _ReceteKivamSinifi;
		
		private string _ReceteDonaKarsiDayaniklikSinifi;
		
		private string _ReceteSuyaKarsiDirencSinifi;
		
		private string _ReceteYogunlukSinifi;
		
		private string _ReceteBetonTipi;
		
		private string _ReceteCevreselEtki;
		
		private string _ReceteKlorurIcerigiSinifi;
		
		private System.Nullable<double> _ReceteMaxSuCimOrani;
		
		private string _ReceteMinCimIcerigi;
		
		private string _ReceteMinBetonDayanimSinifi;
		
		private string _ReceteMinBetonHavaIcerigi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSiraNoChanging(int value);
    partial void OnSiraNoChanged();
    partial void OnReceteAdiChanging(string value);
    partial void OnReceteAdiChanged();
    partial void OnReceteAciklamaChanging(string value);
    partial void OnReceteAciklamaChanged();
    partial void OnReceteAgrega1Changing(System.Nullable<double> value);
    partial void OnReceteAgrega1Changed();
    partial void OnReceteAgrega2Changing(System.Nullable<double> value);
    partial void OnReceteAgrega2Changed();
    partial void OnReceteAgrega3Changing(System.Nullable<double> value);
    partial void OnReceteAgrega3Changed();
    partial void OnReceteAgrega4Changing(System.Nullable<double> value);
    partial void OnReceteAgrega4Changed();
    partial void OnReceteAgrega5Changing(System.Nullable<double> value);
    partial void OnReceteAgrega5Changed();
    partial void OnReceteAgrega6Changing(System.Nullable<double> value);
    partial void OnReceteAgrega6Changed();
    partial void OnReceteCimento1Changing(System.Nullable<double> value);
    partial void OnReceteCimento1Changed();
    partial void OnReceteCimento2Changing(System.Nullable<double> value);
    partial void OnReceteCimento2Changed();
    partial void OnReceteCimento3Changing(System.Nullable<double> value);
    partial void OnReceteCimento3Changed();
    partial void OnReceteCimento4Changing(System.Nullable<double> value);
    partial void OnReceteCimento4Changed();
    partial void OnReceteCimento5Changing(System.Nullable<double> value);
    partial void OnReceteCimento5Changed();
    partial void OnReceteCimento6Changing(System.Nullable<double> value);
    partial void OnReceteCimento6Changed();
    partial void OnReceteSu1Changing(System.Nullable<double> value);
    partial void OnReceteSu1Changed();
    partial void OnReceteSu2Changing(System.Nullable<double> value);
    partial void OnReceteSu2Changed();
    partial void OnReceteSu3Changing(System.Nullable<double> value);
    partial void OnReceteSu3Changed();
    partial void OnReceteSu4Changing(System.Nullable<double> value);
    partial void OnReceteSu4Changed();
    partial void OnReceteSu5Changing(System.Nullable<double> value);
    partial void OnReceteSu5Changed();
    partial void OnReceteSu6Changing(System.Nullable<double> value);
    partial void OnReceteSu6Changed();
    partial void OnReceteKatki1Changing(System.Nullable<double> value);
    partial void OnReceteKatki1Changed();
    partial void OnReceteKatki2Changing(System.Nullable<double> value);
    partial void OnReceteKatki2Changed();
    partial void OnReceteKatki3Changing(System.Nullable<double> value);
    partial void OnReceteKatki3Changed();
    partial void OnReceteKatki4Changing(System.Nullable<double> value);
    partial void OnReceteKatki4Changed();
    partial void OnReceteKatki5Changing(System.Nullable<double> value);
    partial void OnReceteKatki5Changed();
    partial void OnReceteKatki6Changing(System.Nullable<double> value);
    partial void OnReceteKatki6Changed();
    partial void OnReceteCimentoGecikmeSuresiChanging(System.Nullable<int> value);
    partial void OnReceteCimentoGecikmeSuresiChanged();
    partial void OnReceteKatkıGecikmeSuresiChanging(System.Nullable<int> value);
    partial void OnReceteKatkıGecikmeSuresiChanged();
    partial void OnReceteSuGecikmeSuresiChanging(System.Nullable<int> value);
    partial void OnReceteSuGecikmeSuresiChanged();
    partial void OnReceteMikserBosaltmaSuresiChanging(System.Nullable<int> value);
    partial void OnReceteMikserBosaltmaSuresiChanged();
    partial void OnReceteMikserKaristirmaSuresiChanging(System.Nullable<int> value);
    partial void OnReceteMikserKaristirmaSuresiChanged();
    partial void OnReceteMikserKapakAcmaSuresiChanging(System.Nullable<int> value);
    partial void OnReceteMikserKapakAcmaSuresiChanged();
    partial void OnReceteDurumChanging(string value);
    partial void OnReceteDurumChanged();
    partial void OnReceteDayanimSinifiChanging(string value);
    partial void OnReceteDayanimSinifiChanged();
    partial void OnReceteKivamSinifiChanging(string value);
    partial void OnReceteKivamSinifiChanged();
    partial void OnReceteDonaKarsiDayaniklikSinifiChanging(string value);
    partial void OnReceteDonaKarsiDayaniklikSinifiChanged();
    partial void OnReceteSuyaKarsiDirencSinifiChanging(string value);
    partial void OnReceteSuyaKarsiDirencSinifiChanged();
    partial void OnReceteYogunlukSinifiChanging(string value);
    partial void OnReceteYogunlukSinifiChanged();
    partial void OnReceteBetonTipiChanging(string value);
    partial void OnReceteBetonTipiChanged();
    partial void OnReceteCevreselEtkiChanging(string value);
    partial void OnReceteCevreselEtkiChanged();
    partial void OnReceteKlorurIcerigiSinifiChanging(string value);
    partial void OnReceteKlorurIcerigiSinifiChanged();
    partial void OnReceteMaxSuCimOraniChanging(System.Nullable<double> value);
    partial void OnReceteMaxSuCimOraniChanged();
    partial void OnReceteMinCimIcerigiChanging(string value);
    partial void OnReceteMinCimIcerigiChanged();
    partial void OnReceteMinBetonDayanimSinifiChanging(string value);
    partial void OnReceteMinBetonDayanimSinifiChanged();
    partial void OnReceteMinBetonHavaIcerigiChanging(string value);
    partial void OnReceteMinBetonHavaIcerigiChanged();
    #endregion
		
		public Receteler()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiraNo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SiraNo
		{
			get
			{
				return this._SiraNo;
			}
			set
			{
				if ((this._SiraNo != value))
				{
					this.OnSiraNoChanging(value);
					this.SendPropertyChanging();
					this._SiraNo = value;
					this.SendPropertyChanged("SiraNo");
					this.OnSiraNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteAdi", DbType="Char(250)")]
		public string ReceteAdi
		{
			get
			{
				return this._ReceteAdi;
			}
			set
			{
				if ((this._ReceteAdi != value))
				{
					this.OnReceteAdiChanging(value);
					this.SendPropertyChanging();
					this._ReceteAdi = value;
					this.SendPropertyChanged("ReceteAdi");
					this.OnReceteAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteAciklama", DbType="Char(250)")]
		public string ReceteAciklama
		{
			get
			{
				return this._ReceteAciklama;
			}
			set
			{
				if ((this._ReceteAciklama != value))
				{
					this.OnReceteAciklamaChanging(value);
					this.SendPropertyChanging();
					this._ReceteAciklama = value;
					this.SendPropertyChanged("ReceteAciklama");
					this.OnReceteAciklamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteAgrega1", DbType="Float")]
		public System.Nullable<double> ReceteAgrega1
		{
			get
			{
				return this._ReceteAgrega1;
			}
			set
			{
				if ((this._ReceteAgrega1 != value))
				{
					this.OnReceteAgrega1Changing(value);
					this.SendPropertyChanging();
					this._ReceteAgrega1 = value;
					this.SendPropertyChanged("ReceteAgrega1");
					this.OnReceteAgrega1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteAgrega2", DbType="Float")]
		public System.Nullable<double> ReceteAgrega2
		{
			get
			{
				return this._ReceteAgrega2;
			}
			set
			{
				if ((this._ReceteAgrega2 != value))
				{
					this.OnReceteAgrega2Changing(value);
					this.SendPropertyChanging();
					this._ReceteAgrega2 = value;
					this.SendPropertyChanged("ReceteAgrega2");
					this.OnReceteAgrega2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteAgrega3", DbType="Float")]
		public System.Nullable<double> ReceteAgrega3
		{
			get
			{
				return this._ReceteAgrega3;
			}
			set
			{
				if ((this._ReceteAgrega3 != value))
				{
					this.OnReceteAgrega3Changing(value);
					this.SendPropertyChanging();
					this._ReceteAgrega3 = value;
					this.SendPropertyChanged("ReceteAgrega3");
					this.OnReceteAgrega3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteAgrega4", DbType="Float")]
		public System.Nullable<double> ReceteAgrega4
		{
			get
			{
				return this._ReceteAgrega4;
			}
			set
			{
				if ((this._ReceteAgrega4 != value))
				{
					this.OnReceteAgrega4Changing(value);
					this.SendPropertyChanging();
					this._ReceteAgrega4 = value;
					this.SendPropertyChanged("ReceteAgrega4");
					this.OnReceteAgrega4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteAgrega5", DbType="Float")]
		public System.Nullable<double> ReceteAgrega5
		{
			get
			{
				return this._ReceteAgrega5;
			}
			set
			{
				if ((this._ReceteAgrega5 != value))
				{
					this.OnReceteAgrega5Changing(value);
					this.SendPropertyChanging();
					this._ReceteAgrega5 = value;
					this.SendPropertyChanged("ReceteAgrega5");
					this.OnReceteAgrega5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteAgrega6", DbType="Float")]
		public System.Nullable<double> ReceteAgrega6
		{
			get
			{
				return this._ReceteAgrega6;
			}
			set
			{
				if ((this._ReceteAgrega6 != value))
				{
					this.OnReceteAgrega6Changing(value);
					this.SendPropertyChanging();
					this._ReceteAgrega6 = value;
					this.SendPropertyChanged("ReceteAgrega6");
					this.OnReceteAgrega6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteCimento1", DbType="Float")]
		public System.Nullable<double> ReceteCimento1
		{
			get
			{
				return this._ReceteCimento1;
			}
			set
			{
				if ((this._ReceteCimento1 != value))
				{
					this.OnReceteCimento1Changing(value);
					this.SendPropertyChanging();
					this._ReceteCimento1 = value;
					this.SendPropertyChanged("ReceteCimento1");
					this.OnReceteCimento1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteCimento2", DbType="Float")]
		public System.Nullable<double> ReceteCimento2
		{
			get
			{
				return this._ReceteCimento2;
			}
			set
			{
				if ((this._ReceteCimento2 != value))
				{
					this.OnReceteCimento2Changing(value);
					this.SendPropertyChanging();
					this._ReceteCimento2 = value;
					this.SendPropertyChanged("ReceteCimento2");
					this.OnReceteCimento2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteCimento3", DbType="Float")]
		public System.Nullable<double> ReceteCimento3
		{
			get
			{
				return this._ReceteCimento3;
			}
			set
			{
				if ((this._ReceteCimento3 != value))
				{
					this.OnReceteCimento3Changing(value);
					this.SendPropertyChanging();
					this._ReceteCimento3 = value;
					this.SendPropertyChanged("ReceteCimento3");
					this.OnReceteCimento3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteCimento4", DbType="Float")]
		public System.Nullable<double> ReceteCimento4
		{
			get
			{
				return this._ReceteCimento4;
			}
			set
			{
				if ((this._ReceteCimento4 != value))
				{
					this.OnReceteCimento4Changing(value);
					this.SendPropertyChanging();
					this._ReceteCimento4 = value;
					this.SendPropertyChanged("ReceteCimento4");
					this.OnReceteCimento4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteCimento5", DbType="Float")]
		public System.Nullable<double> ReceteCimento5
		{
			get
			{
				return this._ReceteCimento5;
			}
			set
			{
				if ((this._ReceteCimento5 != value))
				{
					this.OnReceteCimento5Changing(value);
					this.SendPropertyChanging();
					this._ReceteCimento5 = value;
					this.SendPropertyChanged("ReceteCimento5");
					this.OnReceteCimento5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteCimento6", DbType="Float")]
		public System.Nullable<double> ReceteCimento6
		{
			get
			{
				return this._ReceteCimento6;
			}
			set
			{
				if ((this._ReceteCimento6 != value))
				{
					this.OnReceteCimento6Changing(value);
					this.SendPropertyChanging();
					this._ReceteCimento6 = value;
					this.SendPropertyChanged("ReceteCimento6");
					this.OnReceteCimento6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteSu1", DbType="Float")]
		public System.Nullable<double> ReceteSu1
		{
			get
			{
				return this._ReceteSu1;
			}
			set
			{
				if ((this._ReceteSu1 != value))
				{
					this.OnReceteSu1Changing(value);
					this.SendPropertyChanging();
					this._ReceteSu1 = value;
					this.SendPropertyChanged("ReceteSu1");
					this.OnReceteSu1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteSu2", DbType="Float")]
		public System.Nullable<double> ReceteSu2
		{
			get
			{
				return this._ReceteSu2;
			}
			set
			{
				if ((this._ReceteSu2 != value))
				{
					this.OnReceteSu2Changing(value);
					this.SendPropertyChanging();
					this._ReceteSu2 = value;
					this.SendPropertyChanged("ReceteSu2");
					this.OnReceteSu2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteSu3", DbType="Float")]
		public System.Nullable<double> ReceteSu3
		{
			get
			{
				return this._ReceteSu3;
			}
			set
			{
				if ((this._ReceteSu3 != value))
				{
					this.OnReceteSu3Changing(value);
					this.SendPropertyChanging();
					this._ReceteSu3 = value;
					this.SendPropertyChanged("ReceteSu3");
					this.OnReceteSu3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteSu4", DbType="Float")]
		public System.Nullable<double> ReceteSu4
		{
			get
			{
				return this._ReceteSu4;
			}
			set
			{
				if ((this._ReceteSu4 != value))
				{
					this.OnReceteSu4Changing(value);
					this.SendPropertyChanging();
					this._ReceteSu4 = value;
					this.SendPropertyChanged("ReceteSu4");
					this.OnReceteSu4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteSu5", DbType="Float")]
		public System.Nullable<double> ReceteSu5
		{
			get
			{
				return this._ReceteSu5;
			}
			set
			{
				if ((this._ReceteSu5 != value))
				{
					this.OnReceteSu5Changing(value);
					this.SendPropertyChanging();
					this._ReceteSu5 = value;
					this.SendPropertyChanged("ReceteSu5");
					this.OnReceteSu5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteSu6", DbType="Float")]
		public System.Nullable<double> ReceteSu6
		{
			get
			{
				return this._ReceteSu6;
			}
			set
			{
				if ((this._ReceteSu6 != value))
				{
					this.OnReceteSu6Changing(value);
					this.SendPropertyChanging();
					this._ReceteSu6 = value;
					this.SendPropertyChanged("ReceteSu6");
					this.OnReceteSu6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKatki1", DbType="Float")]
		public System.Nullable<double> ReceteKatki1
		{
			get
			{
				return this._ReceteKatki1;
			}
			set
			{
				if ((this._ReceteKatki1 != value))
				{
					this.OnReceteKatki1Changing(value);
					this.SendPropertyChanging();
					this._ReceteKatki1 = value;
					this.SendPropertyChanged("ReceteKatki1");
					this.OnReceteKatki1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKatki2", DbType="Float")]
		public System.Nullable<double> ReceteKatki2
		{
			get
			{
				return this._ReceteKatki2;
			}
			set
			{
				if ((this._ReceteKatki2 != value))
				{
					this.OnReceteKatki2Changing(value);
					this.SendPropertyChanging();
					this._ReceteKatki2 = value;
					this.SendPropertyChanged("ReceteKatki2");
					this.OnReceteKatki2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKatki3", DbType="Float")]
		public System.Nullable<double> ReceteKatki3
		{
			get
			{
				return this._ReceteKatki3;
			}
			set
			{
				if ((this._ReceteKatki3 != value))
				{
					this.OnReceteKatki3Changing(value);
					this.SendPropertyChanging();
					this._ReceteKatki3 = value;
					this.SendPropertyChanged("ReceteKatki3");
					this.OnReceteKatki3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKatki4", DbType="Float")]
		public System.Nullable<double> ReceteKatki4
		{
			get
			{
				return this._ReceteKatki4;
			}
			set
			{
				if ((this._ReceteKatki4 != value))
				{
					this.OnReceteKatki4Changing(value);
					this.SendPropertyChanging();
					this._ReceteKatki4 = value;
					this.SendPropertyChanged("ReceteKatki4");
					this.OnReceteKatki4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKatki5", DbType="Float")]
		public System.Nullable<double> ReceteKatki5
		{
			get
			{
				return this._ReceteKatki5;
			}
			set
			{
				if ((this._ReceteKatki5 != value))
				{
					this.OnReceteKatki5Changing(value);
					this.SendPropertyChanging();
					this._ReceteKatki5 = value;
					this.SendPropertyChanged("ReceteKatki5");
					this.OnReceteKatki5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKatki6", DbType="Float")]
		public System.Nullable<double> ReceteKatki6
		{
			get
			{
				return this._ReceteKatki6;
			}
			set
			{
				if ((this._ReceteKatki6 != value))
				{
					this.OnReceteKatki6Changing(value);
					this.SendPropertyChanging();
					this._ReceteKatki6 = value;
					this.SendPropertyChanged("ReceteKatki6");
					this.OnReceteKatki6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteCimentoGecikmeSuresi", DbType="Int")]
		public System.Nullable<int> ReceteCimentoGecikmeSuresi
		{
			get
			{
				return this._ReceteCimentoGecikmeSuresi;
			}
			set
			{
				if ((this._ReceteCimentoGecikmeSuresi != value))
				{
					this.OnReceteCimentoGecikmeSuresiChanging(value);
					this.SendPropertyChanging();
					this._ReceteCimentoGecikmeSuresi = value;
					this.SendPropertyChanged("ReceteCimentoGecikmeSuresi");
					this.OnReceteCimentoGecikmeSuresiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKatkıGecikmeSuresi", DbType="Int")]
		public System.Nullable<int> ReceteKatkıGecikmeSuresi
		{
			get
			{
				return this._ReceteKatkıGecikmeSuresi;
			}
			set
			{
				if ((this._ReceteKatkıGecikmeSuresi != value))
				{
					this.OnReceteKatkıGecikmeSuresiChanging(value);
					this.SendPropertyChanging();
					this._ReceteKatkıGecikmeSuresi = value;
					this.SendPropertyChanged("ReceteKatkıGecikmeSuresi");
					this.OnReceteKatkıGecikmeSuresiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteSuGecikmeSuresi", DbType="Int")]
		public System.Nullable<int> ReceteSuGecikmeSuresi
		{
			get
			{
				return this._ReceteSuGecikmeSuresi;
			}
			set
			{
				if ((this._ReceteSuGecikmeSuresi != value))
				{
					this.OnReceteSuGecikmeSuresiChanging(value);
					this.SendPropertyChanging();
					this._ReceteSuGecikmeSuresi = value;
					this.SendPropertyChanged("ReceteSuGecikmeSuresi");
					this.OnReceteSuGecikmeSuresiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteMikserBosaltmaSuresi", DbType="Int")]
		public System.Nullable<int> ReceteMikserBosaltmaSuresi
		{
			get
			{
				return this._ReceteMikserBosaltmaSuresi;
			}
			set
			{
				if ((this._ReceteMikserBosaltmaSuresi != value))
				{
					this.OnReceteMikserBosaltmaSuresiChanging(value);
					this.SendPropertyChanging();
					this._ReceteMikserBosaltmaSuresi = value;
					this.SendPropertyChanged("ReceteMikserBosaltmaSuresi");
					this.OnReceteMikserBosaltmaSuresiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteMikserKaristirmaSuresi", DbType="Int")]
		public System.Nullable<int> ReceteMikserKaristirmaSuresi
		{
			get
			{
				return this._ReceteMikserKaristirmaSuresi;
			}
			set
			{
				if ((this._ReceteMikserKaristirmaSuresi != value))
				{
					this.OnReceteMikserKaristirmaSuresiChanging(value);
					this.SendPropertyChanging();
					this._ReceteMikserKaristirmaSuresi = value;
					this.SendPropertyChanged("ReceteMikserKaristirmaSuresi");
					this.OnReceteMikserKaristirmaSuresiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteMikserKapakAcmaSuresi", DbType="Int")]
		public System.Nullable<int> ReceteMikserKapakAcmaSuresi
		{
			get
			{
				return this._ReceteMikserKapakAcmaSuresi;
			}
			set
			{
				if ((this._ReceteMikserKapakAcmaSuresi != value))
				{
					this.OnReceteMikserKapakAcmaSuresiChanging(value);
					this.SendPropertyChanging();
					this._ReceteMikserKapakAcmaSuresi = value;
					this.SendPropertyChanged("ReceteMikserKapakAcmaSuresi");
					this.OnReceteMikserKapakAcmaSuresiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteDurum", DbType="Char(250)")]
		public string ReceteDurum
		{
			get
			{
				return this._ReceteDurum;
			}
			set
			{
				if ((this._ReceteDurum != value))
				{
					this.OnReceteDurumChanging(value);
					this.SendPropertyChanging();
					this._ReceteDurum = value;
					this.SendPropertyChanged("ReceteDurum");
					this.OnReceteDurumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteDayanimSinifi", DbType="Char(250)")]
		public string ReceteDayanimSinifi
		{
			get
			{
				return this._ReceteDayanimSinifi;
			}
			set
			{
				if ((this._ReceteDayanimSinifi != value))
				{
					this.OnReceteDayanimSinifiChanging(value);
					this.SendPropertyChanging();
					this._ReceteDayanimSinifi = value;
					this.SendPropertyChanged("ReceteDayanimSinifi");
					this.OnReceteDayanimSinifiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKivamSinifi", DbType="Char(100)")]
		public string ReceteKivamSinifi
		{
			get
			{
				return this._ReceteKivamSinifi;
			}
			set
			{
				if ((this._ReceteKivamSinifi != value))
				{
					this.OnReceteKivamSinifiChanging(value);
					this.SendPropertyChanging();
					this._ReceteKivamSinifi = value;
					this.SendPropertyChanged("ReceteKivamSinifi");
					this.OnReceteKivamSinifiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteDonaKarsiDayaniklikSinifi", DbType="Char(100)")]
		public string ReceteDonaKarsiDayaniklikSinifi
		{
			get
			{
				return this._ReceteDonaKarsiDayaniklikSinifi;
			}
			set
			{
				if ((this._ReceteDonaKarsiDayaniklikSinifi != value))
				{
					this.OnReceteDonaKarsiDayaniklikSinifiChanging(value);
					this.SendPropertyChanging();
					this._ReceteDonaKarsiDayaniklikSinifi = value;
					this.SendPropertyChanged("ReceteDonaKarsiDayaniklikSinifi");
					this.OnReceteDonaKarsiDayaniklikSinifiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteSuyaKarsiDirencSinifi", DbType="Char(100)")]
		public string ReceteSuyaKarsiDirencSinifi
		{
			get
			{
				return this._ReceteSuyaKarsiDirencSinifi;
			}
			set
			{
				if ((this._ReceteSuyaKarsiDirencSinifi != value))
				{
					this.OnReceteSuyaKarsiDirencSinifiChanging(value);
					this.SendPropertyChanging();
					this._ReceteSuyaKarsiDirencSinifi = value;
					this.SendPropertyChanged("ReceteSuyaKarsiDirencSinifi");
					this.OnReceteSuyaKarsiDirencSinifiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteYogunlukSinifi", DbType="Char(100)")]
		public string ReceteYogunlukSinifi
		{
			get
			{
				return this._ReceteYogunlukSinifi;
			}
			set
			{
				if ((this._ReceteYogunlukSinifi != value))
				{
					this.OnReceteYogunlukSinifiChanging(value);
					this.SendPropertyChanging();
					this._ReceteYogunlukSinifi = value;
					this.SendPropertyChanged("ReceteYogunlukSinifi");
					this.OnReceteYogunlukSinifiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteBetonTipi", DbType="Char(100)")]
		public string ReceteBetonTipi
		{
			get
			{
				return this._ReceteBetonTipi;
			}
			set
			{
				if ((this._ReceteBetonTipi != value))
				{
					this.OnReceteBetonTipiChanging(value);
					this.SendPropertyChanging();
					this._ReceteBetonTipi = value;
					this.SendPropertyChanged("ReceteBetonTipi");
					this.OnReceteBetonTipiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteCevreselEtki", DbType="Char(100)")]
		public string ReceteCevreselEtki
		{
			get
			{
				return this._ReceteCevreselEtki;
			}
			set
			{
				if ((this._ReceteCevreselEtki != value))
				{
					this.OnReceteCevreselEtkiChanging(value);
					this.SendPropertyChanging();
					this._ReceteCevreselEtki = value;
					this.SendPropertyChanged("ReceteCevreselEtki");
					this.OnReceteCevreselEtkiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteKlorurIcerigiSinifi", DbType="Char(100)")]
		public string ReceteKlorurIcerigiSinifi
		{
			get
			{
				return this._ReceteKlorurIcerigiSinifi;
			}
			set
			{
				if ((this._ReceteKlorurIcerigiSinifi != value))
				{
					this.OnReceteKlorurIcerigiSinifiChanging(value);
					this.SendPropertyChanging();
					this._ReceteKlorurIcerigiSinifi = value;
					this.SendPropertyChanged("ReceteKlorurIcerigiSinifi");
					this.OnReceteKlorurIcerigiSinifiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteMaxSuCimOrani", DbType="Float")]
		public System.Nullable<double> ReceteMaxSuCimOrani
		{
			get
			{
				return this._ReceteMaxSuCimOrani;
			}
			set
			{
				if ((this._ReceteMaxSuCimOrani != value))
				{
					this.OnReceteMaxSuCimOraniChanging(value);
					this.SendPropertyChanging();
					this._ReceteMaxSuCimOrani = value;
					this.SendPropertyChanged("ReceteMaxSuCimOrani");
					this.OnReceteMaxSuCimOraniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteMinCimIcerigi", DbType="Char(100)")]
		public string ReceteMinCimIcerigi
		{
			get
			{
				return this._ReceteMinCimIcerigi;
			}
			set
			{
				if ((this._ReceteMinCimIcerigi != value))
				{
					this.OnReceteMinCimIcerigiChanging(value);
					this.SendPropertyChanging();
					this._ReceteMinCimIcerigi = value;
					this.SendPropertyChanged("ReceteMinCimIcerigi");
					this.OnReceteMinCimIcerigiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteMinBetonDayanimSinifi", DbType="Char(100)")]
		public string ReceteMinBetonDayanimSinifi
		{
			get
			{
				return this._ReceteMinBetonDayanimSinifi;
			}
			set
			{
				if ((this._ReceteMinBetonDayanimSinifi != value))
				{
					this.OnReceteMinBetonDayanimSinifiChanging(value);
					this.SendPropertyChanging();
					this._ReceteMinBetonDayanimSinifi = value;
					this.SendPropertyChanged("ReceteMinBetonDayanimSinifi");
					this.OnReceteMinBetonDayanimSinifiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceteMinBetonHavaIcerigi", DbType="Char(100)")]
		public string ReceteMinBetonHavaIcerigi
		{
			get
			{
				return this._ReceteMinBetonHavaIcerigi;
			}
			set
			{
				if ((this._ReceteMinBetonHavaIcerigi != value))
				{
					this.OnReceteMinBetonHavaIcerigiChanging(value);
					this.SendPropertyChanging();
					this._ReceteMinBetonHavaIcerigi = value;
					this.SendPropertyChanged("ReceteMinBetonHavaIcerigi");
					this.OnReceteMinBetonHavaIcerigiChanged();
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