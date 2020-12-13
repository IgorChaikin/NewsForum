using NewsForum.Models.ObjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Models.ViewModels
{
    public class EditFormViewModel
    {
        public News News { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
