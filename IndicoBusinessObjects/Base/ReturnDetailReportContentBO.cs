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
    /// ReturnDetailReportContentBO provides the business logic for maintaining Indico.DAL.ReturnDetailReportContent records in the data store.
    /// </summary>
    /// <remarks>
    /// ReturnDetailReportContentBO provides the business logic for maintaining Indico.DAL.ReturnDetailReportContent records in the data store. 
    /// By default it provides basic Search methods for retrieving Indico.DAL.ReturnDetailReportContent
    /// records using the ReturnDetailReportContent DAL class. Other methods implement atomic chunks of Business Logic according to
    /// the business rules.
    /// </remarks>
    public partial class ReturnDetailReportContentBO : BusinessObject, IComparable
    {
        #region fields
        private string _monthAndYear;
        private string _distributorName;
        private string _vLName;
        private string _subItemName;
        private string _jobName;
        private int? _quantity;
        private decimal? _quantityPercentage;
        private decimal? _value;
        private decimal? _valuePercentage;
        private decimal? _avgPrice;
        #endregion
        
        #region Properties
        /// <summary></summary>
        public string MonthAndYear
        {   get {return _monthAndYear;}
            set 
            {
                _monthAndYear = value;
            }
        }
        /// <summary></summary>
        public string DistributorName
        {   get {return _distributorName;}
            set 
            {
                _distributorName = value;
            }
        }
        /// <summary></summary>
        public string VLName
        {   get {return _vLName;}
            set 
            {
                _vLName = value;
            }
        }
        /// <summary></summary>
        public string SubItemName
        {   get {return _subItemName;}
            set 
            {
                _subItemName = value;
            }
        }
        /// <summary></summary>
        public string JobName
        {   get {return _jobName;}
            set 
            {
                _jobName = value;
            }
        }
        /// <summary></summary>
        public int? Quantity
        {   get {return _quantity;}
            set 
            {
                _quantity = value;
            }
        }
        /// <summary></summary>
        public decimal? QuantityPercentage
        {   get {return _quantityPercentage;}
            set 
            {
                _quantityPercentage = value;
            }
        }
        /// <summary></summary>
        public decimal? Value
        {   get {return _value;}
            set 
            {
                _value = value;
            }
        }
        /// <summary></summary>
        public decimal? ValuePercentage
        {   get {return _valuePercentage;}
            set 
            {
                _valuePercentage = value;
            }
        }
        /// <summary></summary>
        public decimal? AvgPrice
        {   get {return _avgPrice;}
            set 
            {
                _avgPrice = value;
            }
        }
        #endregion
        
        #region Internal Constructors
        /// <summary>
        /// Creates an instance of the ReturnDetailReportContentBO class using the supplied Indico.DAL.ReturnDetailReportContent. 
        /// </summary>
        /// <param name="obj">a Indico.DAL.ReturnDetailReportContent whose properties will be used to initialise the ReturnDetailReportContentBO</param>
        internal ReturnDetailReportContentBO(Indico.DAL.ReturnDetailReportContent obj)
        {
            // set the properties from the Indico.DAL.ReturnDetailReportContent 
            this.MonthAndYear = obj.MonthAndYear;
            this.DistributorName = obj.DistributorName;
            this.VLName = obj.VLName;
            this.SubItemName = obj.SubItemName;
            this.JobName = obj.JobName;
            this.Quantity = obj.Quantity;
            this.QuantityPercentage = obj.QuantityPercentage;
            this.Value = obj.Value;
            this.ValuePercentage = obj.ValuePercentage;
            this.AvgPrice = obj.AvgPrice;
        }
        #endregion
        
        #region Internal utility methods
        internal void SetDAL(Indico.DAL.ReturnDetailReportContent obj, IndicoEntities context)
        {
            // set the Indico.DAL.ReturnDetailReportContent properties
            obj.MonthAndYear = MonthAndYear;
            obj.DistributorName = DistributorName;
            obj.VLName = VLName;
            obj.SubItemName = SubItemName;
            obj.JobName = JobName;
            obj.Quantity = Convert.ToInt32(Quantity);
            obj.QuantityPercentage = Convert.ToDecimal(QuantityPercentage);
            obj.Value = Convert.ToDecimal(Value);
            obj.ValuePercentage = Convert.ToDecimal(ValuePercentage);
            obj.AvgPrice = Convert.ToDecimal(AvgPrice);
        }
        
        internal void SetBO(Indico.DAL.ReturnDetailReportContent obj)
        {
            // set the Indico.BusinessObjects.ReturnDetailReportContentBO properties    
            this.MonthAndYear = obj.MonthAndYear;
            this.DistributorName = obj.DistributorName;
            this.VLName = obj.VLName;
            this.SubItemName = obj.SubItemName;
            this.JobName = obj.JobName;
            this.Quantity = obj.Quantity;
            this.QuantityPercentage = obj.QuantityPercentage;
            this.Value = obj.Value;
            this.ValuePercentage = obj.ValuePercentage;
            this.AvgPrice = obj.AvgPrice;
        }
        
        internal void SetBO(Indico.BusinessObjects.ReturnDetailReportContentBO obj)
        {
            // set this Indico.BusinessObjects.ReturnDetailReportContentBO properties
            this.MonthAndYear = obj.MonthAndYear;
            this.DistributorName = obj.DistributorName;
            this.VLName = obj.VLName;
            this.SubItemName = obj.SubItemName;
            this.JobName = obj.JobName;
            this.Quantity = obj.Quantity;
            this.QuantityPercentage = obj.QuantityPercentage;
            this.Value = obj.Value;
            this.ValuePercentage = obj.ValuePercentage;
            this.AvgPrice = obj.AvgPrice;
        }
        
        private static List<Indico.BusinessObjects.ReturnDetailReportContentBO> IQueryableToList(IQueryable<Indico.DAL.ReturnDetailReportContent> oQuery)
        {
            List<Indico.DAL.ReturnDetailReportContent> oList = oQuery.ToList();
            List<Indico.BusinessObjects.ReturnDetailReportContentBO> rList = new List<Indico.BusinessObjects.ReturnDetailReportContentBO>(oList.Count);
            foreach (Indico.DAL.ReturnDetailReportContent o in oList)
            {
                Indico.BusinessObjects.ReturnDetailReportContentBO obj = new Indico.BusinessObjects.ReturnDetailReportContentBO(o);
                rList.Add(obj);
            }
            return rList;
        }
        #endregion
        
        #region BusinessObject methods
        
        #region GetAllObject
        public static List<Indico.BusinessObjects.ReturnDetailReportContentBO> GetAllObject()
        {
            return GetAllObject(0, 0);
        }
        public static List<Indico.BusinessObjects.ReturnDetailReportContentBO> GetAllObject(int maximumRows)
        {
            return GetAllObject(maximumRows, 0);
        }
        public static List<Indico.BusinessObjects.ReturnDetailReportContentBO> GetAllObject(int maximumRows, int startIndex)
        {
            return GetAllObject(maximumRows, startIndex, null, false);
        }
        public static List<Indico.BusinessObjects.ReturnDetailReportContentBO> GetAllObject(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDetailReportContent> oQuery =
                (from o in context.ReturnDetailReportContent
                 orderby o.MonthAndYear
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
                oQuery = oQuery.OrderBy(obj => obj.MonthAndYear).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReturnDetailReportContentBO> returndetailreportcontents = IQueryableToList(oQuery);
            context.Dispose();
            return returndetailreportcontents;
        }
        #endregion
        
        #region SearchObjects
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchObjects()
        {
            return SearchObjects(0,0);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchObjects(int maximumRows)
        {
            return SearchObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchObjects(int maximumRows, int startIndex)
        {
            return SearchObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDetailReportContent> oQuery =
                (from o in context.ReturnDetailReportContent
                 where
                    (this.MonthAndYear == null || this.MonthAndYear == o.MonthAndYear) &&
                    (this.DistributorName == null || this.DistributorName == o.DistributorName) &&
                    (this.VLName == null || this.VLName == o.VLName) &&
                    (this.SubItemName == null || this.SubItemName == o.SubItemName) &&
                    (this.JobName == null || this.JobName == o.JobName) &&
                    (this.Quantity == null || this.Quantity == o.Quantity) &&
                    (this.QuantityPercentage == null || this.QuantityPercentage == o.QuantityPercentage) &&
                    (this.Value == null || this.Value == o.Value) &&
                    (this.ValuePercentage == null || this.ValuePercentage == o.ValuePercentage) &&
                    (this.AvgPrice == null || this.AvgPrice == o.AvgPrice) 
                 orderby o.MonthAndYear
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
                oQuery = oQuery.OrderBy(obj => obj.MonthAndYear).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReturnDetailReportContentBO> returndetailreportcontents = IQueryableToList(oQuery);
            context.Dispose();
            return returndetailreportcontents;
        }
        
        public int SearchObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDetailReportContent
                 where
                    (this.MonthAndYear == null || this.MonthAndYear == o.MonthAndYear) &&
                    (this.DistributorName == null || this.DistributorName == o.DistributorName) &&
                    (this.VLName == null || this.VLName == o.VLName) &&
                    (this.SubItemName == null || this.SubItemName == o.SubItemName) &&
                    (this.JobName == null || this.JobName == o.JobName) &&
                    (this.Quantity == null || this.Quantity == o.Quantity) &&
                    (this.QuantityPercentage == null || this.QuantityPercentage == o.QuantityPercentage) &&
                    (this.Value == null || this.Value == o.Value) &&
                    (this.ValuePercentage == null || this.ValuePercentage == o.ValuePercentage) &&
                    (this.AvgPrice == null || this.AvgPrice == o.AvgPrice) 
                 orderby o.MonthAndYear
                 select o).Count();
        }
        #endregion
        
        #region SearchObjectsLikeAnd
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchLikeAndObjects()
        {
            return SearchLikeAndObjects(0);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchLikeAndObjects(int maximumRows)
        {
            return SearchLikeAndObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchLikeAndObjects(int maximumRows, int startIndex)
        {
            return SearchLikeAndObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchLikeAndObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDetailReportContent> oQuery =
                (from o in context.ReturnDetailReportContent
                 where
                    (this.MonthAndYear == null || o.MonthAndYear.Contains(this.MonthAndYear)) &&
                    (this.DistributorName == null || o.DistributorName.Contains(this.DistributorName)) &&
                    (this.VLName == null || o.VLName.Contains(this.VLName)) &&
                    (this.SubItemName == null || o.SubItemName.Contains(this.SubItemName)) &&
                    (this.JobName == null || o.JobName.Contains(this.JobName)) &&
                    (this.Quantity == null || o.Quantity == this.Quantity) &&
                    (this.QuantityPercentage == null || o.QuantityPercentage == this.QuantityPercentage) &&
                    (this.Value == null || o.Value == this.Value) &&
                    (this.ValuePercentage == null || o.ValuePercentage == this.ValuePercentage) &&
                    (this.AvgPrice == null || o.AvgPrice == this.AvgPrice) 
                 orderby o.MonthAndYear
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
                oQuery = oQuery.OrderBy(obj => obj.MonthAndYear).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReturnDetailReportContentBO> returndetailreportcontents = IQueryableToList(oQuery);
            context.Dispose();
            return returndetailreportcontents;
        }
        
        public int SearchLikeAndObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDetailReportContent
                 where
                    (this.MonthAndYear == null || o.MonthAndYear.Contains(this.MonthAndYear)) &&
                    (this.DistributorName == null || o.DistributorName.Contains(this.DistributorName)) &&
                    (this.VLName == null || o.VLName.Contains(this.VLName)) &&
                    (this.SubItemName == null || o.SubItemName.Contains(this.SubItemName)) &&
                    (this.JobName == null || o.JobName.Contains(this.JobName)) &&
                    (this.Quantity == null || o.Quantity == this.Quantity) &&
                    (this.QuantityPercentage == null || o.QuantityPercentage == this.QuantityPercentage) &&
                    (this.Value == null || o.Value == this.Value) &&
                    (this.ValuePercentage == null || o.ValuePercentage == this.ValuePercentage) &&
                    (this.AvgPrice == null || o.AvgPrice == this.AvgPrice) 
                 orderby o.MonthAndYear
                 select o).Count();
            
        }
        
        #endregion
        
        #region SearchObjectsLikeOr
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchLikeOrObjects()
        {
            return SearchLikeOrObjects(0);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchLikeOrObjects(int maximumRows)
        {
            return SearchLikeOrObjects(maximumRows, 0);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchLikeOrObjects(int maximumRows, int startIndex)
        {
            return SearchLikeOrObjects(maximumRows, startIndex, null, false);
        }
        public List<Indico.BusinessObjects.ReturnDetailReportContentBO> SearchLikeOrObjects(int maximumRows, int startIndex, string sortExpression, bool sortDescending)
        {
            IndicoEntities context = new IndicoEntities();
            IQueryable<Indico.DAL.ReturnDetailReportContent> oQuery =
                (from o in context.ReturnDetailReportContent
                 where
                    (this.Quantity == null || this.Quantity == o.Quantity) && 
                    (this.QuantityPercentage == null || this.QuantityPercentage == o.QuantityPercentage) && 
                    (this.Value == null || this.Value == o.Value) && 
                    (this.ValuePercentage == null || this.ValuePercentage == o.ValuePercentage) && 
                    (this.AvgPrice == null || this.AvgPrice == o.AvgPrice) && 
                    ((o.MonthAndYear.Contains(this.MonthAndYear)) ||
                    (o.DistributorName.Contains(this.DistributorName)) ||
                    (o.VLName.Contains(this.VLName)) ||
                    (o.SubItemName.Contains(this.SubItemName)) ||
                    (o.JobName.Contains(this.JobName)) ||
                    (this.MonthAndYear == null && this.DistributorName == null && this.VLName == null && this.SubItemName == null && this.JobName == null ))
                 orderby o.MonthAndYear
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
                oQuery = oQuery.OrderBy(obj => obj.MonthAndYear).Skip(startIndex).Take((maximumRows == 0) ? Int32.MaxValue : maximumRows);

            List<Indico.BusinessObjects.ReturnDetailReportContentBO> returndetailreportcontents = IQueryableToList(oQuery);
            context.Dispose();
            return returndetailreportcontents;
        }
        
        public int SearchLikeOrObjectsCount()
        {
            IndicoEntities context = new IndicoEntities();
            return (from o in context.ReturnDetailReportContent
                 where
                    (this.Quantity == null || this.Quantity == o.Quantity) && 
                    (this.QuantityPercentage == null || this.QuantityPercentage == o.QuantityPercentage) && 
                    (this.Value == null || this.Value == o.Value) && 
                    (this.ValuePercentage == null || this.ValuePercentage == o.ValuePercentage) && 
                    (this.AvgPrice == null || this.AvgPrice == o.AvgPrice) && 
                    ((o.MonthAndYear.Contains(this.MonthAndYear)) ||
                    (o.DistributorName.Contains(this.DistributorName)) ||
                    (o.VLName.Contains(this.VLName)) ||
                    (o.SubItemName.Contains(this.SubItemName)) ||
                    (o.JobName.Contains(this.JobName)) ||
                    (this.MonthAndYear == null && this.DistributorName == null && this.VLName == null && this.SubItemName == null && this.JobName == null ))
                 orderby o.MonthAndYear
                 select o).Count();
            
        }
        #endregion
        
        #region Serialization methods
        /// <summary>
        /// Serializes the Indico.BusinessObjects.ReturnDetailReportContentBO to an XML representation
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
        /// Deserializes Indico.BusinessObjects.ReturnDetailReportContentBO object from an XML representation
        /// </summary>
        /// <param name="strXML">a XML string serialized representation</param>
        public Indico.BusinessObjects.ReturnDetailReportContentBO DeserializeObject(string strXML)
        {
            Indico.BusinessObjects.ReturnDetailReportContentBO objTemp = null;
            System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();

            objXML.LoadXml(strXML);
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            System.IO.MemoryStream objStream = new System.IO.MemoryStream();
            byte[] b = encoding.GetBytes(objXML.OuterXml);

            objStream.Write(b, 0, (int)b.Length);
            objStream.Position = 0;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());

            objTemp = (Indico.BusinessObjects.ReturnDetailReportContentBO)x.Deserialize(objStream);
            objStream.Close();
            return objTemp;
        }

        /// <summary>
        /// Returns a simple XML representation of Indico.BusinessObjects.ReturnDetailReportContentBO object in an XmlElement
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
            if (!(obj is Indico.BusinessObjects.ReturnDetailReportContentBO))
                return 1;
            Indico.BusinessObjects.ReturnDetailReportContentBOComparer c = new Indico.BusinessObjects.ReturnDetailReportContentBOComparer();
            return c.Compare(this, obj as Indico.BusinessObjects.ReturnDetailReportContentBO);
        }

        #endregion
        #endregion
    }
    
    #region ReturnDetailReportContentBOComparer
    public class ReturnDetailReportContentBOComparer : IComparer<Indico.BusinessObjects.ReturnDetailReportContentBO>
    {
        private string propertyToCompareName;
        public ReturnDetailReportContentBOComparer(string propertyToCompare)
        {
            PropertyInfo p = typeof(Indico.BusinessObjects.ReturnDetailReportContentBO).GetProperty(propertyToCompare);
            if (p == null)
                throw new ArgumentException("is not a public property of Indico.BusinessObjects.ReturnDetailReportContentBO", "propertyToCompare");
            this.propertyToCompareName = propertyToCompare;
        }
        
        public ReturnDetailReportContentBOComparer()
        {
        
        }

        #region IComparer<Indico.BusinessObjects.ReturnDetailReportContentBO> Members
        public int Compare(Indico.BusinessObjects.ReturnDetailReportContentBO x, Indico.BusinessObjects.ReturnDetailReportContentBO y)
        {
            if (propertyToCompareName != null)
            {
                PropertyInfo p = typeof(Indico.BusinessObjects.ReturnDetailReportContentBO).GetProperty(propertyToCompareName);
                return compare(p, x, y);
            }
            else
            {
                PropertyInfo[] arrP = typeof(Indico.BusinessObjects.ReturnDetailReportContentBO).GetProperties();
                foreach (PropertyInfo p in arrP)
                {
                    int v = compare(p, x, y);
                    if (v != 0)
                        return v;
                }
                return 0;
            }
        }

        private int compare(PropertyInfo p, Indico.BusinessObjects.ReturnDetailReportContentBO x, Indico.BusinessObjects.ReturnDetailReportContentBO y)
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
