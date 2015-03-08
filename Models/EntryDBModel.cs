using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeWebPage.Models
{
    public class EntryDbModel : DbContext
    {
        //
        // GET: /EntryDBModel/

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }

    public class EntryDbContext : DbContext
    {
    public DbSet<EntryDbModel> Entry { get; set; }

    }
}
