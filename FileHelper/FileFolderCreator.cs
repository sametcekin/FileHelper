using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileHelper
{
    public static class FileFolderCreator
    {
        /// <summary>
        /// If folder does not exist then create, also files.
        /// </summary>
        /// <param name="pathFolder">For folder path</param>
        /// <param name="pathFile">For array path file</param>
        public static void FolderFileCreate(string pathFolder, string[] pathFile)
        {
            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }
            foreach (var file in pathFile)
            {
                if (!File.Exists(file))
                {
                    using StreamWriter sw = File.CreateText(file);
                }
            }
        }

    }
}
