using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.DATA.DBModel
{
    public class TblUserLogin
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        [Required(ErrorMessage ="Please enter yout user name")]
        [MaxLength(20)]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [StringLength(20)]
        public string? UserPasswordText { get; set; }
        [StringLength(220)]
        public string? UserPasswordEncrypted { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
