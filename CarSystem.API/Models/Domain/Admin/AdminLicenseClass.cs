﻿using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.Admin
{
    public class AdminLicenseClass : Trackable
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }


        [ForeignKey("LicenseClass")]
        public int LicenseClassId { get; set; }
        public LicenseClass LicenseClass { get; set; }
    }
}
