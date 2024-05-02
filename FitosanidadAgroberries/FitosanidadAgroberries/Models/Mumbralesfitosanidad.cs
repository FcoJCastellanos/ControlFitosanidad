using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitosanidadAgroberries.Models
{
    public class Mumbralesfitosanidad
    {
        [PrimaryKey, AutoIncrement]
        public int c_control_log { get; set; }
        public string c_codigo_umb { get; set; }
        public string c_codigo_ces { get; set; }
        public string c_codigo_pla { get; set; }
        public string v_nombre_pla { get; set; }
        public string n_liminf0_umb { get; set; }
        public string n_limsup0_umb { get; set; }
        public string n_liminf1_umb { get; set; }
        public string n_limsup1_umb { get; set; }
        public string n_liminf2_umb { get; set; }
        public string n_limsup2_umb { get; set; }
        public string c_codigo_usu { get; set; }
        public string d_creacion_umb { get; set; }
    }
}
