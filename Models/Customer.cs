using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewTrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public DayOfWeek Days { get; set; }
        [Display(Name = "Special PickUp")]
        public DateTime SpecialPickUp { get; set; }
        [Display(Name = "Start Suspend")]
        public DateTime StartSuspend { get; set; }
        [Display(Name = "Stop Suspend")]
        public DateTime StopSuspend { get; set; }
    }
}
