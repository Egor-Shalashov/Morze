using System;
using System.IO;
using morze_lib;

namespace morze
{
    class Program
    {
        static void Main(string[] args)
        {
            Morze n = new Morze();
            string s = "";
            string language = "en";
            s = Console.ReadLine();
            using (StreamReader input = new StreamReader("in.txt", System.Text.Encoding.Default))
            {
                using (StreamWriter output = new StreamWriter("ou.txt"))
                {
                    if (s == "en" || s == "ru")
                    {
                        while (input.Peek() > 0)
                        {
                            char temp_read = (char)input.Read();
                            output.Write(n.in_morze(temp_read, s));
                            Console.Write(n.in_morze(temp_read, s));
                        }
                    }
                    else if (s == "morze")
                    {
                        language = Console.ReadLine();
                        string temp = "";
                        char temp_read;
                        char t_temp_read = '0';
                        while (input.Peek() > 0)
                        {
                            temp_read = (char)input.Read();
                            if (temp_read != ' ' && temp_read != '\n' && temp_read != '\r')
                            {
                                temp += temp_read;
                            }
                            else if (temp_read == ' ' && t_temp_read == ' ')
                            {
                                Console.Write(' ');

                                output.Write(' ');
                            }
                            else if (temp_read == '\n')
                            {
                                Console.Write(n.fr_morze(temp, language));
                                Console.Write('\n');

                                output.Write(n.fr_morze(temp, language));
                                output.Write('\n');
                            }
                            else
                            {
                                Console.Write(n.fr_morze(temp, language));

                                output.Write(n.fr_morze(temp, language));
                                temp = "";
                            }
                            t_temp_read = temp_read;
                        }
                    }
                    else { }
                }
            }
        }
    }
}