﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Gifte.Services.BusinessModel.OrderModel
{
    public class CreateOrderModel
    {
        [JsonIgnore]
        public string CustomerEmail { get; set; } = "";

        public int? ShipFee { get; set; }

        public string? VoucherCode { get; set; }

        public List<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();
    }

    public class ProductOrder
    {
        public int ProductId { get; set; }

        public int ProductUnitId { get; set; }

        public int Quantity { get; set; }
    }
}
