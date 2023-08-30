﻿using HotelProject.EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concreate
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERMISH\\SQLEXPRESS01;initial catalog=ApiDb;integrated security=true");
        }
        public DbSet <Room> Rooms { get; set; }
        public DbSet <Service> Services { get; set; }
        public DbSet <Staff> Staffs { get; set; }
        public DbSet <Subscribe> Subscribes { get; set; }
        public DbSet <Testimonial> Testimonials { get; set; }
    }
}
