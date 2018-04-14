using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.DataAccessLayer;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataQuadService" in both code and config file together.
    [ServiceContract]
    public interface IDataQuadService
    {
        [OperationContract]
        //WCFService.DataQuadService.tbl_userDetails GetUserDetailByUserId(int id);
        userDetailsModel GetUserDetailByUserId(int id);
        [OperationContract]
        string sample();

    }


}
