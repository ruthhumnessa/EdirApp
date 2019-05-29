using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Edir
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public EdirType EdirType { get; set; }

        [Display(Name ="Edir type")]
        [Required]
        public byte EdirTypeId { get; set; }

        public string Subcity { get; set; }

        public byte Wereda { get; set; }

        public string Email { get; set; }

        //    [DataType(DataType.Password)]
        //    public string Password { get; set; }


        //    [DataType(DataType.Password)]
        //    [Compare("Password")]
        //    public string ConfirmPassword { get; set; }
        //
    }
}