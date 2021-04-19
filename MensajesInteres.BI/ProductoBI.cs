using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensajesInteres.BI.Interfaces;
using MensajesInteres.EN;
using MensajesInteres.PI;


namespace MensajesInteres.BI
{
	public class ProductoBI : ICatalogo<Producto>
	{
		private readonly ProductoProcess cls = new ProductoProcess();
		public Success<Producto> Get(Producto param = null)
		{
			return cls.Get();
		}

		public Success<Producto> Insert(Producto parameters)
		{
			return cls.Insert(parameters);
		}

		public Success<Producto> Update(Producto parameters)
		{
			throw new NotImplementedException();
		}

		public Success<Producto> Delete(Producto parameters)
		{
			throw new NotImplementedException();
		}
	}
}
