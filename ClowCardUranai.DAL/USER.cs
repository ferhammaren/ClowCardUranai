using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Manages user configuration
/// </summary>
namespace ClowCardUranai.DAL
{
    public class USER
    {
        private static string userConfigFile = "Resources/userConfig.dat";

        /// <summary>
        /// Saves the specified username
        /// </summary>
        /// <param name="username"></param>
        public static void saveUserName(string username)
        {
            string[] originalLines;
            originalLines = File.ReadAllLines(userConfigFile);
            originalLines[1] = "username:" + username;
            File.WriteAllLines(userConfigFile, originalLines);
        }

        /// <summary>
        /// Gets the saved username
        /// </summary>
        /// <returns></returns>
        public static string getUsername()
        {
            string line;
            string[] username;
            line = File.ReadLines(userConfigFile).Skip(1).Take(1).First();
            username = line.Split(':');
            return username[1];
        }
    }
}
