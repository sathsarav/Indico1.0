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
    /// GetNonAssignedPriceMarkupDistributorsViewBO provides the business logic for maintaining Indico.DAL.GetNonAssignedPriceMarkupDistributorsView records in the data store.
    /// </summary>
    /// <remarks>
    /// GetNonAssignedPriceMarkupDistributorsViewBO provides the business logic for maintaining Indico.DAL.GetNonAssignedPriceMarkupDistributorsView records in the data store. 
    /// By default it provides basic Search methods for retrieving Indico.DAL.GetNonAssignedPriceMarkupDistributorsView
    /// records using the GetNonAssignedPriceMarkupDistributorsView DAL class. Other methods implement atomic chunks of Business Logic according to
    /// the business rules.
    /// </remarks>
    public partial class GetNonAssignedPriceMarkupDistributorsViewBO : BusinessObject, IComparable
    {
        #region fields
        private int? _iD;
        private string _name;
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
        public string Name
        {   get {return _name;}
            set 
            {
                _name = value;
            }
        }
        #endregion
        
        #region Internal Constructors
        /// <summary>
        /// Creates an instance of the GetNonAssignedPriceMarkupDistributorsViewBO class using the supplied Indico.DAL.GetNonAssignedPriceMarkupDistributorsView. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.GetNonAssignedPriceMarkupDistributorsView whose properties will be used to initialise the GetNonAssignedPriceMarkupDistributorsViewBO</param>
        internal GetNonAssignedPriceMarkupDistributorsViewBO(Indico.DAL.GetNonAssignedPriceMarkupDistributorsView obj)
        {
            // set the properties from the Indico.DAL.GetNonAssignedPriceMarkupDistributorsView 
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        #endregion
        
        #region Internal utility methods
        internal void SetDAL(Indico.DAL.GetNonAssignedPriceMarkupDistributorsView obj, IndicoEntities context)
        {
            // set the Indico.DAL.GetNonAssignedPriceMarkupDistributorsView properties
            obj.ID = Convert.ToInt32(ID);
            obj.Name = Name;
        }
        
        internal void SetBO(Indico.DAL.GetNonAssignedPriceMarkupDistributorsView obj)
        {
            // set the Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO properties    
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        
        internal void SetBO(Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO obj)
        {
            // set this Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO properties
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        
        private static List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> IQueryableToList(IQueryable<Indico.DAL.GetNonAssignedPriceMarkupDistributorsView> oQuery)
        {
            List<Indico.DAL.GetNonAssignedPriceMarkupDistributorsView> oList = oQuery.ToList();
            List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> rList = new List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO>(oList.Count);
            foreach (Indico.DAL.GetNonAssignedPriceMarkupDistributorsView o in oList)
            {
                Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO obj = new Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO(o);
                rList.Add(obj);
            }
            return rList;
        }
        #endregion
        
        #region BusinessObject methods
        
        #region GetAllObject
        public static List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public static List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public static List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public static List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.GetNonAssignedPriceMarkupDistributorsView> oQuery =
                (from o in context.GetNonAssignedPriceMarkupDistributorsView
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

            List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> getnonassignedpricemarkupdistributorsviews = IQueryableToList(oQuery);
            context.Dispose();
            return getnonassignedpricemarkupdistributorsviews;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.GetNonAssignedPriceMarkupDistributorsView> oQuery =
                (from o in context.GetNonAssignedPriceMarkupDistributorsView
                 where
                    (this.ID == null || this.ID == o.ID) &&
                    (this.Name == null || this.Name == o.Name) 
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

            List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> getnonassignedpricemarkupdistributorsviews = IQueryableToList(oQuery);
            context.Dispose();
            return getnonassignedpricemarkupdistributorsviews;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.GetNonAssignedPriceMarkupDistributorsView
                 where
                    (this.ID == null || this.ID == o.ID) &&
                    (this.Name == null || this.Name == o.Name) 
                 orderby o.ID
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.GetNonAssignedPriceMarkupDistributorsView> oQuery =
                (from o in context.GetNonAssignedPriceMarkupDistributorsView
                 where
                    (this.ID == null || o.ID == this.ID) &&
                    (this.Name == null || o.Name.Contains(this.Name)) 
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

            List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> getnonassignedpricemarkupdistributorsviews = IQueryableToList(oQuery);
            context.Dispose();
            return getnonassignedpricemarkupdistributorsviews;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.GetNonAssignedPriceMarkupDistributorsView
                 where
                    (this.ID == null || o.ID == this.ID) &&
                    (this.Name == null || o.Name.Contains(this.Name)) 
                 orderby o.ID
                 select o).Count();
            
        }
        
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.GetNonAssignedPriceMarkupDistributorsView> oQuery =
                (from o in context.GetNonAssignedPriceMarkupDistributorsView
                 where
                    (this.ID == null || this.ID == o.ID) && 
                    ((o.Name.Contains(this.Name)) ||
                    (this.Name == null ))
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

            List<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> getnonassignedpricemarkupdistributorsviews = IQueryableToList(oQuery);
            context.Dispose();
            return getnonassignedpricemarkupdistributorsviews;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.GetNonAssignedPriceMarkupDistributorsView
                 where
                    (this.ID == null || this.ID == o.ID) && 
                    ((o.Name.Contains(this.Name)) ||
                    (this.Name == null ))
                 orderby o.ID
                 select o).Count();
            
        }
        #endregion
        
        #region Serialization methods
        /// <summary>
        /// Serializes the Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO object in an XmlElement
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
            if (!(obj is Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO))
                return 1;
            Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBOComparer c = new Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO);
        }

        #endregion
        #endregion
    }
    
    #region GetNonAssignedPriceMarkupDistributorsViewBOComparer
    public class GetNonAssignedPriceMarkupDistributorsViewBOComparer : IComparer<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO>
    {
        private string propertyToCompareName;
        public GetNonAssignedPriceMarkupDistributorsViewBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public GetNonAssignedPriceMarkupDistributorsViewBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO> Members
        public int Compare(Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO x, Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO x, Indico.BusinessObjects.GetNonAssignedPriceMarkupDistributorsViewBO y)
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
