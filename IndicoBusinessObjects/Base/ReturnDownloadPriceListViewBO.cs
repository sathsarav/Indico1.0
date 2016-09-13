// This file is generated by CodeSmith. Do not edit. All edits to this file will be lost. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Serialization;

//using Indico.BusinessObjects.Util;
//using Indico.BusinessObjects;
using Indico.DAL;


namespace Indico.BusinessObjects
{
    /// <summary>
    /// ReturnDownloadPriceListViewBO provides the business logic for maintaining Indico.DAL.ReturnDownloadPriceListView records in the data store.
    /// </summary>
    /// <remarks>
    /// ReturnDownloadPriceListViewBO provides the business logic for maintaining Indico.DAL.ReturnDownloadPriceListView records in the data store. 
    /// By default it provides basic Search methods for retrieving Indico.DAL.ReturnDownloadPriceListView
    /// records using the ReturnDownloadPriceListView DAL class. Other methods implement atomic chunks of Business Logic according to
    /// the business rules.
    /// </remarks>
    public partial class ReturnDownloadPriceListViewBO : BusinessObject, IComparable
    {
        #region fields
        private int? _distributor;
        private int? _label;
        private string _name;
        private string _priceTerm;
        private bool? _editedPrice;
        private decimal? _creativeDesign;
        private decimal? _studioDesign;
        private decimal? _thirdPartyDesign;
        private decimal? _position1;
        private decimal? _position2;
        private decimal? _position3;
        private string _fileName;
        private DateTime? _createdDate;
        #endregion
        
        #region Properties
        /// <summary></summary>
        public int? Distributor
        {   get {return _distributor;}
            set 
            {
                _distributor = value;
            }
        }
        /// <summary></summary>
        public int? Label
        {   get {return _label;}
            set 
            {
                _label = value;
            }
        }
        /// <summary></summary>
        public string Name
        {   get {return _name;}
            set 
            {
                _name = value;
            }
        }
        /// <summary></summary>
        public string PriceTerm
        {   get {return _priceTerm;}
            set 
            {
                _priceTerm = value;
            }
        }
        /// <summary></summary>
        public bool? EditedPrice
        {   get {return _editedPrice;}
            set 
            {
                _editedPrice = value;
            }
        }
        /// <summary></summary>
        public decimal? CreativeDesign
        {   get {return _creativeDesign;}
            set 
            {
                _creativeDesign = value;
            }
        }
        /// <summary></summary>
        public decimal? StudioDesign
        {   get {return _studioDesign;}
            set 
            {
                _studioDesign = value;
            }
        }
        /// <summary></summary>
        public decimal? ThirdPartyDesign
        {   get {return _thirdPartyDesign;}
            set 
            {
                _thirdPartyDesign = value;
            }
        }
        /// <summary></summary>
        public decimal? Position1
        {   get {return _position1;}
            set 
            {
                _position1 = value;
            }
        }
        /// <summary></summary>
        public decimal? Position2
        {   get {return _position2;}
            set 
            {
                _position2 = value;
            }
        }
        /// <summary></summary>
        public decimal? Position3
        {   get {return _position3;}
            set 
            {
                _position3 = value;
            }
        }
        /// <summary></summary>
        public string FileName
        {   get {return _fileName;}
            set 
            {
                _fileName = value;
            }
        }
        /// <summary></summary>
        public DateTime? CreatedDate
        {   get {return _createdDate;}
            set 
            {
                _createdDate = value;
            }
        }
        #endregion
        
        #region Internal Constructors
        /// <summary>
        /// Creates an instance of the ReturnDownloadPriceListViewBO class using the supplied Indico.DAL.ReturnDownloadPriceListView. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.ReturnDownloadPriceListView whose properties will be used to initialise the ReturnDownloadPriceListViewBO</param>
        internal ReturnDownloadPriceListViewBO(Indico.DAL.ReturnDownloadPriceListView obj)
        {
            // set the properties from the Indico.DAL.ReturnDownloadPriceListView 
            this.Distributor = obj.Distributor;
            this.Label = obj.Label;
            this.Name = obj.Name;
            this.PriceTerm = obj.PriceTerm;
            this.EditedPrice = obj.EditedPrice;
            this.CreativeDesign = obj.CreativeDesign;
            this.StudioDesign = obj.StudioDesign;
            this.ThirdPartyDesign = obj.ThirdPartyDesign;
            this.Position1 = obj.Position1;
            this.Position2 = obj.Position2;
            this.Position3 = obj.Position3;
            this.FileName = obj.FileName;
            this.CreatedDate = obj.CreatedDate;
        }
        #endregion
        
        #region Internal utility methods
        internal void SetDAL(Indico.DAL.ReturnDownloadPriceListView obj, IndicoEntities context)
        {
            // set the Indico.DAL.ReturnDownloadPriceListView properties
            obj.Distributor = Convert.ToInt32(Distributor);
            obj.Label = Convert.ToInt32(Label);
            obj.Name = Name;
            obj.PriceTerm = PriceTerm;
            obj.EditedPrice = Convert.ToBoolean(EditedPrice);
            obj.CreativeDesign = Convert.ToDecimal(CreativeDesign);
            obj.StudioDesign = Convert.ToDecimal(StudioDesign);
            obj.ThirdPartyDesign = Convert.ToDecimal(ThirdPartyDesign);
            obj.Position1 = Convert.ToDecimal(Position1);
            obj.Position2 = Convert.ToDecimal(Position2);
            obj.Position3 = Convert.ToDecimal(Position3);
            obj.FileName = FileName;
            obj.CreatedDate = Convert.ToDateTime(CreatedDate);
        }
        
        internal void SetBO(Indico.DAL.ReturnDownloadPriceListView obj)
        {
            // set the Indico.BusinessObjects.ReturnDownloadPriceListViewBO properties    
            this.Distributor = obj.Distributor;
            this.Label = obj.Label;
            this.Name = obj.Name;
            this.PriceTerm = obj.PriceTerm;
            this.EditedPrice = obj.EditedPrice;
            this.CreativeDesign = obj.CreativeDesign;
            this.StudioDesign = obj.StudioDesign;
            this.ThirdPartyDesign = obj.ThirdPartyDesign;
            this.Position1 = obj.Position1;
            this.Position2 = obj.Position2;
            this.Position3 = obj.Position3;
            this.FileName = obj.FileName;
            this.CreatedDate = obj.CreatedDate;
        }
        
        internal void SetBO(Indico.BusinessObjects.ReturnDownloadPriceListViewBO obj)
        {
            // set this Indico.BusinessObjects.ReturnDownloadPriceListViewBO properties
            this.Distributor = obj.Distributor;
            this.Label = obj.Label;
            this.Name = obj.Name;
            this.PriceTerm = obj.PriceTerm;
            this.EditedPrice = obj.EditedPrice;
            this.CreativeDesign = obj.CreativeDesign;
            this.StudioDesign = obj.StudioDesign;
            this.ThirdPartyDesign = obj.ThirdPartyDesign;
            this.Position1 = obj.Position1;
            this.Position2 = obj.Position2;
            this.Position3 = obj.Position3;
            this.FileName = obj.FileName;
            this.CreatedDate = obj.CreatedDate;
        }
        
        private static List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> IQueryableToList(IQueryable<Indico.DAL.ReturnDownloadPriceListView> oQuery)
        {
            List<Indico.DAL.ReturnDownloadPriceListView> oList = oQuery.ToList();
            List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> rList = new List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO>(oList.Count);
            foreach (Indico.DAL.ReturnDownloadPriceListView o in oList)
            {
                Indico.BusinessObjects.ReturnDownloadPriceListViewBO obj = new Indico.BusinessObjects.ReturnDownloadPriceListViewBO(o);
                rList.Add(obj);
            }
            return rList;
        }
        #endregion
        
        #region BusinessObject methods
        
        #region GetAllObject
        public static List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public static List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public static List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public static List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDownloadPriceListView> oQuery =
                (from o in context.ReturnDownloadPriceListView
                 orderby o.Distributor
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
                oQuery = oQuery.OrderBy(obj => obj.Distributor).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> returndownloadpricelistviews = IQueryableToList(oQuery);
            context.Dispose();
            return returndownloadpricelistviews;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDownloadPriceListView> oQuery =
                (from o in context.ReturnDownloadPriceListView
                 where
                    (this.Distributor == null || this.Distributor == o.Distributor) &&
                    (this.Label == null || this.Label == o.Label) &&
                    (this.Name == null || this.Name == o.Name) &&
                    (this.PriceTerm == null || this.PriceTerm == o.PriceTerm) &&
                    (this.EditedPrice == null || this.EditedPrice == o.EditedPrice) &&
                    (this.CreativeDesign == null || this.CreativeDesign == o.CreativeDesign) &&
                    (this.StudioDesign == null || this.StudioDesign == o.StudioDesign) &&
                    (this.ThirdPartyDesign == null || this.ThirdPartyDesign == o.ThirdPartyDesign) &&
                    (this.Position1 == null || this.Position1 == o.Position1) &&
                    (this.Position2 == null || this.Position2 == o.Position2) &&
                    (this.Position3 == null || this.Position3 == o.Position3) &&
                    (this.FileName == null || this.FileName == o.FileName) &&
                    (this.CreatedDate == null || this.CreatedDate == o.CreatedDate) 
                 orderby o.Distributor
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
                oQuery = oQuery.OrderBy(obj => obj.Distributor).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> returndownloadpricelistviews = IQueryableToList(oQuery);
            context.Dispose();
            return returndownloadpricelistviews;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDownloadPriceListView
                 where
                    (this.Distributor == null || this.Distributor == o.Distributor) &&
                    (this.Label == null || this.Label == o.Label) &&
                    (this.Name == null || this.Name == o.Name) &&
                    (this.PriceTerm == null || this.PriceTerm == o.PriceTerm) &&
                    (this.EditedPrice == null || this.EditedPrice == o.EditedPrice) &&
                    (this.CreativeDesign == null || this.CreativeDesign == o.CreativeDesign) &&
                    (this.StudioDesign == null || this.StudioDesign == o.StudioDesign) &&
                    (this.ThirdPartyDesign == null || this.ThirdPartyDesign == o.ThirdPartyDesign) &&
                    (this.Position1 == null || this.Position1 == o.Position1) &&
                    (this.Position2 == null || this.Position2 == o.Position2) &&
                    (this.Position3 == null || this.Position3 == o.Position3) &&
                    (this.FileName == null || this.FileName == o.FileName) &&
                    (this.CreatedDate == null || this.CreatedDate == o.CreatedDate) 
                 orderby o.Distributor
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDownloadPriceListView> oQuery =
                (from o in context.ReturnDownloadPriceListView
                 where
                    (this.Distributor == null || o.Distributor == this.Distributor) &&
                    (this.Label == null || o.Label == this.Label) &&
                    (this.Name == null || o.Name.Contains(this.Name)) &&
                    (this.PriceTerm == null || o.PriceTerm.Contains(this.PriceTerm)) &&
                    (this.EditedPrice == null || o.EditedPrice == this.EditedPrice) &&
                    (this.CreativeDesign == null || o.CreativeDesign == this.CreativeDesign) &&
                    (this.StudioDesign == null || o.StudioDesign == this.StudioDesign) &&
                    (this.ThirdPartyDesign == null || o.ThirdPartyDesign == this.ThirdPartyDesign) &&
                    (this.Position1 == null || o.Position1 == this.Position1) &&
                    (this.Position2 == null || o.Position2 == this.Position2) &&
                    (this.Position3 == null || o.Position3 == this.Position3) &&
                    (this.FileName == null || o.FileName.Contains(this.FileName)) &&
                    (this.CreatedDate == null || o.CreatedDate == this.CreatedDate) 
                 orderby o.Distributor
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
                oQuery = oQuery.OrderBy(obj => obj.Distributor).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> returndownloadpricelistviews = IQueryableToList(oQuery);
            context.Dispose();
            return returndownloadpricelistviews;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDownloadPriceListView
                 where
                    (this.Distributor == null || o.Distributor == this.Distributor) &&
                    (this.Label == null || o.Label == this.Label) &&
                    (this.Name == null || o.Name.Contains(this.Name)) &&
                    (this.PriceTerm == null || o.PriceTerm.Contains(this.PriceTerm)) &&
                    (this.EditedPrice == null || o.EditedPrice == this.EditedPrice) &&
                    (this.CreativeDesign == null || o.CreativeDesign == this.CreativeDesign) &&
                    (this.StudioDesign == null || o.StudioDesign == this.StudioDesign) &&
                    (this.ThirdPartyDesign == null || o.ThirdPartyDesign == this.ThirdPartyDesign) &&
                    (this.Position1 == null || o.Position1 == this.Position1) &&
                    (this.Position2 == null || o.Position2 == this.Position2) &&
                    (this.Position3 == null || o.Position3 == this.Position3) &&
                    (this.FileName == null || o.FileName.Contains(this.FileName)) &&
                    (this.CreatedDate == null || o.CreatedDate == this.CreatedDate) 
                 orderby o.Distributor
                 select o).Count();
            
        }
        
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDownloadPriceListView> oQuery =
                (from o in context.ReturnDownloadPriceListView
                 where
                    (this.Distributor == null || this.Distributor == o.Distributor) && 
                    (this.Label == null || this.Label == o.Label) && 
                    (this.EditedPrice == null || this.EditedPrice == o.EditedPrice) && 
                    (this.CreativeDesign == null || this.CreativeDesign == o.CreativeDesign) && 
                    (this.StudioDesign == null || this.StudioDesign == o.StudioDesign) && 
                    (this.ThirdPartyDesign == null || this.ThirdPartyDesign == o.ThirdPartyDesign) && 
                    (this.Position1 == null || this.Position1 == o.Position1) && 
                    (this.Position2 == null || this.Position2 == o.Position2) && 
                    (this.Position3 == null || this.Position3 == o.Position3) && 
                    (this.CreatedDate == null || this.CreatedDate == o.CreatedDate) && 
                    ((o.Name.Contains(this.Name)) ||
                    (o.PriceTerm.Contains(this.PriceTerm)) ||
                    (o.FileName.Contains(this.FileName)) ||
                    (this.Name == null && this.PriceTerm == null && this.FileName == null ))
                 orderby o.Distributor
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
                oQuery = oQuery.OrderBy(obj => obj.Distributor).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> returndownloadpricelistviews = IQueryableToList(oQuery);
            context.Dispose();
            return returndownloadpricelistviews;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDownloadPriceListView
                 where
                    (this.Distributor == null || this.Distributor == o.Distributor) && 
                    (this.Label == null || this.Label == o.Label) && 
                    (this.EditedPrice == null || this.EditedPrice == o.EditedPrice) && 
                    (this.CreativeDesign == null || this.CreativeDesign == o.CreativeDesign) && 
                    (this.StudioDesign == null || this.StudioDesign == o.StudioDesign) && 
                    (this.ThirdPartyDesign == null || this.ThirdPartyDesign == o.ThirdPartyDesign) && 
                    (this.Position1 == null || this.Position1 == o.Position1) && 
                    (this.Position2 == null || this.Position2 == o.Position2) && 
                    (this.Position3 == null || this.Position3 == o.Position3) && 
                    (this.CreatedDate == null || this.CreatedDate == o.CreatedDate) && 
                    ((o.Name.Contains(this.Name)) ||
                    (o.PriceTerm.Contains(this.PriceTerm)) ||
                    (o.FileName.Contains(this.FileName)) ||
                    (this.Name == null && this.PriceTerm == null && this.FileName == null ))
                 orderby o.Distributor
                 select o).Count();
            
        }
        #endregion
        
        #region Serialization methods
        /// <summary>
        /// Serializes the Indico.BusinessObjects.ReturnDownloadPriceListViewBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.ReturnDownloadPriceListViewBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.ReturnDownloadPriceListViewBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.ReturnDownloadPriceListViewBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.ReturnDownloadPriceListViewBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.ReturnDownloadPriceListViewBO object in an XmlElement
        /// </summary>
        /// <returns>An XML snippet representing the object</returns>
        public string ToXmlString()
        {
            // MW TODO - implement this better.
            return SerializeObject();
        }
        #endregion
        
        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (!(obj is Indico.BusinessObjects.ReturnDownloadPriceListViewBO))
                return 1;
            Indico.BusinessObjects.ReturnDownloadPriceListViewBOComparer c = new Indico.BusinessObjects.ReturnDownloadPriceListViewBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.ReturnDownloadPriceListViewBO);
        }

        #endregion
        #endregion
    }
    
    #region ReturnDownloadPriceListViewBOComparer
    public class ReturnDownloadPriceListViewBOComparer : IComparer<Indico.BusinessObjects.ReturnDownloadPriceListViewBO>
    {
        private string propertyToCompareName;
        public ReturnDownloadPriceListViewBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.ReturnDownloadPriceListViewBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.ReturnDownloadPriceListViewBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public ReturnDownloadPriceListViewBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.ReturnDownloadPriceListViewBO> Members
        public int Compare(Indico.BusinessObjects.ReturnDownloadPriceListViewBO x, Indico.BusinessObjects.ReturnDownloadPriceListViewBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.ReturnDownloadPriceListViewBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.ReturnDownloadPriceListViewBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.ReturnDownloadPriceListViewBO x, Indico.BusinessObjects.ReturnDownloadPriceListViewBO y)
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
