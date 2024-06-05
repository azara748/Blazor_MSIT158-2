using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TVip
{
    public int Vipid { get; set; }

    public string? Vipname { get; set; }

    public string? Vipphoto { get; set; }

    public virtual ICollection<TMember> TMembers { get; set; } = new List<TMember>();
}
