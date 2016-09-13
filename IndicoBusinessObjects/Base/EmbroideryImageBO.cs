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
    public partial class EmbroideryImageBO : BusinessObject, IComparable
    {
        #region fields
        #region Scalar Fields
        private int id;
        private int _embroideryDetails;
        private string _extension;
        private string _filename;
        private bool _isRequested;
        private int _size;
        #endregion
        
        #region Foreign Key fields
        [NonSerialized][XmlIgnoreAttribute]
        private Indico.BusinessObjects.EmbroideryDetailsBO _objEmbroideryDetails;
        #endregion
        
        #region Foreign Table Foreign Key fields
        #endregion
        
        #region Other fields
        
        private Indico.DAL.EmbroideryImage _objDAL = null;
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
        
        /// <summary>.</summary>
        public int EmbroideryDetails
        {   
            get {return _embroideryDetails;}
            set 
            {
                OnEmbroideryDetailsChanging(value);
                _embroideryDetails = value;
                if (!this._doNotUpdateDALObject && this._context != null && this.ObjDAL != null && ((int)value != 0))
                {
                    this.ObjDAL.EmbroideryDetails = (from o in this._context.Context.EmbroideryDetails
                                           where o.ID == (int)value
                                           select o).ToList<Indico.DAL.EmbroideryDetails>()[0];
                }
                else if (!this._doNotUpdateDALObject && this._context != null && this.ObjDAL != null && (int)value == 0)
                    this.ObjDAL.EmbroideryDetails = null;
                OnEmbroideryDetailsChanged();
            }
        }
        /// <summary>. The maximum length of this property is 10.</summary>
        public string Extension
        {   
            get {return _extension;}
            set 
            {
                OnExtensionChanging(value);
                _extension = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.Extension = value;
                }
                OnExtensionChanged();
            }
        }
        /// <summary>. The maximum length of this property is 255.</summary>
        public string Filename
        {   
            get {return _filename;}
            set 
            {
                OnFilenameChanging(value);
                _filename = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.Filename = value;
                }
                OnFilenameChanged();
            }
        }
        /// <summary>.</summary>
        public bool IsRequested
        {   
            get {return _isRequested;}
            set 
            {
                OnIsRequestedChanging(value);
                _isRequested = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.IsRequested = value;
                }
                OnIsRequestedChanged();
            }
        }
        /// <summary>.</summary>
        public int Size
        {   
            get {return _size;}
            set 
            {
                OnSizeChanging(value);
                _size = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.Size = value;
                }
                OnSizeChanged();
            }
        }
        
        internal Indico.DAL.EmbroideryImage ObjDAL
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
        ///<summary>The EmbroideryDetailsBO object identified by the value of EmbroideryDetails</summary>
        [XmlIgnoreAttribute]
        public Indico.BusinessObjects.EmbroideryDetailsBO objEmbroideryDetails
        {
            get
            {
                if ( _embroideryDetails > 0 && _objEmbroideryDetails == null)
                {
                        if (this._context == null)
                        {
                            _objEmbroideryDetails = new Indico.BusinessObjects.EmbroideryDetailsBO();
                        }
                        else
                        {
                            _objEmbroideryDetails = new Indico.BusinessObjects.EmbroideryDetailsBO(ref this._context);
                        }
                        _objEmbroideryDetails.ID = _embroideryDetails;
                        _objEmbroideryDetails.GetObject(); 
                }
                return _objEmbroideryDetails;
            }
            set
            { 
                _objEmbroideryDetails = value;
                _embroideryDetails = _objEmbroideryDetails.ID;
            }
        }
        #endregion
        
        #region Foreign Object Foreign Key Collections
        #endregion
        
        #endregion
        
        #region Internal Constructors
        /// <summary>
        /// Creates an instance of the EmbroideryImageBO class using the supplied Indico.DAL.EmbroideryImage. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.EmbroideryImage whose properties will be used to initialise the EmbroideryImageBO</param>
        internal EmbroideryImageBO(Indico.DAL.EmbroideryImage obj, ref IndicoContext context)
        {
            this._doNotUpdateDALObject = true;
            
            this.Context = context;
        
            // set the properties from the Indico.DAL.EmbroideryImage 
            this.ID = obj.ID;
            
            this.EmbroideryDetails = (obj.EmbroideryDetailsReference.EntityKey != null && obj.EmbroideryDetailsReference.EntityKey.EntityKeyValues.Count() > 0)
                ? (int)((System.Data.EntityKeyMember)obj.EmbroideryDetailsReference.EntityKey.EntityKeyValues.GetValue(0)).Value
                : 0;
            this.Extension = obj.Extension;
            this.Filename = obj.Filename;
            this.IsRequested = obj.IsRequested;
            this.Size = obj.Size;
            
            this._doNotUpdateDALObject = false;
        }
        #endregion
        
        #region Internal utility methods
        internal Indico.DAL.EmbroideryImage SetDAL(IndicoEntities context)
        {
            this._doNotUpdateDALObject = true;
        
            // set the Indico.DAL.EmbroideryImage properties
            Indico.DAL.EmbroideryImage obj = new Indico.DAL.EmbroideryImage();
            
            if (this.ID > 0)
            {
                obj = context.EmbroideryImage.FirstOrDefault<EmbroideryImage>(o => o.ID == this.ID);
            }
            
            obj.Extension = this.Extension;
            obj.Filename = this.Filename;
            obj.IsRequested = this.IsRequested;
            obj.Size = this.Size;
            
            if (this.EmbroideryDetails > 0) obj.EmbroideryDetails = context.EmbroideryDetails.FirstOrDefault(o => o.ID == this.EmbroideryDetails);
            
            
            this._doNotUpdateDALObject = false;
            
            return obj;
        }
        
        internal void SetBO(System.Data.Objects.DataClasses.EntityObject eObj)
        {
            this._doNotUpdateDALObject = true;
            
            // Check the received type
            if (eObj.GetType() != typeof(Indico.DAL.EmbroideryImage))
            {
                throw new FormatException("Received wrong parameter type...");
            }

            Indico.DAL.EmbroideryImage obj = (Indico.DAL.EmbroideryImage)eObj;
            
            // set the Indico.BusinessObjects.EmbroideryImageBO properties
            this.ID = obj.ID;
            
            this.Extension = obj.Extension;
            this.Filename = obj.Filename;
            this.IsRequested = obj.IsRequested;
            this.Size = obj.Size;
            
            this.EmbroideryDetails = (obj.EmbroideryDetailsReference.EntityKey != null && obj.EmbroideryDetailsReference.EntityKey.EntityKeyValues.Count() > 0)
                ? (int)((System.Data.EntityKeyMember)obj.EmbroideryDetailsReference.EntityKey.EntityKeyValues.GetValue(0)).Value
                : 0;
            
            this._doNotUpdateDALObject = false;
        }
        
        internal void SetBO(Indico.BusinessObjects.EmbroideryImageBO obj)
        {
            this._doNotUpdateDALObject = true;
            
            // set this Indico.BusinessObjects.EmbroideryImageBO properties
            this.ID = obj.ID;
            
            this.EmbroideryDetails = obj.EmbroideryDetails;
            this.Extension = obj.Extension;
            this.Filename = obj.Filename;
            this.IsRequested = obj.IsRequested;
            this.Size = obj.Size;
            
            this._doNotUpdateDALObject = false;
        }
        
        internal List<Indico.BusinessObjects.EmbroideryImageBO> IQueryableToList(IQueryable<Indico.DAL.EmbroideryImage> oQuery)
        {
            List<Indico.DAL.EmbroideryImage> oList = oQuery.ToList();
            List<Indico.BusinessObjects.EmbroideryImageBO> rList = new List<Indico.BusinessObjects.EmbroideryImageBO>(oList.Count);
            foreach (Indico.DAL.EmbroideryImage o in oList)
            {
                Indico.BusinessObjects.EmbroideryImageBO obj = new Indico.BusinessObjects.EmbroideryImageBO(o, ref this._context);
                rList.Add(obj);
            }
            return rList;
        }
        
        internal List<Indico.BusinessObjects.EmbroideryImageBO> ToList(IEnumerable<Indico.DAL.EmbroideryImage> oQuery)
        {
            List<Indico.DAL.EmbroideryImage> oList = oQuery.ToList();
            List<Indico.BusinessObjects.EmbroideryImageBO> rList = new List<Indico.BusinessObjects.EmbroideryImageBO>(oList.Count);
            foreach (Indico.DAL.EmbroideryImage o in oList)
            {
                Indico.BusinessObjects.EmbroideryImageBO obj = new Indico.BusinessObjects.EmbroideryImageBO(o, ref this._context);
                rList.Add(obj);
            }
            return rList;
        }
        
        internal static List<Indico.DAL.EmbroideryImage> ToEntityList(List<EmbroideryImageBO> bos, IndicoEntities context)
        {
            // build a List of EmbroideryImage entities from the business objects
            List<Int32> ids = (from o in bos
                                   select o.ID).ToList<Int32>();

            return (context.EmbroideryImage.Count() == 0) ? new List<Indico.DAL.EmbroideryImage>() : (context.EmbroideryImage.Where(BuildContainsExpression<EmbroideryImage, int>(e => e.ID, ids)))
                .ToList<Indico.DAL.EmbroideryImage>();
        }
        
        internal static System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.EmbroideryImage> ToEntityCollection(List<EmbroideryImageBO> bos, IndicoEntities context)
        {
            // build an EntityCollection of EmbroideryImage entities from the business objects
            List<Int32> ids = (from o in bos
                               select o.ID).ToList<Int32>();

            List<Indico.DAL.EmbroideryImage> el = (context.EmbroideryImage.Count() == 0) ? new List<Indico.DAL.EmbroideryImage>() : 
                context.EmbroideryImage.Where(BuildContainsExpression<EmbroideryImage, int>(e => e.ID, ids))
                .ToList<Indico.DAL.EmbroideryImage>();
                
            System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.EmbroideryImage> ec 
                = new System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.EmbroideryImage>();
                
            foreach (Indico.DAL.EmbroideryImage r in el) 
            {
                ec.Add(r);
            }
            return ec;
        }

        internal Indico.DAL.EmbroideryImage ToEntity(IndicoEntities context)
        {
            return (from o in context.EmbroideryImage
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
                this.Context.Context.AddToEmbroideryImage(this.ObjDAL);
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                Indico.DAL.EmbroideryImage obj = this.SetDAL(objContext.Context);
                objContext.Context.AddToEmbroideryImage(obj);
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
                    Indico.DAL.EmbroideryImage obj = this.SetDAL(this.Context.Context);
                    this.Context.Context.DeleteObject(obj);
                }
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                Indico.DAL.EmbroideryImage obj = this.SetDAL(objContext.Context);
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
            Indico.BusinessObjects.EmbroideryImageBO data = null;
            
            if (blnCache)
            {
                data = this.GetFromCache(this.ID) as Indico.BusinessObjects.EmbroideryImageBO; 
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
                    IQueryable<Indico.DAL.EmbroideryImage> oQuery =
                        from o in context.EmbroideryImage
                        where o.ID == this.ID
                        select o;

                    List<Indico.DAL.EmbroideryImage> oList = oQuery.ToList();
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
        public List<Indico.BusinessObjects.EmbroideryImageBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.EmbroideryImage> oQuery =
                (from o in context.EmbroideryImage
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

            List<Indico.BusinessObjects.EmbroideryImageBO> embroideryimages = IQueryableToList(oQuery);
            context.Dispose();
            return embroideryimages;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.EmbroideryImage> oQuery =
                (from o in context.EmbroideryImage
                 where
                    (this.ID == 0 || this.ID == o.ID) &&
                    (this.EmbroideryDetails == 0 || this.EmbroideryDetails == o.EmbroideryDetails.ID) &&
                    (this.Size == 0 || this.Size == o.Size) &&
                    (this.Filename == null || this.Filename == o.Filename) &&
                    (this.Extension == null || this.Extension == o.Extension) &&
                    (this.IsRequested == false || this.IsRequested == o.IsRequested) 
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

            List<Indico.BusinessObjects.EmbroideryImageBO> embroideryimages = IQueryableToList(oQuery);
            
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return embroideryimages;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.EmbroideryImage
                 where
                    (this.ID == 0 || this.ID == o.ID) &&
                    (this.EmbroideryDetails == 0 || this.EmbroideryDetails == o.EmbroideryDetails.ID) &&
                    (this.Size == 0 || this.Size == o.Size) &&
                    (this.Filename == null || this.Filename == o.Filename) &&
                    (this.Extension == null || this.Extension == o.Extension) &&
                    (this.IsRequested == false || this.IsRequested == o.IsRequested) 
                 orderby o.ID
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.EmbroideryImage> oQuery =
                (from o in context.EmbroideryImage
                 where
                    (this.ID == 0 || o.ID == this.ID) &&
                    (this.EmbroideryDetails == 0 || o.EmbroideryDetails.ID == this.EmbroideryDetails) &&
                    (this.Size == 0 || o.Size == this.Size) &&
                    (this.Filename == null || o.Filename.Contains(this.Filename)) &&
                    (this.Extension == null || o.Extension.Contains(this.Extension)) &&
                    (this.IsRequested == false || o.IsRequested == this.IsRequested) 
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

            List<Indico.BusinessObjects.EmbroideryImageBO> embroideryimages = IQueryableToList(oQuery);
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return embroideryimages;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.EmbroideryImage
                 where
                    (this.ID == 0 || o.ID == this.ID) &&
                    (this.EmbroideryDetails == 0 || o.EmbroideryDetails.ID == this.EmbroideryDetails) &&
                    (this.Size == 0 || o.Size == this.Size) &&
                    (this.Filename == null || o.Filename.Contains(this.Filename)) &&
                    (this.Extension == null || o.Extension.Contains(this.Extension)) &&
                    (this.IsRequested == false || o.IsRequested == this.IsRequested) 
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.EmbroideryImageBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.EmbroideryImage> oQuery =
                (from o in context.EmbroideryImage
                 where
                    (this.ID == 0 || this.ID == o.ID) && 
                    (this.EmbroideryDetails == 0 || this.EmbroideryDetails == o.EmbroideryDetails.ID) && 
                    (this.Size == 0 || this.Size == o.Size) && 
                    (this.IsRequested == false || this.IsRequested == o.IsRequested) && 
                    ((o.Filename.Contains(this.Filename)) ||
                    (o.Extension.Contains(this.Extension)) ||
                    (this.Filename == null && this.Extension == null ))
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

            List<Indico.BusinessObjects.EmbroideryImageBO> embroideryimages = IQueryableToList(oQuery);
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return embroideryimages;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.EmbroideryImage
                 where
                    (this.ID == 0 || this.ID == o.ID) && 
                    (this.EmbroideryDetails == 0 || this.EmbroideryDetails == o.EmbroideryDetails.ID) && 
                    (this.Size == 0 || this.Size == o.Size) && 
                    (this.IsRequested == false || this.IsRequested == o.IsRequested) && 
                    ((o.Filename.Contains(this.Filename)) ||
                    (o.Extension.Contains(this.Extension)) ||
                    (this.Filename == null && this.Extension == null ))
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region Serialization methods
        /// <summary>
        /// Serializes the Indico.BusinessObjects.EmbroideryImageBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.EmbroideryImageBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.EmbroideryImageBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.EmbroideryImageBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.EmbroideryImageBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.EmbroideryImageBO object in an XmlElement
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
            OnEmbroideryImageBOIDChanged();
        }
        
        partial void OnIDChanging(int value)
        {
            if (value < 0)
            {
                throw new Exception(String.Format("EmbroideryImageBO.ID must be more than or equal to 0. The supplied value was {0}.", value));
            }
            OnEmbroideryImageBOIDChanging(value);
        }
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnEmbroideryImageBOIDChanged();
        partial void OnEmbroideryImageBOIDChanging(int value);
        
        partial void OnEmbroideryDetailsChanged()
        {
            OnEmbroideryImageBOEmbroideryDetailsChanged();
        }
        
        partial void OnEmbroideryDetailsChanging(int value)
        {
            if (value < 0)
            {
                throw new Exception(String.Format("EmbroideryImageBO.EmbroideryDetails must be more than or equal to 0. The supplied value was {0}.", value));
            }
            OnEmbroideryImageBOEmbroideryDetailsChanging(value);
        }
        partial void OnEmbroideryDetailsChanged();
        partial void OnEmbroideryDetailsChanging(int value);
        partial void OnEmbroideryImageBOEmbroideryDetailsChanged();
        partial void OnEmbroideryImageBOEmbroideryDetailsChanging(int value);
        
        partial void OnSizeChanged()
        {
            OnEmbroideryImageBOSizeChanged();
        }
        
        partial void OnSizeChanging(int value)
        {
            OnEmbroideryImageBOSizeChanging(value);
        }
        partial void OnSizeChanged();
        partial void OnSizeChanging(int value);
        partial void OnEmbroideryImageBOSizeChanged();
        partial void OnEmbroideryImageBOSizeChanging(int value);
        
        partial void OnFilenameChanged()
        {
            OnEmbroideryImageBOFilenameChanged();
        }
        
        partial void OnFilenameChanging(string value)
        {
            if (value != null && value.Length > 255)
            {
                throw new Exception(String.Format("EmbroideryImageBO.Filename has a maximum length of 255. The supplied value \"{0}\" has a length of {1}", value, value.Length));
            }
            OnEmbroideryImageBOFilenameChanging(value);
        }
        partial void OnFilenameChanged();
        partial void OnFilenameChanging(string value);
        partial void OnEmbroideryImageBOFilenameChanged();
        partial void OnEmbroideryImageBOFilenameChanging(string value);
        
        partial void OnExtensionChanged()
        {
            OnEmbroideryImageBOExtensionChanged();
        }
        
        partial void OnExtensionChanging(string value)
        {
            if (value != null && value.Length > 10)
            {
                throw new Exception(String.Format("EmbroideryImageBO.Extension has a maximum length of 10. The supplied value \"{0}\" has a length of {1}", value, value.Length));
            }
            OnEmbroideryImageBOExtensionChanging(value);
        }
        partial void OnExtensionChanged();
        partial void OnExtensionChanging(string value);
        partial void OnEmbroideryImageBOExtensionChanged();
        partial void OnEmbroideryImageBOExtensionChanging(string value);
        
        partial void OnIsRequestedChanged()
        {
            OnEmbroideryImageBOIsRequestedChanged();
        }
        
        partial void OnIsRequestedChanging(bool value)
        {
            OnEmbroideryImageBOIsRequestedChanging(value);
        }
        partial void OnIsRequestedChanged();
        partial void OnIsRequestedChanging(bool value);
        partial void OnEmbroideryImageBOIsRequestedChanged();
        partial void OnEmbroideryImageBOIsRequestedChanging(bool value);
        
        #endregion
        
        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (!(obj is Indico.BusinessObjects.EmbroideryImageBO))
                return 1;
            Indico.BusinessObjects.EmbroideryImageBOComparer c = new Indico.BusinessObjects.EmbroideryImageBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.EmbroideryImageBO);
        }

        #endregion
        #endregion
        
        #region Events
        
        void obj_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ID")
            {
                // reload me
                this.SetBO((Indico.DAL.EmbroideryImage)sender);
            }
        }
        
        void Context_OnSendBeforeChanges(object sender, EventArgs e)
        {        
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
    
    #region EmbroideryImageBOComparer
    public class EmbroideryImageBOComparer : IComparer<Indico.BusinessObjects.EmbroideryImageBO>
    {
        private string propertyToCompareName;
        public EmbroideryImageBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.EmbroideryImageBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.EmbroideryImageBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public EmbroideryImageBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.EmbroideryImageBO> Members
        public int Compare(Indico.BusinessObjects.EmbroideryImageBO x, Indico.BusinessObjects.EmbroideryImageBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.EmbroideryImageBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.EmbroideryImageBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.EmbroideryImageBO x, Indico.BusinessObjects.EmbroideryImageBO y)
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
