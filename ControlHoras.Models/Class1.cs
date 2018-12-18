using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alc.Data;
using Alc.Model;

namespace ControlHoras.Models
{
    public class Class1
    {
    }
    public class FichadorMio
    {
        public string Nombre { get; set; }
        public int IDUsuario { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }
        public int ID { get; set; }
     
    }

    public class UsuariosListas
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public bool EsAdmin { get; set; }
    }

    public class TareasLista
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public int IDUsuario { get; set; }
        public string Proyecto { get; set; }
        public DateTime? HoraInicioTarea { get; set; }
        public int duracion { get; set; }
        public string Descripcion { get; set; }
        public DateTime? HoraFinTarea { get; set; }
        
    }

    public class Jornada
    {
        public DateTime Dia { get; set; }
        public int HorasTrabajadas { get; set; }
        public int TotalTareas { get; set; }
        public int Diferencia { get { return this.HorasTrabajadas - this.TotalTareas; } set { } }
    }
}
