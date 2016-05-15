using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ionic.Zip;
using System.Windows.Forms;


namespace ZIP_Archivator
{
    class ArchivingActions
    {
        // Create archive using filesToArchive and archivePath
        public static  void ArchCreate (List<string> filesToArchive, string pathToArchive)
        
        {

          string pathInArchive=@"\"; //Path for items inside of Archive

         ZipFile zip = new ZipFile();
         //zip.AlternateEncodingUsage= true;  // utf-8
         //zip.AlternateEncodingUsage = System.Text.Encoding.GetEncoding("utf-8");

         if (ArchParameters.IncludeFullPath)
         {
             pathInArchive = ArchParameters.AbsolutePath;
         }
        

         
            try
            {
                foreach (string path in filesToArchive )
                {

                    if (File.Exists(path))
                    {
                        // path is a file.
                        // MessageBox.Show("Zipping file: " + path + "...");
                        zip.AddItem(path,pathInArchive);
                       
                    }
                    else if (Directory.Exists(path))
                    {
                      
                      //  MessageBox.Show("Zipping directory: " + path + " ...");
                        zip.AddDirectory(path + @"\", pathInArchive + new DirectoryInfo(path).Name);
                     
                    }
                    else
                    {
                        // path doesn't exist.
                        MessageBox.Show("Path doesn't exist: \n" + path + "\n It will be skipped!!!");
                    }
                                       
                    
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("You need to catch this Exception!!!!");
                MessageBox.Show(e.ToString());
                
            }
            finally {
                
                // Save Archive with added files
                zip.Save(pathToArchive);
                MessageBox.Show("Archive created Succesfuly");
                
            }
        }


        // Extract archive using zipFileName and pathToExtract
        public static void ArchExtract ( string zipFileName, string pathToExtract)
        {

            if (ZipFile.CheckZip(zipFileName))
            {
                try
                {
                   // using (ZipFile zip = new ZipFile(zipFileName))
                  {
                    
 
                        using (ZipFile zip = Ionic.Zip.ZipFile.Read(zipFileName))
                        {
                            if (ArchParameters.OverwriteSilently == false)
                            {
                                
                                foreach (var entry in zip)
                                {
                                    // extract only the entries I want:
                                    if (File.Exists(pathToExtract + @"\" + entry.FileName) || Directory.Exists(pathToExtract + @"\" + entry.FileName))
                                    {
                                        DialogResult result = MessageBox.Show("\""+entry.FileName.ToString()+ "\" already exists. \n Do you whant to overwrite?", 
                                                                                "Overwriting existing files...", 
                                                                                MessageBoxButtons.YesNoCancel, 
                                                                                MessageBoxIcon.Exclamation, 
                                                                                MessageBoxDefaultButton.Button1);

                                        if (result == DialogResult.Yes)
                                        {
                                            entry.Extract(pathToExtract, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                                        }
                                        if (result == DialogResult.Cancel)
                                        {
                                            return;
                                        }

                                    }
                                }
                            }
                            else
                            {
                                
                                // if ArchParameters.OverwriteSilently = true --> Do extarct with overwriting
                                zip.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                                zip.ExtractAll(pathToExtract);
                            }

                            MessageBox.Show("Archive extracted successfuly.");
                            



                        }
      
                    }
                }

                catch (Exception e)
                {
                    MessageBox.Show("You need to catch this Exception!!!!");
                    MessageBox.Show(e.ToString());

                }
               
            }

            else MessageBox.Show("Selected file is no an archive!. \n Please select archive file.");

        }
    

        //Test Archive
        public static bool ArchiveIsOk(string zipFileName)
        {

             if(ZipFile.IsZipFile(zipFileName))
             {
                 MessageBox.Show("Archive is Ok");
                 return true;
             }
            else 
             {
                MessageBox.Show("Archive is coruptued");
                return true;
             }
        }



    }
}
