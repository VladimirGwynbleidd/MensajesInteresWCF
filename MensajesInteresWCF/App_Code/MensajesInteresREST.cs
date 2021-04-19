using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MensajesInteres.BI;
using MensajesInteres.BI.Interfaces;
using MensajesInteres.EN;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MensajesInteresREST" in code, svc and config file together.
public class MensajesInteresREST : IMensajesInteresREST
{
	public void DoWork()
	{
	}
	public List<Producto> ObtenerProducto()
	{
		ICatalogo<Producto> producto = new ProductoBI();
		Success<Producto> success = new Success<Producto>();

		try
		{
			return producto.Get().ResponseDataEnumerable.ToList();

		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}


	public Success<Producto> InsertarProducto(Producto producto)
	{
		ICatalogo<Producto> insertarProducto = new ProductoBI();
		Success<Producto> success = new Success<Producto>();

		try
		{
			return insertarProducto.Insert(producto);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}

	}
}
