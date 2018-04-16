using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WCFService.DataAccessLayer
{
    public partial class tbl_userProfileImages
    {
        //This property is used to send the file from view to controller and then 
        //set the properties to the table respective properties
        public HttpPostedFileBase File { get; set; }
    }
}
