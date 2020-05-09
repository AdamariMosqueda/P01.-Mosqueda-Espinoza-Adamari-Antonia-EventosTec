﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventosTec.Web.Models.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }
        
        [MaxLength(50)]
        [Display(Name = "Appelidos")]
        public string LastName { get; set; }
       
        [MaxLength(50)]
        [Display(Name = "Telefono")]
        public string FixedPhone { get; set; }
      
        [Required]
        [MaxLength(50)]
        [Display(Name = "Correo")]
        public string Email { get; set; }
       
        [Required]
        [MaxLength(50)]
        [Display(Name = "Celular")]
        public string CellPhone { get; set; }
     
        [MaxLength(500)]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Nombre Completo")]
        public string FullName => $"{FirstName} {LastName}";
    }
}