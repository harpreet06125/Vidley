﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidley.Models;

namespace Vidley.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Min18YearsIfMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        public MemberShipTypeDto MemberShipType { get; set; }

        public byte MemberShipTypeId { get; set; }


    }
}