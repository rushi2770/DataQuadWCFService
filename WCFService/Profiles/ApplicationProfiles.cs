using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.Profiles
{
    public class ApplicationProfiles : AutoMapper.Profile
    {
        
        public ApplicationProfiles()
        {
            AutoMapper.Mapper.Initialize(
                cfg => cfg.AddProfile<Profiles.ApplicationProfiles>());
            CreateMap<DataAccessLayer.tbl_userDetails, userDetailsModel>();
        }
    }
}
