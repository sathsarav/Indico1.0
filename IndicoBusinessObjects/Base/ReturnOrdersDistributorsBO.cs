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
    /// ReturnOrdersDistributorsBO provides the business logic for maintaining Indico.DAL.ReturnOrdersDistributors records in the data store.
    /// </summary>
    /// <remarks>
    /// ReturnOrdersDistributorsBO provides the business logic for maintaining Indico.DAL.ReturnOrdersDistributors records in the data store. 
    /// By default it provides basic Search methods for retrieving Indico.DAL.ReturnOrdersDistributors
    /// records using the ReturnOrdersDistributors DAL class. Other methods implement atomic chunks of Business Logic according to
    /// the business rules.
    /// </remarks>
    public partial class ReturnOrdersDistributorsBO : BusinessObject, IComparable
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
        /// Creates an instance of the ReturnOrdersDistributorsBO class using the supplied Indico.DAL.ReturnOrdersDistributors. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.ReturnOrdersDistributors whose properties will be used to initialise the ReturnOrdersDistributorsBO</param>
        internal ReturnOrdersDistributorsBO(Indico.DAL.ReturnOrdersDistributors obj)
        {
            // set the properties from the Indico.DAL.ReturnOrdersDistributors 
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        #endregion
        
        #region Internal utility methods
        internal void SetDAL(Indico.DAL.ReturnOrdersDistributors obj, IndicoEntities context)
        {
            // set the Indico.DAL.ReturnOrdersDistributors properties
            obj.ID = Convert.ToInt32(ID);
            obj.Name = Name;
        }
        
        internal void SetBO(Indico.DAL.ReturnOrdersDistributors obj)
        {
            // set the Indico.BusinessObjects.ReturnOrdersDistributorsBO properties    
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        
        internal void SetBO(Indico.BusinessObjects.ReturnOrdersDistributorsBO obj)
        {
            // set this Indico.BusinessObjects.ReturnOrdersDistributorsBO properties
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        
        private static List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> IQueryableToList(IQueryable<Indico.DAL.ReturnOrdersDistributors> oQuery)
        {
            List<Indico.DAL.ReturnOrdersDistributors> oList = oQuery.ToList();
            List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> rList = new List<Indico.BusinessObjects.ReturnOrdersDistributorsBO>(oList.Count);
            foreach (Indico.DAL.ReturnOrdersDistributors o in oList)
            {
                Indico.BusinessObjects.ReturnOrdersDistributorsBO obj = new Indico.BusinessObjects.ReturnOrdersDistributorsBO(o);
                rList.Add(obj);
            }
            return rList;
        }
        #endregion
        
        #region BusinessObject methods
        
        #region GetAllObject
        public static List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public static List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public static List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public static List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnOrdersDistributors> oQuery =
                (from o in context.ReturnOrdersDistributors
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

            List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> returnordersdistributorss = IQueryableToList(oQuery);
            context.Dispose();
            return returnordersdistributorss;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnOrdersDistributors> oQuery =
                (from o in context.ReturnOrdersDistributors
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

            List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> returnordersdistributorss = IQueryableToList(oQuery);
            context.Dispose();
            return returnordersdistributorss;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnOrdersDistributors
                 where
                    (this.ID == null || this.ID == o.ID) &&
                    (this.Name == null || this.Name == o.Name) 
                 orderby o.ID
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnOrdersDistributors> oQuery =
                (from o in context.ReturnOrdersDistributors
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

            List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> returnordersdistributorss = IQueryableToList(oQuery);
            context.Dispose();
            return returnordersdistributorss;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnOrdersDistributors
                 where
                    (this.ID == null || o.ID == this.ID) &&
                    (this.Name == null || o.Name.Contains(this.Name)) 
                 orderby o.ID
                 select o).Count();
            
        }
        
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnOrdersDistributors> oQuery =
                (from o in context.ReturnOrdersDistributors
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

            List<Indico.BusinessObjects.ReturnOrdersDistributorsBO> returnordersdistributorss = IQueryableToList(oQuery);
            context.Dispose();
            return returnordersdistributorss;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnOrdersDistributors
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
        /// Serializes the Indico.BusinessObjects.ReturnOrdersDistributorsBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.ReturnOrdersDistributorsBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.ReturnOrdersDistributorsBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.ReturnOrdersDistributorsBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.ReturnOrdersDistributorsBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.ReturnOrdersDistributorsBO object in an XmlElement
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
            if (!(obj is Indico.BusinessObjects.ReturnOrdersDistributorsBO))
                return 1;
            Indico.BusinessObjects.ReturnOrdersDistributorsBOComparer c = new Indico.BusinessObjects.ReturnOrdersDistributorsBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.ReturnOrdersDistributorsBO);
        }

        #endregion
        #endregion
    }
    
    #region ReturnOrdersDistributorsBOComparer
    public class ReturnOrdersDistributorsBOComparer : IComparer<Indico.BusinessObjects.ReturnOrdersDistributorsBO>
    {
        private string propertyToCompareName;
        public ReturnOrdersDistributorsBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.ReturnOrdersDistributorsBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.ReturnOrdersDistributorsBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public ReturnOrdersDistributorsBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.ReturnOrdersDistributorsBO> Members
        public int Compare(Indico.BusinessObjects.ReturnOrdersDistributorsBO x, Indico.BusinessObjects.ReturnOrdersDistributorsBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.ReturnOrdersDistributorsBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.ReturnOrdersDistributorsBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.ReturnOrdersDistributorsBO x, Indico.BusinessObjects.ReturnOrdersDistributorsBO y)
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
