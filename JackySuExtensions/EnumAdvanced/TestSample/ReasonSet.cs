using System;

namespace JPDataExchange.EnumAdvanced.TestSample
{
    [AttributeUsage(AttributeTargets.Field)]
    class ReasonSet : Attribute
    {
        public LeaveReasons Yes { get; set; }
        public LeaveReasons No { get; set; }
        public ReasonSet(LeaveReasons no, LeaveReasons yes)
        {
            Yes = yes;
            No = no;
        }
    }
}
