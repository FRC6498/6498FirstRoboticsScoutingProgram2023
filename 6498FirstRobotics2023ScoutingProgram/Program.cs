using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _6498FirstRobotics2023ScoutingProgram.Program;
namespace _6498FirstRobotics2023ScoutingProgram
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmData());


        }

        #region Form non-specific methods
        /* I've moved this out of the form class and into the program class
         * since it doesn't actually relate to the form itself.  Mostly just an organizational thing.
         * Also setting it to accept the csv dictionary variable as an input so it can use it from outside
         * of the form like expected.
         */
        internal static int RecordDataIntoCSV(Dictionary<string, List<string>> csvData, string filePath, int i,StreamWriter writer)
        {
            
            string newLine = "";

            //checks to see if the file path is valid, and if so, it will write a line to it, over time for each submission
            if (File.Exists(filePath) && filePath != "")
            {
                writer = new StreamWriter(filePath, append: true);

                foreach (KeyValuePair<string, List<string>> j in csvData)
                {
                    newLine += csvData[j.Key][i]+",";
                }
            }
            writer.WriteLine(newLine);

            writer.Close();

            i++;
            return i;
        }
        #endregion

        internal static void RecoveryDataCSV(Dictionary<string, List<string>> csvData)
        {
            StreamWriter writer = null;
            string fileAccess = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\6498Scouting\2023";

            if (Directory.Exists(fileAccess))
            {
                //success
            }
            else
            {
                //creates a path to be saved to if it does not actively exist
                DirectoryInfo di = Directory.CreateDirectory(fileAccess);
            }
            bool fileExists = true;
            int i = 0;
            string fileName = "";
            while (fileExists != false)
            {
                i++;
                fileName = @"/recovery" + i + @".csv";
                if (!Directory.Exists(fileAccess + fileName)) 
                {
                    fileExists = false;
                }
            }

            writer = new StreamWriter(fileAccess+fileName);
            //writes the header on the file
            string header = "";
            foreach (KeyValuePair<string, List<string>> j in csvData)
            {
                header += (j.Key + ",");
            }
            writer.WriteLine(header);

            //used to count the amount of items in the list in the dictionary
            //great help from stack overflow
            //https://stackoverflow.com/questions/34468224/how-do-i-count-the-number-of-values-in-a-particular-key-in-a-dictionary

            int csvLines = csvData["Team Number"].Count;

            for (int x = 0; x < csvLines; x++)
            {
                string newLine = "";
                foreach (KeyValuePair<string, List<string>> j in csvData)
                {
                    newLine += csvData[j.Key][x]+",";
                }
                writer.WriteLine(newLine);
            }


            writer.Close();
        }

    }

    //List<Checkboxes> check = new List<Checkboxes>;
    //check.add(chkBox1);

}
