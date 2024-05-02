using FitosanidadAgroberries.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitosanidadAgroberries.Connection
{
    public class LocalDataBase
    {
        private readonly SQLiteAsyncConnection _database;
        public LocalDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Mcampos>();
            _database.CreateTableAsync<Mgeodata>();
            _database.CreateTableAsync<Mlogin>();
            _database.CreateTableAsync<Mplagas>();
            _database.CreateTableAsync<Msector>();
            _database.CreateTableAsync<Msemanas>();
            _database.CreateTableAsync<Mtablasfitosanidad>();
            _database.CreateTableAsync<Mtablatunelfitosanidad>();
            _database.CreateTableAsync<Mtunelesfitosanidad>();
            _database.CreateTableAsync<Mumbralesfitosanidad>();
            _database.CreateTableAsync<Mz_regfitosanidad>();
            _database.CreateTableAsync<Mpinsmapas>();
        }
        public Task<List<Mcampos>> GetCamposAsync()
        {
            return _database.Table<Mcampos>().ToListAsync();
        }
        public Task<List<Mcampos>> ConsultaCamposLocal()
        {
            return _database.QueryAsync<Mcampos>("SELECT codigoCampo, nombreCampo FROM Mcampos");
        }

        public Task<List<Mgeodata>> GetGeoDataAsync()
        {
            return _database.Table<Mgeodata>().ToListAsync();
        }
        public Task<List<Mgeodata>> ConsultaGeoDataLocal()
        {
            return _database.QueryAsync<Mgeodata>("SELECT * FROM Mgeodata");
        }

        public Task<List<Mlogin>> GetUsuariosAsync()
        {
            return _database.Table<Mlogin>().ToListAsync();
        }
        public Task<List<Mlogin>> CheckLogin(string V_contraseniaMD5, string V_usuario)
        {
            return _database.QueryAsync<Mlogin>("SELECT * FROM Mlogin WHERE c_codigo_usu = '" + V_usuario + "' AND v_password_usu = '" + V_contraseniaMD5 + "'");
        }

        public Task<List<Mplagas>> GetPlagasAsync()
        {
            return _database.Table<Mplagas>().ToListAsync();
        }
        public Task<List<Mplagas>> ConsultaPlagasLocal()
        {
            return _database.QueryAsync<Mplagas>("SELECT * FROM Mplagas");
        }

        public Task<List<Msector>> GetSectoresAsync()
        {
            return _database.Table<Msector>().ToListAsync();
        }
        public Task<List<Msector>> ConsultaSectoresLocal(string V_Campo)
        {
            return _database.QueryAsync<Msector>("SELECT * FROM Msector WHERE c_activo_lot='1' AND c_codigo_cam='" + V_Campo + "'");
        }

        public Task<List<Msemanas>> GetSemanasAsync()
        {
            return _database.Table<Msemanas>().ToListAsync();
        }
        public Task<List<Msemanas>> ConsultaSemanasLocal()
        {
            return _database.QueryAsync<Msemanas>("SELECT * FROM Msemanas");
        }

        public Task<List<Mtablasfitosanidad>> GetTablasAsync()
        {
            return _database.Table<Mtablasfitosanidad>().ToListAsync();
        }
        public Task<List<Mtablasfitosanidad>> ConsultaTablasLocal()
        {
            return _database.QueryAsync<Mtablasfitosanidad>("SELECT * FROM Mtablasfitosanidad");
        }

        public Task<List<Mtablatunelfitosanidad>> GetTablaTunelessAsync()
        {
            return _database.Table<Mtablatunelfitosanidad>().ToListAsync();
        }
        public Task<List<Mtablatunelfitosanidad>> BuscaTablasLocal(string codigoCampo, string codigoSector)
        {
            return _database.QueryAsync<Mtablatunelfitosanidad>("SELECT DISTINCT * FROM Mtablatunelfitosanidad WHERE c_codigo_cam = '" + codigoCampo + "' AND c_codigo_lot = '" + codigoSector + "' GROUP BY c_codigo_tab");
        }
        public Task<List<Mtablatunelfitosanidad>> BuscaTunelesLocal(string codigoCampo, string codigoSector, string codigoTabla)
        {
            return _database.QueryAsync<Mtablatunelfitosanidad>("SELECT * FROM Mtablatunelfitosanidad WHERE c_codigo_cam = '" + codigoCampo + "' AND c_codigo_lot = '" + codigoSector + "' AND c_codigo_tab = '" + codigoTabla + "'");
        }
        public Task<List<Mtablatunelfitosanidad>> ConsultaTablasTunelesLocal(string codigoCampo, string codigoSector, string codigoTabla, string codigoTunel)
        {
            return _database.QueryAsync<Mtablatunelfitosanidad>("SELECT * FROM Mtablatunelfitosanidad WHERE c_codigo_cam = '" + codigoCampo + "' AND c_codigo_lot = '" + codigoSector + "' AND c_codigo_tab = '" + codigoTabla + "' AND c_codigo_tun = '" + codigoTunel + "'");
        }

        public Task<List<Mtunelesfitosanidad>> GetTunelesAsync()
        {
            return _database.Table<Mtunelesfitosanidad>().ToListAsync();
        }
        public Task<List<Mtunelesfitosanidad>> ConsultaTunelesLocal()
        {
            return _database.QueryAsync<Mtunelesfitosanidad>("SELECT * FROM Mtunelesfitosanidad");
        }

        public Task<List<Mumbralesfitosanidad>> GetUmbralesAsync()
        {
            return _database.Table<Mumbralesfitosanidad>().ToListAsync();
        }
        public Task<List<Mumbralesfitosanidad>> ConsultaUmbralesLocal(string V_nombrePlaga)
        {
            return _database.QueryAsync<Mumbralesfitosanidad>("SELECT * FROM Mumbralesfitosanidad WHERE c_codigo_pla='" + V_nombrePlaga + "'");
        }

        public Task<List<Mz_regfitosanidad>> GetRegistrosFitosanidaAsync()
        {
            return _database.Table<Mz_regfitosanidad>().ToListAsync();
        }
        public Task<List<Mz_regfitosanidad>> BuscaRegistroFitosanidad(string d_captura_fit, string c_codigo_ttu, string c_semana_fit, string c_codigo_pla, string n_poblacion_fit, string c_codigo_usu)
        {
            return _database.QueryAsync<Mz_regfitosanidad>("SELECT * FROM Mz_regfitosanidad WHERE d_captura_fit = '" + d_captura_fit + "' AND c_codigo_ttu = '" + c_codigo_ttu + "' AND c_semana_fit = '" + c_semana_fit + "' AND c_codigo_pla = '" + c_codigo_pla + "' AND n_poblacion_fit = '" + n_poblacion_fit + "' AND c_codigo_usu = '" + c_codigo_usu + "'");
        }
        public Task<List<Mz_regfitosanidad>> ActualizaMz_regfitosanidadLocal(string c_codigo_fit)
        {
            return _database.QueryAsync<Mz_regfitosanidad>("UPDATE Mz_regfitosanidad SET c_sincronizado_fit = '1' WHERE c_codigo_fit = '" + c_codigo_fit + "'");
        }

        public Task<List<Mpinsmapas>> GetPinsMapasAsync()
        {
            return _database.Table<Mpinsmapas>().ToListAsync();
        }
        public Task<List<Mpinsmapas>> ConsultaPinsMapasLocal(string c_codigo_cam, string c_semana_fit, string c_codigo_pla)
        {
            return _database.QueryAsync<Mpinsmapas>("SELECT * FROM Mpinsmapas WHERE c_codigo_cam = '" + c_codigo_cam + "' AND c_semana_fit = '" + c_semana_fit + "' AND c_codigo_pla = '" + c_codigo_pla + "'");
        }

        public Task<List<Mpinsmapas>> ConsultaDatosParaConsultaSemanalLocal(string c_codigo_cam, string c_semana_fit)
        {
            return _database.QueryAsync<Mpinsmapas>("SELECT * FROM Mpinsmapas WHERE c_codigo_cam = '" + c_codigo_cam + "' AND c_semana_fit = '" + c_semana_fit + "'");
        }

        public Task<int> SaveData<T>(T SaveAllData)
        {
            return _database.InsertAsync(SaveAllData);
        }

        public Task<int> DeleteAllItems<T>()
        {
            return _database.DeleteAllAsync<T>();
        }
    }
}
