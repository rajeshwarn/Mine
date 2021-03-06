using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace DianDang
{
    /// <summary>
    /// Controller class for DDPawnTicket
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class DDPawnTicketController
    {
        // Preload our schema..
        DDPawnTicket thisSchemaLoad = new DDPawnTicket();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public DDPawnTicketCollection FetchAll()
        {
            DDPawnTicketCollection coll = new DDPawnTicketCollection();
            Query qry = new Query(DDPawnTicket.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public DDPawnTicketCollection FetchByID(object TicketID)
        {
            DDPawnTicketCollection coll = new DDPawnTicketCollection().Where("TicketID", TicketID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public DDPawnTicketCollection FetchByQuery(Query qry)
        {
            DDPawnTicketCollection coll = new DDPawnTicketCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object TicketID)
        {
            return (DDPawnTicket.Delete(TicketID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object TicketID)
        {
            return (DDPawnTicket.Destroy(TicketID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? CustomerID,string TicketNumber,string StartDate,string EndDate,int? StatusID)
	    {
		    DDPawnTicket item = new DDPawnTicket();
		    
            item.CustomerID = CustomerID;
            
            item.TicketNumber = TicketNumber;
            
            item.StartDate = StartDate;
            
            item.EndDate = EndDate;
            
            item.StatusID = StatusID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int TicketID,int? CustomerID,string TicketNumber,string StartDate,string EndDate,int? StatusID)
	    {
		    DDPawnTicket item = new DDPawnTicket();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.TicketID = TicketID;
				
			item.CustomerID = CustomerID;
				
			item.TicketNumber = TicketNumber;
				
			item.StartDate = StartDate;
				
			item.EndDate = EndDate;
				
			item.StatusID = StatusID;
				
	        item.Save(UserName);
	    }
    }
}
