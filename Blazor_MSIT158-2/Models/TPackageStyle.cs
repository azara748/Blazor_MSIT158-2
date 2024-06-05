using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TPackageStyle
{
    public int PackageStyleId { get; set; }

    public string StyleName { get; set; } = null!;

    public string? Picture { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TAllPackage> TAllPackages { get; set; } = new List<TAllPackage>();
}
