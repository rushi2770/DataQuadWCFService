﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WCFService.DataAccessLayer
{
    public partial class tbl_userFilesCollection
    {
        public HttpPostedFileBase File { get; set; }
    }
}
