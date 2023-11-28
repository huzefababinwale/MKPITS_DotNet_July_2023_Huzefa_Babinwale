using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic=new Dictionary<string, string>();
            dic.Add("hu", "zefa");
            dic.Add("um", "mema");
            dic.Add("Pri", "ya");

            StringBuilder sb = new StringBuilder();
            foreach(string key in dic.Keys)
            {
                sb.Append("\tkey: "+key+"\tValues: " + dic[key]+"\n");
            }
            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
