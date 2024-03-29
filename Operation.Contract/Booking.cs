using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Operation.Contract;

namespace Operation.Contract
{

    public class Booking : IContract
    {
        public Booking() { }


        public string BookingNo { get; set; }


        public DateTime BookingDate { get; set; }


        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        public int Status { get; set; }

        public DateTime RequiredDate { get; set; }


        public string LocationFrom { get; set; }


        public string LocationTo { get; set; }


        public string CargoDescription { get; set; }


        public Int16 VehicleType { get; set; }
        public string VehicleTypeDescription { get; set; }

        public Int16 VehicleGroup { get; set; }


        public string Remarks { get; set; }


        public bool IsConfirm { get; set; }


        public DateTime ConfirmDate { get; set; }


        public string DriverID { get; set; }


        public string VehicleNo { get; set; }


        public bool IsCancel { get; set; }


        public DateTime CancelTime { get; set; }


        public string CancelRemarks { get; set; }


        public bool IsComplete { get; set; }


        public DateTime CompleteTime { get; set; }

        public string PayLoad { get; set; }

        public string CargoType { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public decimal ToLatitude { get; set; }

        public decimal ToLongitude { get; set; }

        public string ReceiverMobileNo { get; set; }

        public Int16 LoadingUnLoading { get; set; }

        public string LoadingUnLoadingDescription { get; set; }

        public string OTP { get; set; }
        public string DriverName { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string InvoiceNo { get; set; }
    }
}




