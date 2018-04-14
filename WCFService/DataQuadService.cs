using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.DataAccessLayer;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataQuadService" in both code and config file together.
    public class DataQuadService : IDataQuadService
    {
        private DataquadEntities db = new DataquadEntities();
        public userDetailsModel GetUserDetailByUserId(int id)
        {
            //userDetailsModel user = new userDetailsModel();
            try
            {
                var userDetailsFromDb = db.tbl_userDetails.Where(x => x.userId == id).FirstOrDefault();
                //Creating AutoMapper Map for tbl_userDetails as source and userDetailsModel as destination
                var config = new AutoMapper.MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<DataAccessLayer.tbl_userDetails, userDetailsModel>();
                });

                //Initiliazing or create an instance of mapper
                AutoMapper.IMapper mapper = config.CreateMapper();

                //Automapping userDetailsFromDb to userDetailsModel
                var userDetailsModel = mapper.Map<userDetailsModel>(userDetailsFromDb);
                
                
                #region copying data from database table to view model by each property
                //user.userId = data.userId;
                //user.FirstName = data.FirstName;
                //user.LastName = data.LastName;
                //user.password = data.password;
                //user.resetPasswordCode = data.resetPasswordCode;
                //user.dateOfBirth = data.dateOfBirth;
                //user.emailId = data.emailId;
                //user.activationCode = data.activationCode;
                //user.isEmailVerified = data.isEmailVerified;
                //user.tbl_userPersonalDetail = data.tbl_userPersonalDetail; 
                #endregion

                return userDetailsModel;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string sample()
        {
            return "test success";
        }



        //[DataContract]
        //public class tbl_userDetails
        //{
            
        //   [DataMember]
        //    public int userId { get; set; }
        //    [DataMember]
        //    public string FirstName { get; set; }
        //    [DataMember]
        //    public string LastName { get; set; }
        //    [DataMember]
        //    public string emailId { get; set; }
        //    public System.DateTime dateOfBirth { get; set; }
        //    public string password { get; set; }
        //    public bool isEmailVerified { get; set; }
        //    public System.Guid activationCode { get; set; }
        //    public string resetPasswordCode { get; set; }

           
        //}
    }
}
