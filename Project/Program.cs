using NLog;


namespace Project
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("��������� ��������");

            // ��� ��� �����


            // ������ ������������ ���������

            

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            logger.Info("��������� ���������");
        }
    }
}