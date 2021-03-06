﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnoCraftSchool_Model
{
    public class Admission_Additional_Info 
    {
        [Key]
        public long Admission_Additional_Info_ID { get; set; }

        public long Admission_ID { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.DateTime)]
        public DateTime? Date_of_Birth { get; set; }

        [Required]
        [Display(Name = "Birth Place")]
        public string BirthPlace { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name = "Mother Tongue")]
        public string MotherTongue { get; set; }

        [Required]
        [Display(Name = "Religion")]
        public string Religion { get; set; }

        [Required]
        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string PermanentCity { get; set; }

        [Required]
        [Display(Name = "Taluka")]
        public string PermanentTaluka { get; set; }

        [Required]
        [Display(Name = "District")]
        public string PermanentDistrict { get; set; }

        [Required]
        [Display(Name = "Phone No")]
        public string PermanentPhone { get; set; }

        [Required]
        [Display(Name = "Local Address")]
        public string LocalAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string LocalCity { get; set; }

        [Required]
        [Display(Name = "Taluka")]
        public string LocalTaluka { get; set; }

        [Required]
        [Display(Name = "District")]
        public string LocalDistrict { get; set; }

        [Required]
        [Display(Name = "Phone No")]
        public string LocalPhone { get; set; }

        [Required]
        [Display(Name = "Student Phone No")]
        public string StudentPhone { get; set; }

        [Required]
        [Display(Name = "Father Phone No")]
        public string FatherPhone { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public virtual Admissions Admission { get; set; }

    }

    public class Guardian_Details
    {
        [Key]
        public long Guardian_Id { get; set; }

        public long Admission_ID { get; set; }

        [Display(Name = "Relationship With")]
        public int Relationship_ID { get; set; }

        [Required]
        [Display(Name = "Guardian First Name")]
        public string GuardianFirstName { get; set; }

        [Required]
        [Display(Name = "Guardian Middle Name")]
        public string GuardianMiddleName { get; set; }

        [Required]
        [Display(Name = "Guardian Last Name")]
        public string GuardianLastName { get; set; }

        [Required]
        [Display(Name = "Qualification")]
        public string Qualification { get; set; }

        [Required]
        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [Required]
        [Display(Name = "Education")]
        public string Education { get; set; }

        [Required]
        [Display(Name = "Occupation Address")]
        public string Occ_Address { get; set; }

        [Required]
        [Display(Name = "Mobile No")]
        public string Guardian_MobileNo { get; set; }
        [Required]
        [Display(Name = "Guardian Email")]
        public string Guardian_Email { get; set; }

        [Required]
        [Display(Name = "Annual Income")]
        public long Income { get; set; }

        public virtual Admissions Admissions { get; set; }
    }

    public class Last_Attended_Details
    {
        [Key]
        public long Last_Attended_Details_ID { get; set; }

        public long Admission_ID { get; set; }

        [Required]
        [Display(Name = "Name Of School")]
        public string Name_of_School { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Medium")]
        public int Medium_ID { get; set; }

        [Required]
        [Display(Name = "Standard")]
        public int Last_Standard_Id { get; set; }

        [Required]
        [Display(Name = "Exam Board")]
        public string Exam_Board { get; set; }

        [Required]
        [Display(Name = "Percentage or Grade")]
        public string Percentage_or_Grade { get; set; }

        [Required]
        [Display(Name = "Reason for change")]
        [DataType(DataType.MultilineText)]
        public string Change_Reason { get; set; }

        public virtual Admissions Admissionsl { get; set; }

    }
}