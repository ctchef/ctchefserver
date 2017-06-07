using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChefDemo.Service
{
    public class Index
    {
        public virtual ChefDemo.Models.Index Get()
        {
            return new ChefDemo.Models.Index()
            {
                FirstName = "Chef",
                LastName = "Demo1"
            };
        }
    }
}