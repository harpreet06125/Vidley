﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidley.Models;

namespace Vidley.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}