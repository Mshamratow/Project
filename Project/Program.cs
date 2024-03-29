using NLog;


namespace Project
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("Программа запущена");

            // Ваш код здесь


            // Другие логировочные сообщения

            

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            logger.Info("Программа завершена");
        }
    }
}