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
    public partial class PageBO : BusinessObject, IComparable
    {
        #region fields
        #region Scalar Fields
        private int id;
        private string _heading = string.Empty;
        private string _name = string.Empty;
        private string _title = string.Empty;
        #endregion
        
        #region Foreign Key fields
        #endregion
        
        #region Foreign Table Foreign Key fields
        [NonSerialized][XmlIgnoreAttribute]
        private IndicoList<Indico.BusinessObjects.MenuItemBO> menuItemsWhereThisIsPageList;
        [NonSerialized][XmlIgnoreAttribute]
        private bool _menuItemsWhereThisIsPageLoaded;
        #endregion
        
        #region Other fields
        
        private Indico.DAL.Page _objDAL = null;
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
        
        /// <summary>The Heading of the Page. The maximum length of this property is 128.</summary>
        public string Heading
        {   
            get {return _heading;}
            set 
            {
                OnHeadingChanging(value);
                _heading = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.Heading = value;
                }
                OnHeadingChanged();
            }
        }
        /// <summary>The Name of the Page. The maximum length of this property is 128.</summary>
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
        /// <summary>The Title of the Page. The maximum length of this property is 128.</summary>
        public string Title
        {   
            get {return _title;}
            set 
            {
                OnTitleChanging(value);
                _title = value;
                if (!this._doNotUpdateDALObject && this.Context != null && this.ObjDAL != null){
                    this.ObjDAL.Title = value;
                }
                OnTitleChanged();
            }
        }
        
        internal Indico.DAL.Page ObjDAL
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
        public IndicoList<Indico.BusinessObjects.MenuItemBO> MenuItemsWhereThisIsPage // FK_MenuItem_Page
        {
            get
            {
                if (!_menuItemsWhereThisIsPageLoaded)
                {
                    _menuItemsWhereThisIsPageLoaded = true;
                    if (this.ID > 0)
                    {
                         IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
                        Indico.DAL.Page obj = (from o in context.Page
                                     where o.ID == this.ID
                                     select o).FirstOrDefault();

                        obj.MenuItemsWhereThisIsPage.Load();
                        menuItemsWhereThisIsPageList = new IndicoList<Indico.BusinessObjects.MenuItemBO>(obj.MenuItemsWhereThisIsPage.Count);
                        
                        foreach (Indico.DAL.MenuItem o in obj.MenuItemsWhereThisIsPage)
                        {
                            Indico.BusinessObjects.MenuItemBO fkObj = new Indico.BusinessObjects.MenuItemBO(o, ref this._context);
                            menuItemsWhereThisIsPageList.Add(fkObj);
                        }
                        
                        if (this.Context == null)
                        {
                            context.Dispose();
                        }
                    }
                    else
                    {
                        menuItemsWhereThisIsPageList = new IndicoList<Indico.BusinessObjects.MenuItemBO>();
                    }
                    
                    menuItemsWhereThisIsPageList.OnBeforeRemove += new EventHandler(MenuItemsWhereThisIsPageList_OnBeforeRemove);
                    menuItemsWhereThisIsPageList.OnAfterAdd += new EventHandler(MenuItemsWhereThisIsPageList_OnAfterAdd);
                }
                
                return menuItemsWhereThisIsPageList;
            }
        }
        #endregion
        
        #endregion
        
        #region Internal Constructors
        /// <summary>
        /// Creates an instance of the PageBO class using the supplied Indico.DAL.Page. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.Page whose properties will be used to initialise the PageBO</param>
        internal PageBO(Indico.DAL.Page obj, ref IndicoContext context)
        {
            this._doNotUpdateDALObject = true;
            
            this.Context = context;
        
            // set the properties from the Indico.DAL.Page 
            this.ID = obj.ID;
            
            this.Heading = obj.Heading;
            this.Name = obj.Name;
            this.Title = obj.Title;
            
            this._doNotUpdateDALObject = false;
        }
        #endregion
        
        #region Internal utility methods
        internal Indico.DAL.Page SetDAL(IndicoEntities context)
        {
            this._doNotUpdateDALObject = true;
        
            // set the Indico.DAL.Page properties
            Indico.DAL.Page obj = new Indico.DAL.Page();
            
            if (this.ID > 0)
            {
                obj = context.Page.FirstOrDefault<Page>(o => o.ID == this.ID);
            }
            
            obj.Heading = this.Heading;
            obj.Name = this.Name;
            obj.Title = this.Title;
            
            
            if (_menuItemsWhereThisIsPageLoaded)
                BusinessObject.SynchroniseEntityList(
                    Indico.BusinessObjects.MenuItemBO.ToEntityList(this.MenuItemsWhereThisIsPage, context), 
                    obj.MenuItemsWhereThisIsPage);
            
            this._doNotUpdateDALObject = false;
            
            return obj;
        }
        
        internal void SetBO(System.Data.Objects.DataClasses.EntityObject eObj)
        {
            this._doNotUpdateDALObject = true;
            
            // Check the received type
            if (eObj.GetType() != typeof(Indico.DAL.Page))
            {
                throw new FormatException("Received wrong parameter type...");
            }

            Indico.DAL.Page obj = (Indico.DAL.Page)eObj;
            
            // set the Indico.BusinessObjects.PageBO properties
            this.ID = obj.ID;
            
            this.Heading = obj.Heading;
            this.Name = obj.Name;
            this.Title = obj.Title;
            
            
            this._doNotUpdateDALObject = false;
        }
        
        internal void SetBO(Indico.BusinessObjects.PageBO obj)
        {
            this._doNotUpdateDALObject = true;
            
            // set this Indico.BusinessObjects.PageBO properties
            this.ID = obj.ID;
            
            this.Heading = obj.Heading;
            this.Name = obj.Name;
            this.Title = obj.Title;
            
            this._doNotUpdateDALObject = false;
        }
        
        internal List<Indico.BusinessObjects.PageBO> IQueryableToList(IQueryable<Indico.DAL.Page> oQuery)
        {
            List<Indico.DAL.Page> oList = oQuery.ToList();
            List<Indico.BusinessObjects.PageBO> rList = new List<Indico.BusinessObjects.PageBO>(oList.Count);
            foreach (Indico.DAL.Page o in oList)
            {
                Indico.BusinessObjects.PageBO obj = new Indico.BusinessObjects.PageBO(o, ref this._context);
                rList.Add(obj);
            }
            return rList;
        }
        
        internal List<Indico.BusinessObjects.PageBO> ToList(IEnumerable<Indico.DAL.Page> oQuery)
        {
            List<Indico.DAL.Page> oList = oQuery.ToList();
            List<Indico.BusinessObjects.PageBO> rList = new List<Indico.BusinessObjects.PageBO>(oList.Count);
            foreach (Indico.DAL.Page o in oList)
            {
                Indico.BusinessObjects.PageBO obj = new Indico.BusinessObjects.PageBO(o, ref this._context);
                rList.Add(obj);
            }
            return rList;
        }
        
        internal static List<Indico.DAL.Page> ToEntityList(List<PageBO> bos, IndicoEntities context)
        {
            // build a List of Page entities from the business objects
            List<Int32> ids = (from o in bos
                                   select o.ID).ToList<Int32>();

            return (context.Page.Count() == 0) ? new List<Indico.DAL.Page>() : (context.Page.Where(BuildContainsExpression<Page, int>(e => e.ID, ids)))
                .ToList<Indico.DAL.Page>();
        }
        
        internal static System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.Page> ToEntityCollection(List<PageBO> bos, IndicoEntities context)
        {
            // build an EntityCollection of Page entities from the business objects
            List<Int32> ids = (from o in bos
                               select o.ID).ToList<Int32>();

            List<Indico.DAL.Page> el = (context.Page.Count() == 0) ? new List<Indico.DAL.Page>() : 
                context.Page.Where(BuildContainsExpression<Page, int>(e => e.ID, ids))
                .ToList<Indico.DAL.Page>();
                
            System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.Page> ec 
                = new System.Data.Objects.DataClasses.EntityCollection<Indico.DAL.Page>();
                
            foreach (Indico.DAL.Page r in el) 
            {
                ec.Add(r);
            }
            return ec;
        }

        internal Indico.DAL.Page ToEntity(IndicoEntities context)
        {
            return (from o in context.Page
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
                this.Context.Context.AddToPage(this.ObjDAL);
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                Indico.DAL.Page obj = this.SetDAL(objContext.Context);
                objContext.Context.AddToPage(obj);
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
                    Indico.DAL.Page obj = this.SetDAL(this.Context.Context);
                    this.Context.Context.DeleteObject(obj);
                }
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                Indico.DAL.Page obj = this.SetDAL(objContext.Context);
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
            Indico.BusinessObjects.PageBO data = null;
            
            if (blnCache)
            {
                data = this.GetFromCache(this.ID) as Indico.BusinessObjects.PageBO; 
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
                    IQueryable<Indico.DAL.Page> oQuery =
                        from o in context.Page
                        where o.ID == this.ID
                        select o;

                    List<Indico.DAL.Page> oList = oQuery.ToList();
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
        public List<Indico.BusinessObjects.PageBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public List<Indico.BusinessObjects.PageBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PageBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PageBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.Page> oQuery =
                (from o in context.Page
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

            List<Indico.BusinessObjects.PageBO> pages = IQueryableToList(oQuery);
            context.Dispose();
            return pages;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.PageBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.PageBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PageBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PageBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.Page> oQuery =
                (from o in context.Page
                 where
                    (this.ID == 0 || this.ID == o.ID) &&
                    (this.Name == string.Empty || this.Name == o.Name) &&
                    (this.Title == string.Empty || this.Title == o.Title) &&
                    (this.Heading == string.Empty || this.Heading == o.Heading) 
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

            List<Indico.BusinessObjects.PageBO> pages = IQueryableToList(oQuery);
            
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return pages;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.Page
                 where
                    (this.ID == 0 || this.ID == o.ID) &&
                    (this.Name == string.Empty || this.Name == o.Name) &&
                    (this.Title == string.Empty || this.Title == o.Title) &&
                    (this.Heading == string.Empty || this.Heading == o.Heading) 
                 orderby o.ID
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.PageBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.PageBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PageBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PageBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.Page> oQuery =
                (from o in context.Page
                 where
                    (this.ID == 0 || o.ID == this.ID) &&
                    (this.Name == string.Empty || o.Name.Contains(this.Name)) &&
                    (this.Title == string.Empty || o.Title.Contains(this.Title)) &&
                    (this.Heading == string.Empty || o.Heading.Contains(this.Heading)) 
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

            List<Indico.BusinessObjects.PageBO> pages = IQueryableToList(oQuery);
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return pages;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.Page
                 where
                    (this.ID == 0 || o.ID == this.ID) &&
                    (this.Name == string.Empty || o.Name.Contains(this.Name)) &&
                    (this.Title == string.Empty || o.Title.Contains(this.Title)) &&
                    (this.Heading == string.Empty || o.Heading.Contains(this.Heading)) 
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.PageBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.PageBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PageBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PageBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            IQueryable<Indico.DAL.Page> oQuery =
                (from o in context.Page
                 where
                    (this.ID == 0 || this.ID == o.ID) && 
                    ((o.Name.Contains(this.Name)) ||
                    (o.Title.Contains(this.Title)) ||
                    (o.Heading.Contains(this.Heading)) ||
                    (this.Name == null && this.Title == null && this.Heading == null ))
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

            List<Indico.BusinessObjects.PageBO> pages = IQueryableToList(oQuery);
            if (this.Context == null)
            {
                context.Dispose();
            }
            
            return pages;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = (this.Context != null) ? this.Context.Context : new IndicoEntities();
            return (from o in context.Page
                 where
                    (this.ID == 0 || this.ID == o.ID) && 
                    ((o.Name.Contains(this.Name)) ||
                    (o.Title.Contains(this.Title)) ||
                    (o.Heading.Contains(this.Heading)) ||
                    (this.Name == null && this.Title == null && this.Heading == null ))
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region Serialization methods
        /// <summary>
        /// Serializes the Indico.BusinessObjects.PageBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.PageBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.PageBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.PageBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.PageBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.PageBO object in an XmlElement
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
            OnPageBOIDChanged();
        }
        
        partial void OnIDChanging(int value)
        {
            if (value < 0)
            {
                throw new Exception(String.Format("PageBO.ID must be more than or equal to 0. The supplied value was {0}.", value));
            }
            OnPageBOIDChanging(value);
        }
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnPageBOIDChanged();
        partial void OnPageBOIDChanging(int value);
        
        partial void OnNameChanged()
        {
            OnPageBONameChanged();
        }
        
        partial void OnNameChanging(string value)
        {
            if (value != null && value.Length > 128)
            {
                throw new Exception(String.Format("PageBO.Name has a maximum length of 128. The supplied value \"{0}\" has a length of {1}", value, value.Length));
            }
            OnPageBONameChanging(value);
        }
        partial void OnNameChanged();
        partial void OnNameChanging(string value);
        partial void OnPageBONameChanged();
        partial void OnPageBONameChanging(string value);
        
        partial void OnTitleChanged()
        {
            OnPageBOTitleChanged();
        }
        
        partial void OnTitleChanging(string value)
        {
            if (value != null && value.Length > 128)
            {
                throw new Exception(String.Format("PageBO.Title has a maximum length of 128. The supplied value \"{0}\" has a length of {1}", value, value.Length));
            }
            OnPageBOTitleChanging(value);
        }
        partial void OnTitleChanged();
        partial void OnTitleChanging(string value);
        partial void OnPageBOTitleChanged();
        partial void OnPageBOTitleChanging(string value);
        
        partial void OnHeadingChanged()
        {
            OnPageBOHeadingChanged();
        }
        
        partial void OnHeadingChanging(string value)
        {
            if (value != null && value.Length > 128)
            {
                throw new Exception(String.Format("PageBO.Heading has a maximum length of 128. The supplied value \"{0}\" has a length of {1}", value, value.Length));
            }
            OnPageBOHeadingChanging(value);
        }
        partial void OnHeadingChanged();
        partial void OnHeadingChanging(string value);
        partial void OnPageBOHeadingChanged();
        partial void OnPageBOHeadingChanging(string value);
        
        #endregion
        
        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (!(obj is Indico.BusinessObjects.PageBO))
                return 1;
            Indico.BusinessObjects.PageBOComparer c = new Indico.BusinessObjects.PageBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.PageBO);
        }

        #endregion
        #endregion
        
        #region Events
        
        void obj_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ID")
            {
                // reload me
                this.SetBO((Indico.DAL.Page)sender);
            }
        }
        
        void MenuItemsWhereThisIsPageList_OnAfterAdd(object sender, EventArgs e)
        {
            Indico.DAL.MenuItem obj = null;
            if (this.Context != null)
            {
                if (((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender).Count > 0)
                {
                    obj = ((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender)[((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender).Count - 1].ObjDAL;
                    this.ObjDAL.MenuItemsWhereThisIsPage.Add(obj);
                }
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                obj = ((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender)[((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender).Count - 1].SetDAL(objContext.Context);
                this.ObjDAL.MenuItemsWhereThisIsPage.Add(obj);
                objContext.SaveChanges();
                objContext.Dispose();
            }
        }
        
        void MenuItemsWhereThisIsPageList_OnBeforeRemove(object sender, EventArgs e)
        {
            Indico.DAL.MenuItem obj = null;
            if (this.Context != null)
            {
                if (((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender).Count > 0)
                {
                    obj = ((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender)[((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender).Count - 1].ObjDAL;
                    this.ObjDAL.MenuItemsWhereThisIsPage.Remove(obj);
                }
            }
            else
            {
                IndicoContext objContext = new IndicoContext();
                obj = ((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender)[((IndicoList<Indico.BusinessObjects.MenuItemBO>)sender).Count - 1].SetDAL(objContext.Context);
                this.ObjDAL.MenuItemsWhereThisIsPage.Remove(obj);
                objContext.SaveChanges();
                objContext.Dispose();
            }
        }
        
        void Context_OnSendBeforeChanges(object sender, EventArgs e)
        {        
            this._menuItemsWhereThisIsPageLoaded = false;
            if (this.menuItemsWhereThisIsPageList != null)
            {
                this.menuItemsWhereThisIsPageList.OnBeforeRemove -= new EventHandler(MenuItemsWhereThisIsPageList_OnBeforeRemove);
                this.menuItemsWhereThisIsPageList.OnAfterAdd -= new EventHandler(MenuItemsWhereThisIsPageList_OnAfterAdd);
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
    
    #region PageBOComparer
    public class PageBOComparer : IComparer<Indico.BusinessObjects.PageBO>
    {
        private string propertyToCompareName;
        public PageBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.PageBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.PageBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public PageBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.PageBO> Members
        public int Compare(Indico.BusinessObjects.PageBO x, Indico.BusinessObjects.PageBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.PageBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.PageBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.PageBO x, Indico.BusinessObjects.PageBO y)
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
