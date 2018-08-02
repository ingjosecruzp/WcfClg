using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfClg
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWcfClientes" in both code and config file together.
    [ServiceContract]
    public interface IWcfClientes
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "",
         BodyStyle = WebMessageBodyStyle.Bare,
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         Method = "GET")]
        List<clientes> all();

        [OperationContract]
        [WebInvoke(UriTemplate = "{id}",
         BodyStyle = WebMessageBodyStyle.Bare,
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         Method = "GET")]
         clientes get(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "",
         BodyStyle = WebMessageBodyStyle.Bare,
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         Method = "POST")]
        clientes add(clientes item);

        [OperationContract]
        [WebInvoke(UriTemplate = "",
         BodyStyle = WebMessageBodyStyle.Bare,
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         Method = "PUT")]
        clientes update(clientes item);

        [OperationContract]
        [WebInvoke(UriTemplate = "{id}",
         BodyStyle = WebMessageBodyStyle.Bare,
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         Method = "DELETE")]
        clientes delete(string id);
    }
}
