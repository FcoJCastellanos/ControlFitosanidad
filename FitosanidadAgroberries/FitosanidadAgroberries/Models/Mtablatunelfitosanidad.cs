using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitosanidadAgroberries.Models
{
    public class Mtablatunelfitosanidad
    {
        [PrimaryKey, AutoIncrement]
        public int c_control_log { get; set; }
        public string c_codigo_ttu { get; set; }
        public string c_codigo_cam { get; set; }
        public string c_codigo_lot { get; set; }
        public string c_codigo_tab { get; set; }
        public string v_nombre_tab { get; set; }
        public string c_codigo_tun { get; set; }
        public string v_nombre_tun { get; set; }
        public string c_codigo_tem { get; set; }
        public string n_ha_ttu { get; set; }
        public string n_acres_ttu { get; set; }
        public string n_plantas_ttu { get; set; }
        public string c_codigo_usu { get; set; }
        public string d_creacion_ttu { get; set; }
    }
}
