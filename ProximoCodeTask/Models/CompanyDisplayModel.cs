using DataAccessLibrary.Data;
using System.ComponentModel.DataAnnotations;

namespace ProximoCodeTask.Models
{
    public class CompanyDisplayModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Company Name is Too Long")]
        [MinLength(0, ErrorMessage = "Company Name is Too Short")]
        public string? Name { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "Phone Number is Too Long")]
        [MinLength(11, ErrorMessage = "Phone Number is Too Short")]
        public string? PhoneNumber { get; set; } = "";

        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; } = "";

        #region Address
        [Required]
        [StringLength(50, ErrorMessage = "Address Line 1 is Too Long")]
        [MinLength(1, ErrorMessage = "Address Line 1 is Too Short")]
        public string AddressLine1 { get; set; } = "";
        public string? AddressLine2 { get; set; } = "";
        public string? AddressLine3 { get; set; } = "";
        [Required]
        [StringLength(50, ErrorMessage = "Town is Too Long")]
        [MinLength(1, ErrorMessage = "Town is Too Short")]
        public string? Town { get; set; } = "";
        public string? County { get; set; } = "";
        [Required]
        [StringLength(50, ErrorMessage = "Postcode is Too Long")]
        [MinLength(1, ErrorMessage = "Postcode is Too Short")]
        public string? Postcode { get; set; } = "";
        #endregion

        public bool Active { get; set; } = true;

        public string? CreatedBy { get; set; } = "SYS Ricky";
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public CompanyDisplayModel() { }

        public CompanyDisplayModel(Company company)
        {
            ID = company.ID;
            Name = company.Name;
            PhoneNumber = company.PhoneNumber;
            EmailAddress = company.EmailAddress;
            AddressLine1 = company.AddressLine1;
            AddressLine2 = company.AddressLine2;
            AddressLine3 = company.AddressLine3;
            Town = company.Town;
            County = company.County;
            Postcode = company.Postcode;
            Active = company.Active;
            CreatedBy = company.CreatedBy;
            CreatedDate = company.CreatedDate;
            UpdatedBy = company.UpdatedBy;
            UpdatedDate = company.UpdatedDate;
        }

        public Company ToDataModel() => new Company
        {
            ID = this.ID,
            Name = this.Name,
            PhoneNumber = this.PhoneNumber,
            EmailAddress = this.EmailAddress,
            AddressLine1 = this.AddressLine1,
            AddressLine2 = this.AddressLine2,
            AddressLine3 = this.AddressLine3,
            Town = this.Town,
            County = this.County,
            Postcode = this.Postcode,
            Active = this.Active,
            CreatedDate = this.CreatedDate,
            CreatedBy = this.CreatedBy,
            UpdatedDate = this.UpdatedDate,
            UpdatedBy = this.UpdatedBy,
        };
    }
}
