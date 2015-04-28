﻿using Demo.Library.Command;
using Demo.Library.Responses;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Warehouse.Warehouse.Services
{
    [Api("Warehouse")]
    [Route("/warehouse/warehouse", "POST")]
    public class Create : IReturn<Base<Command>>
    {
        public Guid WarehouseId { get; set; }

        public String Identity { get; set; }

        public String Name { get; set; }
    }
}