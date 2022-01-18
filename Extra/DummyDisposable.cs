namespace CheatSheet.Extra
{
    internal class DummyDisposable : IDisposable, IAsyncDisposable
    {
        public void Do()
        {
        }

        public Task DoAsync()
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {
        }

        public ValueTask DisposeAsync()
        {
            return ValueTask.CompletedTask;
        }
    }
}
