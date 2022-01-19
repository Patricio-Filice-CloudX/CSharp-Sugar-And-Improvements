using CheatSheet.Extra;

namespace CheatSheet.CSharp8
{
    /// <summary>
    /// Avoid repetitive coding when disposing is involved.
    /// For more detail (sync): https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#using-declarations
    /// For more detail (async): https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#asynchronous-disposable
    /// </summary>
    public static class UsingCSharp8
    {
        public static async void Run()
        {
            // Old way.
            var oldDisposable = new DummyDisposable();
            try
            {
                oldDisposable.Do();
                // Code
            }
            finally
            {
                Console.WriteLine("Old disposing format");
                oldDisposable.Dispose();
            }

            var oldDisposableAsync = new DummyDisposable();
            try
            {
                await oldDisposableAsync.DoAsync();
                // Code
            }
            finally
            {
                Console.WriteLine("Old disposing async format");
                await oldDisposableAsync.DisposeAsync();
            }

            // New way.
            using var newDisposable = new DummyDisposable();
            Console.WriteLine("New disposing format, will dispose before exiting the method");

            using (var newDisposableOnBlock = new DummyDisposable())
            {
                Console.WriteLine("New disposing format, will dispose before exiting the block");
            };

            await using var newDisposableAsync = new DummyDisposable();
            Console.WriteLine("New disposing async format, will dispose before exiting the method");

            await using (var newDisposableAsyncOnBlock = new DummyDisposable())
            {
                Console.WriteLine("New disposing async format, will dispose before exiting the block");
            }
        }
    }
}
