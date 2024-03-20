namespace SistemasVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new PersonaVistas.PersonaListarVista());
            //////------Codigo para ver los registros
            /* Application.Run(new UsuarioVistas.UsuarioListarVista());
             Application.Run(new ClienteVistas.ClienteListarVista());
             Application.Run(new DetalleIngVistas.DetalleIngListarVista());
             Application.Run(new DetalleVentaVistas.DetalleVentaListarVista());
             Application.Run(new IngresoVistas.IngresoListarVista());
             Application.Run(new MarcaVistas.MarcaListarVista());
             Application.Run(new ProductoVistas.ProductoListarVista());
             Application.Run(new ProveeVistas.ProveeListarVista());
             Application.Run(new ProveedorVistas.ProveedorListarVista());
             Application.Run(new RolVistas.RolListarVista());
             Application.Run(new TipoProdVistas.TipoProdListarVista());
             Application.Run(new UsuarioRolVistas.UsuarioRolListarVista());
             Application.Run(new VentaVistas.VentaListarVista());*/
            /////Codigo para insertar datos atraves de una consola
            /*    Application.Run(new PersonaVistas.PersonaInsertarVista());
                  Application.Run(new ClienteVistas.ClienteInsertarVista());
                  Application.Run(new DetalleIngVistas.DetalleIngInsertarVista());
                  Application.Run(new DetalleVentaVistas.DetalleVentaInsertarVista());
                  Application.Run(new IngresoVistas.IngresoInsertarVista());
                  Application.Run(new MarcaVistas.MarcaInsertarVenta());
                  Application.Run(new ProductoVistas.ProductoInsertarVista());
                  Application.Run(new ProveedorVistas.ProveedorInsertarVista());
                  Application.Run(new ProveeVistas.ProveeInsertarVista());
                  Application.Run(new RolVistas.RolInsertarVista());
                  Application.Run(new TipoProdVistas.TipoProdInsertarVista());
                  Application.Run(new UsuarioRolVistas.UsuarioRolInsertarVista());
                  Application.Run(new UsuarioVistas.UsuarioInsertarVista());
                  Application.Run(new VentaVistas.VentaInsertarVista());*/
    
                 //Application.Run(new VentaVistas.VentaInsertarVista());
            ///aqui van con seleccionar
         Application.Run(new UsuarioVista.UsuarioInsertarVista1());
         Application.Run(new ClienteVista.ClienteInsertarVista());
            //Application.Run(new DetalleIngVista.DetalleIngeVista());
            //Application.Run(new PersonaVistas.PersonaListarVista());
            //Application.Run(new DetalleVentaVista.DetalleVentaInsertarVista());
            //Application.Run(new IngresoVista.IngresoInsertarVista());
           // Application.Run(new ProductoVista.ProductoInsertarVista());
          //Application.Run(new VentaVista.VentaInsertarVista());
        }
    }
    
}