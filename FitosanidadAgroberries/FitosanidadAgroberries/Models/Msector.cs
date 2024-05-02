using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitosanidadAgroberries.Models
{
    public class Msector
    {
        [PrimaryKey, AutoIncrement]
        public int c_control_log { get; set; }
        public string c_codigo_tem { get; set; }
        public string c_codigo_lot { get; set; }
        public string v_nombre_lot { get; set; }
        public string c_codigo_cul { get; set; }
        public string n_superf_lot { get; set; }
        public string c_codigo_cam { get; set; }
        public string c_codigo_cic { get; set; }
        public string c_identificador_lot { get; set; }
        public string c_nodisponible_lot { get; set; }
        public string c_empaque_lot { get; set; }
        public string c_activo_lot { get; set; }
        public string n_superfconvert_lot { get; set; }
        public string c_unidadmedida_lot { get; set; }
        public string c_nivel_lot { get; set; }
    }
}
