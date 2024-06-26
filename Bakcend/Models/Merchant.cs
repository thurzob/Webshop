﻿using System;
using System.Collections.Generic;

namespace Bakcend.Models;

public partial class Merchant
{
    public int Id { get; set; }

    public string SerialName { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Price { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Quantity> Quantity { get; set; } = new List<Quantity>();

    public virtual User? User { get; set; }
}
