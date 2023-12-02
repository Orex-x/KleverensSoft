namespace KleverensSoft
{
    public class Task3
    {
        public static void Start()
        {
            var random = new Random();
            
            for(int i = 0; i < 3; i++) {

                var readerThread = new Thread(() =>
                {
                    while (true)
                    {
                        int currentCount = Server.GetCount();
                        Console.WriteLine($"Читение значения: {currentCount}");
                        Thread.Sleep(new Random().Next(1000));
                    }
                });

                readerThread.Start();
            }

            for (int i = 0; i < 3; i++)
            {
                var writerThread = new Thread(() =>
                {
                    while (true)
                    {
                        Server.AddToCount(1);
                        Thread.Sleep(new Random().Next(2000));
                    }
                });

                writerThread.Start();
            }
        }
    }

    public static class Server
    {
        private static int _count = 0;
        private static ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();

        public static int GetCount()
        {
            try
            {
                rwLock.EnterReadLock();
                return _count;
            }
            finally
            {
                rwLock.ExitReadLock();
            }
        }

        public static void AddToCount(int value)
        {
            rwLock.EnterWriteLock();
            try
            {
                _count += value;
                Console.WriteLine($"value += {value}");
            }
            finally
            {
                rwLock.ExitWriteLock();
            }
        }
    }

}
