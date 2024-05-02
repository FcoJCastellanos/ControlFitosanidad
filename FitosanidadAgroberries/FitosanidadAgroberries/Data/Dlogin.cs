using FitosanidadAgroberries.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Essentials;

namespace FitosanidadAgroberries.Data
{
    public class Dlogin
    {
        public async Task<string> LoginUsuarioAppAsync(string V_usuario, string V_contrasenia)
        {
            string V_contraseniaMD5;
            MD5 md5 = new MD5CryptoServiceProvider();
            //Se calcula el coidgo Hash de los bytes de texto
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(V_contrasenia));
            //Se optiene el Hash resultante despues de calcularlo
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //Se cambia a numeros haxadexcimales de 2 digitos  por cada uno de los bytes de informacion
                strBuilder.Append(result[i].ToString("x2"));
            }
            V_contraseniaMD5 = strBuilder.ToString();

            string respuesta;
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                try
                {
                    if (VersionTracking.IsFirstLaunchForCurrentBuild)
                    {
                        var SincronizaSoloUnaVez = new Dsincronizacatalogos();
                        await SincronizaSoloUnaVez.DatosLoginUsuarioLocal();

                    }
                    var funcion = new Dsincronizacatalogos();
                    await funcion.DatosLoginUsuarioLocal();
                    List<Mlogin> usuario = await App.LocalDB.CheckLogin(V_contraseniaMD5, V_usuario);
                    if (usuario[0].c_codigo_usu.ToString().Equals(V_usuario) && usuario[0].v_password_usu.ToString().Equals(V_contraseniaMD5))
                    {
                        ((App)App.Current).VG_nombreUsuario = usuario[0].v_nombre_usu.ToString().Trim();
                        ((App)App.Current).VG_usuario = usuario[0].c_codigo_usu.ToString().Trim();
                    }
                }
                catch (Exception Ex) { return Ex.ToString(); }


                XElement xml1 = XElement.Load("http://54.165.41.23:5054/ValidaAcceso.asmx/validaUsuarioExpo?V_usuario=" + V_usuario + "&V_pwd=" + V_contrasenia + "&V_metodoAcceso=APP");
                if (xml1.Value == "1")
                {
                    respuesta = "1";
                }
                else
                {
                    respuesta = "0";
                }
                return respuesta;
            }
            else
            {
                try
                {
                    List<Mlogin> usuario = await App.LocalDB.CheckLogin(V_contraseniaMD5, V_usuario);
                    if (usuario[0].c_codigo_usu.ToString().Equals(V_usuario) && usuario[0].v_password_usu.ToString().Equals(V_contraseniaMD5))
                    {
                        respuesta = "1";
                        ((App)App.Current).VG_nombreUsuario = usuario[0].v_nombre_usu.ToString().Trim();
                        ((App)App.Current).VG_usuario = usuario[0].c_codigo_usu.ToString().Trim();
                    }
                    else
                    {
                        respuesta = "0";
                    }
                    return respuesta;
                }
                catch (Exception Ex) { return Ex.ToString(); }
            }
        }
    }
}
