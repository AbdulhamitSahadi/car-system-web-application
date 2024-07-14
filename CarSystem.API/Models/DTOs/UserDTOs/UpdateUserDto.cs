﻿using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.UserDTOs
{
    public class UpdateUserDto
    {
        public int Id { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
