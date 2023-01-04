using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class Address
    {
        [Required]
        [StringLength(50, ErrorMessage = "Address Line 1 is Too Long")]
        [MinLength(2, ErrorMessage = "Address Line 1 is Too Short")]
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; } = "";
        public string? AddressLine3 { get; set; } = "";

        [Required]
        [StringLength(100, ErrorMessage = "Town is Too Long")]
        [MinLength(2, ErrorMessage = "Town is Too Short")]
        public string? Town { get; set; } = "";
        public string? County { get; set; } = "";

        [Required]
        [StringLength(10, ErrorMessage = "Postcode is Too Long")]
        [MinLength(2, ErrorMessage = "Postcode is Too Short")]
        public string? Postcode { get; set; } = "";
    }
}
