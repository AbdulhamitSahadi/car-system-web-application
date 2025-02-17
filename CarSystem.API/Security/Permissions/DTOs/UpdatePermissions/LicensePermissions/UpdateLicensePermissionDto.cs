﻿using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.LicensePermissions
{
    public class UpdateLicensePermissionDto
    {

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public int LicenseNumber { get; set; }


        [Required]
        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }


        [Required]
        public LicenseClassType LicenseClassType { get; set; }


        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public bool IsActive { get; set; }


        public Status Status { get; set; }


        [Required]
        public ApplicationType ReleaseType { get; set; }
    }
}
