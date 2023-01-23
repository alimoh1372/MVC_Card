using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Card.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Customer { get; set; }
        public string Link { get; set; }
        public Project(int id, string name, string image, string description, string customer,string link)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Customer = customer;
            Link = link;
        }
    }


 
  
}
