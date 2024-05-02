using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitosanidadAgroberries.Models
{
    public class Mcampos
    {
        [PrimaryKey, AutoIncrement]
        public int c_control_log { get; set; }
        public string codigoCampo { get; set; }
        public string nombreCampo { get; set; }
    }
}
