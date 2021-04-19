using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MensajesInteres.EN
{
	public class Producto
	{
        public int IdProducto { get; set; }
        [Required, StringLength(2, MinimumLength = 1)]
        public string ClaveProducto { get; set; }
        [Required, StringLength(100, MinimumLength = 3)]
        public string ProductoDescripcion { get; set; }
        [Required, StringLength(100, MinimumLength = 3)]
        public string Comentario { get; set; }
    }
}
