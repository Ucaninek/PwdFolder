using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zVault;

namespace PwdFolder
{
    internal class LockUtil
    {
        public static async Task ProtectFolderAsync(string folderPath, string password, IProgress<int>? progress = null)
        {
            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException("The folder does not exist.");
            }

            // Create a unique file name for the zip file
            string zipFileName = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".zip");

            // Create a zip archive in the temp directory
            using (FileStream zipFile = new FileStream(zipFileName, FileMode.Create))
            {
                ZipArchive archive = new ZipArchive(zipFile, ZipArchiveMode.Create);

                // Add all files in the directory to the zip archive
                string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    string relativePath = file.Substring(folderPath.Length + 1);
                    archive.CreateEntryFromFile(file, relativePath);

                    // Report progress
                    if (progress != null)
                    {
                        int percentComplete = (int)((double)(Array.IndexOf(files, file) + 1) / files.Length * 100);
                        progress.Report(percentComplete / 2); // 0-50% for zipping
                    }
                }
            }

            Directory.Delete(folderPath, true);

            await Crypto.EncryptFileAsync(zipFileName, password, new CancellationToken(), new Progress<int>(current =>
            {
                int percentComplete = current;
                progress?.Report(50 + percentComplete / 2); // 50-100% for encryption
            }));

            if(Directory.GetParent(folderPath)?.FullName == null)
            {
                throw new DirectoryNotFoundException("The parent folder does not exist.");
            }

            //Move the zip in temp directory to the parent folder
            File.Move(zipFileName, Path.Combine((Directory.GetParent(folderPath)!.FullName), Path.GetFileName(folderPath) + ".pwf"));
        }


        //returns temp folder path
        public static async Task<string> UnlockFolderAsync(string filePath, string password, IProgress<int>? progress = null)
        {
            string tempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

            UnzipToFolder(filePath, tempFolder);

            return tempFolder;
        }

        private static void UnzipToFolder(string zipPath, string folderPath)
        {
            Directory.CreateDirectory(folderPath);
            using (ZipArchive archive = new ZipArchive(File.OpenRead(zipPath), ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    string entryPath = Path.Combine(folderPath, entry.FullName);
                    entry.ExtractToFile(entryPath, true);
                }
            }
        }
    }
}
