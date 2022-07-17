namespace main
{
    //creación de la clase Usuario
    public class Usuario
    {
        private int usuarioId;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasenia;
        private string mail;
    }
    
    //creación de la clase Producto
    public class Producto
    {
        private int productoId;
        private string descripcion;
        private double costo;
        private double precioVenta;
        private int stock;
        private int usuarioId;
    }

    //creacion de la clase Venta
    public class Venta
    {
        private int ventaId;
        private string comentarios;
    }

    //creacion de la clase ProductoVendido
    public class ProductoVendido
    {
        private int productoVendidoId;
        private int productoId;
        private int stock;
        private int ventaId;
    }
}

