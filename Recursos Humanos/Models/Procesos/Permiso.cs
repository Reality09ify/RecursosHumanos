﻿using Recursos_Humanos.Models.Colaboradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recursos_Humanos.Models.Procesos
{
    public class Permiso
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Empleado")]
        public Empleado Empleado { get; set; }
        [Required]
        public int EmpleadoId { get; set; }
        [Required]
        public DateTime Desde { get; set; }
        [Required]
        public DateTime Hasta { get; set; }
        [Required]
        public string Comentarios { get; set; }
    }
}
