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
    /// ReturnDistributorSecondaryCoordinatorBO provides the business logic for maintaining Indico.DAL.ReturnDistributorSecondaryCoordinator records in the data store.
    /// </summary>
    /// <remarks>
    /// ReturnDistributorSecondaryCoordinatorBO provides the business logic for maintaining Indico.DAL.ReturnDistributorSecondaryCoordinator records in the data store. 
    /// By default it provides basic Search methods for retrieving Indico.DAL.ReturnDistributorSecondaryCoordinator
    /// records using the ReturnDistributorSecondaryCoordinator DAL class. Other methods implement atomic chunks of Business Logic according to
    /// the business rules.
    /// </remarks>
    public partial class ReturnDistributorSecondaryCoordinatorBO : BusinessObject, IComparable
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
        /// Creates an instance of the ReturnDistributorSecondaryCoordinatorBO class using the supplied Indico.DAL.ReturnDistributorSecondaryCoordinator. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.ReturnDistributorSecondaryCoordinator whose properties will be used to initialise the ReturnDistributorSecondaryCoordinatorBO</param>
        internal ReturnDistributorSecondaryCoordinatorBO(Indico.DAL.ReturnDistributorSecondaryCoordinator obj)
        {
            // set the properties from the Indico.DAL.ReturnDistributorSecondaryCoordinator 
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        #endregion
        
        #region Internal utility methods
        internal void SetDAL(Indico.DAL.ReturnDistributorSecondaryCoordinator obj, IndicoEntities context)
        {
            // set the Indico.DAL.ReturnDistributorSecondaryCoordinator properties
            obj.ID = Convert.ToInt32(ID);
            obj.Name = Name;
        }
        
        internal void SetBO(Indico.DAL.ReturnDistributorSecondaryCoordinator obj)
        {
            // set the Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO properties    
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        
        internal void SetBO(Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO obj)
        {
            // set this Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO properties
            this.ID = obj.ID;
            this.Name = obj.Name;
        }
        
        private static List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> IQueryableToList(IQueryable<Indico.DAL.ReturnDistributorSecondaryCoordinator> oQuery)
        {
            List<Indico.DAL.ReturnDistributorSecondaryCoordinator> oList = oQuery.ToList();
            List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> rList = new List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO>(oList.Count);
            foreach (Indico.DAL.ReturnDistributorSecondaryCoordinator o in oList)
            {
                Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO obj = new Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO(o);
                rList.Add(obj);
            }
            return rList;
        }
        #endregion
        
        #region BusinessObject methods
        
        #region GetAllObject
        public static List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public static List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public static List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public static List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDistributorSecondaryCoordinator> oQuery =
                (from o in context.ReturnDistributorSecondaryCoordinator
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

            List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> returndistributorsecondarycoordinators = IQueryableToList(oQuery);
            context.Dispose();
            return returndistributorsecondarycoordinators;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDistributorSecondaryCoordinator> oQuery =
                (from o in context.ReturnDistributorSecondaryCoordinator
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

            List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> returndistributorsecondarycoordinators = IQueryableToList(oQuery);
            context.Dispose();
            return returndistributorsecondarycoordinators;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDistributorSecondaryCoordinator
                 where
                    (this.ID == null || this.ID == o.ID) &&
                    (this.Name == null || this.Name == o.Name) 
                 orderby o.ID
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDistributorSecondaryCoordinator> oQuery =
                (from o in context.ReturnDistributorSecondaryCoordinator
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

            List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> returndistributorsecondarycoordinators = IQueryableToList(oQuery);
            context.Dispose();
            return returndistributorsecondarycoordinators;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDistributorSecondaryCoordinator
                 where
                    (this.ID == null || o.ID == this.ID) &&
                    (this.Name == null || o.Name.Contains(this.Name)) 
                 orderby o.ID
                 select o).Count();
            
        }
        
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDistributorSecondaryCoordinator> oQuery =
                (from o in context.ReturnDistributorSecondaryCoordinator
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

            List<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> returndistributorsecondarycoordinators = IQueryableToList(oQuery);
            context.Dispose();
            return returndistributorsecondarycoordinators;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDistributorSecondaryCoordinator
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
        /// Serializes the Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO object in an XmlElement
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
            if (!(obj is Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO))
                return 1;
            Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBOComparer c = new Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO);
        }

        #endregion
        #endregion
    }
    
    #region ReturnDistributorSecondaryCoordinatorBOComparer
    public class ReturnDistributorSecondaryCoordinatorBOComparer : IComparer<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO>
    {
        private string propertyToCompareName;
        public ReturnDistributorSecondaryCoordinatorBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public ReturnDistributorSecondaryCoordinatorBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO> Members
        public int Compare(Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO x, Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO x, Indico.BusinessObjects.ReturnDistributorSecondaryCoordinatorBO y)
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
