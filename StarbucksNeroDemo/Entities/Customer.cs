using NeroStarbucks.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroStarbucks
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateYear { get; set; }
        public string TcNo { get; set; }

    }
}
