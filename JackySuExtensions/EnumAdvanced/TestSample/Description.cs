using System;

namespace JPDataExchange.EnumAdvanced.TestSample
{
    [AttributeUsage(AttributeTargets.Field)]
    class Description : Attribute
    {
        private string desc { get; set; }
        public Description(string desc)
        {
            this.desc = desc;
        }
        public override string ToString()
        {
            return desc;
        }
    }
}
