using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp.Attributes_Reflection.CustomSql
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [IgnoreQuery(allowSelect: true, allowInsert: false, allowUpdate: false)]
        public DateTime BirtDate { get; set; }
        public int Age { get; set; }
    }
}
