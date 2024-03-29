﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Dtos.TaskDto
{
    public class TaskUpdateDto
    { 
            public int TupIdpk { get; set; }

            public DateTime? TupDate { get; set; }

            public int? TupTaskIdfk { get; set; }

            public string? TupUpdate { get; set; }

            public decimal? TupPercentComplete { get; set; }

            public DateTime? TupCompletionDate { get; set; }

            public string? TupUpdatedBy { get; set; }

            public int? TupStatusIdfk { get; set; }

            public bool? TupLocked { get; set; }

            public bool? TupActive { get; set; }

            public string? TupRmks { get; set; }

            public string? TupCreatedBy { get; set; }

            public int? TupEditedBy { get; set; }

            public DateTime? TupCreationDate { get; set; }

            public DateTime? TupEditedDate { get; set; }
    }
}
