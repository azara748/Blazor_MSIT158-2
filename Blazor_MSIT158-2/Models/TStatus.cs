using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TStatus
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<TOrder> TOrders { get; set; } = new List<TOrder>();
}
