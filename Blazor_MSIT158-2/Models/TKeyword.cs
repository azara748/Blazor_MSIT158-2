using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TKeyword
{
    public int? ProductId { get; set; }

    public int TagId { get; set; }

    public string? Festival { get; set; }

    public string? Topic { get; set; }

    public string? Color { get; set; }

    public string Tag { get; set; } = null!;

    public virtual TProduct? Product { get; set; }
}
