using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIP_Archivator
{
    public static class ArchParameters
    {
        //Absolute Path to Selected Files and Folders 
        public static string AbsolutePath { get; set; }

        //Selected Files and Folders to Archive
        public static List<string> ItemsToArchive {get;set;}

        //Path and Archive name 
        public static string ArchivePathAndName { get; set; }

        //Path and Archive name to Extract
        public static string ArchivePathToExtract { get; set; }

        //Path and Archive name to Extract
        public static string ArchiveFileToExtract { get; set; }

        //Path and Archive name to Extract
        public static bool OverwriteSilently { get; set; }
        
        //Include full Path to the Archive 
        public static bool IncludeFullPath { get; set; }


        

    }






}
