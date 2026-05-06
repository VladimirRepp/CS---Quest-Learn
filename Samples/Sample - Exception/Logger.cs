namespace Sample
{
    public class Logger
    {
        private static Logger INSTANCE;

        private string _path;

        public static Logger getInstance {
            get
            {
                if (INSTANCE == null)
                    INSTANCE = new Logger();

                return INSTANCE;
            }
        }

        private Logger() {
            _path = "log.txt";
        }


        public void Log(string message)
        {
            string logMessage = "[" + DateTime.Now.ToString("dd.MM.yyyy hh:MM") + "]: " + message;

            using (StreamWriter writer = new StreamWriter(_path, true))
            {
                writer.WriteLine(logMessage);
            }
        }
    }
}
