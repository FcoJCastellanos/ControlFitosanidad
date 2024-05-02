using SQLite;

namespace FitosanidadAgroberries.Models
{
    public class Mplagas
    {
        [PrimaryKey]
        public string c_codigo_pla { get; set; }
        public string v_nombre_pla { get; set; }
        public string v_abrevia_pla { get; set; }
        public string c_activo_pla { get; set; }
    }
}
