using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Models.ObjModels
{
    public class Category
    {
        /*----------------------------------*/
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }

        public IEnumerable<News> News { get; set; }
    }
}
