using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EmployeeLeavePortal.Models
{
    
    public class LeaveRequest
    {

            [Required]
            public int LeaveRequestId { get; set; }

             
            [Required(ErrorMessage = "Date is mandatory")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            [Display(Name = "Leave From")]
            public DateTime From { get; set; }
 
            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            [Display(Name = "Leave To")]
            //[DateMustBeEqualOrGreaterThanCurrentDate]
            public DateTime To { get; set; }

           
            [Required]
            public int NumDays { get; set; }

             
            [Required]
            public string Comments { get; set; }
 
          
            public DateTime CreationDate { get; set; }

            public DateTime LastModifiedDate { get; set; }

            [Required]
            public int EmployeeId { get; set; }

           
            public EmployeeViewModel Employee { get; set; }
        }

    //internal class DateMustBeEqualOrGreaterThanCurrentDateAttribute : Attribute
    //{
    //    public override bool IsValid(object date)
    //    {
    //        DateTime date = (DateTime)date;
    //        return date >= DateTime.Now;
    //    }
    //}
}