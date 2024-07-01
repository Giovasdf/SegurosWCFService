using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;

namespace SegurosWCFService
{
    [ServiceContract]
    public interface IServicioSeguros
    {
        // CRUD para Cliente
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/RegistrarCliente", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void RegistrarCliente(Cliente cliente);

        [OperationContract]
        [WebGet(UriTemplate = "/ObtenerCliente/{id}", ResponseFormat = WebMessageFormat.Json)]
        Cliente ObtenerCliente(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/ActualizarCliente", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ActualizarCliente(Cliente cliente);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarCliente/{id}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarCliente(string id);

        // CRUD para ProductoPago
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/RegistrarProductoPago", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void RegistrarProductoPago(ProductoPago productoPago);

        [OperationContract]
        [WebGet(UriTemplate = "/ObtenerProductoPago/{id}", ResponseFormat = WebMessageFormat.Json)]
        ProductoPago ObtenerProductoPago(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/ActualizarProductoPago", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ActualizarProductoPago(ProductoPago productoPago);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarProductoPago/{id}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarProductoPago(string id);

        // CRUD para DetalleSeguro
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/RegistrarDetalleSeguro", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void RegistrarDetalleSeguro(DetalleSeguro detalleSeguro);

        [OperationContract]
        [WebGet(UriTemplate = "/ObtenerDetalleSeguro/{id}", ResponseFormat = WebMessageFormat.Json)]
        DetalleSeguro ObtenerDetalleSeguro(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/ActualizarDetalleSeguro", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ActualizarDetalleSeguro(DetalleSeguro detalleSeguro);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarDetalleSeguro/{id}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarDetalleSeguro(string id);

        // CRUD para Transaccion
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/RegistrarTransaccion", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void RegistrarTransaccion(Transaccion transaccion);

        [OperationContract]
        [WebGet(UriTemplate = "/ObtenerTransaccion/{id}", ResponseFormat = WebMessageFormat.Json)]
        Transaccion ObtenerTransaccion(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/ActualizarTransaccion", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ActualizarTransaccion(Transaccion transaccion);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarTransaccion/{id}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarTransaccion(string id);
    }

    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Direccion { get; set; }

        // Otros campos...
    }

    [DataContract]
    public class ProductoPago
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Tipo { get; set; } // Ejemplo: "Pago Automático", "Cheque", "Efectivo"
    }

    [DataContract]
    public class DetalleSeguro
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Tipo { get; set; }

        [DataMember]
        public double Prima { get; set; }

        // Otros campos...
    }

    [DataContract]
    public class Transaccion
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ClienteId { get; set; }

        [DataMember]
        public double Monto { get; set; }

        [DataMember]
        public string TipoPago { get; set; } // Ejemplo: "Pago Automático", "Cheque", "Efectivo"

        // Otros campos...
    }
}
