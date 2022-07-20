﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Karnosh.Models
{
    [Index("Name",  IsUnique = true)]
    public class Year
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Video> ?Video { get; set; }
    }
}
