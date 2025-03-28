﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Gifte.Repositories.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? UserAccountId { get; set; }

    public decimal? TotalPrice { get; set; }

    public string DeliveryAddress { get; set; }

    public string PaymentStatus { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual UserAccount UserAccount { get; set; }
}