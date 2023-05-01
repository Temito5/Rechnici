using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TelefonenUkazatel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> kontakti = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string name = tokens[1];

                if (command=="A")
                {
                    string phone = tokens[2];
                    kontakti.Add(name, phone);
                }
                else if (command=="S")
                {
                    if (kontakti.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {kontakti[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                       

                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
