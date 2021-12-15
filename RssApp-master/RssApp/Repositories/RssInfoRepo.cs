using RssApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Repositories
{

    public class RssInfoRepo
    {
        private readonly RssAppDBContext _db;

        public RssInfoRepo()
        {
            _db = new RssAppDBContext();
        }


        public void AddRss(RssInfo rss)
        {

            _db.Add(rss);
            _db.SaveChanges();

        }

        public List<RssInfo> Get()
        {
            return _db.RssInfo.ToList();
        }

        public void Update(RssInfo rssinfo)
        {
            _db.RssInfo.Update(rssinfo);
            _db.SaveChanges();
        }

        public RssInfo FindByName(string name)
        {
            return _db.RssInfo.Find(name);

        }

      



    }
}
