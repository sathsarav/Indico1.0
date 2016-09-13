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
    /// PriceLevelCostViewBO provides the business logic for maintaining Indico.DAL.PriceLevelCostView records in the data store.
    /// </summary>
    /// <remarks>
    /// PriceLevelCostViewBO provides the business logic for maintaining Indico.DAL.PriceLevelCostView records in the data store. 
    /// By default it provides basic Search methods for retrieving Indico.DAL.PriceLevelCostView
    /// records using the PriceLevelCostView DAL class. Other methods implement atomic chunks of Business Logic according to
    /// the business rules.
    /// </remarks>
    public partial class PriceLevelCostViewBO : BusinessObject, IComparable
    {
        #region fields
        private int? _iD;
        private int? _pattern;
        private int? _fabricCode;
        private string _number;
        private string _nickName;
        private int? _item;
        private int? _subItem;
        private int? _coreCategory;
        private string _fabricCodeName;
        private string _itemSubCategory;
        private string _otherCategories;
        private decimal? _convertionFactor;
        private bool? _enableForPriceList;
        #endregion
        
        #region Properties
        /// <summary></summary>
        public int? ID
        {   get {return _iD;}
            set 
            {
                _iD = value;
            }
        }
        /// <summary></summary>
        public int? Pattern
        {   get {return _pattern;}
            set 
            {
                _pattern = value;
            }
        }
        /// <summary></summary>
        public int? FabricCode
        {   get {return _fabricCode;}
            set 
            {
                _fabricCode = value;
            }
        }
        /// <summary></summary>
        public string Number
        {   get {return _number;}
            set 
            {
                _number = value;
            }
        }
        /// <summary></summary>
        public string NickName
        {   get {return _nickName;}
            set 
            {
                _nickName = value;
            }
        }
        /// <summary></summary>
        public int? Item
        {   get {return _item;}
            set 
            {
                _item = value;
            }
        }
        /// <summary></summary>
        public int? SubItem
        {   get {return _subItem;}
            set 
            {
                _subItem = value;
            }
        }
        /// <summary></summary>
        public int? CoreCategory
        {   get {return _coreCategory;}
            set 
            {
                _coreCategory = value;
            }
        }
        /// <summary></summary>
        public string FabricCodeName
        {   get {return _fabricCodeName;}
            set 
            {
                _fabricCodeName = value;
            }
        }
        /// <summary></summary>
        public string ItemSubCategory
        {   get {return _itemSubCategory;}
            set 
            {
                _itemSubCategory = value;
            }
        }
        /// <summary></summary>
        public string OtherCategories
        {   get {return _otherCategories;}
            set 
            {
                _otherCategories = value;
            }
        }
        /// <summary></summary>
        public decimal? ConvertionFactor
        {   get {return _convertionFactor;}
            set 
            {
                _convertionFactor = value;
            }
        }
        /// <summary></summary>
        public bool? EnableForPriceList
        {   get {return _enableForPriceList;}
            set 
            {
                _enableForPriceList = value;
            }
        }
        #endregion
        
        #region Internal Constructors
        /// <summary>
        /// Creates an instance of the PriceLevelCostViewBO class using the supplied Indico.DAL.PriceLevelCostView. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.PriceLevelCostView whose properties will be used to initialise the PriceLevelCostViewBO</param>
        internal PriceLevelCostViewBO(Indico.DAL.PriceLevelCostView obj)
        {
            // set the properties from the Indico.DAL.PriceLevelCostView 
            this.ID = obj.ID;
            this.Pattern = obj.Pattern;
            this.FabricCode = obj.FabricCode;
            this.Number = obj.Number;
            this.NickName = obj.NickName;
            this.Item = obj.Item;
            this.SubItem = obj.SubItem;
            this.CoreCategory = obj.CoreCategory;
            this.FabricCodeName = obj.FabricCodeName;
            this.ItemSubCategory = obj.ItemSubCategory;
            this.OtherCategories = obj.OtherCategories;
            this.ConvertionFactor = obj.ConvertionFactor;
            this.EnableForPriceList = obj.EnableForPriceList;
        }
        #endregion
        
        #region Internal utility methods
        internal void SetDAL(Indico.DAL.PriceLevelCostView obj, IndicoEntities context)
        {
            // set the Indico.DAL.PriceLevelCostView properties
            obj.ID = Convert.ToInt32(ID);
            obj.Pattern = Convert.ToInt32(Pattern);
            obj.FabricCode = Convert.ToInt32(FabricCode);
            obj.Number = Number;
            obj.NickName = NickName;
            obj.Item = Convert.ToInt32(Item);
            obj.SubItem = Convert.ToInt32(SubItem);
            obj.CoreCategory = Convert.ToInt32(CoreCategory);
            obj.FabricCodeName = FabricCodeName;
            obj.ItemSubCategory = ItemSubCategory;
            obj.OtherCategories = OtherCategories;
            obj.ConvertionFactor = Convert.ToDecimal(ConvertionFactor);
            obj.EnableForPriceList = Convert.ToBoolean(EnableForPriceList);
        }
        
        internal void SetBO(Indico.DAL.PriceLevelCostView obj)
        {
            // set the Indico.BusinessObjects.PriceLevelCostViewBO properties    
            this.ID = obj.ID;
            this.Pattern = obj.Pattern;
            this.FabricCode = obj.FabricCode;
            this.Number = obj.Number;
            this.NickName = obj.NickName;
            this.Item = obj.Item;
            this.SubItem = obj.SubItem;
            this.CoreCategory = obj.CoreCategory;
            this.FabricCodeName = obj.FabricCodeName;
            this.ItemSubCategory = obj.ItemSubCategory;
            this.OtherCategories = obj.OtherCategories;
            this.ConvertionFactor = obj.ConvertionFactor;
            this.EnableForPriceList = obj.EnableForPriceList;
        }
        
        internal void SetBO(Indico.BusinessObjects.PriceLevelCostViewBO obj)
        {
            // set this Indico.BusinessObjects.PriceLevelCostViewBO properties
            this.ID = obj.ID;
            this.Pattern = obj.Pattern;
            this.FabricCode = obj.FabricCode;
            this.Number = obj.Number;
            this.NickName = obj.NickName;
            this.Item = obj.Item;
            this.SubItem = obj.SubItem;
            this.CoreCategory = obj.CoreCategory;
            this.FabricCodeName = obj.FabricCodeName;
            this.ItemSubCategory = obj.ItemSubCategory;
            this.OtherCategories = obj.OtherCategories;
            this.ConvertionFactor = obj.ConvertionFactor;
            this.EnableForPriceList = obj.EnableForPriceList;
        }
        
        private static List<Indico.BusinessObjects.PriceLevelCostViewBO> IQueryableToList(IQueryable<Indico.DAL.PriceLevelCostView> oQuery)
        {
            List<Indico.DAL.PriceLevelCostView> oList = oQuery.ToList();
            List<Indico.BusinessObjects.PriceLevelCostViewBO> rList = new List<Indico.BusinessObjects.PriceLevelCostViewBO>(oList.Count);
            foreach (Indico.DAL.PriceLevelCostView o in oList)
            {
                Indico.BusinessObjects.PriceLevelCostViewBO obj = new Indico.BusinessObjects.PriceLevelCostViewBO(o);
                rList.Add(obj);
            }
            return rList;
        }
        #endregion
        
        #region BusinessObject methods
        
        #region GetAllObject
        public static List<Indico.BusinessObjects.PriceLevelCostViewBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public static List<Indico.BusinessObjects.PriceLevelCostViewBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public static List<Indico.BusinessObjects.PriceLevelCostViewBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public static List<Indico.BusinessObjects.PriceLevelCostViewBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.PriceLevelCostView> oQuery =
                (from o in context.PriceLevelCostView
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

            List<Indico.BusinessObjects.PriceLevelCostViewBO> pricelevelcostviews = IQueryableToList(oQuery);
            context.Dispose();
            return pricelevelcostviews;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.PriceLevelCostView> oQuery =
                (from o in context.PriceLevelCostView
                 where
                    (this.ID == null || this.ID == o.ID) &&
                    (this.Pattern == null || this.Pattern == o.Pattern) &&
                    (this.FabricCode == null || this.FabricCode == o.FabricCode) &&
                    (this.Number == null || this.Number == o.Number) &&
                    (this.NickName == null || this.NickName == o.NickName) &&
                    (this.Item == null || this.Item == o.Item) &&
                    (this.SubItem == null || this.SubItem == o.SubItem) &&
                    (this.CoreCategory == null || this.CoreCategory == o.CoreCategory) &&
                    (this.FabricCodeName == null || this.FabricCodeName == o.FabricCodeName) &&
                    (this.ItemSubCategory == null || this.ItemSubCategory == o.ItemSubCategory) &&
                    (this.OtherCategories == null || this.OtherCategories == o.OtherCategories) &&
                    (this.ConvertionFactor == null || this.ConvertionFactor == o.ConvertionFactor) &&
                    (this.EnableForPriceList == null || this.EnableForPriceList == o.EnableForPriceList) 
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

            List<Indico.BusinessObjects.PriceLevelCostViewBO> pricelevelcostviews = IQueryableToList(oQuery);
            context.Dispose();
            return pricelevelcostviews;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.PriceLevelCostView
                 where
                    (this.ID == null || this.ID == o.ID) &&
                    (this.Pattern == null || this.Pattern == o.Pattern) &&
                    (this.FabricCode == null || this.FabricCode == o.FabricCode) &&
                    (this.Number == null || this.Number == o.Number) &&
                    (this.NickName == null || this.NickName == o.NickName) &&
                    (this.Item == null || this.Item == o.Item) &&
                    (this.SubItem == null || this.SubItem == o.SubItem) &&
                    (this.CoreCategory == null || this.CoreCategory == o.CoreCategory) &&
                    (this.FabricCodeName == null || this.FabricCodeName == o.FabricCodeName) &&
                    (this.ItemSubCategory == null || this.ItemSubCategory == o.ItemSubCategory) &&
                    (this.OtherCategories == null || this.OtherCategories == o.OtherCategories) &&
                    (this.ConvertionFactor == null || this.ConvertionFactor == o.ConvertionFactor) &&
                    (this.EnableForPriceList == null || this.EnableForPriceList == o.EnableForPriceList) 
                 orderby o.ID
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.PriceLevelCostView> oQuery =
                (from o in context.PriceLevelCostView
                 where
                    (this.ID == null || o.ID == this.ID) &&
                    (this.Pattern == null || o.Pattern == this.Pattern) &&
                    (this.FabricCode == null || o.FabricCode == this.FabricCode) &&
                    (this.Number == null || o.Number.Contains(this.Number)) &&
                    (this.NickName == null || o.NickName.Contains(this.NickName)) &&
                    (this.Item == null || o.Item == this.Item) &&
                    (this.SubItem == null || o.SubItem == this.SubItem) &&
                    (this.CoreCategory == null || o.CoreCategory == this.CoreCategory) &&
                    (this.FabricCodeName == null || o.FabricCodeName.Contains(this.FabricCodeName)) &&
                    (this.ItemSubCategory == null || o.ItemSubCategory.Contains(this.ItemSubCategory)) &&
                    (this.OtherCategories == null || o.OtherCategories.Contains(this.OtherCategories)) &&
                    (this.ConvertionFactor == null || o.ConvertionFactor == this.ConvertionFactor) &&
                    (this.EnableForPriceList == null || o.EnableForPriceList == this.EnableForPriceList) 
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

            List<Indico.BusinessObjects.PriceLevelCostViewBO> pricelevelcostviews = IQueryableToList(oQuery);
            context.Dispose();
            return pricelevelcostviews;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.PriceLevelCostView
                 where
                    (this.ID == null || o.ID == this.ID) &&
                    (this.Pattern == null || o.Pattern == this.Pattern) &&
                    (this.FabricCode == null || o.FabricCode == this.FabricCode) &&
                    (this.Number == null || o.Number.Contains(this.Number)) &&
                    (this.NickName == null || o.NickName.Contains(this.NickName)) &&
                    (this.Item == null || o.Item == this.Item) &&
                    (this.SubItem == null || o.SubItem == this.SubItem) &&
                    (this.CoreCategory == null || o.CoreCategory == this.CoreCategory) &&
                    (this.FabricCodeName == null || o.FabricCodeName.Contains(this.FabricCodeName)) &&
                    (this.ItemSubCategory == null || o.ItemSubCategory.Contains(this.ItemSubCategory)) &&
                    (this.OtherCategories == null || o.OtherCategories.Contains(this.OtherCategories)) &&
                    (this.ConvertionFactor == null || o.ConvertionFactor == this.ConvertionFactor) &&
                    (this.EnableForPriceList == null || o.EnableForPriceList == this.EnableForPriceList) 
                 orderby o.ID
                 select o).Count();
            
        }
        
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.PriceLevelCostViewBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.PriceLevelCostView> oQuery =
                (from o in context.PriceLevelCostView
                 where
                    (this.ID == null || this.ID == o.ID) && 
                    (this.Pattern == null || this.Pattern == o.Pattern) && 
                    (this.FabricCode == null || this.FabricCode == o.FabricCode) && 
                    (this.Item == null || this.Item == o.Item) && 
                    (this.SubItem == null || this.SubItem == o.SubItem) && 
                    (this.CoreCategory == null || this.CoreCategory == o.CoreCategory) && 
                    (this.ConvertionFactor == null || this.ConvertionFactor == o.ConvertionFactor) && 
                    (this.EnableForPriceList == null || this.EnableForPriceList == o.EnableForPriceList) && 
                    ((o.Number.Contains(this.Number)) ||
                    (o.NickName.Contains(this.NickName)) ||
                    (o.FabricCodeName.Contains(this.FabricCodeName)) ||
                    (o.ItemSubCategory.Contains(this.ItemSubCategory)) ||
                    (o.OtherCategories.Contains(this.OtherCategories)) ||
                    (this.Number == null && this.NickName == null && this.FabricCodeName == null && this.ItemSubCategory == null && this.OtherCategories == null ))
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

            List<Indico.BusinessObjects.PriceLevelCostViewBO> pricelevelcostviews = IQueryableToList(oQuery);
            context.Dispose();
            return pricelevelcostviews;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.PriceLevelCostView
                 where
                    (this.ID == null || this.ID == o.ID) && 
                    (this.Pattern == null || this.Pattern == o.Pattern) && 
                    (this.FabricCode == null || this.FabricCode == o.FabricCode) && 
                    (this.Item == null || this.Item == o.Item) && 
                    (this.SubItem == null || this.SubItem == o.SubItem) && 
                    (this.CoreCategory == null || this.CoreCategory == o.CoreCategory) && 
                    (this.ConvertionFactor == null || this.ConvertionFactor == o.ConvertionFactor) && 
                    (this.EnableForPriceList == null || this.EnableForPriceList == o.EnableForPriceList) && 
                    ((o.Number.Contains(this.Number)) ||
                    (o.NickName.Contains(this.NickName)) ||
                    (o.FabricCodeName.Contains(this.FabricCodeName)) ||
                    (o.ItemSubCategory.Contains(this.ItemSubCategory)) ||
                    (o.OtherCategories.Contains(this.OtherCategories)) ||
                    (this.Number == null && this.NickName == null && this.FabricCodeName == null && this.ItemSubCategory == null && this.OtherCategories == null ))
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region Serialization methods
        /// <summary>
        /// Serializes the Indico.BusinessObjects.PriceLevelCostViewBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.PriceLevelCostViewBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.PriceLevelCostViewBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.PriceLevelCostViewBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.PriceLevelCostViewBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.PriceLevelCostViewBO object in an XmlElement
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
            if (!(obj is Indico.BusinessObjects.PriceLevelCostViewBO))
                return 1;
            Indico.BusinessObjects.PriceLevelCostViewBOComparer c = new Indico.BusinessObjects.PriceLevelCostViewBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.PriceLevelCostViewBO);
        }

        #endregion
        #endregion
    }
    
    #region PriceLevelCostViewBOComparer
    public class PriceLevelCostViewBOComparer : IComparer<Indico.BusinessObjects.PriceLevelCostViewBO>
    {
        private string propertyToCompareName;
        public PriceLevelCostViewBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.PriceLevelCostViewBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.PriceLevelCostViewBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public PriceLevelCostViewBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.PriceLevelCostViewBO> Members
        public int Compare(Indico.BusinessObjects.PriceLevelCostViewBO x, Indico.BusinessObjects.PriceLevelCostViewBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.PriceLevelCostViewBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.PriceLevelCostViewBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.PriceLevelCostViewBO x, Indico.BusinessObjects.PriceLevelCostViewBO y)
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
