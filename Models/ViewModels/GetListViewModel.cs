using NewsForum.Models.ObjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Models.ViewModels
{
    public class GetListViewModel
    {
        public string PageTitle { get; set; }
        public string PageDesc { get; set; }
        public IEnumerable<News> News { get; set; }
    }
}
