using NewsForum.Models.ObjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Models.ViewModels
{
    public class GetItemViewModel
    {
        public int? Offset { get; set; }
        public News News { get; set; }
    }
}
