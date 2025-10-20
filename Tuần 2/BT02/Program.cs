using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    static extern bool GetVolumeInformation(string root, StringBuilder vol, int volSize,
        out uint serial, out uint maxLen, out uint flags, StringBuilder fs, int fsSize);

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string path = GetValidDirectoryPath();
        string root = Path.GetPathRoot(path) ?? Path.GetPathRoot(Directory.GetCurrentDirectory());
        DriveInfo drive = new DriveInfo(root);

        uint serial = GetDriveSerialNumber(root);

        PrintDriveInfo(drive, serial);
        PrintDirectoryContents(path, drive);
    }

    static string GetValidDirectoryPath()
    {
        while (true)
        {
            Console.Write("Nhap duong dan thu muc: ");
            string path = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(path))
                continue;

            if (path == "\\" || path == "/")
                path = Directory.GetCurrentDirectory();

            if (Directory.Exists(path))
                return path;

            Console.WriteLine("Thu muc khong ton tai. Vui long nhap lai");
        }
    }

    static uint GetDriveSerialNumber(string root)
    {
        GetVolumeInformation(root, new StringBuilder(261), 261,
            out uint serial, out _, out _, new StringBuilder(261), 261);
        return serial;
    }

    static void PrintDriveInfo(DriveInfo drive, uint serial)
    {
        Console.WriteLine($"\n Volume in drive {drive.Name.TrimEnd('\\')} is {drive.VolumeLabel}");
        Console.WriteLine($" Volume Serial Number is {serial:X4}-{serial >> 16:X4}\n");
    }

    static void PrintDirectoryContents(string path, DriveInfo drive)
    {
        Console.WriteLine($" Directory of {path}\n");

        string[] dirs = Directory.GetDirectories(path);
        string[] files = Directory.GetFiles(path);
        long totalSize = 0;

        foreach (var dir in dirs)
        {
            var info = new DirectoryInfo(dir);
            Console.WriteLine($"{info.LastWriteTime:MM/dd/yyyy  hh:mm tt}    <DIR>          {info.Name}");
        }

        foreach (var file in files)
        {
            var info = new FileInfo(file);
            Console.WriteLine($"{info.LastWriteTime:MM/dd/yyyy  hh:mm tt} {info.Length,15:N0} {info.Name}");
            totalSize += info.Length;
        }

        Console.WriteLine($"\n {files.Length,2} File(s) {totalSize,20:N0} bytes");
        Console.WriteLine($" {dirs.Length,2} Dir(s)  {drive.AvailableFreeSpace,20:N0} bytes free");
    }
}
