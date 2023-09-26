﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.MODEL.ViewModel
{
    public class CountryMasterVM
    {
        public int Id { get; set; }
        public string? CountryName { get; set; }
        public string? CountryAbb { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? IsCountryActive { get; set; }
    }
}
