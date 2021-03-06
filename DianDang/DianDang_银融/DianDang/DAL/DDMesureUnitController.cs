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
    /// Controller class for DDMesureUnit
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class DDMesureUnitController
    {
        // Preload our schema..
        DDMesureUnit thisSchemaLoad = new DDMesureUnit();
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
        public DDMesureUnitCollection FetchAll()
        {
            DDMesureUnitCollection coll = new DDMesureUnitCollection();
            Query qry = new Query(DDMesureUnit.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public DDMesureUnitCollection FetchByID(object UnitID)
        {
            DDMesureUnitCollection coll = new DDMesureUnitCollection().Where("UnitID", UnitID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public DDMesureUnitCollection FetchByQuery(Query qry)
        {
            DDMesureUnitCollection coll = new DDMesureUnitCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object UnitID)
        {
            return (DDMesureUnit.Delete(UnitID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object UnitID)
        {
            return (DDMesureUnit.Destroy(UnitID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string UnitName,string UnitType,string Description)
	    {
		    DDMesureUnit item = new DDMesureUnit();
		    
            item.UnitName = UnitName;
            
            item.UnitType = UnitType;
            
            item.Description = Description;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int UnitID,string UnitName,string UnitType,string Description)
	    {
		    DDMesureUnit item = new DDMesureUnit();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.UnitID = UnitID;
				
			item.UnitName = UnitName;
				
			item.UnitType = UnitType;
				
			item.Description = Description;
				
	        item.Save(UserName);
	    }
    }
}
