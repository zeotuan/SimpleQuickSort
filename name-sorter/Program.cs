using System;
using System.IO;
using System.Collections.Generic;  
using System.Threading.Tasks;
using library;
namespace name_sorter
{

    ///<summary>
    /// Main Driver Class of the program 
    ///</summary>    
    public class Program
    {

        ///<summary>
        /// Driver Function 
        /// take 1 input of string type: fileName
        ///</summary>
        static async Task Main(string[] args)
        {
            if(args == null || args.Length == 0)
            {
                Console.WriteLine("No argument was Passed! Press any key to exit");
                Console.ReadLine();
            }
            else
            {
                string filename = args[0];
                List<Name> nameList = readNameFile(filename);
                nameList.PerformSort();
                nameList.printList();
                await writeFile(nameList,"sorted-names-list.txt");
            }
        }

        ///<summary>
        /// ReadFile and Convert File to List of Name Object
        ///</summary>
        /// <remarks>
        /// This function start searching from your current relative directory
        /// </remarks>
        /// <returns>
        /// List of object with type Name
        /// </returns>
        /// <example>
        /// <code>
        /// List&lt;Name&gt; = readNameFile("fileName");
        /// </code>
        /// </example>     
        /// <exception cref="System.IO.FileNotFoundException">
        ///Thrown when input file name cannot be found
        ///</exception>  
        /// <exception cref="System.IO.DirectoryNotFoundException">
        ///Thrown when direcotry cannot be found
        ///</exception>  
        static List<Name> readNameFile(string fileName){
            List<Name> names = new List<Name>();
            StreamReader file;
            try{
                string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                file = new StreamReader(path);
                string line;
                while((line = file.ReadLine()) != null){
                    if(!string.IsNullOrEmpty(line)){
                        Name temp = new Name(line);
                        names.Add(temp); 
                    }
                }
                file.Close(); 
            }catch(FileNotFoundException e){
                Console.WriteLine($"Error trying to find file: {fileName}");
                Console.WriteLine(e.Message);
            }catch(DirectoryNotFoundException e){
                Console.WriteLine("Error trying to find directory");
                Console.WriteLine(e.Message);
            }
            return names;
        }


         ///<summary>
        /// A generic async function that Write a List content file 
        ///</summary>
        /// <remarks>
        /// This function will write the result of the object toString method to specified file
        /// </remarks>
        /// <example>
        /// <code>
        /// List&lt;double&gt; listOfDouble=  List&lt;double&gt;{ 1.2, 1.3, 1.4, 1.5 };
        /// await writeFile("fileName", listOfDouble);
        /// </code>
        /// </example>     
        /// <exception cref="System.IO.FileNotFoundException">
        ///Thrown when input file name cannot be found
        ///</exception>  
        /// <exception cref="System.IO.DirectoryNotFoundException">
        ///Thrown when direcotry cannot be found
        ///</exception>  
        static async Task writeFile<T>(List<T> list, string fileName){
            StreamWriter file;
            try{
                string path = Path.Combine(Directory.GetCurrentDirectory(),fileName);
                file = new StreamWriter(path);
                foreach(T element in list){
                   await file.WriteLineAsync(element.ToString());
                }
                file.Close();
            }catch(FileNotFoundException e){
                Console.WriteLine($"Error trying to find file: {fileName}");
                Console.WriteLine(e.Message);
            }catch(DirectoryNotFoundException e){
                Console.WriteLine("Error trying to find directory");
                Console.WriteLine(e.Message);
            }
        }

    }
}
