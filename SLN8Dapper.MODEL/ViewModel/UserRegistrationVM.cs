using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.MODEL.ViewModel
{
    public class UserRegistrationVM
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? UserContact { get; set; }
        public string EmailId { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public string? TempAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public string? City { get; set; }
        //public bool IsActive { get; set; }
        //public int? UploadFileId { get; set; }
        //public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        //public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
