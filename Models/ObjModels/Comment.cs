using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Models.ObjModels
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
    }
}
