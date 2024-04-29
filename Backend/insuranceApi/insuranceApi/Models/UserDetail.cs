using System;
using System.Collections.Generic;

namespace insuranceApi.Models;

public partial class UserDetail
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserEmployeeid { get; set; } = null!;

    public string UserCompany { get; set; } = null!;

    //public virtual UserCredential User { get; set; } = null!;
}
