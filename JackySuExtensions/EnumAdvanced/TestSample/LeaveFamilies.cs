namespace JPDataExchange.EnumAdvanced.TestSample
{
    enum LeaveFamilies
    {
        [Description("Paid Leave of Absence")]
        [ReferenceID("LEAVE_OF_ABSENCE_FAMILY-6-1")]
        Paid_Leave_of_Absence,
        [Description("Leave of Absence")]
        [ReferenceID("LEAVE_OF_ABSENCE_FAMILY-6-2")]
        Leave_of_Absence,
    }
}
