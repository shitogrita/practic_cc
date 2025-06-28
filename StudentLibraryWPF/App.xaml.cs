using System;
using System.Windows;

namespace StudentLibraryWPF
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Глобальный перехват необработанных исключений
            AppDomain.CurrentDomain.UnhandledException += (s, args) =>
            {
                MessageBox.Show(
                    ((Exception)args.ExceptionObject).ToString(),
                    "Unhandled Exception",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                Shutdown();
            };

            try
            {
                // Создаём ваше окно вручную
                var main = new Views.MainWindow();
                main.Show();
            }
            catch (Exception ex)
            {
                // Показать, что пошло не так при создании окна
                MessageBox.Show(
                    ex.ToString(),
                    "Ошибка запуска MainWindow",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                Shutdown();
            }
        }
    }
}