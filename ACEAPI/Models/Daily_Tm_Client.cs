using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Daily_Tm_Client
    {
        public decimal? TaxIdNumber { get; set; }
        public string ClientNumber { get; set; }
        public string ClientName { get; set; }
        public string ClientId { get; set; }
        public int? RespCode { get; set; }
        public string OfficerName { get; set; }
        public string Name { get; set; }
        public decimal? NameId { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CountryCode { get; set; }
        public DateTime? DateOpened { get; set; }
        public string YearsInBusiness { get; set; }
        public decimal? NaicsCode { get; set; }
    }
}
