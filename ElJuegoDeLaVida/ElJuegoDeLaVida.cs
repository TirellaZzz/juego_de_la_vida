namespace ElJuegoDeLaVida
{
    // Clase principal del programa
    internal static class ElJuegoDeLaVida
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormMenu());
        }
    }
}