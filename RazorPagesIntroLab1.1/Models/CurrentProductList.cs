﻿using System;
using System.Collections.Generic;

namespace RazorPagesIntroLab1._1.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
