﻿using CarSystem.API.Models.Domain.AdminDomainModels;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class DamageLicense : DomainTrackable<AdminDamageLicense>
    {
        //[Key]
        //public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(License))]
        public int LicenseId { get; set; }
        public License License { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateReported { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        [Required]
        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        [Required]
        [StringLength(200)]
        public string Reason { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        //[Required]
        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }
    }
}
