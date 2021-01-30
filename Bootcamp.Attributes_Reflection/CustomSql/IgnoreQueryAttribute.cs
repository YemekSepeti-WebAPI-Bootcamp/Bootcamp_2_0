using System;

namespace Bootcamp.Attributes_Reflection.CustomSql
{
    public class IgnoreQueryAttribute : Attribute
    {

        public bool Select { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }


        public IgnoreQueryAttribute(bool allowSelect, bool allowInsert, bool allowUpdate)
        {
            this.Select = allowSelect;
            this.Insert = allowInsert;
            this.Update = allowUpdate;
        }

    }
}
