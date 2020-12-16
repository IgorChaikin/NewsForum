using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Models.ObjModels
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string ShortDesc { get; set; }
        public string Desc { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
