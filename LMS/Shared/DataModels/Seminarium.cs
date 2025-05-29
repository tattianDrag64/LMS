﻿using System.ComponentModel.DataAnnotations;
namespace BibliotekBoklusen.Shared
{
    public class Seminarium
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obligatorisk fält")]
        public string Title { get; set; } 
        [Required(ErrorMessage = "Obligatorisk fält")]
        public string FirstName { get; set; } 
        [Required(ErrorMessage = "Obligatorisk fält")]
        public string LastName { get; set; } 
        [Required(ErrorMessage = "Obligatorisk fält")]
        public DateTime SeminarDate { get; set; }
        [Required(ErrorMessage = "Obligatorisk fält")]
        public DateTime SeminarTime { get; set; }
    }
}
