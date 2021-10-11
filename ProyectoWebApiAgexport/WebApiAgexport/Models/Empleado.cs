using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiAgexport.Models
{
    public class Empleado
    {

        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaNacimiento  { get; set; }
        public int Edad { get; set; }
        public int DPI { get; set; }
        public string NIT { get; set; }
        public int AfiliacionIGGS { get; set; }
        public int AfilicacionIrtra { get; set; }
        public int NoPasaporte { get; set; }
        public int PaisId { get; set; }
        public int Telefono { get; set; }
        public string DireccionResidencia { get; set; }
        public string Puesto { get; set; }
        public decimal Sueldo { get; set; }
        public decimal Bonificacion { get; set; }
        public int EstadoId { get; set; }


    }
}