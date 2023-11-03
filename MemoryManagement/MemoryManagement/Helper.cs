namespace MemoryManagement
{
    public class Helper : IDisposable
    {
        FileStream fileStream = null;
        public void Dispose()
        {
            fileStream.Dispose();
            GC.SuppressFinalize(this);


        }
    }
}
