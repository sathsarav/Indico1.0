// This file is generated by CodeSmith. Do not edit. All edits to this file will be lost. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Serialization;

using Indico.DAL;

//namespace Indico.BusinessObjects
namespace Indico.BusinessObjects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReservationStatusBO : BusinessObject, IComparable
    {
        #region fields
        #region Scalar Fields
        private int id;
        private string _description = string.Empty;
        private string _name = string.Empty;
        #endregion
        
        #region Foreign Key fields
        #endregion
        
        #region Foreign Table Foreign Key fields
        [NonSerialized][XmlIgnoreAttribute]
        private IndicoList<Indico.BusinessObjects.ReservationBO> reservationsWhereThisIsStatusList;
        [NonSerialized][XmlIgnoreAttribute]
        private bool _reservationsWhereThisIsStatusLoaded;
        #endregion
        
        #region Other fields
        
        private Indico.DAL.ReservationStatus _objDAL = null;
        private bool _doNotUpdateDALObject = false;
        
        #endregion
        
        #endregion
        
        #region Properties
        /// <summary>The Primary Key for this object</summary>
        public int ID
        {   get {return id;}
            set 
            {
                OnIDChanging(value);
                id = value;
                OnIDChanged();
            }
        }
        
        /// <summary>. The maximum length of this property is 512.</summary>
        public string Description
        {   
            get {return _description;}
            set 
            {
                OnDescriptionChanging(value);
                _description = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.Description = value;
                }
                OnDescriptionChanged();
            }
        }
        /// <summary>. The maximum length of this property is 64.</summary>
        public string Name
        {   
            get {return _name;}
            set 
            {
                OnNameChanging(value);
                _name = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.Name = value;
                }
                OnNameChanged();
            }
        }
        
        internal Indico.DAL.ReservationStatus ObjDAL
        {
            get 
            {
                if (_objDAL == null && base._createDAL)
                {
                    _objDAL = this.SetDAL(this.Context.Context);
                    this.ObjDAL.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(obj_PropertyChanged);
                }

                return _objDAL;
            }
            set 
            {
                _objDAL = value;
            }
        }
        
        #endregion
        
        #region Non-scalar Properties
        
        #region Foreign Key Objects
        #endregion
        
        #region Foreign Object Foreign Key Collections
        [XmlIgnoreAttribute]
        public IndicoList<Indico.BusinessObjects.ReservationBO> ReservationsWhereThisIsStatus // FK_Reservation_Status
        {
            get
            {
                if (!_reservationsWhereThisIsStatusLoaded)
                {
                    _reservationsWhereThisIsStatusLoaded = true;
                    if (this.ID > 0)
                    {
                         IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
                        Indico.DAL.ReservationStatus obj = (from o in context.ReservationStatus
                                     where o.ID == this.ID
                                     select o).FirstOrDefault();

                        obj.ReservationsWhereThisIsStatus.Load();
                        reservationsWhereThisIsStatusList = new IndicoList<Indico.BusinessObjects.ReservationBO>(obj.ReservationsWhereThisIsStatus.Count);
                        
                        foreach (Indico.DAL.Reservation o in obj.ReservationsWhereThisIsStatus)
                        {
                            Indico.BusinessObjects.ReservationBO fkObj = new Indico.BusinessObjects.ReservationBO(o, ref this._context);
                            reservationsWhereThisIsStatusList.Add(fkObj);
                        }
                        
                        if (this.Context == null)
                        {
                            context.Dispose();
                        }
                    }
                    else
                    {
                        reservationsWhereThisIsStatusList = new IndicoList<Indico.BusinessObjects.ReservationBO>();
                    }
                    
                    reservationsWhereThisIsStatusList.OnBeforeRemove += new EventHandler(ReservationsWhereThisIsStatusList_OnBeforeRemove);
                    reservationsWhereThisIsStatusList.OnAfterAdd += new EventHandler(ReservationsWhereThisIsStatusList_OnAfterAdd);
                }
                
                return reservationsWhereThisIsStatusList;
            }
        }
        #endregion
        
        #endregion
        
        #region Internal Constructors
        /// <summary>
        /// Creates an instance of the ReservationStatusBO class using the supplied Indico.DAL.ReservationStatus. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.ReservationStatus whose properties will be used to initialise the ReservationStatusBO</param>
        internal ReservationStatusBO(Indico.DAL.ReservationStatus obj, ref IndicoContext context)
        {
            this._doNotUpdateDALObject = true;
            
            this.Context = context;
        
            // set the properties from the Indico.DAL.ReservationStatus 
            this.ID = obj.ID;
            
            this.Description = obj.Description;
            this.Name = obj.Name;
            
            this._doNotUpdateDALObject = false;
        }
        #endregion
        
        #region Internal utility methods
        internal Indico.DAL.ReservationStatus SetDAL(IndicoEntities context)
        {
            this._doNotUpdateDALObject = true;
        
            // set the Indico.DAL.ReservationStatus properties
            Indico.DAL.ReservationStatus obj = new Indico.DAL.ReservationStatus();
            
            if (this.ID > 0)
            {
                obj = context.ReservationStatus.FirstOrDefault<ReservationStatus>(o => o.ID == this.ID);
            }
            
            obj.Description = this.Description;
            obj.Name = this.Name;
            
            
            if (_reservationsWhereThisIsStatusLoaded)
                BusinessObject.SynchroniseEntityList(
                    Indico.BusinessObjects.ReservationBO.ToEntityList(this.ReservationsWhereThisIsStatus, context), 
                    obj.ReservationsWhereThisIsStatus);
            
            this._doNotUpdateDALObject = false;
            
            return obj;
        }
        
        internal void SetBO(System.Data.Objects.DataClasses.EntityObject eObj)
        {
            this._doNotUpdateDALObject = true;
            
            // Check the received type
            if (eObj.GetType() != typeof(Indico.DAL.ReservationStatus))
            {
                throw new FormatException("Received wrong parameter type...");
            }

            Indico.DAL.ReservationStatus obj = (Indico.DAL.ReservationStatus)eObj;
            
            // set the Indico.BusinessObjects.ReservationStatusBO properties
            this.ID = obj.ID;
            
            this.Description = obj.Description;
            this.Name = obj.Name;
            
            
            this._doNotUpdateDALObject = false;
        }
        
        internal void SetBO(Indico.BusinessObjects.ReservationStatusBO obj)
        {
            this._doNotUpdateDALObject = true;
            
            // set this Indico.BusinessObjects.ReservationStatusBO properties
            this.ID = obj.ID;
            
            this.Description = obj.Description;
            this.Name = obj.Name;
            
            this._doNotUpdateDALObject = false;
        }
        
        internal List<Indico.BusinessObjects.ReservationStatusBO> IQueryableToList(IQueryable<Indico.DAL.ReservationStatus> oQuery)
        {
            List<Indico.DAL.ReservationStatus> oList = oQuery.ToList();
            List<Indico.BusinessObjects.ReservationStatusBO> rList = new List<Indico.BusinessObjects.ReservationStatusBO>(oList.Count);
            foreach (Indico.DAL.ReservationStatus o in oList)
            {
                Indico.BusinessObjects.ReservationStatusBO obj = new Indico.BusinessObjects.ReservationStatusBO(o, ref this._context);
                rList.Add(obj);
            }
            return rList;
        }
        
        internal List<Indico.BusinessObjects.ReservationStatusBO> ToList(IEnumerable<Indico.DAL.ReservationStatus> oQuery)
        {
            List<Indico.DAL.ReservationStatus> oList = oQuery.ToList();
            List<Indico.BusinessObjects.ReservationStatusBO> rList = new List<Indico.BusinessObjects.ReservationStatusBO>(oList.Count);
            foreach (Indico.DAL.ReservationStatus o in oList)
            {
                Indico.BusinessObjects.ReservationStatusBO obj = new Indico.BusinessObjects.ReservationStatusBO(o, ref this._context);
                rList.Add(obj);
            }
            return rList;
        }
        
        internal static List<Indico.DAL.ReservationStatus> ToEntityList(List<ReservationStatusBO> bos, IndicoEntities context)
        {
            // build a List of ReservationStatus entities from the business objects
            List<Int32> ids = (from o in bos
                                   select o.ID).ToList<Int32>();

            return (context.ReservationStatus.Count() == 0) ? new List<Indico.DAL.ReservationStatus>() : (context.ReservationStatus.Where(BuildContainsExpression<ReservationStatus, int>(e => e.ID, ids)))
                .ToList<Indico.DAL.ReservationStatus>();
        }
        
        internal static System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.ReservationStatus> ToEntityCollection(List<ReservationStatusBO> bos, IndicoEntities context)
        {
            // build an EntityCollection of ReservationStatus entities from the business objects
            List<Int32> ids = (from o in bos
                               select o.ID).ToList<Int32>();

            List<Indico.DAL.ReservationStatus> el = (context.ReservationStatus.Count() == 0) ? new List<Indico.DAL.ReservationStatus>() : 
                context.ReservationStatus.Where(BuildContainsExpression<ReservationStatus, int>(e => e.ID, ids))
                .ToList<Indico.DAL.ReservationStatus>();
                
            System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.ReservationStatus> ec 
                = new System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.ReservationStatus>();
                
            foreach (Indico.DAL.ReservationStatus r in el) 
            {
                ec.Add(r);
            }
            return ec;
        }

        internal Indico.DAL.ReservationStatus ToEntity(IndicoEntities context)
        {
            return (from o in context.ReservationStatus
                    where o.ID == this.ID
                    select o).FirstOrDefault();
        }
        #endregion
        
        #region BusinessObject methods
        
        #region Add Object
        
        public void Add()
        {
            if (this.Context != null)
            {
                this.Context.Context.AddToReservationStatus(this.ObjDAL);
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                Indico.DAL.ReservationStatus obj = this.SetDAL(objContext.Context);
                objContext.Context.AddToReservationStatus(obj);
                objContext.SaveChanges();
                objContext.Dispose(); 
            }
        }
        
        #endregion
        
        #region Delete Object
        
        public void Delete()
        {
            if (this.Context != null)
            {
                if (this.ObjDAL != null && this.ObjDAL.EntityKey != null)
                {
                    if (this.ObjDAL.EntityState == System.Data.EntityState.Detached)
                    {
                        this.Context.Context.Attach(this.ObjDAL);
                        this.Context.Context.DeleteObject(this.ObjDAL);
                    }
                    else
                    {
                        this.Context.Context.DeleteObject(this.ObjDAL);
                    }
                }
                else
                {
                    Indico.DAL.ReservationStatus obj = this.SetDAL(this.Context.Context);
                    this.Context.Context.DeleteObject(obj);
                }
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                Indico.DAL.ReservationStatus obj = this.SetDAL(objContext.Context);
                this.Context.Context.DeleteObject(obj);
                objContext.Context.SaveChanges();
                objContext.Dispose();
            }
        }
        
        #endregion
        
        #region Get Single Object
        
        public bool GetObject()
        {
            return GetObject(true);
        }
        public bool GetObject(bool blnCache)
        {
            Indico.BusinessObjects.ReservationStatusBO data = null;
            
            if (blnCache)
            {
                data = this.GetFromCache(this.ID) as Indico.BusinessObjects.ReservationStatusBO; 
            }

            if (data != null)
            {
                SetBO(data);
            }
            else
            {
                try
                {
                    IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
                    IQueryable<Indico.DAL.ReservationStatus> oQuery =
                        from o in context.ReservationStatus
                        where o.ID == this.ID
                        select o;

                    List<Indico.DAL.ReservationStatus> oList = oQuery.ToList();
                    if (oList.Count != 1)
                        return false;
                    else
                    {
                        SetBO(oList[0]);
                        this.Cache();
                    }
                    
                    if (this.Context == null)
                    {
                        context.Dispose();
                    }
                }
                catch (System.Exception e)
                {
                    throw new IndicoException(String.Format(System.Globalization.CultureInfo.InvariantCulture, ResourceManager.GetString("Could not Retrieve a {0} from the data store", System.Globalization.CultureInfo.CurrentCulture), this.ToString()), e, IndicoException.Severities.USER, IndicoException.ERRNO.INT_ERR_BO_SELECT_FAIL);
                }
            }
            return true;
        }
        #endregion
        
        #region GetAllObject
        public List<Indico.BusinessObjects.ReservationStatusBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReservationStatus> oQuery =
                (from o in context.ReservationStatus
                 orderby o.ID
                 select o);

            if (sortExpression != null && sortExpression.Length > 0)
            {
                // using System.Linq.Dynamic here in Dynamic.cs;
                if (sortDescending)
                    oQuery = oQuery.OrderBy(sortExpression + " desc").Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);
                else
                    oQuery = oQuery.OrderBy(sortExpression + " asc").Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);
            }
            else
                oQuery = oQuery.OrderBy(obj => obj.ID).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReservationStatusBO> reservationstatuss = IQueryableToList(oQuery);
            context.Dispose();
            return reservationstatuss;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.ReservationStatus> oQuery =
                (from o in context.ReservationStatus
                 where
                    (this.ID == 0 || this.ID == o.ID) &&
                    (this.Name == string.Empty || this.Name == o.Name) &&
                    (this.Description == string.Empty || this.Description == o.Description) 
                 orderby o.ID
                 select o);

            if (sortExpression != null && sortExpression.Length > 0)
            {
                // using System.Linq.Dynamic here in Dynamic.cs;
                if (sortDescending)
                    oQuery = oQuery.OrderBy(sortExpression + " desc").Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);
                else
                    oQuery = oQuery.OrderBy(sortExpression + " asc").Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);
            }
            else
                oQuery = oQuery.OrderBy(obj => obj.ID).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReservationStatusBO> reservationstatuss = IQueryableToList(oQuery);
            
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return reservationstatuss;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.ReservationStatus
                 where
                    (this.ID == 0 || this.ID == o.ID) &&
                    (this.Name == string.Empty || this.Name == o.Name) &&
                    (this.Description == string.Empty || this.Description == o.Description) 
                 orderby o.ID
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.ReservationStatus> oQuery =
                (from o in context.ReservationStatus
                 where
                    (this.ID == 0 || o.ID == this.ID) &&
                    (this.Name == string.Empty || o.Name.Contains(this.Name)) &&
                    (this.Description == string.Empty || o.Description.Contains(this.Description)) 
                 orderby o.ID
                 select o);

            if (sortExpression != null && sortExpression.Length > 0)
            {
                // using System.Linq.Dynamic here in Dynamic.cs;
                if (sortDescending)
                    oQuery = oQuery.OrderBy(sortExpression + " desc").Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);
                else
                    oQuery = oQuery.OrderBy(sortExpression + " asc").Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);
            }
            else
                oQuery = oQuery.OrderBy(obj => obj.ID).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReservationStatusBO> reservationstatuss = IQueryableToList(oQuery);
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return reservationstatuss;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.ReservationStatus
                 where
                    (this.ID == 0 || o.ID == this.ID) &&
                    (this.Name == string.Empty || o.Name.Contains(this.Name)) &&
                    (this.Description == string.Empty || o.Description.Contains(this.Description)) 
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReservationStatusBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.ReservationStatus> oQuery =
                (from o in context.ReservationStatus
                 where
                    (this.ID == 0 || this.ID == o.ID) && 
                    ((o.Name.Contains(this.Name)) ||
                    (o.Description.Contains(this.Description)) ||
                    (this.Name == null && this.Description == null ))
                 orderby o.ID
                 select o);

            if (sortExpression != null && sortExpression.Length > 0)
            {
                // using System.Linq.Dynamic here in Dynamic.cs;
                if (sortDescending)
                    oQuery = oQuery.OrderBy(sortExpression + " desc").Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);
                else
                    oQuery = oQuery.OrderBy(sortExpression + " asc").Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);
            }
            else
                oQuery = oQuery.OrderBy(obj => obj.ID).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReservationStatusBO> reservationstatuss = IQueryableToList(oQuery);
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return reservationstatuss;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.ReservationStatus
                 where
                    (this.ID == 0 || this.ID == o.ID) && 
                    ((o.Name.Contains(this.Name)) ||
                    (o.Description.Contains(this.Description)) ||
                    (this.Name == null && this.Description == null ))
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region Serialization methods
        /// <summary>
        /// Serializes the Indico.BusinessObjects.ReservationStatusBO to an XML representation
        /// </summary>
        /// <returns>a XML string serialized representation</returns>
        public string SerializeObject()
        {
            string strReturn = "";

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            x.Serialize(objStream, this);

            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            // Read string from binary file with UTF8 encoding
            strReturn = encoding.GetString(objStream.GetBuffer());

            objStream.Close();
            return strReturn;

        }

        /// <summary>
        /// Deserializes Indico.BusinessObjects.ReservationStatusBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.ReservationStatusBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.ReservationStatusBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.ReservationStatusBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.ReservationStatusBO object in an XmlElement
        /// </summary>
        /// <returns>An XML snippet representing the object</returns>
        public string ToXmlString()
        {
            // MW TODO - implement this better.
            return SerializeObject();
        }
        #endregion
        
        #region OnPropertyChange Methods
        partial void OnIDChanged()
        {
            OnReservationStatusBOIDChanged();
        }
        
        partial void OnIDChanging(int value)
        {
            if (value < 0)
            {
                throw new Exception(String.Format("ReservationStatusBO.ID must be more than or equal to 0. The supplied value was {0}.", value));
            }
            OnReservationStatusBOIDChanging(value);
        }
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnReservationStatusBOIDChanged();
        partial void OnReservationStatusBOIDChanging(int value);
        
        partial void OnNameChanged()
        {
            OnReservationStatusBONameChanged();
        }
        
        partial void OnNameChanging(string value)
        {
            if (value != null && value.Length > 64)
            {
                throw new Exception(String.Format("ReservationStatusBO.Name has a maximum length of 64. The supplied value \"{0}\" has a length of {1}", value, value.Length));
            }
            OnReservationStatusBONameChanging(value);
        }
        partial void OnNameChanged();
        partial void OnNameChanging(string value);
        partial void OnReservationStatusBONameChanged();
        partial void OnReservationStatusBONameChanging(string value);
        
        partial void OnDescriptionChanged()
        {
            OnReservationStatusBODescriptionChanged();
        }
        
        partial void OnDescriptionChanging(string value)
        {
            if (value != null && value.Length > 512)
            {
                throw new Exception(String.Format("ReservationStatusBO.Description has a maximum length of 512. The supplied value \"{0}\" has a length of {1}", value, value.Length));
            }
            OnReservationStatusBODescriptionChanging(value);
        }
        partial void OnDescriptionChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnReservationStatusBODescriptionChanged();
        partial void OnReservationStatusBODescriptionChanging(string value);
        
        #endregion
        
        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (!(obj is Indico.BusinessObjects.ReservationStatusBO))
                return 1;
            Indico.BusinessObjects.ReservationStatusBOComparer c = new Indico.BusinessObjects.ReservationStatusBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.ReservationStatusBO);
        }

        #endregion
        #endregion
        
        #region Events
        
        void obj_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ID")
            {
                // reload me
                this.SetBO((Indico.DAL.ReservationStatus)sender);
            }
        }
        
        void ReservationsWhereThisIsStatusList_OnAfterAdd(object sender, EventArgs e)
        {
            Indico.DAL.Reservation obj = null;
            if (this.Context != null)
            {
                if (((IndicoList<Indico.BusinessObjects.ReservationBO>)sender).Count > 0)
                {
                    obj = ((IndicoList<Indico.BusinessObjects.ReservationBO>)sender)[((IndicoList<Indico.BusinessObjects.ReservationBO>)sender).Count - 1].ObjDAL;
                    this.ObjDAL.ReservationsWhereThisIsStatus.Add(obj);
                }
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                obj = ((IndicoList<Indico.BusinessObjects.ReservationBO>)sender)[((IndicoList<Indico.BusinessObjects.ReservationBO>)sender).Count - 1].SetDAL(objContext.Context);
                this.ObjDAL.ReservationsWhereThisIsStatus.Add(obj);
                objContext.SaveChanges();
                objContext.Dispose();
            }
        }
        
        void ReservationsWhereThisIsStatusList_OnBeforeRemove(object sender, EventArgs e)
        {
            Indico.DAL.Reservation obj = null;
            if (this.Context != null)
            {
                if (((IndicoList<Indico.BusinessObjects.ReservationBO>)sender).Count > 0)
                {
                    obj = ((IndicoList<Indico.BusinessObjects.ReservationBO>)sender)[((IndicoList<Indico.BusinessObjects.ReservationBO>)sender).Count - 1].ObjDAL;
                    this.ObjDAL.ReservationsWhereThisIsStatus.Remove(obj);
                }
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                obj = ((IndicoList<Indico.BusinessObjects.ReservationBO>)sender)[((IndicoList<Indico.BusinessObjects.ReservationBO>)sender).Count - 1].SetDAL(objContext.Context);
                this.ObjDAL.ReservationsWhereThisIsStatus.Remove(obj);
                objContext.SaveChanges();
                objContext.Dispose();
            }
        }
        
        void Context_OnSendBeforeChanges(object sender, EventArgs e)
        {        
            this._reservationsWhereThisIsStatusLoaded = false;
            if (this.reservationsWhereThisIsStatusList != null)
            {
                this.reservationsWhereThisIsStatusList.OnBeforeRemove -= new EventHandler(ReservationsWhereThisIsStatusList_OnBeforeRemove);
                this.reservationsWhereThisIsStatusList.OnAfterAdd -= new EventHandler(ReservationsWhereThisIsStatusList_OnAfterAdd);
            }
        }
        
        void Context_OnSendAfterChanges(object sender, EventArgs e)
        {   
            if (this.ID > 0)
            {
                this.Cache();
            }
        }

        #endregion
    }
    
    #region ReservationStatusBOComparer
    public class ReservationStatusBOComparer : IComparer<Indico.BusinessObjects.ReservationStatusBO>
    {
        private string propertyToCompareName;
        public ReservationStatusBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.ReservationStatusBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.ReservationStatusBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public ReservationStatusBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.ReservationStatusBO> Members
        public int Compare(Indico.BusinessObjects.ReservationStatusBO x, Indico.BusinessObjects.ReservationStatusBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.ReservationStatusBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.ReservationStatusBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.ReservationStatusBO x, Indico.BusinessObjects.ReservationStatusBO y)
        {
            object xVal = p.GetValue(x, null);
            object yVal = p.GetValue(y, null);

            if (xVal == null)
            {
                if (yVal == null)
                    return 0;
                else
                    return -1; // x is null, y is not, y is greater
            }
            else
            {
                if (y == null)
                    return 1; // x non null, y is null, x is greater
                else if (xVal is string)
                {
                    return StringComparer.OrdinalIgnoreCase.Compare(xVal, yVal);
                }
                else if (xVal is IComparable)
                {
                    return ((IComparable)xVal).CompareTo((IComparable)yVal);
                }
                else
                    throw new ArgumentException
                        ("is not string or valuetype that implements IComparable", "propertyToCompare");

            }
        }

        #endregion
    }
    #endregion
}
