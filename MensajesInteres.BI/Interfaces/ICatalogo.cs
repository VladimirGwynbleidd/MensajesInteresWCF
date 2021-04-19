using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensajesInteres.EN;

namespace MensajesInteres.BI.Interfaces
{
	public interface ICatalogo<T> where T : class
	{
		Success<T> Get(T param = null);
		Success<T> Insert(T parameters);
		Success<T> Update(T parameters);
		Success<T> Delete(T parameters);
	}
}
