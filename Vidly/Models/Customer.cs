using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter customer name")]
        [StringLength(255)]
        public string Name{ get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
       
        [Display(Name = "Date Of Birth")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Membership Type")]
        [Min18YearsIfAMember]
        public byte  MembershipTypeId { get; set; }
    }
}