using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDifferenciator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public class NaturalComparer : Comparer<string>, IDisposable
        {
            private Dictionary<string, string[]> table;

            public NaturalComparer()
            {
                table = new Dictionary<string, string[]>();
            }

            public void Dispose()
            {
                table.Clear();
                table = null;
            }

            public override int Compare(string x, string y)
            {
                if (x == y)
                {
                    return 0;
                }
                string[] x1, y1;
                if (!table.TryGetValue(x, out x1))
                {
                    x1 = Regex.Split(x.Replace(" ", ""), "([0-9]+)");
                    table.Add(x, x1);
                }
                if (!table.TryGetValue(y, out y1))
                {
                    y1 = Regex.Split(y.Replace(" ", ""), "([0-9]+)");
                    table.Add(y, y1);
                }

                for (int i = 0; i < x1.Length && i < y1.Length; i++)
                {
                    if (x1[i] != y1[i])
                    {
                        return PartCompare(x1[i], y1[i]);
                    }
                }
                if (y1.Length > x1.Length)
                {
                    return 1;
                }
                else if (x1.Length > y1.Length)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

            private static int PartCompare(string left, string right)
            {
                int x, y;
                if (!int.TryParse(left, out x))
                {
                    return left.CompareTo(right);
                }

                if (!int.TryParse(right, out y))
                {
                    return left.CompareTo(right);
                }

                return x.CompareTo(y);
            }
        }
        public int imageCount = 0;
        List<string> imagesInFolder = new List<string>();

        private void FolderBrowse_Click(object sender, EventArgs e)
        {
            imageCount = 0;

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPath.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;


                var files = Directory.EnumerateFiles(folderDlg.SelectedPath, "*.jpg").OrderBy(filename => filename);

                imagesInFolder = files.ToList<string>();
                using (NaturalComparer comparer = new NaturalComparer())
                {
                    imagesInFolder.Sort(comparer);
                }



            }
        }

        private void ProduceCSV_Click(object sender, EventArgs e)
        {
            float pixelBrightness = float.Parse(selectedPixelBrightness.Text);
            //each collumn should be a list -- this is to avoid using CSV helper and have to make objects.
            List<string> csvList = new List<string>();

            //write all resullt to csv by appending the lines formatted e.g. filename.jpg, Wet

            //loop through folder filenames and check all

            int count = 0;

            foreach (string img in imagesInFolder)
            {

                int startX = int.Parse(centerPositionX.Text);
                int startY = int.Parse(centerPositionY.Text);
                //crop and draw
                Rectangle rect = new Rectangle(startX-(int.Parse(cropSquare.Text)/2), startY - (int.Parse(cropSquare.Text) / 2), int.Parse(cropSquare.Text), int.Parse(cropSquare.Text));

                Bitmap crop = ImgKit.cropAtRect(new Bitmap(img), rect);

                if (ImgKit.isWet((float)pixelBrightness, crop))
                {
                    csvList.Add(img + "," + "Wet" + "," + ImgKit.AveragePixelsBlack(crop.Width, crop.Height, crop));
                }
                else
                {
                    csvList.Add(img + "," + "Dry" + "," + ImgKit.AveragePixelsBlack(crop.Width, crop.Height, crop));
                }
                crop.Save(outputFolderPath + "\\" + count + "crop.jpg");
                crop.Dispose();
                count++;
            }
            //list is produced in variable currentOCRResults --- ensure to clear before resetting
            var saveFile = outputFolderPath  + "\\DifferentiatorFile.csv";
            File.WriteAllLines(saveFile, csvList);
            GC.Collect();

        }
        string outputFolderPath = "";
        private void FolderBrowseOutput_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                foldernameOutput.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                outputFolderPath = folderDlg.SelectedPath;
            }
            


            
        }

        private void TestCrop_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (string img in imagesInFolder)
            {

                int startX = int.Parse(centerPositionX.Text);
                int startY = int.Parse(centerPositionY.Text);
                //crop and draw
                Rectangle rect = new Rectangle(startX - (int.Parse(cropSquare.Text) / 2), startY - (int.Parse(cropSquare.Text) / 2), int.Parse(cropSquare.Text), int.Parse(cropSquare.Text));

                Bitmap crop = ImgKit.cropAtRect(new Bitmap(img), rect);
                crop.Save(outputFolderPath + "\\" + count + "crop.jpg");
                crop.Dispose();
                count++;
            }
            GC.Collect();
        }
    }
}
