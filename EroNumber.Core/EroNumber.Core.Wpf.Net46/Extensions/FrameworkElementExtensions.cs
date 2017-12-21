using System;
using System.Threading.Tasks;
using System.Windows;

namespace EroNumber.Extensions
{
    public static class FrameworkElementExtensions
    {
        public static Task WaitForLoadedAsync(this FrameworkElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            if (element.IsLoaded)
            {
                return Task.CompletedTask;
            }

            var tcs = new TaskCompletionSource<object>();

            void Loaded(object sender, RoutedEventArgs e)
            {
                element.Loaded -= Loaded;
                tcs.SetResult(null);
            }
            element.Loaded += Loaded;

            return tcs.Task;
        }
    }
}