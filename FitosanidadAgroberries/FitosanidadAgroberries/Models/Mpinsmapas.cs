using SQLite;

namespace FitosanidadAgroberries.Models
{
    public class Mpinsmapas
    {
        [PrimaryKey]
        public int c_codigo_fit { get; set; }
        public string v_nombre_cam { get; set; }
        public string c_codigo_cam { get; set; }
        public string v_nombre_lot { get; set; }
        public string c_codigo_lot { get; set; }
        public string c_codigo_tab { get; set; }
        public string c_codigo_tun { get; set; }
        public string d_captura_fit { get; set; }
        public string c_semana_fit { get; set; }
        public string c_codigo_pla { get; set; }
        public string v_nombre_pla { get; set; }
        public string n_poblacion_fit { get; set; }
        public string c_latitud_fit { get; set; }
        public string c_longitud_fit { get; set; }
        public string c_altura_fit { get; set; }
    }
}
