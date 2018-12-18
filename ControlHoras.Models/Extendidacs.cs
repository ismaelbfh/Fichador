using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alc.Data;

namespace Alc.Model.ControlHoras
{
   
    public partial class Tareas:IDataErrorInfo
    {
     [ResultColumn]
       public string Nombre { get; set; }
    }
    public partial class Fichador
    {
        [ResultColumn]
        public string Nombre { get; set; }
    }
    

}
