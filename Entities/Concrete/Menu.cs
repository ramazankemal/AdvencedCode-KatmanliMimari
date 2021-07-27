using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Menu:IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
