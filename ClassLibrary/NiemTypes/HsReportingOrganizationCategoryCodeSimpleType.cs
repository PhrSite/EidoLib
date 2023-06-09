/*
 * NiemTypes
 *
 * NIEM Types for the EIDO
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NiemTypes
{ 
        /// <summary>
        /// A data type for a kind of an organization reporting information.
        /// </summary>
        /// <value>A data type for a kind of an organization reporting information.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HsReportingOrganizationCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum AdvocateEnum for Advocate
            /// </summary>
            [EnumMember(Value = "Advocate")]
            AdvocateEnum = 0,
            /// <summary>
            /// Enum CommunityActionOrganizationEnum for Community Action Organization
            /// </summary>
            [EnumMember(Value = "Community Action Organization")]
            CommunityActionOrganizationEnum = 1,
            /// <summary>
            /// Enum ConsultantEnum for Consultant
            /// </summary>
            [EnumMember(Value = "Consultant")]
            ConsultantEnum = 2,
            /// <summary>
            /// Enum EducationalDepartmentEnum for Educational Department
            /// </summary>
            [EnumMember(Value = "Educational Department")]
            EducationalDepartmentEnum = 3,
            /// <summary>
            /// Enum ElementaryAndSecondarySchoolEnum for Elementary and Secondary School
            /// </summary>
            [EnumMember(Value = "Elementary and Secondary School")]
            ElementaryAndSecondarySchoolEnum = 4,
            /// <summary>
            /// Enum EnvironmentalOrganizationEnum for Environmental Organization
            /// </summary>
            [EnumMember(Value = "Environmental Organization")]
            EnvironmentalOrganizationEnum = 5,
            /// <summary>
            /// Enum FinancialInstitutionEnum for Financial Institution
            /// </summary>
            [EnumMember(Value = "Financial Institution")]
            FinancialInstitutionEnum = 6,
            /// <summary>
            /// Enum HealthDepartmentEnum for Health Department
            /// </summary>
            [EnumMember(Value = "Health Department")]
            HealthDepartmentEnum = 7,
            /// <summary>
            /// Enum HospitalEnum for Hospital
            /// </summary>
            [EnumMember(Value = "Hospital")]
            HospitalEnum = 8,
            /// <summary>
            /// Enum IndianTribalProgramEnum for Indian Tribal Program
            /// </summary>
            [EnumMember(Value = "Indian Tribal Program")]
            IndianTribalProgramEnum = 9,
            /// <summary>
            /// Enum IntermediaryOrganizationEnum for Intermediary Organization
            /// </summary>
            [EnumMember(Value = "Intermediary Organization")]
            IntermediaryOrganizationEnum = 10,
            /// <summary>
            /// Enum JuniorCollegeCollegeAndUniversityEnum for Junior College, College and University
            /// </summary>
            [EnumMember(Value = "Junior College, College and University")]
            JuniorCollegeCollegeAndUniversityEnum = 11,
            /// <summary>
            /// Enum LawEnforcementAgencyEnum for Law Enforcement Agency
            /// </summary>
            [EnumMember(Value = "Law Enforcement Agency")]
            LawEnforcementAgencyEnum = 12,
            /// <summary>
            /// Enum LibraryAndMuseumEnum for Library and Museum
            /// </summary>
            [EnumMember(Value = "Library and Museum")]
            LibraryAndMuseumEnum = 13,
            /// <summary>
            /// Enum NursingHomeOROtherDomiciliaryCareFacilityEnum for Nursing Home OR Other Domiciliary Care Facility
            /// </summary>
            [EnumMember(Value = "Nursing Home OR Other Domiciliary Care Facility")]
            NursingHomeOROtherDomiciliaryCareFacilityEnum = 14,
            /// <summary>
            /// Enum OtherEducationalOrganizationEnum for Other Educational Organization
            /// </summary>
            [EnumMember(Value = "Other Educational Organization")]
            OtherEducationalOrganizationEnum = 15,
            /// <summary>
            /// Enum OtherHealthOrganizationEnum for Other Health Organization
            /// </summary>
            [EnumMember(Value = "Other Health Organization")]
            OtherHealthOrganizationEnum = 16,
            /// <summary>
            /// Enum OtherSocialServicesOrganizationEnum for Other Social Services Organization
            /// </summary>
            [EnumMember(Value = "Other Social Services Organization")]
            OtherSocialServicesOrganizationEnum = 17,
            /// <summary>
            /// Enum OtherSpecialInterestOrganizationEnum for Other Special Interest Organization
            /// </summary>
            [EnumMember(Value = "Other Special Interest Organization")]
            OtherSpecialInterestOrganizationEnum = 18,
            /// <summary>
            /// Enum PlanningAndAdministrativeOrganizationsEnum for Planning and Administrative Organizations
            /// </summary>
            [EnumMember(Value = "Planning and Administrative Organizations")]
            PlanningAndAdministrativeOrganizationsEnum = 19,
            /// <summary>
            /// Enum RehabilitationOrganizationEnum for Rehabilitation Organization
            /// </summary>
            [EnumMember(Value = "Rehabilitation Organization")]
            RehabilitationOrganizationEnum = 20,
            /// <summary>
            /// Enum ResearchInstitutionFoundationAndLaboratoryEnum for Research Institution, Foundation and Laboratory
            /// </summary>
            [EnumMember(Value = "Research Institution, Foundation and Laboratory")]
            ResearchInstitutionFoundationAndLaboratoryEnum = 21,
            /// <summary>
            /// Enum SchoolBoardAndSchoolDistrictEnum for School Board and School District
            /// </summary>
            [EnumMember(Value = "School Board and School District")]
            SchoolBoardAndSchoolDistrictEnum = 22,
            /// <summary>
            /// Enum ShelterEnum for Shelter
            /// </summary>
            [EnumMember(Value = "Shelter")]
            ShelterEnum = 23,
            /// <summary>
            /// Enum SubstanceAbuseTreatmentCenterEnum for Substance Abuse Treatment Center
            /// </summary>
            [EnumMember(Value = "Substance Abuse Treatment Center")]
            SubstanceAbuseTreatmentCenterEnum = 24,
            /// <summary>
            /// Enum SupplierOrganizationsEnum for Supplier Organizations
            /// </summary>
            [EnumMember(Value = "Supplier Organizations")]
            SupplierOrganizationsEnum = 25,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 26,
            /// <summary>
            /// Enum VocationalAndTrainingSchoolEnum for Vocational and Training School
            /// </summary>
            [EnumMember(Value = "Vocational and Training School")]
            VocationalAndTrainingSchoolEnum = 27,
            /// <summary>
            /// Enum WelfareDepartmentEnum for Welfare Department
            /// </summary>
            [EnumMember(Value = "Welfare Department")]
            WelfareDepartmentEnum = 28        }
}
