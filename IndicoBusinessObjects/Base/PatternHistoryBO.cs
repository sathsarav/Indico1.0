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
    public partial class PatternHistoryBO : BusinessObject, IComparable
    {
        #region fields
        #region Scalar Fields
        private int id;
        private string _meassage;
        private DateTime _modifiedDate = DateTime.MinValue;
        private int _modifier;
        private int _pattern;
        #endregion
        
        #region Foreign Key fields
        [NonSerialized][XmlIgnoreAttribute]
        private Indico.BusinessObjects.UserBO _objModifier;
        [NonSerialized][XmlIgnoreAttribute]
        private Indico.BusinessObjects.PatternBO _objPattern;
        #endregion
        
        #region Foreign Table Foreign Key fields
        #endregion
        
        #region Other fields
        
        private Indico.DAL.PatternHistory _objDAL = null;
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
        
        /// <summary>. The maximum length of this property is 1000.</summary>
        public string Meassage
        {   
            get {return _meassage;}
            set 
            {
                OnMeassageChanging(value);
                _meassage = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.Meassage = value;
                }
                OnMeassageChanged();
            }
        }
        /// <summary>.</summary>
        public DateTime ModifiedDate
        {   
            get {return _modifiedDate;}
            set 
            {
                OnModifiedDateChanging(value);
                _modifiedDate = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.ModifiedDate = value;
                }
                OnModifiedDateChanged();
            }
        }
        /// <summary>.</summary>
        public int Modifier
        {   
            get {return _modifier;}
            set 
            {
                OnModifierChanging(value);
                _modifier = value;
                if (!this._doNotUpdateDALObject && this._context != null && this.ObjDAL != null && ((int)value != 0))
                {
                    this.ObjDAL.Modifier = (from o in this._context.Context.User
                                           where o.ID == (int)value
                                           select o).ToList<Indico.DAL.User>()[0];
                }
                else if (!this._doNotUpdateDALObject && this._context != null && this.ObjDAL != null && (int)value == 0)
                    this.ObjDAL.Modifier = null;
                OnModifierChanged();
            }
        }
        /// <summary>.</summary>
        public int Pattern
        {   
            get {return _pattern;}
            set 
            {
                OnPatternChanging(value);
                _pattern = value;
                if (!this._doNotUpdateDALObject && this._context != null && this.ObjDAL != null && ((int)value != 0))
                {
                    this.ObjDAL.Pattern = (from o in this._context.Context.Pattern
                                           where o.ID == (int)value
                                           select o).ToList<Indico.DAL.Pattern>()[0];
                }
                else if (!this._doNotUpdateDALObject && this._context != null && this.ObjDAL != null && (int)value == 0)
                    this.ObjDAL.Pattern = null;
                OnPatternChanged();
            }
        }
        
        internal Indico.DAL.PatternHistory ObjDAL
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
        ///<summary>The UserBO object identified by the value of Modifier</summary>
        [XmlIgnoreAttribute]
        public Indico.BusinessObjects.UserBO objModifier
        {
            get
            {
                if ( _modifier > 0 && _objModifier == null)
                {
                        if (this._context == null)
                        {
                            _objModifier = new Indico.BusinessObjects.UserBO();
                        }
                        else
                        {
                            _objModifier = new Indico.BusinessObjects.UserBO(ref this._context);
                        }
                        _objModifier.ID = _modifier;
                        _objModifier.GetObject(); 
                }
                return _objModifier;
            }
            set
            { 
                _objModifier = value;
                _modifier = _objModifier.ID;
            }
        }
        ///<summary>The PatternBO object identified by the value of Pattern</summary>
        [XmlIgnoreAttribute]
        public Indico.BusinessObjects.PatternBO objPattern
        {
            get
            {
                if ( _pattern > 0 && _objPattern == null)
                {
                        if (this._context == null)
                        {
                            _objPattern = new Indico.BusinessObjects.PatternBO();
                        }
                        else
                        {
                            _objPattern = new Indico.BusinessObjects.PatternBO(ref this._context);
                        }
                        _objPattern.ID = _pattern;
                        _objPattern.GetObject(); 
                }
                return _objPattern;
            }
            set
            { 
                _objPattern = value;
                _pattern = _objPattern.ID;
            }
        }
        #endregion
        
        #region Foreign Object Foreign Key Collections
        #endregion
        
        #endregion
        
        #region Internal Constructors
        /// <summary>
        /// Creates an instance of the PatternHistoryBO class using the supplied Indico.DAL.PatternHistory. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.PatternHistory whose properties will be used to initialise the PatternHistoryBO</param>
        internal PatternHistoryBO(Indico.DAL.PatternHistory obj, ref IndicoContext context)
        {
            this._doNotUpdateDALObject = true;
            
            this.Context = context;
        
            // set the properties from the Indico.DAL.PatternHistory 
            this.ID = obj.ID;
            
            this.Meassage = obj.Meassage;
            this.ModifiedDate = obj.ModifiedDate;
            this.Modifier = (obj.ModifierReference.EntityKey != null && obj.ModifierReference.EntityKey.EntityKeyValues.Count() > 0)
                ? (int)((System.Data.EntityKeyMember)obj.ModifierReference.EntityKey.EntityKeyValues.GetValue(0)).Value
                : 0;
            this.Pattern = (obj.PatternReference.EntityKey != null && obj.PatternReference.EntityKey.EntityKeyValues.Count() > 0)
                ? (int)((System.Data.EntityKeyMember)obj.PatternReference.EntityKey.EntityKeyValues.GetValue(0)).Value
                : 0;
            
            this._doNotUpdateDALObject = false;
        }
        #endregion
        
        #region Internal utility methods
        internal Indico.DAL.PatternHistory SetDAL(IndicoEntities context)
        {
            this._doNotUpdateDALObject = true;
        
            // set the Indico.DAL.PatternHistory properties
            Indico.DAL.PatternHistory obj = new Indico.DAL.PatternHistory();
            
            if (this.ID > 0)
            {
                obj = context.PatternHistory.FirstOrDefault<PatternHistory>(o => o.ID == this.ID);
            }
            
            obj.Meassage = this.Meassage;
            obj.ModifiedDate = this.ModifiedDate;
            
            if (this.Modifier > 0) obj.Modifier = context.User.FirstOrDefault(o => o.ID == this.Modifier);
            if (this.Pattern > 0) obj.Pattern = context.Pattern.FirstOrDefault(o => o.ID == this.Pattern);
            
            
            this._doNotUpdateDALObject = false;
            
            return obj;
        }
        
        internal void SetBO(System.Data.Objects.DataClasses.EntityObject eObj)
        {
            this._doNotUpdateDALObject = true;
            
            // Check the received type
            if (eObj.GetType() != typeof(Indico.DAL.PatternHistory))
            {
                throw new FormatException("Received wrong parameter type...");
            }

            Indico.DAL.PatternHistory obj = (Indico.DAL.PatternHistory)eObj;
            
            // set the Indico.BusinessObjects.PatternHistoryBO properties
            this.ID = obj.ID;
            
            this.Meassage = obj.Meassage;
            this.ModifiedDate = obj.ModifiedDate;
            
            this.Modifier = (obj.ModifierReference.EntityKey != null && obj.ModifierReference.EntityKey.EntityKeyValues.Count() > 0)
                ? (int)((System.Data.EntityKeyMember)obj.ModifierReference.EntityKey.EntityKeyValues.GetValue(0)).Value
                : 0;
            this.Pattern = (obj.PatternReference.EntityKey != null && obj.PatternReference.EntityKey.EntityKeyValues.Count() > 0)
                ? (int)((System.Data.EntityKeyMember)obj.PatternReference.EntityKey.EntityKeyValues.GetValue(0)).Value
                : 0;
            
            this._doNotUpdateDALObject = false;
        }
        
        internal void SetBO(Indico.BusinessObjects.PatternHistoryBO obj)
        {
            this._doNotUpdateDALObject = true;
            
            // set this Indico.BusinessObjects.PatternHistoryBO properties
            this.ID = obj.ID;
            
            this.Meassage = obj.Meassage;
            this.ModifiedDate = obj.ModifiedDate;
            this.Modifier = obj.Modifier;
            this.Pattern = obj.Pattern;
            
            this._doNotUpdateDALObject = false;
        }
        
        internal List<Indico.BusinessObjects.PatternHistoryBO> IQueryableToList(IQueryable<Indico.DAL.PatternHistory> oQuery)
        {
            List<Indico.DAL.PatternHistory> oList = oQuery.ToList();
            List<Indico.BusinessObjects.PatternHistoryBO> rList = new List<Indico.BusinessObjects.PatternHistoryBO>(oList.Count);
            foreach (Indico.DAL.PatternHistory o in oList)
            {
                Indico.BusinessObjects.PatternHistoryBO obj = new Indico.BusinessObjects.PatternHistoryBO(o, ref this._context);
                rList.Add(obj);
            }
            return rList;
        }
        
        internal List<Indico.BusinessObjects.PatternHistoryBO> ToList(IEnumerable<Indico.DAL.PatternHistory> oQuery)
        {
            List<Indico.DAL.PatternHistory> oList = oQuery.ToList();
            List<Indico.BusinessObjects.PatternHistoryBO> rList = new List<Indico.BusinessObjects.PatternHistoryBO>(oList.Count);
            foreach (Indico.DAL.PatternHistory o in oList)
            {
                Indico.BusinessObjects.PatternHistoryBO obj = new Indico.BusinessObjects.PatternHistoryBO(o, ref this._context);
                rList.Add(obj);
            }
            return rList;
        }
        
        internal static List<Indico.DAL.PatternHistory> ToEntityList(List<PatternHistoryBO> bos, IndicoEntities context)
        {
            // build a List of PatternHistory entities from the business objects
            List<Int32> ids = (from o in bos
                                   select o.ID).ToList<Int32>();

            return (context.PatternHistory.Count() == 0) ? new List<Indico.DAL.PatternHistory>() : (context.PatternHistory.Where(BuildContainsExpression<PatternHistory, int>(e => e.ID, ids)))
                .ToList<Indico.DAL.PatternHistory>();
        }
        
        internal static System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.PatternHistory> ToEntityCollection(List<PatternHistoryBO> bos, IndicoEntities context)
        {
            // build an EntityCollection of PatternHistory entities from the business objects
            List<Int32> ids = (from o in bos
                               select o.ID).ToList<Int32>();

            List<Indico.DAL.PatternHistory> el = (context.PatternHistory.Count() == 0) ? new List<Indico.DAL.PatternHistory>() : 
                context.PatternHistory.Where(BuildContainsExpression<PatternHistory, int>(e => e.ID, ids))
                .ToList<Indico.DAL.PatternHistory>();
                
            System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.PatternHistory> ec 
                = new System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.PatternHistory>();
                
            foreach (Indico.DAL.PatternHistory r in el) 
            {
                ec.Add(r);
            }
            return ec;
        }

        internal Indico.DAL.PatternHistory ToEntity(IndicoEntities context)
        {
            return (from o in context.PatternHistory
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
                this.Context.Context.AddToPatternHistory(this.ObjDAL);
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                Indico.DAL.PatternHistory obj = this.SetDAL(objContext.Context);
                objContext.Context.AddToPatternHistory(obj);
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
                    Indico.DAL.PatternHistory obj = this.SetDAL(this.Context.Context);
                    this.Context.Context.DeleteObject(obj);
                }
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                Indico.DAL.PatternHistory obj = this.SetDAL(objContext.Context);
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
            Indico.BusinessObjects.PatternHistoryBO data = null;
            
            if (blnCache)
            {
                data = this.GetFromCache(this.ID) as Indico.BusinessObjects.PatternHistoryBO; 
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
                    IQueryable<Indico.DAL.PatternHistory> oQuery =
                        from o in context.PatternHistory
                        where o.ID == this.ID
                        select o;

                    List<Indico.DAL.PatternHistory> oList = oQuery.ToList();
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
        public List<Indico.BusinessObjects.PatternHistoryBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.PatternHistory> oQuery =
                (from o in context.PatternHistory
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

            List<Indico.BusinessObjects.PatternHistoryBO> patternhistorys = IQueryableToList(oQuery);
            context.Dispose();
            return patternhistorys;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.PatternHistory> oQuery =
                (from o in context.PatternHistory
                 where
                    (this.ID == 0 || this.ID == o.ID) &&
                    (this.Pattern == 0 || this.Pattern == o.Pattern.ID) &&
                    (this.Modifier == 0 || this.Modifier == o.Modifier.ID) &&
                    (this.ModifiedDate == DateTime.MinValue || this.ModifiedDate == o.ModifiedDate) &&
                    (this.Meassage == null || this.Meassage == o.Meassage) 
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

            List<Indico.BusinessObjects.PatternHistoryBO> patternhistorys = IQueryableToList(oQuery);
            
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return patternhistorys;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.PatternHistory
                 where
                    (this.ID == 0 || this.ID == o.ID) &&
                    (this.Pattern == 0 || this.Pattern == o.Pattern.ID) &&
                    (this.Modifier == 0 || this.Modifier == o.Modifier.ID) &&
                    (this.ModifiedDate == DateTime.MinValue || this.ModifiedDate == o.ModifiedDate) &&
                    (this.Meassage == null || this.Meassage == o.Meassage) 
                 orderby o.ID
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.PatternHistory> oQuery =
                (from o in context.PatternHistory
                 where
                    (this.ID == 0 || o.ID == this.ID) &&
                    (this.Pattern == 0 || o.Pattern.ID == this.Pattern) &&
                    (this.Modifier == 0 || o.Modifier.ID == this.Modifier) &&
                    (this.ModifiedDate == DateTime.MinValue || o.ModifiedDate == this.ModifiedDate) &&
                    (this.Meassage == null || o.Meassage.Contains(this.Meassage)) 
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

            List<Indico.BusinessObjects.PatternHistoryBO> patternhistorys = IQueryableToList(oQuery);
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return patternhistorys;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.PatternHistory
                 where
                    (this.ID == 0 || o.ID == this.ID) &&
                    (this.Pattern == 0 || o.Pattern.ID == this.Pattern) &&
                    (this.Modifier == 0 || o.Modifier.ID == this.Modifier) &&
                    (this.ModifiedDate == DateTime.MinValue || o.ModifiedDate == this.ModifiedDate) &&
                    (this.Meassage == null || o.Meassage.Contains(this.Meassage)) 
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PatternHistoryBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.PatternHistory> oQuery =
                (from o in context.PatternHistory
                 where
                    (this.ID == 0 || this.ID == o.ID) && 
                    (this.Pattern == 0 || this.Pattern == o.Pattern.ID) && 
                    (this.Modifier == 0 || this.Modifier == o.Modifier.ID) && 
                    (this.ModifiedDate == DateTime.MinValue || this.ModifiedDate == o.ModifiedDate) && 
                    ((o.Meassage.Contains(this.Meassage)) ||
                    (this.Meassage == null ))
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

            List<Indico.BusinessObjects.PatternHistoryBO> patternhistorys = IQueryableToList(oQuery);
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return patternhistorys;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.PatternHistory
                 where
                    (this.ID == 0 || this.ID == o.ID) && 
                    (this.Pattern == 0 || this.Pattern == o.Pattern.ID) && 
                    (this.Modifier == 0 || this.Modifier == o.Modifier.ID) && 
                    (this.ModifiedDate == DateTime.MinValue || this.ModifiedDate == o.ModifiedDate) && 
                    ((o.Meassage.Contains(this.Meassage)) ||
                    (this.Meassage == null ))
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region Serialization methods
        /// <summary>
        /// Serializes the Indico.BusinessObjects.PatternHistoryBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.PatternHistoryBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.PatternHistoryBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.PatternHistoryBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.PatternHistoryBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.PatternHistoryBO object in an XmlElement
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
            OnPatternHistoryBOIDChanged();
        }
        
        partial void OnIDChanging(int value)
        {
            if (value < 0)
            {
                throw new Exception(String.Format("PatternHistoryBO.ID must be more than or equal to 0. The supplied value was {0}.", value));
            }
            OnPatternHistoryBOIDChanging(value);
        }
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnPatternHistoryBOIDChanged();
        partial void OnPatternHistoryBOIDChanging(int value);
        
        partial void OnPatternChanged()
        {
            OnPatternHistoryBOPatternChanged();
        }
        
        partial void OnPatternChanging(int value)
        {
            if (value < 0)
            {
                throw new Exception(String.Format("PatternHistoryBO.Pattern must be more than or equal to 0. The supplied value was {0}.", value));
            }
            OnPatternHistoryBOPatternChanging(value);
        }
        partial void OnPatternChanged();
        partial void OnPatternChanging(int value);
        partial void OnPatternHistoryBOPatternChanged();
        partial void OnPatternHistoryBOPatternChanging(int value);
        
        partial void OnModifierChanged()
        {
            OnPatternHistoryBOModifierChanged();
        }
        
        partial void OnModifierChanging(int value)
        {
            if (value < 0)
            {
                throw new Exception(String.Format("PatternHistoryBO.Modifier must be more than or equal to 0. The supplied value was {0}.", value));
            }
            OnPatternHistoryBOModifierChanging(value);
        }
        partial void OnModifierChanged();
        partial void OnModifierChanging(int value);
        partial void OnPatternHistoryBOModifierChanged();
        partial void OnPatternHistoryBOModifierChanging(int value);
        
        partial void OnModifiedDateChanged()
        {
            OnPatternHistoryBOModifiedDateChanged();
        }
        
        partial void OnModifiedDateChanging(DateTime value)
        {
            OnPatternHistoryBOModifiedDateChanging(value);
        }
        partial void OnModifiedDateChanged();
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnPatternHistoryBOModifiedDateChanged();
        partial void OnPatternHistoryBOModifiedDateChanging(DateTime value);
        
        partial void OnMeassageChanged()
        {
            OnPatternHistoryBOMeassageChanged();
        }
        
        partial void OnMeassageChanging(string value)
        {
            if (value != null && value.Length > 1000)
            {
                throw new Exception(String.Format("PatternHistoryBO.Meassage has a maximum length of 1000. The supplied value \"{0}\" has a length of {1}", value, value.Length));
            }
            OnPatternHistoryBOMeassageChanging(value);
        }
        partial void OnMeassageChanged();
        partial void OnMeassageChanging(string value);
        partial void OnPatternHistoryBOMeassageChanged();
        partial void OnPatternHistoryBOMeassageChanging(string value);
        
        #endregion
        
        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (!(obj is Indico.BusinessObjects.PatternHistoryBO))
                return 1;
            Indico.BusinessObjects.PatternHistoryBOComparer c = new Indico.BusinessObjects.PatternHistoryBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.PatternHistoryBO);
        }

        #endregion
        #endregion
        
        #region Events
        
        void obj_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ID")
            {
                // reload me
                this.SetBO((Indico.DAL.PatternHistory)sender);
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
    
    #region PatternHistoryBOComparer
    public class PatternHistoryBOComparer : IComparer<Indico.BusinessObjects.PatternHistoryBO>
    {
        private string propertyToCompareName;
        public PatternHistoryBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.PatternHistoryBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.PatternHistoryBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public PatternHistoryBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.PatternHistoryBO> Members
        public int Compare(Indico.BusinessObjects.PatternHistoryBO x, Indico.BusinessObjects.PatternHistoryBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.PatternHistoryBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.PatternHistoryBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.PatternHistoryBO x, Indico.BusinessObjects.PatternHistoryBO y)
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
