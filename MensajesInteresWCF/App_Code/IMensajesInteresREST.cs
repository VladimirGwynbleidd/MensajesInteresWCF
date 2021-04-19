using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using MensajesInteres.EN;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMensajesInteresREST" in both code and config file together.
[ServiceContract]
public interface IMensajesInteresREST
{

	[OperationContract]
	[WebInvoke(Method = "GET",
		UriTemplate = "/DoWork",
		BodyStyle = WebMessageBodyStyle.Wrapped,
		RequestFormat = WebMessageFormat.Json,
		ResponseFormat = WebMessageFormat.Json)]
	void DoWork();

	[OperationContract]
	[WebInvoke(Method = "GET",
		UriTemplate = "/ObtenerProducto/",
		BodyStyle = WebMessageBodyStyle.Wrapped,
		RequestFormat = WebMessageFormat.Json,
		ResponseFormat = WebMessageFormat.Json)]
	List<Producto> ObtenerProducto();


	[OperationContract]
	[WebInvoke(Method = "POST",
		UriTemplate = "/InsertarProducto",
		BodyStyle = WebMessageBodyStyle.Wrapped,
		RequestFormat = WebMessageFormat.Json,
		ResponseFormat = WebMessageFormat.Json
		)]
	Success<Producto> InsertarProducto(Producto producto);
}
