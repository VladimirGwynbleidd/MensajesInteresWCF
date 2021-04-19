using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensajesInteres.EN;
using Newtonsoft.Json;

namespace MensajesInteres.PI
{
	class FunctionDelegate<T> where T : class
    {
        public delegate IEnumerable<T> ObtenerResultadoDelegate(string sp, IDictionary<string, object> parametros);
        public delegate int ObtenerResultadoEscalarDelegate(string sp, Dictionary<string, object> parametros);

        public static Success<T> ObtenerListaResultado(ObtenerResultadoDelegate metodo,
            string sp, IDictionary<string, object> parametros)
        {
            Success<T> success = new Success<T>();

            try
            {
                success.Exito = true;
                success.ResponseDataEnumerable = metodo(sp, parametros).ToList();
                success.ResponseData = new List<T>();

                return success;
            }
            catch (Exception ex)
            {
                success.Exito = false;
                success.Mensaje = ex.Message;
                success.ResponseData = new List<T>();

                throw new ArgumentException(JsonConvert.SerializeObject(success), ex);
            }
        }

        public static Success<T> ObtenerResultado(ObtenerResultadoEscalarDelegate metodo, string sp, Dictionary<string, object> parametros, T arg)
        {
            Success<T> success = new Success<T>();

            try
            {
                int valor = metodo(sp, parametros);
                string mensaje = valor > 0 ? "Se actualizó correctamente el registro" : "No se actualizó correctamente el resgistro";

                success.Exito = true;
                success.Valor = valor;
                success.Mensaje = mensaje;

                return success;
            }
            catch (Exception ex)
            {
                success.Exito = false;
                success.Mensaje = ex.Message;
                success.Data = arg;

                throw new ArgumentException(JsonConvert.SerializeObject(success), ex);
            }

        }
    }
}
