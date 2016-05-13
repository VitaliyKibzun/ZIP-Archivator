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
        
        public static  void ArchCreate (List<string> filesToArchive, string archivePath)
        
        {
        
         ZipFile zip = new ZipFile();

            try
            {
                foreach (string path in filesToArchive )
                {

                    if (File.Exists(path))
                    {
                        // path is a file.
                        zip.AddItem(path);
                        MessageBox.Show("Zipping file: " + path + "...");
                    }
                    else if (Directory.Exists(path))
                    {
                        // path is a directory.
                        //zip.AddDirectory(path);

                        if (1 == 1) //include full path in Archive
                        {
                            zip.AddDirectory(path, path);
                        }
                        else //Don't include full path in Archive
                        {
                            zip.AddDirectory(path, path);
                        }

                        MessageBox.Show("Zipping Directory: " + path + "...");
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
                MessageBox.Show("Exception!!!!");
                MessageBox.Show(e.ToString());
                
            }
            finally {
                MessageBox.Show(@archivePath);

                zip.Save(@archivePath);
                MessageBox.Show("Saved");
                
            }
        
     
        }
        public static void ArchExtract ( string zipFileName, string pathToExtract)
        {

            if (ZipFile.CheckZip(zipFileName))
            {

                try
                {
                    using (ZipFile zip = new ZipFile(zipFileName))
                    {
                        zip.ExtractExistingFile =ExtractExistingFileAction.OverwriteSilently;
                        zip.ExtractAll(pathToExtract );
                        
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception!!!!");
                    MessageBox.Show(e.ToString());

                }
                finally
                {


                    MessageBox.Show("Extracted");

                }
            }

            else MessageBox.Show("Selected file is no an archive!. \n Please select archive file.");

        }
    

    }
}
