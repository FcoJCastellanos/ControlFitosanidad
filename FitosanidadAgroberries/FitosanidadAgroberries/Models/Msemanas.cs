using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitosanidadAgroberries.Models
{
    public class Msemanas
    {
        [PrimaryKey]
        public string c_codigo_sem { get; set; }
        public string d_ini_sem { get; set; }
        public string d_fin_sem { get; set; }
    }
}
