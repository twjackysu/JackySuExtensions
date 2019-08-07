using System;

namespace JPDataExchange.EnumAdvanced.TestSample
{
    [AttributeUsage(AttributeTargets.Field)]
    class Eligible : Attribute
    {
        public EligibleForVSCashOutDuringLOA EligibleForVSCashOutDuringLOA { get; set; }
        public Eligible(EligibleForVSCashOutDuringLOA eligibleForVSCashOutDuringLOA)
        {
            EligibleForVSCashOutDuringLOA = eligibleForVSCashOutDuringLOA;
        }
        public override string ToString()
        {
            return EligibleForVSCashOutDuringLOA.ToString();
        }
    }
}
