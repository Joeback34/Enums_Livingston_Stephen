using System;
using System.IO;

namespace Enums_Livingston_Stephen
{
    enum Months // Global enum sets Jan-Dec as constants
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec

    }
    class Program
    {   
   
        static void Main(string[] args)
        {   
            
            int myBirthMonth = (int)Months.Feb; // Integer set to my birth month.
            int myBirthDay = 07; // Integer set to my birth day.
            int myBirthYear = 1995; // Integer set to my birth yea.

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}."; // string that stores birthday/month/year in myBirthDate.

            File.WriteAllText("myFile.txt", "This is a sentence!"); // creates a new file and writes the contents to it.
            Console.WriteLine(File.ReadAllText("myFile.txt")); // prints the contents of the file.
            
            File.AppendAllText("myFile.txt", "MORE TEXT IN THE FILE\n"); // adds additional text to myFile.txt.
            Console.WriteLine(File.ReadAllText("myFile.txt")); // prints the contents of the file.

            if (!File.Exists("newFile.txt")) // if statement that copies the file.
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else // esle statement that replaces the file with myFile.txt.
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            File.AppendAllText("newFile.txt", myBirthDate); // adds additional text to newFile.txt
            Console.WriteLine(File.ReadAllText("newFile.txt")); // prints newFile.txt content.


        }
        
    }
}
