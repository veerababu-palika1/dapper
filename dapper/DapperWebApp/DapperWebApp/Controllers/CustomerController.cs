﻿using DapperWebData.BusinessManagers;
using DapperWebData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DapperWebApp.Controllers
{
    public class CustomerController : BaseController<CustomerBusinessManager, Customer>
    {
    }
}
