using System;
using System.Collections.Generic;

namespace insuranceApi.Models;

public partial class UserCredential
{
    public int UserId { get; set; }

    public string UserUsername { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    //public virtual ICollection<UserPaymentDetail> UserPaymentDetails { get; set; } = new List<UserPaymentDetail>();
}
