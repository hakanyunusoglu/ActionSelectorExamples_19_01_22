using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelDB.Models
{
    public class MultiModel
    {
        public List<Product> pList { get; set; }
        public List<Category> cList { get; set; }
    }
}