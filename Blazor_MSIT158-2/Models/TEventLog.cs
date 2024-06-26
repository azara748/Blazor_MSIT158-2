﻿using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TEventLog
{
    public int EventId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ProductId { get; set; }

    public string? EventDateTime { get; set; }

    public string? EventBrief { get; set; }

    public virtual TEmployee? Employee { get; set; }
}
