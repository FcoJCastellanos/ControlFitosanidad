using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitosanidadAgroberries.Models
{
    public class Mlogin
    {
        [PrimaryKey, AutoIncrement]
        public int c_control_log { get; set; }
        public string c_codigo_usu { get; set; }
        public string v_nombre_usu { get; set; }
        public string v_password_usu { get; set; }
        public string v_email_usu { get; set; }
        public string c_admin_usu { get; set; }
        public string c_autorizanom_usu { get; set; }
    }
}
