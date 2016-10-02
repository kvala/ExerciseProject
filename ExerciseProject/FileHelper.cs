using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    public class FileHelper
    {
        public byte[] FileReader(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return null;
            }

            byte[] byets = new byte[1001];
            FileStream reader =  File.OpenRead(filepath);
            reader.Read(byets, 0, 1000);

            return byets;


        }

        public string FileReaderString(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return null;
            }

            byte[] byets = new byte[1001];
            FileStream reader = File.OpenRead(filepath);
            reader.Read(byets, 0, 1000);

            return byets.ToString();


        }
    }
}
