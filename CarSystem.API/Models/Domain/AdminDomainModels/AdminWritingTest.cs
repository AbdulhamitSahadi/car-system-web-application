﻿using CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.AdminDomainModels
{
    public class AdminWritingTest : AdminTrackable<WritingTest, int>
    {
        //[Key]
        //public int Id { get; set; }

        //[ForeignKey("Admin")]
        //public int AdminId { get; set; }
        //public Admin Admin { get; set; }


        //[ForeignKey("WritingTest")]
        //public int WritingTestId { get; set; }
        //public WritingTest WritingTest { get; set; }
    }
}
