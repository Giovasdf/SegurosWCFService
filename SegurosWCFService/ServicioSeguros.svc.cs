using System;
using System.Collections.Generic;
using System.Linq;

namespace SegurosWCFService
{
    public class ServicioSeguros : IServicioSeguros
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static List<ProductoPago> productosPago = new List<ProductoPago>();
        private static List<DetalleSeguro> detallesSeguros = new List<DetalleSeguro>();
        private static List<Transaccion> transacciones = new List<Transaccion>();

        // Implementación de CRUD para Cliente
        public void RegistrarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public Cliente ObtenerCliente(string id)
        {
            int clienteId = int.Parse(id);
            return clientes.FirstOrDefault(c => c.Id == clienteId);
        }

        public void ActualizarCliente(Cliente cliente)
        {
            var clienteExistente = clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Direccion = cliente.Direccion;
                // Actualizar otros campos según sea necesario
            }
        }

        public void EliminarCliente(string id)
        {
            int clienteId = int.Parse(id);
            var cliente = clientes.FirstOrDefault(c => c.Id == clienteId);
            if (cliente != null)
            {
                clientes.Remove(cliente);
            }
        }

        // Implementación de CRUD para ProductoPago
        public void RegistrarProductoPago(ProductoPago productoPago)
        {
            productosPago.Add(productoPago);
        }

        public ProductoPago ObtenerProductoPago(string id)
        {
            int productoPagoId = int.Parse(id);
            return productosPago.FirstOrDefault(p => p.Id == productoPagoId);
        }

        public void ActualizarProductoPago(ProductoPago productoPago)
        {
            var productoPagoExistente = productosPago.FirstOrDefault(p => p.Id == productoPago.Id);
            if (productoPagoExistente != null)
            {
                productoPagoExistente.Tipo = productoPago.Tipo;
                // Actualizar otros campos según sea necesario
            }
        }

        public void EliminarProductoPago(string id)
        {
            int productoPagoId = int.Parse(id);
            var productoPago = productosPago.FirstOrDefault(p => p.Id == productoPagoId);
            if (productoPago != null)
            {
                productosPago.Remove(productoPago);
            }
        }

        // Implementación de CRUD para DetalleSeguro
        public void RegistrarDetalleSeguro(DetalleSeguro detalleSeguro)
        {
            detallesSeguros.Add(detalleSeguro);
        }

        public DetalleSeguro ObtenerDetalleSeguro(string id)
        {
            int detalleSeguroId = int.Parse(id);
            return detallesSeguros.FirstOrDefault(d => d.Id == detalleSeguroId);
        }

        public void ActualizarDetalleSeguro(DetalleSeguro detalleSeguro)
        {
            var detalleSeguroExistente = detallesSeguros.FirstOrDefault(d => d.Id == detalleSeguro.Id);
            if (detalleSeguroExistente != null)
            {
                detalleSeguroExistente.Tipo = detalleSeguro.Tipo;
                detalleSeguroExistente.Prima = detalleSeguro.Prima;
                // Actualizar otros campos según sea necesario
            }
        }

        public void EliminarDetalleSeguro(string id)
        {
            int detalleSeguroId = int.Parse(id);
            var detalleSeguro = detallesSeguros.FirstOrDefault(d => d.Id == detalleSeguroId);
            if (detalleSeguro != null)
            {
                detallesSeguros.Remove(detalleSeguro);
            }
        }

        // Implementación de CRUD para Transaccion
        public void RegistrarTransaccion(Transaccion transaccion)
        {
            transacciones.Add(transaccion);
        }

        public Transaccion ObtenerTransaccion(string id)
        {
            int transaccionId = int.Parse(id);
            return transacciones.FirstOrDefault(t => t.Id == transaccionId);
        }

        public void ActualizarTransaccion(Transaccion transaccion)
        {
            var transaccionExistente = transacciones.FirstOrDefault(t => t.Id == transaccion.Id);
            if (transaccionExistente != null)
            {
                transaccionExistente.ClienteId = transaccion.ClienteId;
                transaccionExistente.Monto = transaccion.Monto;
                transaccionExistente.TipoPago = transaccion.TipoPago;
                // Actualizar otros campos según sea necesario
            }
        }

        public void EliminarTransaccion(string id)
        {
            int transaccionId = int.Parse(id);
            var transaccion = transacciones.FirstOrDefault(t => t.Id == transaccionId);
            if (transaccion != null)
            {
                transacciones.Remove(transaccion);
            }
        }
    }
}
