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
    public class Page1Model : PageModel
    {

        RssService _rssservice;
        RssInfoRepo _rssinforepo;

        public Page1Model(RssService rssservice, RssInfoRepo rssinforepo)
        {
            _rssinforepo = rssinforepo;
            _rssservice = rssservice;
        }

        [BindProperty]
        public Priority priority { get; set; }

        [BindProperty]
        public RssInfo rssinfo { get; set; }

        public List<SelectListItem> SelectListItems = new List<SelectListItem>();



        public void OnGet()
        {

        }

        public void OnPostSave()
        {

            // _rssservice.SetPriority(rssinfo, priority);

            rssinfo.Priority = (int)priority;

            _rssservice.CreateRss(rssinfo);



        }
    }
}
                           