﻿using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftSafetyGroupSafetyMeetingProperty
{
    public int SmpIdpk { get; set; }

    public int? SmpGroupIdfk { get; set; }

    public DateTime? SmpStartDate { get; set; }

    public DateTime? SmpEndDate { get; set; }

    public bool SmpActive { get; set; }

    public string SmpRmks { get; set; } = null!;

    public int? SmpCreatedBy { get; set; }

    public int? SmpEditedBy { get; set; }

    public int SmpNoOfAnnualSafetyMeetings { get; set; }

    public int SmpNoOfAnnualCompulsaryMeetingAttendance { get; set; }

    public int SmpNoOfFirstQuarterSafetyMeetings { get; set; }

    public int SmpNoOfSecondQuarterSafetyMeetings { get; set; }

    public int? SmpNoOfThirdQuarterSafetyMeetings { get; set; }

    public int? SmpNoOfFourthQuarterSafetyMeetings { get; set; }

    public int? SmpMinMeetingDuration { get; set; }

    public int? SmpMaxMeetingDuration { get; set; }

    public byte? SmpNoOfJanuaryMeetings { get; set; }

    public byte? SmpNoOfFebruaryMeetings { get; set; }

    public byte? SmpNoOfMarchMeetings { get; set; }

    public byte? SmpNoOfAprilMeetings { get; set; }

    public byte? SmpNoOfMayMeetings { get; set; }

    public byte? SmpNoOfJuneMeetings { get; set; }

    public byte? SmpNoOfJulyMeetings { get; set; }

    public byte? SmpNoOfAugustMeetings { get; set; }

    public byte? SmpNoOfSeptemberMeetings { get; set; }

    public byte? SmpNoOfOctoberMeetings { get; set; }

    public byte? SmpNoOfNovemberMeetings { get; set; }

    public byte? SmpNoOfDecemberMeetings { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public string? SgpCodeName { get; set; }

    public bool? SgpSafetyGroup { get; set; }

    public bool? SgpTechnicalGroup { get; set; }

    public bool? SgpMasterGroup { get; set; }
}
