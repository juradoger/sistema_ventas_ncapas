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
            Application.Run(new PersonaVistas.PersonaListarVista());
            Application.Run(new UsuarioVistas.UsuarioListarVista());
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
            Application.Run(new VentaVistas.VentaListarVista());
        }
    }
}