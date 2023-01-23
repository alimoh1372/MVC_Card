using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Card.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public  string Image { get; set; }
        public string Context { get; set; }
        public string Link { get; set; }

        public Article(int id, string title, string image, string context, string link)
        {
            Id = id;
            Title = title;
            Image = image;
            Context = context;
            Link = link;
        }
    }
    
}
