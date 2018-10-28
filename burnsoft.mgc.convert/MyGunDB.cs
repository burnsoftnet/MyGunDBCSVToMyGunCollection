using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace burnsoft.mgc.convert
{
    public class MyGunDB
    {
        public static void GetData(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    //listA.Add(values[0]);
                }
            }
        }
    }
}
