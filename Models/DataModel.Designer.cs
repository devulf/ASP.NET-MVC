﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("WP11_cu222ai_WeatherModel", "FK_Weather_Geoname", "Geoname", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(projekt1.Models.Geoname), "Weather", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(projekt1.Models.Weather), true)]

#endregion

namespace projekt1.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WP11_cu222ai_WeatherEntities2 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WP11_cu222ai_WeatherEntities2 object using the connection string found in the 'WP11_cu222ai_WeatherEntities2' section of the application configuration file.
        /// </summary>
        public WP11_cu222ai_WeatherEntities2() : base("name=WP11_cu222ai_WeatherEntities2", "WP11_cu222ai_WeatherEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WP11_cu222ai_WeatherEntities2 object.
        /// </summary>
        public WP11_cu222ai_WeatherEntities2(string connectionString) : base(connectionString, "WP11_cu222ai_WeatherEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WP11_cu222ai_WeatherEntities2 object.
        /// </summary>
        public WP11_cu222ai_WeatherEntities2(EntityConnection connection) : base(connection, "WP11_cu222ai_WeatherEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Geoname> Geonames
        {
            get
            {
                if ((_Geonames == null))
                {
                    _Geonames = base.CreateObjectSet<Geoname>("Geonames");
                }
                return _Geonames;
            }
        }
        private ObjectSet<Geoname> _Geonames;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Weather> Weathers
        {
            get
            {
                if ((_Weathers == null))
                {
                    _Weathers = base.CreateObjectSet<Weather>("Weathers");
                }
                return _Weathers;
            }
        }
        private ObjectSet<Weather> _Weathers;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Geonames EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToGeonames(Geoname geoname)
        {
            base.AddObject("Geonames", geoname);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Weathers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWeathers(Weather weather)
        {
            base.AddObject("Weathers", weather);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WP11_cu222ai_WeatherModel", Name="Geoname")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Geoname : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Geoname object.
        /// </summary>
        /// <param name="locationID">Initial value of the LocationID property.</param>
        /// <param name="country">Initial value of the Country property.</param>
        /// <param name="county">Initial value of the County property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Geoname CreateGeoname(global::System.Int32 locationID, global::System.String country, global::System.String county, global::System.String name)
        {
            Geoname geoname = new Geoname();
            geoname.LocationID = locationID;
            geoname.Country = country;
            geoname.County = county;
            geoname.Name = name;
            return geoname;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 LocationID
        {
            get
            {
                return _LocationID;
            }
            set
            {
                if (_LocationID != value)
                {
                    OnLocationIDChanging(value);
                    ReportPropertyChanging("LocationID");
                    _LocationID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("LocationID");
                    OnLocationIDChanged();
                }
            }
        }
        private global::System.Int32 _LocationID;
        partial void OnLocationIDChanging(global::System.Int32 value);
        partial void OnLocationIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String County
        {
            get
            {
                return _County;
            }
            set
            {
                OnCountyChanging(value);
                ReportPropertyChanging("County");
                _County = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("County");
                OnCountyChanged();
            }
        }
        private global::System.String _County;
        partial void OnCountyChanging(global::System.String value);
        partial void OnCountyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> NextUpdate
        {
            get
            {
                return _NextUpdate;
            }
            set
            {
                OnNextUpdateChanging(value);
                ReportPropertyChanging("NextUpdate");
                _NextUpdate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NextUpdate");
                OnNextUpdateChanged();
            }
        }
        private Nullable<global::System.DateTime> _NextUpdate;
        partial void OnNextUpdateChanging(Nullable<global::System.DateTime> value);
        partial void OnNextUpdateChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WP11_cu222ai_WeatherModel", "FK_Weather_Geoname", "Weather")]
        public EntityCollection<Weather> Weathers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Weather>("WP11_cu222ai_WeatherModel.FK_Weather_Geoname", "Weather");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Weather>("WP11_cu222ai_WeatherModel.FK_Weather_Geoname", "Weather", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WP11_cu222ai_WeatherModel", Name="Weather")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Weather : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Weather object.
        /// </summary>
        /// <param name="weatherID">Initial value of the WeatherID property.</param>
        /// <param name="locationID">Initial value of the LocationID property.</param>
        /// <param name="temperature">Initial value of the Temperature property.</param>
        /// <param name="symbol">Initial value of the Symbol property.</param>
        /// <param name="time">Initial value of the Time property.</param>
        public static Weather CreateWeather(global::System.Int32 weatherID, global::System.Int32 locationID, global::System.String temperature, global::System.String symbol, global::System.DateTime time)
        {
            Weather weather = new Weather();
            weather.WeatherID = weatherID;
            weather.LocationID = locationID;
            weather.Temperature = temperature;
            weather.Symbol = symbol;
            weather.Time = time;
            return weather;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 WeatherID
        {
            get
            {
                return _WeatherID;
            }
            set
            {
                if (_WeatherID != value)
                {
                    OnWeatherIDChanging(value);
                    ReportPropertyChanging("WeatherID");
                    _WeatherID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("WeatherID");
                    OnWeatherIDChanged();
                }
            }
        }
        private global::System.Int32 _WeatherID;
        partial void OnWeatherIDChanging(global::System.Int32 value);
        partial void OnWeatherIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 LocationID
        {
            get
            {
                return _LocationID;
            }
            set
            {
                OnLocationIDChanging(value);
                ReportPropertyChanging("LocationID");
                _LocationID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LocationID");
                OnLocationIDChanged();
            }
        }
        private global::System.Int32 _LocationID;
        partial void OnLocationIDChanging(global::System.Int32 value);
        partial void OnLocationIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Temperature
        {
            get
            {
                return _Temperature;
            }
            set
            {
                OnTemperatureChanging(value);
                ReportPropertyChanging("Temperature");
                _Temperature = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Temperature");
                OnTemperatureChanged();
            }
        }
        private global::System.String _Temperature;
        partial void OnTemperatureChanging(global::System.String value);
        partial void OnTemperatureChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Symbol
        {
            get
            {
                return _Symbol;
            }
            set
            {
                OnSymbolChanging(value);
                ReportPropertyChanging("Symbol");
                _Symbol = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Symbol");
                OnSymbolChanged();
            }
        }
        private global::System.String _Symbol;
        partial void OnSymbolChanging(global::System.String value);
        partial void OnSymbolChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Time
        {
            get
            {
                return _Time;
            }
            set
            {
                OnTimeChanging(value);
                ReportPropertyChanging("Time");
                _Time = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Time");
                OnTimeChanged();
            }
        }
        private global::System.DateTime _Time;
        partial void OnTimeChanging(global::System.DateTime value);
        partial void OnTimeChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WP11_cu222ai_WeatherModel", "FK_Weather_Geoname", "Geoname")]
        public Geoname Geoname
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Geoname>("WP11_cu222ai_WeatherModel.FK_Weather_Geoname", "Geoname").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Geoname>("WP11_cu222ai_WeatherModel.FK_Weather_Geoname", "Geoname").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Geoname> GeonameReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Geoname>("WP11_cu222ai_WeatherModel.FK_Weather_Geoname", "Geoname");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Geoname>("WP11_cu222ai_WeatherModel.FK_Weather_Geoname", "Geoname", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
