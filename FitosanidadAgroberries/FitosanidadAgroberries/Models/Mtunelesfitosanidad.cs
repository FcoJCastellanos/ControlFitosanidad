using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitosanidadAgroberries.Models
{
    public class Mtunelesfitosanidad
    {
        [PrimaryKey, AutoIncrement]
        public int c_control_log { get; set; }
        public string c_codigo_tun { get; set; }
        public string v_nombre_tun { get; set; }
        public string c_activo_tun { get; set; }
        public string c_codigo_usu { get; set; }
        public string d_creacion_tun { get; set; }
    }
}