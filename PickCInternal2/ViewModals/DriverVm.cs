using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Master.Contract;
using PickC.Services.DTO;

namespace PickC.Internal2.ViewModals
{
    public class DriverVm
    {
        public Driver driver { get; set; }
        public Operator Operator { get; set; }
        public DriverLookupDTO driverLookupDTO { get; set; }
    }
}