namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            try
            {
                worker.Run_1(1, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Logger.getInstance.Log(ex.Message);

                worker.Run_1(1, 2);
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                Logger.getInstance.Log(ex.Message);
            }

            Console.WriteLine("------------------------------");

            try
            {
                worker.Run_2(1, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Logger.getInstance.Log(ex.Message);

                worker.Run_1(1, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Logger.getInstance.Log(ex.Message);
            }

            Console.WriteLine("------------------------------");

            try
            {
                worker.Run_3();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
                Logger.getInstance.Log(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Logger.getInstance.Log(ex.Message);
            }
        }
    }
}
