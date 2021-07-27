using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Article:IEntity
    {
        public int ID { get; set; }
        public int MenuId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime RevisedDate { get; set; }

    }
}
