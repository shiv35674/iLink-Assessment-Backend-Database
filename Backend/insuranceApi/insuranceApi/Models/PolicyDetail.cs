using System;
using System.Collections.Generic;

namespace insuranceApi.Models;

public partial class PolicyDetail
{
    public int PolicyId { get; set; }

    public string PolicyName { get; set; } = null!;

    public string PolicyInsurer { get; set; } = null!;

    public string PolicyTpa { get; set; } = null!;
}
