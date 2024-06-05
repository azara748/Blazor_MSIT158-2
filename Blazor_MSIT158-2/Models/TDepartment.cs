using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TDepartment
{
    public int DepId { get; set; }

    public string? DepName { get; set; }

    public virtual ICollection<TEmployee> TEmployees { get; set; } = new List<TEmployee>();
}
