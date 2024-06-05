﻿using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TPurchase
{
    public int OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Qty { get; set; }

    public string? Memo { get; set; }

    public int PurchaseId { get; set; }

    public decimal? PurchaseAmount { get; set; }

    public virtual TOrder Order { get; set; } = null!;

    public virtual TProduct? Product { get; set; }
}
