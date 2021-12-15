using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RssApp.Models;
using RssApp.Repositories;
using RssApp.Services;

namespace RssApp.Pages
{

    public class rssViewModel
    {
        public string name { get; set; }
        public string URL { get; set; }
        public int Priority { get; set; }
    }
    public class Page2Model : PageModel
    {

        RssService _rssservice;
        RssInfoRepo _rssinforepo;

        [BindProperty]
        public rssViewModel ViewModel { get; set; }

        public Page2Model(RssService rssservice, RssInfoRepo rssinforepo)
        {
            _rssinforepo = rssinforepo;
            _rssservice = rssservice;
            ViewModel = new rssViewModel();
        }


        [BindProperty]
        public RssInfo rssinfo { get; set; }

        public List<SelectListItem> SelectListItems = new List<SelectListItem>();

        [BindProperty]
        public List<RssInfo> rssinfolist { get; set; }

        [BindProperty]
        public List<RssInfo> rss { get; set; } = new List<RssInfo>();

        [BindProperty]
        public string ID { get; set; }

        [BindProperty]
        public string rssName { get; set; }

        [BindProperty]

        public string url { get; set; }

        [BindProperty]
        public List<SelectListItem> selectedrsss { get; set; } = new List<SelectListItem>();

        [BindProperty]
        public string selectedrss { get; set; }



        public void OnGet()
        {

            rss = _rssinforepo.Get();


            SelectListItems = rss.Select(x => new SelectListItem
            {
                Value = x.Id,
                Text = x.Name

            }).ToList();


           

        }

       
    }
}
