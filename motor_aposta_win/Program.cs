using motor_aposta.domain.Repositories.Interfaces;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using motor_aposta_win.Login;
using motor_aposta_win.Control;

namespace motor_aposta_win
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuración de dependencias
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Build ServiceProvider
            var serviceProvider = services.BuildServiceProvider();
            
            var usuarioService = serviceProvider.GetRequiredService<IUsuarioRepository>();
            var tipoJogoService = serviceProvider.GetRequiredService<ITipoJogoRepository>();
            var concursoService = serviceProvider.GetRequiredService<IConcursoRepository>();
            var calculoService = serviceProvider.GetRequiredService<ICalculoRepository>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = serviceProvider.GetRequiredService<frm_menu>();
            Application.Run(mainForm); // Pasamos la instancia al formulario
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Registrar o serviço Refit com a URL base da API
            var baseUrl = ConfigurationManager.AppSettings["baseUrl"];

            services.AddRefitClient<IUsuarioRepository>()
                    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseUrl));

            services.AddRefitClient<ITipoJogoRepository>()
                    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseUrl));

            services.AddRefitClient<IConcursoRepository>()
                    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseUrl));

            services.AddRefitClient<ICalculoRepository>()
                    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseUrl));

            // Registrar o formulário principal
            services.AddSingleton<frm_menu>();
            services.AddSingleton<frm_login>();
            services.AddSingleton<control_calculo>();

        }
    }
}