﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTracker
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="time_track")]
	public partial class employeesDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void Insertemployees(employees instance);
    partial void Updateemployees(employees instance);
    partial void Deleteemployees(employees instance);
    partial void Insertpositions(positions instance);
    partial void Updatepositions(positions instance);
    partial void Deletepositions(positions instance);
    partial void Insertschedule(schedule instance);
    partial void Updateschedule(schedule instance);
    partial void Deleteschedule(schedule instance);
    partial void Insertfaculties(faculties instance);
    partial void Updatefaculties(faculties instance);
    partial void Deletefaculties(faculties instance);
    partial void Insertactivities(activities instance);
    partial void Updateactivities(activities instance);
    partial void Deleteactivities(activities instance);
    partial void Insertinstitutes(institutes instance);
    partial void Updateinstitutes(institutes instance);
    partial void Deleteinstitutes(institutes instance);
    #endregion
		
		public employeesDataContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["time_trackConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public employeesDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public employeesDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public employeesDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public employeesDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<employees> employees
		{
			get
			{
				return this.GetTable<employees>();
			}
		}
		
		public System.Data.Linq.Table<positions> positions
		{
			get
			{
				return this.GetTable<positions>();
			}
		}
		
		public System.Data.Linq.Table<schedule> schedule
		{
			get
			{
				return this.GetTable<schedule>();
			}
		}
		
		public System.Data.Linq.Table<faculties> faculties
		{
			get
			{
				return this.GetTable<faculties>();
			}
		}
		
		public System.Data.Linq.Table<activities> activities
		{
			get
			{
				return this.GetTable<activities>();
			}
		}
		
		public System.Data.Linq.Table<institutes> institutes
		{
			get
			{
				return this.GetTable<institutes>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employees")]
	public partial class employees : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_employee;
		
		private string _login;
		
		private string _pswd;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _role;
		
		private System.Nullable<int> _position;
		
		private System.Nullable<int> _faculty_id;
		
		private EntitySet<schedule> _schedule;
		
		private EntityRef<positions> _positions;
		
		private EntityRef<faculties> _faculties;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_employeeChanging(int value);
    partial void Onid_employeeChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnpswdChanging(string value);
    partial void OnpswdChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    partial void OnpositionChanging(System.Nullable<int> value);
    partial void OnpositionChanged();
    partial void Onfaculty_idChanging(System.Nullable<int> value);
    partial void Onfaculty_idChanged();
    #endregion
		
		public employees()
		{
			this._schedule = new EntitySet<schedule>(new Action<schedule>(this.attach_schedule), new Action<schedule>(this.detach_schedule));
			this._positions = default(EntityRef<positions>);
			this._faculties = default(EntityRef<faculties>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_employee", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_employee
		{
			get
			{
				return this._id_employee;
			}
			set
			{
				if ((this._id_employee != value))
				{
					this.Onid_employeeChanging(value);
					this.SendPropertyChanging();
					this._id_employee = value;
					this.SendPropertyChanged("id_employee");
					this.Onid_employeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pswd", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string pswd
		{
			get
			{
				return this._pswd;
			}
			set
			{
				if ((this._pswd != value))
				{
					this.OnpswdChanging(value);
					this.SendPropertyChanging();
					this._pswd = value;
					this.SendPropertyChanged("pswd");
					this.OnpswdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="Int")]
		public System.Nullable<int> position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					if (this._positions.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpositionChanging(value);
					this.SendPropertyChanging();
					this._position = value;
					this.SendPropertyChanged("position");
					this.OnpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_faculty_id", DbType="Int")]
		public System.Nullable<int> faculty_id
		{
			get
			{
				return this._faculty_id;
			}
			set
			{
				if ((this._faculty_id != value))
				{
					if (this._faculties.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onfaculty_idChanging(value);
					this.SendPropertyChanging();
					this._faculty_id = value;
					this.SendPropertyChanged("faculty_id");
					this.Onfaculty_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="employees_schedule", Storage="_schedule", ThisKey="id_employee", OtherKey="employes_id")]
		public EntitySet<schedule> schedule
		{
			get
			{
				return this._schedule;
			}
			set
			{
				this._schedule.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="positions_employees", Storage="_positions", ThisKey="position", OtherKey="Id_positions", IsForeignKey=true, DeleteRule="CASCADE")]
		public positions positions
		{
			get
			{
				return this._positions.Entity;
			}
			set
			{
				positions previousValue = this._positions.Entity;
				if (((previousValue != value) 
							|| (this._positions.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._positions.Entity = null;
						previousValue.employees.Remove(this);
					}
					this._positions.Entity = value;
					if ((value != null))
					{
						value.employees.Add(this);
						this._position = value.Id_positions;
					}
					else
					{
						this._position = default(Nullable<int>);
					}
					this.SendPropertyChanged("positions");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="faculties_employees", Storage="_faculties", ThisKey="faculty_id", OtherKey="Id_faculty", IsForeignKey=true, DeleteRule="CASCADE")]
		public faculties faculties
		{
			get
			{
				return this._faculties.Entity;
			}
			set
			{
				faculties previousValue = this._faculties.Entity;
				if (((previousValue != value) 
							|| (this._faculties.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._faculties.Entity = null;
						previousValue.employees.Remove(this);
					}
					this._faculties.Entity = value;
					if ((value != null))
					{
						value.employees.Add(this);
						this._faculty_id = value.Id_faculty;
					}
					else
					{
						this._faculty_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("faculties");
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
		
		private void attach_schedule(schedule entity)
		{
			this.SendPropertyChanging();
			entity.employees = this;
		}
		
		private void detach_schedule(schedule entity)
		{
			this.SendPropertyChanging();
			entity.employees = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.positions")]
	public partial class positions : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_positions;
		
		private string _name_of_position;
		
		private EntitySet<employees> _employees;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_positionsChanging(int value);
    partial void OnId_positionsChanged();
    partial void Onname_of_positionChanging(string value);
    partial void Onname_of_positionChanged();
    #endregion
		
		public positions()
		{
			this._employees = new EntitySet<employees>(new Action<employees>(this.attach_employees), new Action<employees>(this.detach_employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_positions", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_positions
		{
			get
			{
				return this._Id_positions;
			}
			set
			{
				if ((this._Id_positions != value))
				{
					this.OnId_positionsChanging(value);
					this.SendPropertyChanging();
					this._Id_positions = value;
					this.SendPropertyChanged("Id_positions");
					this.OnId_positionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_of_position", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name_of_position
		{
			get
			{
				return this._name_of_position;
			}
			set
			{
				if ((this._name_of_position != value))
				{
					this.Onname_of_positionChanging(value);
					this.SendPropertyChanging();
					this._name_of_position = value;
					this.SendPropertyChanged("name_of_position");
					this.Onname_of_positionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="positions_employees", Storage="_employees", ThisKey="Id_positions", OtherKey="position")]
		public EntitySet<employees> employees
		{
			get
			{
				return this._employees;
			}
			set
			{
				this._employees.Assign(value);
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
		
		private void attach_employees(employees entity)
		{
			this.SendPropertyChanging();
			entity.positions = this;
		}
		
		private void detach_employees(employees entity)
		{
			this.SendPropertyChanging();
			entity.positions = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.schedule")]
	public partial class schedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_schedule_;
		
		private int _employes_id;
		
		private System.Nullable<System.DateTime> _data;
		
		private System.Nullable<System.TimeSpan> _started_to_work_time;
		
		private System.Nullable<System.TimeSpan> _ended_to_work_time;
		
		private int _activity_id;
		
		private System.Nullable<System.TimeSpan> _work_hours;
		
		private string _name_of_theme;
		
		private EntityRef<employees> _employees;
		
		private EntityRef<activities> _activities;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_schedule_Changing(int value);
    partial void OnId_schedule_Changed();
    partial void Onemployes_idChanging(int value);
    partial void Onemployes_idChanged();
    partial void OndataChanging(System.Nullable<System.DateTime> value);
    partial void OndataChanged();
    partial void Onstarted_to_work_timeChanging(System.Nullable<System.TimeSpan> value);
    partial void Onstarted_to_work_timeChanged();
    partial void Onended_to_work_timeChanging(System.Nullable<System.TimeSpan> value);
    partial void Onended_to_work_timeChanged();
    partial void Onactivity_idChanging(int value);
    partial void Onactivity_idChanged();
    partial void Onwork_hoursChanging(System.Nullable<System.TimeSpan> value);
    partial void Onwork_hoursChanged();
    partial void Onname_of_themeChanging(string value);
    partial void Onname_of_themeChanged();
    #endregion
		
		public schedule()
		{
			this._employees = default(EntityRef<employees>);
			this._activities = default(EntityRef<activities>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Id_schedule ]", Storage="_Id_schedule_", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_schedule_
		{
			get
			{
				return this._Id_schedule_;
			}
			set
			{
				if ((this._Id_schedule_ != value))
				{
					this.OnId_schedule_Changing(value);
					this.SendPropertyChanging();
					this._Id_schedule_ = value;
					this.SendPropertyChanged("Id_schedule_");
					this.OnId_schedule_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employes_id", DbType="Int NOT NULL")]
		public int employes_id
		{
			get
			{
				return this._employes_id;
			}
			set
			{
				if ((this._employes_id != value))
				{
					if (this._employees.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onemployes_idChanging(value);
					this.SendPropertyChanging();
					this._employes_id = value;
					this.SendPropertyChanged("employes_id");
					this.Onemployes_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data", DbType="Date")]
		public System.Nullable<System.DateTime> data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((this._data != value))
				{
					this.OndataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("data");
					this.OndataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_started_to_work_time", DbType="Time")]
		public System.Nullable<System.TimeSpan> started_to_work_time
		{
			get
			{
				return this._started_to_work_time;
			}
			set
			{
				if ((this._started_to_work_time != value))
				{
					this.Onstarted_to_work_timeChanging(value);
					this.SendPropertyChanging();
					this._started_to_work_time = value;
					this.SendPropertyChanged("started_to_work_time");
					this.Onstarted_to_work_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ended_to_work_time", DbType="Time")]
		public System.Nullable<System.TimeSpan> ended_to_work_time
		{
			get
			{
				return this._ended_to_work_time;
			}
			set
			{
				if ((this._ended_to_work_time != value))
				{
					this.Onended_to_work_timeChanging(value);
					this.SendPropertyChanging();
					this._ended_to_work_time = value;
					this.SendPropertyChanged("ended_to_work_time");
					this.Onended_to_work_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activity_id", DbType="Int NOT NULL")]
		public int activity_id
		{
			get
			{
				return this._activity_id;
			}
			set
			{
				if ((this._activity_id != value))
				{
					if (this._activities.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onactivity_idChanging(value);
					this.SendPropertyChanging();
					this._activity_id = value;
					this.SendPropertyChanged("activity_id");
					this.Onactivity_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_work_hours", DbType="Time")]
		public System.Nullable<System.TimeSpan> work_hours
		{
			get
			{
				return this._work_hours;
			}
			set
			{
				if ((this._work_hours != value))
				{
					this.Onwork_hoursChanging(value);
					this.SendPropertyChanging();
					this._work_hours = value;
					this.SendPropertyChanged("work_hours");
					this.Onwork_hoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_of_theme", DbType="NVarChar(50)")]
		public string name_of_theme
		{
			get
			{
				return this._name_of_theme;
			}
			set
			{
				if ((this._name_of_theme != value))
				{
					this.Onname_of_themeChanging(value);
					this.SendPropertyChanging();
					this._name_of_theme = value;
					this.SendPropertyChanged("name_of_theme");
					this.Onname_of_themeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="employees_schedule", Storage="_employees", ThisKey="employes_id", OtherKey="id_employee", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public employees employees
		{
			get
			{
				return this._employees.Entity;
			}
			set
			{
				employees previousValue = this._employees.Entity;
				if (((previousValue != value) 
							|| (this._employees.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._employees.Entity = null;
						previousValue.schedule.Remove(this);
					}
					this._employees.Entity = value;
					if ((value != null))
					{
						value.schedule.Add(this);
						this._employes_id = value.id_employee;
					}
					else
					{
						this._employes_id = default(int);
					}
					this.SendPropertyChanged("employees");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="activities_schedule", Storage="_activities", ThisKey="activity_id", OtherKey="Id_activity", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public activities activities
		{
			get
			{
				return this._activities.Entity;
			}
			set
			{
				activities previousValue = this._activities.Entity;
				if (((previousValue != value) 
							|| (this._activities.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._activities.Entity = null;
						previousValue.schedule.Remove(this);
					}
					this._activities.Entity = value;
					if ((value != null))
					{
						value.schedule.Add(this);
						this._activity_id = value.Id_activity;
					}
					else
					{
						this._activity_id = default(int);
					}
					this.SendPropertyChanged("activities");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.faculties")]
	public partial class faculties : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_faculty;
		
		private string _name_of_faculty;
		
		private int _institute_id;
		
		private EntitySet<employees> _employees;
		
		private EntityRef<institutes> _institutes;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_facultyChanging(int value);
    partial void OnId_facultyChanged();
    partial void Onname_of_facultyChanging(string value);
    partial void Onname_of_facultyChanged();
    partial void Oninstitute_idChanging(int value);
    partial void Oninstitute_idChanged();
    #endregion
		
		public faculties()
		{
			this._employees = new EntitySet<employees>(new Action<employees>(this.attach_employees), new Action<employees>(this.detach_employees));
			this._institutes = default(EntityRef<institutes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_faculty", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_faculty
		{
			get
			{
				return this._Id_faculty;
			}
			set
			{
				if ((this._Id_faculty != value))
				{
					this.OnId_facultyChanging(value);
					this.SendPropertyChanging();
					this._Id_faculty = value;
					this.SendPropertyChanged("Id_faculty");
					this.OnId_facultyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_of_faculty", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string name_of_faculty
		{
			get
			{
				return this._name_of_faculty;
			}
			set
			{
				if ((this._name_of_faculty != value))
				{
					this.Onname_of_facultyChanging(value);
					this.SendPropertyChanging();
					this._name_of_faculty = value;
					this.SendPropertyChanged("name_of_faculty");
					this.Onname_of_facultyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_institute_id", DbType="Int NOT NULL")]
		public int institute_id
		{
			get
			{
				return this._institute_id;
			}
			set
			{
				if ((this._institute_id != value))
				{
					if (this._institutes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oninstitute_idChanging(value);
					this.SendPropertyChanging();
					this._institute_id = value;
					this.SendPropertyChanged("institute_id");
					this.Oninstitute_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="faculties_employees", Storage="_employees", ThisKey="Id_faculty", OtherKey="faculty_id")]
		public EntitySet<employees> employees
		{
			get
			{
				return this._employees;
			}
			set
			{
				this._employees.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="institutes_faculties", Storage="_institutes", ThisKey="institute_id", OtherKey="Id_institute", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public institutes institutes
		{
			get
			{
				return this._institutes.Entity;
			}
			set
			{
				institutes previousValue = this._institutes.Entity;
				if (((previousValue != value) 
							|| (this._institutes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._institutes.Entity = null;
						previousValue.faculties.Remove(this);
					}
					this._institutes.Entity = value;
					if ((value != null))
					{
						value.faculties.Add(this);
						this._institute_id = value.Id_institute;
					}
					else
					{
						this._institute_id = default(int);
					}
					this.SendPropertyChanged("institutes");
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
		
		private void attach_employees(employees entity)
		{
			this.SendPropertyChanging();
			entity.faculties = this;
		}
		
		private void detach_employees(employees entity)
		{
			this.SendPropertyChanging();
			entity.faculties = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.activities")]
	public partial class activities : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_activity;
		
		private string _name_of_act;
		
		private EntitySet<schedule> _schedule;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_activityChanging(int value);
    partial void OnId_activityChanged();
    partial void Onname_of_actChanging(string value);
    partial void Onname_of_actChanged();
    #endregion
		
		public activities()
		{
			this._schedule = new EntitySet<schedule>(new Action<schedule>(this.attach_schedule), new Action<schedule>(this.detach_schedule));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_activity", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_activity
		{
			get
			{
				return this._Id_activity;
			}
			set
			{
				if ((this._Id_activity != value))
				{
					this.OnId_activityChanging(value);
					this.SendPropertyChanging();
					this._Id_activity = value;
					this.SendPropertyChanged("Id_activity");
					this.OnId_activityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_of_act", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name_of_act
		{
			get
			{
				return this._name_of_act;
			}
			set
			{
				if ((this._name_of_act != value))
				{
					this.Onname_of_actChanging(value);
					this.SendPropertyChanging();
					this._name_of_act = value;
					this.SendPropertyChanged("name_of_act");
					this.Onname_of_actChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="activities_schedule", Storage="_schedule", ThisKey="Id_activity", OtherKey="activity_id")]
		public EntitySet<schedule> schedule
		{
			get
			{
				return this._schedule;
			}
			set
			{
				this._schedule.Assign(value);
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
		
		private void attach_schedule(schedule entity)
		{
			this.SendPropertyChanging();
			entity.activities = this;
		}
		
		private void detach_schedule(schedule entity)
		{
			this.SendPropertyChanging();
			entity.activities = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.institutes")]
	public partial class institutes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_institute;
		
		private string _name_of_institute;
		
		private EntitySet<faculties> _faculties;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_instituteChanging(int value);
    partial void OnId_instituteChanged();
    partial void Onname_of_instituteChanging(string value);
    partial void Onname_of_instituteChanged();
    #endregion
		
		public institutes()
		{
			this._faculties = new EntitySet<faculties>(new Action<faculties>(this.attach_faculties), new Action<faculties>(this.detach_faculties));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_institute", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_institute
		{
			get
			{
				return this._Id_institute;
			}
			set
			{
				if ((this._Id_institute != value))
				{
					this.OnId_instituteChanging(value);
					this.SendPropertyChanging();
					this._Id_institute = value;
					this.SendPropertyChanged("Id_institute");
					this.OnId_instituteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_of_institute", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name_of_institute
		{
			get
			{
				return this._name_of_institute;
			}
			set
			{
				if ((this._name_of_institute != value))
				{
					this.Onname_of_instituteChanging(value);
					this.SendPropertyChanging();
					this._name_of_institute = value;
					this.SendPropertyChanged("name_of_institute");
					this.Onname_of_instituteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="institutes_faculties", Storage="_faculties", ThisKey="Id_institute", OtherKey="institute_id")]
		public EntitySet<faculties> faculties
		{
			get
			{
				return this._faculties;
			}
			set
			{
				this._faculties.Assign(value);
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
		
		private void attach_faculties(faculties entity)
		{
			this.SendPropertyChanging();
			entity.institutes = this;
		}
		
		private void detach_faculties(faculties entity)
		{
			this.SendPropertyChanging();
			entity.institutes = null;
		}
	}
}
#pragma warning restore 1591