﻿using System;
using System.Collections.Generic;

namespace RazorPagesIntroLab1._1.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
