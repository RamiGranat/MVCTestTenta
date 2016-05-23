using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTestTenta.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Band { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}