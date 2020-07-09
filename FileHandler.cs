using BioThreads.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BioThreads
{
    class FileHandler
    {
        static string _fileLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Files/intergenidb.csv";

        public static /* async*/ /*Task<string>*/ void ReadFile()
        {
            //var degreeOfParallelism = Environment.ProcessorCount / 2;

            //using (var fileStream = new FileStream(_fileLocation, FileMode.Open))
            //{
            //    var totalBytes = (int)fileStream.Length;

            //    using (var reader = new StreamReader(fileStream))
            //    {
            //        var bytesToRead = totalBytes / degreeOfParallelism;

            //        var buffer = new char[totalBytes];

            //        for (int i = 0; i < degreeOfParallelism; i++)
            //        {
            //            if (await reader.ReadAsync(buffer, i * bytesToRead, bytesToRead) == 0)
            //                break;
            //        }

            //        return new string(buffer);
            //    }
            //}



            //while (!reader.EndOfStream)
            //{
            //    string line = reader.ReadLine();
            //    // Console.WriteLine(line);
            //}




            List<Gene> genes = new List<Gene>();

            Parallel.ForEach(File.ReadLines(_fileLocation), (line, _, lineNumber) =>
            {
                string[] lineSplitted = line.Split(';');

                string first = lineSplitted[0];//nome do organismo | Borrelia burgdorferi B31
                string second = lineSplitted[1];//alguma sigla     | smpB
                string third = lineSplitted[2];//categoria?        | Bacteria
                string fourth = lineSplitted[3];//subcategoria?    | Spirochaetes
                string fifth = lineSplitted[4];//role? sigla?      | Roles will be associated as soon as possible
                string sixth = lineSplitted[5];//codigo            | 31026
                string seventh = lineSplitted[6];//codigo          | 31016
                string eighth = lineSplitted[7];//gene             | AAGGAATAGAT

                Gene gene = new Gene(lineSplitted[0], lineSplitted[1], lineSplitted[2], lineSplitted[3], lineSplitted[4], lineSplitted[5], lineSplitted[6], lineSplitted[7]);

                genes.Add(gene);
                //ordenar a lista ou inserir já ordenado?


                // Console.WriteLine(lineNumber);

            });

            
            Console.WriteLine(genes.Count);
        }

        private void SortList()
        {

        }
    }

}
