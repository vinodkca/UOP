using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Week1
{
    class FileInfo
    {
        public void WriteFile(string[] names, string filename)
        {
            //using disposes resources correctly
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
        }

        public string[] ReadFile(string filename)
        {
           List<string> lstnames = new List<string>();
            string line = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lstnames.Add(line);
                }
            }
            return lstnames.ToArray();            
        }
    }
}
