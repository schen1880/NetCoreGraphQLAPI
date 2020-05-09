using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Daily_CollateralExtract
    {
        public string NameId { get; set; }
        public string NoteNumber { get; set; }
        public decimal? CollateralCode { get; set; }
        public string CollateralCodeDesc { get; set; }
        public string CollateralId { get; set; }
        public string CollateralIdentifier { get; set; }
        public decimal? OrigCollateralValue { get; set; }
        public decimal? CollateralValue { get; set; }
        public string ProductDescription { get; set; }
        public string OwnerOccupiedCodeDesc { get; set; }
        public string Description1 { get; set; }
        public decimal? AppraisalValue { get; set; }
        public decimal? DateAppraised { get; set; }
        public string Comment { get; set; }
    }
}
