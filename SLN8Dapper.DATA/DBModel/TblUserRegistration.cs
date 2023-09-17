using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.DATA.DBModel
{
    public class TblUserRegistration
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserFname { get; set; }
        [MaxLength(100)]
        public string? UserLname { get; set; }
        [MaxLength(12)]
        public string? UserContact { get; set; }
        [MaxLength(75)]
        public string UserEmail { get; set; }
        public DateTime? DOB { get; set; }
        [MaxLength(20)]
        public string? Gender { get; set; }
        [MaxLength(30)]
        public string? Nationality { get; set; }
        [MaxLength(250)]
        public string? TemporaryAddress { get; set; }
        [MaxLength(250)]
        public string? PermanentAddress { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        public bool IsActive { get; set; }
        public int? UploadFileId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
