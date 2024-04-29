using System;
using System.Collections.Generic;

namespace insuranceApi.Models;

public partial class UserPolicy
{
    public int UserId { get; set; }

    public int PolicyId { get; set; }

    public DateOnly UserPolicyfrom { get; set; }

    public DateOnly UserPolicyto { get; set; }

    //public virtual PolicyDetail Policy { get; set; } = null!;

    //public virtual UserCredential User { get; set; } = null!;
}
