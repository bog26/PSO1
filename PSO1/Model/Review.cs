﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class Review : IPSOEntity, ISearchProductId, ISearchUserId
    {
        public int Id { get; set; }
        public int ReviewMark { get; set; }
        public string ReviewText { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}
