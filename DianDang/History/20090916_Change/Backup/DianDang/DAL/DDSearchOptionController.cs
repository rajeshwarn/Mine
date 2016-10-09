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
    /// Controller class for DDSearchOption
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class DDSearchOptionController
    {
        // Preload our schema..
        DDSearchOption thisSchemaLoad = new DDSearchOption();
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
        public DDSearchOptionCollection FetchAll()
        {
            DDSearchOptionCollection coll = new DDSearchOptionCollection();
            Query qry = new Query(DDSearchOption.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public DDSearchOptionCollection FetchByID(object OptionID)
        {
            DDSearchOptionCollection coll = new DDSearchOptionCollection().Where("OptionID", OptionID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public DDSearchOptionCollection FetchByQuery(Query qry)
        {
            DDSearchOptionCollection coll = new DDSearchOptionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object OptionID)
        {
            return (DDSearchOption.Delete(OptionID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object OptionID)
        {
            return (DDSearchOption.Destroy(OptionID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string OptionName,string FieldName,int? SearchTypeID,string Description)
	    {
		    DDSearchOption item = new DDSearchOption();
		    
            item.OptionName = OptionName;
            
            item.FieldName = FieldName;
            
            item.SearchTypeID = SearchTypeID;
            
            item.Description = Description;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int OptionID,string OptionName,string FieldName,int? SearchTypeID,string Description)
	    {
		    DDSearchOption item = new DDSearchOption();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.OptionID = OptionID;
				
			item.OptionName = OptionName;
				
			item.FieldName = FieldName;
				
			item.SearchTypeID = SearchTypeID;
				
			item.Description = Description;
				
	        item.Save(UserName);
	    }
    }
}