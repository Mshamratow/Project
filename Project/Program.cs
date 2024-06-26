using NLog;


namespace Project
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"Nlog.config", false))
            {
                string text = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
<nlog xmlns=""http://www.nlog-project.org/schemas/NLog.xsd""
      xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""
      xsi:schemaLocation=""http://www.nlog-project.org/schemas/NLog.xsd NLog.xsd""
      autoReload=""true""
      throwExceptions=""false""
      internalLogLevel=""Off"" internalLogFile=""c:\temp\nlog-internal.log"">

  <!-- optional, add some variables
  https://github.com/nlog/NLog/wiki/Configuration-file#variables
  -->
  <variable name=""myvar"" value=""myvalue""/>

  <!--
  See https://github.com/nlog/nlog/wiki/Configuration-file
  for information on customizing logging rules and outputs.
   -->
  <targets>

    <!--
    add your targets here
    See https://github.com/nlog/NLog/wiki/Targets for possible targets.
    See https://github.com/nlog/NLog/wiki/Layout-Renderers for the possible layout renderers.
    -->
    
    <target name=""file"" xsi:type=""File"" fileName=""log.txt"" />
  


    <!--
    Write events to a file with the date in the filename.
    <target xsi:type=""File"" name=""f"" fileName=""${basedir}/logs/${shortdate}.log""
            layout=""${longdate} ${uppercase:${level}} ${message}"" />
    -->
  </targets>

   <rules>
    <logger name=""*"" minlevel=""Trace"" writeTo=""file"" />

  </rules>
</nlog>
";
                w.Write(text);
            }
            logger.Info("��������� ��������");

            // ��� ��� �����


            // ������ ������������ ���������

            

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            logger.Info("��������� ���������");
        }
    }
}