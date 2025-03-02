using ImageMagick;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ImageMagick;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Convert2PNG;
namespace Convert2PNG_GUI
{
    internal static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            /*
             The scope of this program
             Convert any image to PNG in the same file path
            */

            if (args.Length == 1)
            {
                //Found filepath
                var verify = new Main();
                verify.VerifyAndConvert(args[0]);
            }
            else
            {
                [DllImport("kernel32.dll")]
                static extern bool AllocConsole();
                AllocConsole();
                Console.WriteLine("-----Convert2PNG ver 1.0.0-BETA-----\nCheck for updates here=> https://github.com/ProtoSparky/Convert2PNG \n");
                Console.WriteLine("No file path was provided!");
                Console.WriteLine("Correct syntax is:");
                Console.WriteLine("> ./Convert2PNG.exe ./path_to_image\n\nPress any key to close the terminal");
                Console.ReadLine();

            }

        }
    }
    public class Main
    {
        public void VerifyAndConvert(string arg)
        {
            var hasPermissions = false;
            var random = new Random();
            random.FindBaseDirectory(arg, out string baseDirectory, out string filename);
            hasPermissions = random.CheckPermissions(baseDirectory); //checks if it can write to the directory. 

            if (hasPermissions)
            {
                random.ConvertToPNG(arg, baseDirectory + "/" + Path.GetFileNameWithoutExtension(filename) + ".png");
            }

        }

    }

    public class Random
    {
        public void FindBaseDirectory(string path, out string baseDirectory, out string file)
        {
            baseDirectory = Path.GetDirectoryName(path);
            file = Path.GetFileName(path);
        }
        public bool CheckPermissions(string path)
        {
            Debug.WriteLine(path);
            try
            {
                if (!Directory.Exists(path))
                {
                    return false;

                }
                else
                {
                    string tempfile = Path.Combine(path, Path.GetRandomFileName());
                    using (File.Create(tempfile, 1, FileOptions.DeleteOnClose)) { }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public void ConvertToPNG(string originalImage, string newImage)
        {
            try
            {
                using (var image = new MagickImage(originalImage))
                {
                    image.Write(newImage, MagickFormat.Png);
                }
            }
            catch (ImageMagick.MagickMissingDelegateErrorException) //Catch errors if the files are not convertable
            {
                MessageBox.Show("The file type cannot be converted to PNG", "Convert2PNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ImageMagick.MagickDelegateErrorException ex)
            {   
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                                
                if (ex.Message.Contains("gswin64c"))
                {
                    //Cannot find Ghostscript
                    var MissingErrorPackagesBox = new MissingPackages();
                    MissingErrorPackagesBox.PopulateText("ghostscript","https://ghostscript.com/releases/gsdnld.html");
                    Application.Run(MissingErrorPackagesBox);
                }
                else
                {
                    var VisualErrorBox = new ErrorReporting();
                    VisualErrorBox.Append2ErrorBox(ex.Message);
                    Application.Run(VisualErrorBox);
                }

            }            
            catch(Exception ex) //generic exceptions
            {
                if(ex.Message.Contains("improper image header"))
                {
                    //not actually image
                    MessageBox.Show("The file type cannot be converted to PNG", "Convert2PNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    var VisualErrorBox = new ErrorReporting();
                    VisualErrorBox.Append2ErrorBox(ex.Message);
                    Application.Run(VisualErrorBox);
                }
            }
        }
    }
}