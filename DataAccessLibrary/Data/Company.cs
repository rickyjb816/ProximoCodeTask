using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class Company
    {
        public int ID { get; set; }

        public string? Name { get; set; }
        public string? PhoneNumber { get; set; } = "";
        public string? EmailAddress { get; set; } = "";

        #region Address
        public string AddressLine1 { get; set; } = "";
        public string? AddressLine2 { get; set; } = "";
        public string? AddressLine3 { get; set; } = "";
        public string? Town { get; set; } = "";
        public string? County { get; set; } = "";
        public string? Postcode { get; set; } = "";
        #endregion

        public bool Active { get; set; } = true;
        public string? CreatedBy { get; set; } = "SYS Ricky";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; } = "SYS Ricky";
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
