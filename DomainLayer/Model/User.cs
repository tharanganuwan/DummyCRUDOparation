﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class User
    {
        [Key]
        public long userId { get; set; }
        public string userName { get; set; }
        public string userPhone { get; set; }
        public string userEmailId { get; set; }
        public string userAddress { get; set; }
        public DateTime createDateTime { get; set; }
        public DateTime updateDateTime { get; set; }
    }
}



