﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Indico.Common;
using Indico.BusinessObjects;
using System.Transactions;
using Telerik.Web.UI;

namespace Indico
{
    public partial class ViewIndimanInvoices : IndicoPage
    {
        #region Field

        private int urlWeeklyID = -1;

        #endregion

        #region Properties

        private string SortExpression
        {
            get
            {
                string sort = (string)ViewState["InvoiceSortExpression"];
                if (string.IsNullOrEmpty(sort))
                {
                    sort = "InvoiceNo";
                }
                return sort;
            }
            set
            {
                ViewState["InvoiceSortExpression"] = value;
            }
        }

        protected int WeeklyCapacityID
        {
            get
            {
                if (urlWeeklyID > -1)
                    return urlWeeklyID;

                urlWeeklyID = 0;
                if (Request.QueryString["wid"] != null)
                {
                    urlWeeklyID = Convert.ToInt32(Request.QueryString["wid"].ToString());
                }
                return urlWeeklyID;
            }
        }

        #endregion

        #region Constructors

        #endregion

        #region Event

        protected void OnPreRender(object sender, EventArgs e)
        {
            Session["IsPostBack"] = Server.UrlEncode(Guid.NewGuid().ToString());
            ViewState["IsPostBack"] = Session["IsPostBack"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                PopulateControls();
            }
        }

        protected void RadIndimanInvoice_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == RadGrid.FilterCommandName)
            {
                this.ReBindGrid();
            }
        }

        protected void RadIndimanInvoice_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                var item = e.Item as GridDataItem;

                if ((item.ItemIndex > -1 && item.DataItem is ReturnInvoiceDetailsBO))
                {
                    ReturnInvoiceDetailsBO objInvoice = (ReturnInvoiceDetailsBO)item.DataItem;

                    HyperLink linkEdit = (HyperLink)item.FindControl("linkEdit");
                    linkEdit.NavigateUrl = "/AddEditIndimanInvoice.aspx?id=" + objInvoice.Invoice.ToString();

                    //decimal totalindimanprice = 0;

                    //totalindimanprice = (decimal)(objInvoice.Qty * objInvoice.IndimanRate);

                    //Literal litAmount = (Literal)item.FindControl("litAmount");
                    //litAmount.Text = totalindimanprice.ToString("0.00");
                    
                    LinkButton btnIndimanInvoice = (LinkButton)item.FindControl("btnIndimanInvoice");
                    btnIndimanInvoice.Attributes.Add("qid", objInvoice.Invoice.ToString());
                 
                }
            }
        }

        protected void RadIndimanInvoice_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            this.ReBindGrid();
        }

        protected void RadIndimanInvoice_SortCommand(object sender, Telerik.Web.UI.GridSortCommandEventArgs e)
        {
            this.ReBindGrid();
        }

        protected void RadIndimanInvoice_GroupsChanging(object sender, GridGroupsChangingEventArgs e)
        {
            this.ReBindGrid();
        }

        protected void HeaderContextMenu_ItemCLick(object sender, RadMenuEventArgs e)
        {
            this.ReBindGrid();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.PopulateDataGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int invoiceID = int.Parse(hdnSelectedID.Value.Trim());

            if (invoiceID > 0)
            {
                try
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        InvoiceBO objInvoice = new InvoiceBO(this.ObjContext);
                        objInvoice.ID = invoiceID;
                        objInvoice.GetObject();

                        List<InvoiceOrderBO> lstInvoiceOrder = (new InvoiceOrderBO()).GetAllObject().Where(o => o.Invoice == objInvoice.ID).ToList();
                        foreach (InvoiceOrderBO objDelInvoiceOrder in lstInvoiceOrder)
                        {
                            InvoiceOrderBO objInvoiceOrder = new InvoiceOrderBO(this.ObjContext);
                            objInvoiceOrder.ID = objDelInvoiceOrder.ID;
                            objInvoiceOrder.GetObject();

                            objInvoiceOrder.Delete();

                        }

                        objInvoice.Delete();
                        this.ObjContext.SaveChanges();
                        ts.Complete();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                this.PopulateDataGrid();
            }

        }

        protected void btnInvoiceDetail_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((System.Web.UI.WebControls.WebControl)(sender)).Attributes["qid"].ToString());
            //int id = int.Parse(this.hdnSelectedID.Value);

            if (id > 0)
            {
                try
                {
                    string pdfFilePath = Common.GenerateOdsPdf.GenerateJKInvoiceDetail(id);

                    this.DownloadPDFFile(pdfFilePath);
                }
                catch (Exception ex)
                {
                    IndicoLogging.log.Error("Error occured while printing JKInvoiceOrderDetail from ViewInvoices.aspx", ex);
                }
            }
        }

        protected void btnPrintInvoiceSummary_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((System.Web.UI.WebControls.WebControl)(sender)).Attributes["qid"].ToString());
            //int id = int.Parse(this.hdnSelectedID.Value);

            if (id > 0)
            {
                try
                {
                    string pdfFilePath = Common.GenerateOdsPdf.GenerateJKInvoiceSummary(id);

                    this.DownloadPDFFile(pdfFilePath);
                }
                catch (Exception ex)
                {
                    IndicoLogging.log.Error("Error occured while printing JKInvoiceSummary from ViewInvoices.aspx", ex);
                }
            }
        }

        /*protected void btnCombineInvoice_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((System.Web.UI.WebControls.WebControl)(sender)).Attributes["qid"].ToString());
            //int id = int.Parse(this.hdnSelectedID.Value);

            if (id > 0)
            {
                try
                {
                    string pdfFilePath = Common.GenerateOdsPdf.CombinedInvoice(id);

                    this.DownloadPDFFile(pdfFilePath);
                }
                catch (Exception ex)
                {
                    IndicoLogging.log.Error("Error occured while printing JKCombineInvoice from ViewInvoices.aspx", ex);
                }
            }
        }*/

        protected void btnIndimanInvoice_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((System.Web.UI.WebControls.WebControl)(sender)).Attributes["qid"].ToString());
            //int id = int.Parse(this.hdnSelectedID.Value);

            if (id > 0)
            {
                try
                {
                    string pdfFilePath = Common.GenerateOdsPdf.GenerateIndimanInvoice(id);

                    this.DownloadPDFFile(pdfFilePath);
                }
                catch (Exception ex)
                {
                    IndicoLogging.log.Error("Error occured while printing Indiman Invoice from ViewInvoices.aspx", ex);
                }
            }
        }

        #endregion

        #region Methods

        private void PopulateControls()
        {
            // Header Text
            this.litHeaderText.Text = this.ActivePage.Heading;
            this.PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            // Hide Controls
            this.dvEmptyContent.Visible = false;
            this.dvDataContent.Visible = false;
            this.dvNoSearchResult.Visible = false;            

            // Search text
            string searchText = this.txtSearchInvoiceNo.Text.ToLower().Trim();

            // Populate Items
            List<ReturnInvoiceDetailsBO> lstInvoice = new List<ReturnInvoiceDetailsBO>();
            if ((searchText != string.Empty) && (searchText != "search"))
            {
                lstInvoice = (new ReturnInvoiceDetailsBO()).SearchObjects().Where(o => o.IndimanInvoiceDate.ToLower().Contains(searchText) ||
                                                                                  o.ShipmentMode.ToLower().Contains(searchText) ||
                                                                                  o.ShipTo.ToLower().Contains(searchText) ||
                                                                                  o.AWBNo.ToLower().Contains(searchText) ||
                                                                                  o.IndimanInvoiceNo.ToLower().Contains(searchText)).ToList();
            }
            else
            {
                lstInvoice = (new ReturnInvoiceDetailsBO()).SearchObjects().OrderByDescending(o => o.Invoice).ToList();

            }

            if (this.WeeklyCapacityID > 0)
            {
                lstInvoice = lstInvoice.Where(o => o.WeeklyProductionCapacity == this.WeeklyCapacityID).ToList();

            }

            if (lstInvoice.Count > 0)
            {
                this.RadIndimanInvoice.AllowPaging = (lstInvoice.Count > this.RadIndimanInvoice.PageSize);
                this.RadIndimanInvoice.DataSource = lstInvoice;
                this.RadIndimanInvoice.DataBind();

                this.dvDataContent.Visible = true;

                Session["Invoice"] = lstInvoice;
            }
            else if ((searchText != string.Empty && searchText != "search"))
            {
                this.lblSerchKey.Text = searchText + ((searchText != string.Empty) ? " - " : string.Empty);

                this.dvDataContent.Visible = true;
                this.dvNoSearchResult.Visible = true;
            }
            else
            {
                this.dvEmptyContent.Visible = true;
                //this.btnAddInvoice.Visible = false;
                this.litNoInvoice.Visible = true;
            }

            this.RadIndimanInvoice.Visible = (lstInvoice.Count > 0);
        }

        private void ReBindGrid()
        {
            if (Session["Invoice"] != null)
            {
                RadIndimanInvoice.DataSource = (List<ReturnInvoiceDetailsBO>)Session["Invoice"];
                RadIndimanInvoice.DataBind();
            }

        }

        #endregion

    }
}