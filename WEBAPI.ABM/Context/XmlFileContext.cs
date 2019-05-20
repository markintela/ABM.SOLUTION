using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.ABM.Models;

namespace WEBAPI.ABM.Context
{
    public class XmlFileContext : DbContext
    {
        public XmlFileContext(DbContextOptions<XmlFileContext> options)
          : base(options)
        {
        }

        public DbSet<XmlFileModel> TodoItems { get; set; }

    }
}
