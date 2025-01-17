﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121250036_ActividadRADIX.Modelos
{
    public class Paciente : EntidadBase
    {
        [Key]
        public int Pacienteid { get; set; }

        [Required]
        [MaxLength(10)]

        public string Nombres { get; set; }

        [Required]
        [MaxLength(120)]

        public string Apellidos { get; set; }

        [Required]
        [MaxLength(120)]

    }
}
