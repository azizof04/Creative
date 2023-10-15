using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Models
{
    public class Portfolio
    {
        public int  id { get; set; }
        public string  ProjectName { get; set; }
        public string  PhotoUrl { get; set; }
        public string  CategoryId { get; set; }
        public Category  Category { get; set; }
        public string  FootTitle { get; set; }
        
        
        
    }
}