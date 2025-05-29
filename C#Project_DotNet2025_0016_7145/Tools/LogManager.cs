

namespace Tools
{

       
    public static class LogManager
    {
        private static string logDirPath = "Log";

        private static string GetFolderPath()
        {
            return @$"{logDirPath}\{DateTime.Now.Year}_{DateTime.Now.Month}";
        }

        private static string GetFilePath()
        {
            return @$"{LogManager.GetFolderPath()}\Log_{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}.txt";
        }
        public static void WriteToLog(string projectName, string funcName, string message)
        {
            if (!Directory.Exists(LogManager.GetFolderPath()))
            {
                Directory.CreateDirectory(LogManager.GetFolderPath());
            }

            if (!File.Exists(LogManager.GetFilePath()))
            {
                File.Create(LogManager.GetFilePath()).Dispose();
            }


            using (StreamWriter sw = new StreamWriter(LogManager.GetFilePath(), true))
            {
                sw.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
            }
        }

        public static void DeleteLog()
        {
            string[] subDirectories = Directory.GetDirectories(logDirPath);
            foreach (string Dir in subDirectories)
            {
                if (int.TryParse(Dir.Substring(0, 4), out int year) && year < DateTime.Now.Year)
                {
                    Directory.Delete(Dir, true);
                }
                else if (int.TryParse(Dir.Substring(5, Dir.Length), out int month) && year == DateTime.Now.Year && month < DateTime.Now.Month)
                {
                    Directory.Delete(Dir, true);
                }
            }
        }

    }


}
