﻿using System;
using System.Collections.Generic;

namespace Blazor_MSIT158_2.Models;

public partial class TSubCategory
{
    public int SubCategoryId { get; set; }

    public string? SubCategoryName { get; set; }

    public string? SubCategoryCname { get; set; }

    public int? CategoryId { get; set; }

    public virtual TCategory? Category { get; set; }

    public virtual ICollection<TProduct> TProducts { get; set; } = new List<TProduct>();
}
