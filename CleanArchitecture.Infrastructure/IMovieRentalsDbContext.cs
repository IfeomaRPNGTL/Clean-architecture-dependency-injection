﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    public interface IMovieRentalsDbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
