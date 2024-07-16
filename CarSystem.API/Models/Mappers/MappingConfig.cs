﻿using AutoMapper;
using CarSystem.API.Models.Domain;
using CarSystem.API.Models.DTOs.LicenseClassDTOs;
using CarSystem.API.Models.DTOs.LostLicenseDTOs;
using CarSystem.API.Models.DTOs.NationalityDTOs;
using CarSystem.API.Models.DTOs.PersonDTOs;
using CarSystem.API.Models.DTOs.RenewalLicenseDTOs;
using CarSystem.API.Models.DTOs.TestCategoryDTOs;
using CarSystem.API.Models.DTOs.UserDTOs;

namespace CarSystem.API.Models.Mappers
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CreateAdminDto, Admin>().ReverseMap();
            CreateMap<UpdateAdminDto, Admin>().ReverseMap();
            CreateMap<AdminDto, Admin>().ReverseMap();

            CreateMap<CreateApplicationDto, Application>().ReverseMap();
            CreateMap<UpdateApplicationDto, Application>().ReverseMap();
            CreateMap<ApplicationDto, Application>().ReverseMap();

            CreateMap<CreateDamageLicenseDto, DamageLicense>().ReverseMap();
            CreateMap<UpdateDamageLicenseDto, DamageLicense>().ReverseMap();
            CreateMap<DamageLicenseDto, DamageLicense>().ReverseMap();

            CreateMap<CreateDriverDto, Driver>().ReverseMap();
            CreateMap<UpdateDriverDto, Driver>().ReverseMap();
            CreateMap<DriverDto, Driver>().ReverseMap();

            CreateMap<CreateLicenseDto, License>().ReverseMap();
            CreateMap<UpdateLicenseDto, License>().ReverseMap();
            CreateMap<LicenseDto, License>().ReverseMap();

            CreateMap<CreateLicenseClassDto, LicenseClass>().ReverseMap();
            CreateMap<UpdateLicenseClassDto, LicenseClass>().ReverseMap();
            CreateMap<ReadLicenseClassPermissionDto, LicenseClass>().ReverseMap();

            CreateMap<CreateLostLicenseDto, LostLicense>().ReverseMap();
            CreateMap<UpdateLostLicenseDto, LostLicense>().ReverseMap();
            CreateMap<ReadLostLicensePermissionDto, LostLicense>().ReverseMap();

            CreateMap<CreateNationalityDto, Nationality>().ReverseMap();
            CreateMap<UpdateNationalityDto, Nationality>().ReverseMap();
            CreateMap<ReadNationalityPermissionDto, Nationality>().ReverseMap();

            CreateMap<CreateOptionDto, Option>().ReverseMap();
            CreateMap<UpdateOptionDto, Option>().ReverseMap();
            CreateMap<OptionDto, Option>().ReverseMap();

            CreateMap<CreatePersonDto, Person>().ReverseMap();
            CreateMap<UpdatePersonPermissionDto, Person>().ReverseMap();
            CreateMap<ReadPersonPermissionDto, Person>().ReverseMap();

            CreateMap<CreateQuestionDto, Question>().ReverseMap();
            CreateMap<UpdateQuestionDto, Question>().ReverseMap();  
            CreateMap<QuestionDto, Question>().ReverseMap();

            CreateMap<CreateRenewalLicenseDto, RenewalLicense>().ReverseMap();
            CreateMap<UpdateRenewalLicenseDto, RenewalLicense>().ReverseMap();
            CreateMap<ReadRenewalLicensePermissionDto, RenewalLicense>().ReverseMap();

            CreateMap<CreateTestDto, Test>().ReverseMap();
            CreateMap<UpdateTestDto, Test>().ReverseMap();
            CreateMap<ReadTestDto, Test>().ReverseMap();

            CreateMap<CreateTestCategory, TestCategory>().ReverseMap();
            CreateMap<UpdateTestCategoryPermissionDto, TestCategory>().ReverseMap();
            CreateMap<ReadTestCategoryPermissionDto, TestCategory>().ReverseMap();

            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();
            CreateMap<ReadUserPermissionDto, User>().ReverseMap();

            CreateMap<CreateVisionTestDto, VisionTest>().ReverseMap();
            CreateMap<UpdateVisionTestDto, VisionTest>().ReverseMap();
            CreateMap<VisionTestDto, VisionTest>().ReverseMap();

            CreateMap<CreateWritingTestDto, WritingTest>().ReverseMap();
            CreateMap<UpdateWritingTestDto, WritingTest>().ReverseMap();
            CreateMap<WritingTestDto, WritingTest>().ReverseMap();
        }
    }
}
