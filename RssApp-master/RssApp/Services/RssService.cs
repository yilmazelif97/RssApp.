using RssApp.Models;
using RssApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Services
{
    public class RssService
    {

        RssInfoRepo _rssinforepo;

        public RssService(RssInfoRepo rssinforepo)
        {
            _rssinforepo = rssinforepo;
        }

        public void CreateRss(RssInfo rss)
        {

            if (rss==null)
            {
                throw new Exception("Rss boş geçilemez");
            }

            if (string.IsNullOrEmpty(rss.Name))
            {
                throw new Exception("Name kısmı boş geçilemez");
            }

            if (string.IsNullOrEmpty(rss.URL))
            {
                throw new Exception("URL kısmını boş geçemezsiniz");
            }

            if (rss.Priority==0)
            {
                throw new Exception("Priority kısmı boş geçilemez");
            }

            _rssinforepo.AddRss(rss);

        }

      

    }
}
