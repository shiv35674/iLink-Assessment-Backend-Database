using System;
using System.Collections.Generic;

namespace insuranceApi.Models;

public partial class UserPaymentDetail
{
    public int PaymentId { get; set; }

    public string UserCardname { get; set; } = null!;

    public long UserCardnumber { get; set; }

    public int UserCvv { get; set; }

    public string UserCardvalidity { get; set; } = null!;

    public int? UserId { get; set; }

    //public virtual UserCredential? User { get; set; }
}
