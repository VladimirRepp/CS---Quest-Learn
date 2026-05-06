namespace Sample
{
    internal class Worker
    {
        private int Task(int a, int b) => a / b;

        public void Run_1(int a, int b)
        {
            try
            {
                Console.WriteLine("Run_1 start ...");
                float result = Task(a, b);
                Console.WriteLine($"Result = {result.ToString()}");
                Console.WriteLine("Run_1 end ...");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Run_2(int a, int b)
        {
            try
            {
                Console.WriteLine("Run_2 start ...");
                Console.WriteLine($"Result = {Task(a, b).ToString()}");
                Console.WriteLine("Run_2 end ...");
            }
            catch (Exception ex)
            {
                throw new Exception($"Worker.Run_2(error): {ex.Message}");
            }
        }

        public void Run_3()
        {
            Console.WriteLine("Run_3 start ...");
            throw new NotImplementedException();
            Console.WriteLine("Run_3 end ...");
        }
    }
}
