using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZipFile.CreateFromDirectory(@"E:\ZipFileDemo", @"E:\ZipFileDemo2\myZipFile.zip");

            ZipFile.ExtractToDirectory(@"E:\ZipFileDemo2\myZipFile.zip", @"E:\ZipFileExtract");
        }
    }
}
