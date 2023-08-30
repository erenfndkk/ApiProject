﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concreate
{
    public class Service
    {
        [Key]
        public int ServideID { get; set; }
        public string ServicesIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
