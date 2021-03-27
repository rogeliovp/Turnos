﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos.Models
{
    public class Especialidades
    {
        [Key]
        public int IdEspecialidad { get; set; }
        public string Descripcion { get; set; }
    }
}
