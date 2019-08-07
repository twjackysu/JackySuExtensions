using System;

namespace JPDataExchange.EnumAdvanced.TestSample
{
    [AttributeUsage(AttributeTargets.Field)]
    class ReferenceID : Attribute
    {
        private string id;
        public ReferenceID(string id)
        {
            this.id = id;
        }
        public override string ToString()
        {
            return id;
        }
    }
}
