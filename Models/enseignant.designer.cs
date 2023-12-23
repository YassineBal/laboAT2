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

namespace laboAT2.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF")]
	public partial class enseignantDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertenseignant(enseignant instance);
    partial void Updateenseignant(enseignant instance);
    partial void Deleteenseignant(enseignant instance);
    partial void InsertEtudiant(Etudiant instance);
    partial void UpdateEtudiant(Etudiant instance);
    partial void DeleteEtudiant(Etudiant instance);
    partial void InsertLogin(Login instance);
    partial void UpdateLogin(Login instance);
    partial void DeleteLogin(Login instance);
    partial void InsertNiveauEducation(NiveauEducation instance);
    partial void UpdateNiveauEducation(NiveauEducation instance);
    partial void DeleteNiveauEducation(NiveauEducation instance);
    partial void InsertvideoCour(videoCour instance);
    partial void UpdatevideoCour(videoCour instance);
    partial void DeletevideoCour(videoCour instance);
    partial void Insertcour(cour instance);
    partial void Updatecour(cour instance);
    partial void Deletecour(cour instance);
    partial void Insertvideo(video instance);
    partial void Updatevideo(video instance);
    partial void Deletevideo(video instance);
    #endregion
		
		public enseignantDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["D__DEC_AUTOMN2023_AT2_LABOAT2_APP_DATA_DBEDUCATIONAT2_MDFConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public enseignantDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public enseignantDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public enseignantDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public enseignantDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<enseignant> enseignants
		{
			get
			{
				return this.GetTable<enseignant>();
			}
		}
		
		public System.Data.Linq.Table<Etudiant> Etudiants
		{
			get
			{
				return this.GetTable<Etudiant>();
			}
		}
		
		public System.Data.Linq.Table<Login> Logins
		{
			get
			{
				return this.GetTable<Login>();
			}
		}
		
		public System.Data.Linq.Table<NiveauEducation> NiveauEducations
		{
			get
			{
				return this.GetTable<NiveauEducation>();
			}
		}
		
		public System.Data.Linq.Table<videoCour> videoCours
		{
			get
			{
				return this.GetTable<videoCour>();
			}
		}
		
		public System.Data.Linq.Table<cour> cours
		{
			get
			{
				return this.GetTable<cour>();
			}
		}
		
		public System.Data.Linq.Table<video> videos
		{
			get
			{
				return this.GetTable<video>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.enseignants")]
	public partial class enseignant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nom;
		
		private string _prenom;
		
		private string _email;
		
		private string _mdp;
		
		private EntitySet<cour> _cours;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnmdpChanging(string value);
    partial void OnmdpChanged();
    #endregion
		
		public enseignant()
		{
			this._cours = new EntitySet<cour>(new Action<cour>(this.attach_cours), new Action<cour>(this.detach_cours));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mdp", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string mdp
		{
			get
			{
				return this._mdp;
			}
			set
			{
				if ((this._mdp != value))
				{
					this.OnmdpChanging(value);
					this.SendPropertyChanging();
					this._mdp = value;
					this.SendPropertyChanged("mdp");
					this.OnmdpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="enseignant_cour", Storage="_cours", ThisKey="id", OtherKey="idEnseignant")]
		public EntitySet<cour> cours
		{
			get
			{
				return this._cours;
			}
			set
			{
				this._cours.Assign(value);
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
		
		private void attach_cours(cour entity)
		{
			this.SendPropertyChanging();
			entity.enseignant = this;
		}
		
		private void detach_cours(cour entity)
		{
			this.SendPropertyChanging();
			entity.enseignant = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Etudiant")]
	public partial class Etudiant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _nom;
		
		private string _prenom;
		
		private string _email;
		
		private int _Neducation;
		
		private bool _Status;
		
		private EntitySet<Login> _Logins;
		
		private EntityRef<NiveauEducation> _NiveauEducation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnNeducationChanging(int value);
    partial void OnNeducationChanged();
    partial void OnStatusChanging(bool value);
    partial void OnStatusChanged();
    #endregion
		
		public Etudiant()
		{
			this._Logins = new EntitySet<Login>(new Action<Login>(this.attach_Logins), new Action<Login>(this.detach_Logins));
			this._NiveauEducation = default(EntityRef<NiveauEducation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Neducation", DbType="Int NOT NULL")]
		public int Neducation
		{
			get
			{
				return this._Neducation;
			}
			set
			{
				if ((this._Neducation != value))
				{
					if (this._NiveauEducation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNeducationChanging(value);
					this.SendPropertyChanging();
					this._Neducation = value;
					this.SendPropertyChanged("Neducation");
					this.OnNeducationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Bit NOT NULL")]
		public bool Status
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Etudiant_Login", Storage="_Logins", ThisKey="Id", OtherKey="id_Etudiant")]
		public EntitySet<Login> Logins
		{
			get
			{
				return this._Logins;
			}
			set
			{
				this._Logins.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NiveauEducation_Etudiant", Storage="_NiveauEducation", ThisKey="Neducation", OtherKey="Id", IsForeignKey=true)]
		public NiveauEducation NiveauEducation
		{
			get
			{
				return this._NiveauEducation.Entity;
			}
			set
			{
				NiveauEducation previousValue = this._NiveauEducation.Entity;
				if (((previousValue != value) 
							|| (this._NiveauEducation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NiveauEducation.Entity = null;
						previousValue.Etudiants.Remove(this);
					}
					this._NiveauEducation.Entity = value;
					if ((value != null))
					{
						value.Etudiants.Add(this);
						this._Neducation = value.Id;
					}
					else
					{
						this._Neducation = default(int);
					}
					this.SendPropertyChanged("NiveauEducation");
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
		
		private void attach_Logins(Login entity)
		{
			this.SendPropertyChanging();
			entity.Etudiant = this;
		}
		
		private void detach_Logins(Login entity)
		{
			this.SendPropertyChanging();
			entity.Etudiant = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Login")]
	public partial class Login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _us;
		
		private string _mdp;
		
		private int _id_Etudiant;
		
		private EntityRef<Etudiant> _Etudiant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnusChanging(string value);
    partial void OnusChanged();
    partial void OnmdpChanging(string value);
    partial void OnmdpChanged();
    partial void Onid_EtudiantChanging(int value);
    partial void Onid_EtudiantChanged();
    #endregion
		
		public Login()
		{
			this._Etudiant = default(EntityRef<Etudiant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_us", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string us
		{
			get
			{
				return this._us;
			}
			set
			{
				if ((this._us != value))
				{
					this.OnusChanging(value);
					this.SendPropertyChanging();
					this._us = value;
					this.SendPropertyChanged("us");
					this.OnusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mdp", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string mdp
		{
			get
			{
				return this._mdp;
			}
			set
			{
				if ((this._mdp != value))
				{
					this.OnmdpChanging(value);
					this.SendPropertyChanging();
					this._mdp = value;
					this.SendPropertyChanged("mdp");
					this.OnmdpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_Etudiant", DbType="Int NOT NULL")]
		public int id_Etudiant
		{
			get
			{
				return this._id_Etudiant;
			}
			set
			{
				if ((this._id_Etudiant != value))
				{
					if (this._Etudiant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_EtudiantChanging(value);
					this.SendPropertyChanging();
					this._id_Etudiant = value;
					this.SendPropertyChanged("id_Etudiant");
					this.Onid_EtudiantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Etudiant_Login", Storage="_Etudiant", ThisKey="id_Etudiant", OtherKey="Id", IsForeignKey=true)]
		public Etudiant Etudiant
		{
			get
			{
				return this._Etudiant.Entity;
			}
			set
			{
				Etudiant previousValue = this._Etudiant.Entity;
				if (((previousValue != value) 
							|| (this._Etudiant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Etudiant.Entity = null;
						previousValue.Logins.Remove(this);
					}
					this._Etudiant.Entity = value;
					if ((value != null))
					{
						value.Logins.Add(this);
						this._id_Etudiant = value.Id;
					}
					else
					{
						this._id_Etudiant = default(int);
					}
					this.SendPropertyChanged("Etudiant");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NiveauEducation")]
	public partial class NiveauEducation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _description;
		
		private string _titre;
		
		private EntitySet<Etudiant> _Etudiants;
		
		private EntitySet<cour> _cours;
		
		private EntitySet<video> _videos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OntitreChanging(string value);
    partial void OntitreChanged();
    #endregion
		
		public NiveauEducation()
		{
			this._Etudiants = new EntitySet<Etudiant>(new Action<Etudiant>(this.attach_Etudiants), new Action<Etudiant>(this.detach_Etudiants));
			this._cours = new EntitySet<cour>(new Action<cour>(this.attach_cours), new Action<cour>(this.detach_cours));
			this._videos = new EntitySet<video>(new Action<video>(this.attach_videos), new Action<video>(this.detach_videos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titre", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string titre
		{
			get
			{
				return this._titre;
			}
			set
			{
				if ((this._titre != value))
				{
					this.OntitreChanging(value);
					this.SendPropertyChanging();
					this._titre = value;
					this.SendPropertyChanged("titre");
					this.OntitreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NiveauEducation_Etudiant", Storage="_Etudiants", ThisKey="Id", OtherKey="Neducation")]
		public EntitySet<Etudiant> Etudiants
		{
			get
			{
				return this._Etudiants;
			}
			set
			{
				this._Etudiants.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NiveauEducation_cour", Storage="_cours", ThisKey="Id", OtherKey="niveauEducation")]
		public EntitySet<cour> cours
		{
			get
			{
				return this._cours;
			}
			set
			{
				this._cours.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NiveauEducation_video", Storage="_videos", ThisKey="Id", OtherKey="niveauEducation")]
		public EntitySet<video> videos
		{
			get
			{
				return this._videos;
			}
			set
			{
				this._videos.Assign(value);
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
		
		private void attach_Etudiants(Etudiant entity)
		{
			this.SendPropertyChanging();
			entity.NiveauEducation = this;
		}
		
		private void detach_Etudiants(Etudiant entity)
		{
			this.SendPropertyChanging();
			entity.NiveauEducation = null;
		}
		
		private void attach_cours(cour entity)
		{
			this.SendPropertyChanging();
			entity.NiveauEducation1 = this;
		}
		
		private void detach_cours(cour entity)
		{
			this.SendPropertyChanging();
			entity.NiveauEducation1 = null;
		}
		
		private void attach_videos(video entity)
		{
			this.SendPropertyChanging();
			entity.NiveauEducation1 = this;
		}
		
		private void detach_videos(video entity)
		{
			this.SendPropertyChanging();
			entity.NiveauEducation1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.videoCours")]
	public partial class videoCour : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _idCours;
		
		private int _idVideo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnidCoursChanging(int value);
    partial void OnidCoursChanged();
    partial void OnidVideoChanging(int value);
    partial void OnidVideoChanged();
    #endregion
		
		public videoCour()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCours", DbType="Int NOT NULL")]
		public int idCours
		{
			get
			{
				return this._idCours;
			}
			set
			{
				if ((this._idCours != value))
				{
					this.OnidCoursChanging(value);
					this.SendPropertyChanging();
					this._idCours = value;
					this.SendPropertyChanged("idCours");
					this.OnidCoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVideo", DbType="Int NOT NULL")]
		public int idVideo
		{
			get
			{
				return this._idVideo;
			}
			set
			{
				if ((this._idVideo != value))
				{
					this.OnidVideoChanging(value);
					this.SendPropertyChanging();
					this._idVideo = value;
					this.SendPropertyChanged("idVideo");
					this.OnidVideoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cours")]
	public partial class cour : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCours;
		
		private string _titre;
		
		private int _niveauEducation;
		
		private string _description;
		
		private string _img;
		
		private int _idEnseignant;
		
		private System.Nullable<double> _prix;
		
		private EntityRef<enseignant> _enseignant;
		
		private EntityRef<NiveauEducation> _NiveauEducation1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCoursChanging(int value);
    partial void OnidCoursChanged();
    partial void OntitreChanging(string value);
    partial void OntitreChanged();
    partial void OnniveauEducationChanging(int value);
    partial void OnniveauEducationChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    partial void OnidEnseignantChanging(int value);
    partial void OnidEnseignantChanged();
    partial void OnprixChanging(System.Nullable<double> value);
    partial void OnprixChanged();
    #endregion
		
		public cour()
		{
			this._enseignant = default(EntityRef<enseignant>);
			this._NiveauEducation1 = default(EntityRef<NiveauEducation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCours", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idCours
		{
			get
			{
				return this._idCours;
			}
			set
			{
				if ((this._idCours != value))
				{
					this.OnidCoursChanging(value);
					this.SendPropertyChanging();
					this._idCours = value;
					this.SendPropertyChanged("idCours");
					this.OnidCoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string titre
		{
			get
			{
				return this._titre;
			}
			set
			{
				if ((this._titre != value))
				{
					this.OntitreChanging(value);
					this.SendPropertyChanging();
					this._titre = value;
					this.SendPropertyChanged("titre");
					this.OntitreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_niveauEducation", DbType="Int NOT NULL")]
		public int niveauEducation
		{
			get
			{
				return this._niveauEducation;
			}
			set
			{
				if ((this._niveauEducation != value))
				{
					if (this._NiveauEducation1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnniveauEducationChanging(value);
					this.SendPropertyChanging();
					this._niveauEducation = value;
					this.SendPropertyChanged("niveauEducation");
					this.OnniveauEducationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="NVarChar(MAX)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEnseignant", DbType="Int NOT NULL")]
		public int idEnseignant
		{
			get
			{
				return this._idEnseignant;
			}
			set
			{
				if ((this._idEnseignant != value))
				{
					if (this._enseignant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidEnseignantChanging(value);
					this.SendPropertyChanging();
					this._idEnseignant = value;
					this.SendPropertyChanged("idEnseignant");
					this.OnidEnseignantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prix", DbType="Float")]
		public System.Nullable<double> prix
		{
			get
			{
				return this._prix;
			}
			set
			{
				if ((this._prix != value))
				{
					this.OnprixChanging(value);
					this.SendPropertyChanging();
					this._prix = value;
					this.SendPropertyChanged("prix");
					this.OnprixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="enseignant_cour", Storage="_enseignant", ThisKey="idEnseignant", OtherKey="id", IsForeignKey=true)]
		public enseignant enseignant
		{
			get
			{
				return this._enseignant.Entity;
			}
			set
			{
				enseignant previousValue = this._enseignant.Entity;
				if (((previousValue != value) 
							|| (this._enseignant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._enseignant.Entity = null;
						previousValue.cours.Remove(this);
					}
					this._enseignant.Entity = value;
					if ((value != null))
					{
						value.cours.Add(this);
						this._idEnseignant = value.id;
					}
					else
					{
						this._idEnseignant = default(int);
					}
					this.SendPropertyChanged("enseignant");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NiveauEducation_cour", Storage="_NiveauEducation1", ThisKey="niveauEducation", OtherKey="Id", IsForeignKey=true)]
		public NiveauEducation NiveauEducation1
		{
			get
			{
				return this._NiveauEducation1.Entity;
			}
			set
			{
				NiveauEducation previousValue = this._NiveauEducation1.Entity;
				if (((previousValue != value) 
							|| (this._NiveauEducation1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NiveauEducation1.Entity = null;
						previousValue.cours.Remove(this);
					}
					this._NiveauEducation1.Entity = value;
					if ((value != null))
					{
						value.cours.Add(this);
						this._niveauEducation = value.Id;
					}
					else
					{
						this._niveauEducation = default(int);
					}
					this.SendPropertyChanged("NiveauEducation1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.videos")]
	public partial class video : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idVideo;
		
		private int _niveauEducation;
		
		private string _titre;
		
		private string _lien;
		
		private int _dure;
		
		private string _description;
		
		private EntityRef<NiveauEducation> _NiveauEducation1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidVideoChanging(int value);
    partial void OnidVideoChanged();
    partial void OnniveauEducationChanging(int value);
    partial void OnniveauEducationChanged();
    partial void OntitreChanging(string value);
    partial void OntitreChanged();
    partial void OnlienChanging(string value);
    partial void OnlienChanged();
    partial void OndureChanging(int value);
    partial void OndureChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public video()
		{
			this._NiveauEducation1 = default(EntityRef<NiveauEducation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVideo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idVideo
		{
			get
			{
				return this._idVideo;
			}
			set
			{
				if ((this._idVideo != value))
				{
					this.OnidVideoChanging(value);
					this.SendPropertyChanging();
					this._idVideo = value;
					this.SendPropertyChanged("idVideo");
					this.OnidVideoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_niveauEducation", DbType="Int NOT NULL")]
		public int niveauEducation
		{
			get
			{
				return this._niveauEducation;
			}
			set
			{
				if ((this._niveauEducation != value))
				{
					if (this._NiveauEducation1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnniveauEducationChanging(value);
					this.SendPropertyChanging();
					this._niveauEducation = value;
					this.SendPropertyChanged("niveauEducation");
					this.OnniveauEducationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string titre
		{
			get
			{
				return this._titre;
			}
			set
			{
				if ((this._titre != value))
				{
					this.OntitreChanging(value);
					this.SendPropertyChanging();
					this._titre = value;
					this.SendPropertyChanged("titre");
					this.OntitreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lien", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string lien
		{
			get
			{
				return this._lien;
			}
			set
			{
				if ((this._lien != value))
				{
					this.OnlienChanging(value);
					this.SendPropertyChanging();
					this._lien = value;
					this.SendPropertyChanged("lien");
					this.OnlienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dure", DbType="Int NOT NULL")]
		public int dure
		{
			get
			{
				return this._dure;
			}
			set
			{
				if ((this._dure != value))
				{
					this.OndureChanging(value);
					this.SendPropertyChanging();
					this._dure = value;
					this.SendPropertyChanged("dure");
					this.OndureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(MAX)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NiveauEducation_video", Storage="_NiveauEducation1", ThisKey="niveauEducation", OtherKey="Id", IsForeignKey=true)]
		public NiveauEducation NiveauEducation1
		{
			get
			{
				return this._NiveauEducation1.Entity;
			}
			set
			{
				NiveauEducation previousValue = this._NiveauEducation1.Entity;
				if (((previousValue != value) 
							|| (this._NiveauEducation1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NiveauEducation1.Entity = null;
						previousValue.videos.Remove(this);
					}
					this._NiveauEducation1.Entity = value;
					if ((value != null))
					{
						value.videos.Add(this);
						this._niveauEducation = value.Id;
					}
					else
					{
						this._niveauEducation = default(int);
					}
					this.SendPropertyChanged("NiveauEducation1");
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
