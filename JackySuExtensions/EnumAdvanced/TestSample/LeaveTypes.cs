namespace JPDataExchange.EnumAdvanced.TestSample
{
    enum LeaveTypes
    {
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_1, LeaveReasons.LEAVE_TYPE_REASON_6_2)]
        [Description("California Family Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-1")]
        California_Family_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_3, LeaveReasons.LEAVE_TYPE_REASON_6_4)]
        [Description("Unpaid Partial /Ttl Disability")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-2")]
        Unpaid_Partial_Ttl_Disability,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_5, LeaveReasons.LEAVE_TYPE_REASON_6_6)]
        [Description("Unpaid Bereavement Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-3")]
        Unpaid_Bereavement_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_7, LeaveReasons.LEAVE_TYPE_REASON_6_8)]
        [Description("Unpaid Birth of adoption Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-4")]
        Unpaid_Birth_of_adoption_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_9, LeaveReasons.LEAVE_TYPE_REASON_6_10)]
        [Description("Unpaid Child Care Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-5")]
        Unpaid_Child_Care_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_11, LeaveReasons.LEAVE_TYPE_REASON_6_12)]
        [Description("Unpaid Compassionate Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-6")]
        Unpaid_Compassionate_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_13, LeaveReasons.LEAVE_TYPE_REASON_6_14)]
        [Description("Unpaid Education Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-7")]
        Unpaid_Education_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_15, LeaveReasons.LEAVE_TYPE_REASON_6_16)]
        [Description("Unpaid Extended Travel Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-8")]
        Unpaid_Extended_Travel_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_17, LeaveReasons.LEAVE_TYPE_REASON_6_18)]
        [Description("Unpaid Family & Medical Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-9")]
        Unpaid_Family_Medical_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_19, LeaveReasons.LEAVE_TYPE_REASON_6_20)]
        [Description("Unpaid Family Nursing")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-10")]
        Unpaid_Family_Nursing,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_21, LeaveReasons.LEAVE_TYPE_REASON_6_22)]
        [Description("Unpaid Injury Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-11")]
        Unpaid_Injury_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_23, LeaveReasons.LEAVE_TYPE_REASON_6_24)]
        [Description("Unpaid Jury Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-12")]
        Unpaid_Jury_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_25, LeaveReasons.LEAVE_TYPE_REASON_6_26)]
        [Description("Unpaid Long Term Disability")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-13")]
        Unpaid_Long_Term_Disability,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_27, LeaveReasons.LEAVE_TYPE_REASON_6_28)]
        [Description("Unpaid Marriage-Family Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-14")]
        Unpaid_Marriage_Family_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_29, LeaveReasons.LEAVE_TYPE_REASON_6_30)]
        [Description("Unpaid Marriage-Own Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-15")]
        Unpaid_Marriage_Own_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_31, LeaveReasons.LEAVE_TYPE_REASON_6_32)]
        [Description("Unpaid Maternity/Paternity")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-16")]
        Unpaid_Maternity_Paternity,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_33, LeaveReasons.LEAVE_TYPE_REASON_6_34)]
        [Description("Unpaid Military Service Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-17")]
        Unpaid_Military_Service_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_35, LeaveReasons.LEAVE_TYPE_REASON_6_36)]
        [Description("Unpaid Personal Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-18")]
        Unpaid_Personal_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_37, LeaveReasons.LEAVE_TYPE_REASON_6_38)]
        [Description("Unpaid Short Term Disability")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-19")]
        Unpaid_Short_Term_Disability,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_39, LeaveReasons.LEAVE_TYPE_REASON_6_40)]
        [Description("Unpaid Sickness Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-20")]
        Unpaid_Sickness_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_41, LeaveReasons.LEAVE_TYPE_REASON_6_42)]
        [Description("Unpaid Statutory Holiday")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-21")]
        Unpaid_Statutory_Holiday,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_43, LeaveReasons.LEAVE_TYPE_REASON_6_44)]
        [Description("Worker's Compensation")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-22")]
        Worker_Compensation,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_45, LeaveReasons.LEAVE_TYPE_REASON_6_46)]
        [Description("Long Term Disability with Pay")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-23")]
        Long_Term_Disability_with_Pay,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_47, LeaveReasons.LEAVE_TYPE_REASON_6_48)]
        [Description("Other Special Reason")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-24")]
        Other_Special_Reason,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_49, LeaveReasons.LEAVE_TYPE_REASON_6_50)]
        [Description("Paid Maternity Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-25")]
        Paid_Maternity_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_51, LeaveReasons.LEAVE_TYPE_REASON_6_52)]
        [Description("Paid Paternity Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-26")]
        Paid_Paternity_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_53, LeaveReasons.LEAVE_TYPE_REASON_6_54)]
        [Description("Parental Leave")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-27")]
        Parental_Leave,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_55, LeaveReasons.LEAVE_TYPE_REASON_6_56)]
        [Description("STD – Salary Continuance")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-28")]
        STD_Salary_Continuance,
        [ReasonSet(LeaveReasons.LEAVE_TYPE_REASON_6_57, LeaveReasons.LEAVE_TYPE_REASON_6_58)]
        [Description("Short Term Disability with Pay")]
        [ReferenceID("LEAVE_OF_ABSENCE_TYPE-6-29")]
        Short_Term_Disability_with_Pay
    }
}
