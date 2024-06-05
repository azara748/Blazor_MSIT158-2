﻿using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TActive
{
    public int ActiveId { get; set; }

    public string? ActiveName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? Discount { get; set; }

    public string? Description { get; set; }

    public byte[]? ActiveImage { get; set; }

    public virtual ICollection<TProduct> TProducts { get; set; } = new List<TProduct>();
}
