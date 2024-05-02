using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitosanidadAgroberries.Models
{
    public class Mz_regfitosanidad
    {
        [PrimaryKey, AutoIncrement]
        public int c_codigo_fit { get; set; }
        public string d_captura_fit { get; set; }
        public string c_codigo_ttu { get; set; }
        public string c_semana_fit { get; set; }
        public string c_codigo_pla { get; set; }
        public string n_poblacion_fit { get; set; }
        public string n_tempmax_fit { get; set; }
        public string n_tempmin_fit { get; set; }
        public string n_tempprom_fit { get; set; }
        public string n_hummax_fit { get; set; }
        public string n_hummin_fit { get; set; }
        public string n_humprom_fit { get; set; }
        public string n_precip_fit { get; set; }
        public string n_viento_fit { get; set; }
        public string v_observacion_fit { get; set; }
        public string c_longitud_fit { get; set; }
        public string c_latitud_fit { get; set; }
        public string c_altura_fit { get; set; }
        public string c_codigo_usu { get; set; }
        public string c_sincronizado_fit { get; set; }
    }
}
