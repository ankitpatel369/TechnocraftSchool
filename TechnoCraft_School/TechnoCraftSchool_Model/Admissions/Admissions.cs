﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechnoCraftSchool_Model
{
    public class Admissions
    {
        [Key]
        public long Admission_ID { get; set; }

        [Required]
        [Display(Name = "Academic Year")]
        public int AcademicYear_ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Student Photo")]
        public string StudentPhoto { get; set; }

        [Required]
        [Display(Name = "Caste")]
        public string CasteName { get; set; }

        [Required]
        [Display(Name = "Caste Category")]
        public string CasteCategory { get; set; }

        [Display(Name = "Course Name")]
        public int Course_ID { get; set; }

        [Display(Name = "Standard Name")]
        public int Standard_ID { get; set; }

        [Display(Name = "Class Name")]
        public int Class_ID { get; set; }

        [Display(Name = "Devision Name")]
        public int Devision_ID { get; set; }

        [Display(Name = "Date Of Admission")]
        [DataType(DataType.DateTime)]
        public DateTime Date_Of_Admission { get; set; }

        [Display(Name = "Year Of Admission")]
        public string Year_Of_Admission { get; set; }

        [Display(Name = "Verification Date")]
        [DataType(DataType.DateTime)]
        public DateTime VerificationDate { get; set; }

        public virtual Admission_Additional_Info Admission_Additional_Infos { get; set; }

        public virtual Guardian_Details Guardian_Details { get; set; }

        public virtual Last_Attended_Details Last_Attended_Details { get; set; }
    }
}