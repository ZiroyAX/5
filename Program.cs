using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        public static string open (string value)
        {
            switch (value)
            {
                case "(":
                    return "(";
                    break;

                case "[":
                    return "[";
                    break;

                case "{":
                    return "{";
                    break;

                default:
                    return "WARNING_1";
                    break;

            }

        }

        public static string exit (string value)
        {

            switch (value)
            {
                case ")":
                    return ")";
                    break;

                case "]":
                    return "]";
                    break;

                case "}":
                    return "}";
                    break;

                default:
                    return "WARNING_2";
                    break;

            }
        }


        static void Main(string[] args)
        {
            string[] var_1 = { "{", ")", ")", "}" };
            string rezult = "Неверная последовательность last";

            string temp_one = var_1[0];
            string temp_last = var_1[3];

            string open_one = "(";
            string open_two = "[";
            string open_three = "{";

            string exit_one = ")";
            string exit_two = "]";
            string exit_three = "}";

            string join_one = open_one + exit_one;
            string join_two = open_two + exit_two;
            string join_three = open_three + exit_three;


            if ((temp_one == open_one || temp_one == open_two || temp_one == open_three) && 
                (temp_last == exit_one || temp_last == exit_two || temp_last == exit_three))
            {


                if (var_1[1] == exit(var_1[1]))
                {
                    string temp_1 = var_1[0] + var_1[1];
                    if ((temp_1 == join_one) || (temp_1 == join_two) || (temp_1 == join_three))
                    {
                        rezult = "Верная последовательность";
                        }
                } else if (var_1[1] == open(var_1[1]))  //цикл 2
                {
                    if (var_1[2] == exit(var_1[2]))
                    {
                        string temp_2 = var_1[1] + var_1[2];
                        if ((temp_2 == join_one) || (temp_2 == join_two) || (temp_2 == join_three))
                        {
                            if (var_1[3] == exit(var_1[3]))
                            {
                                string temp_2_1 = var_1[0] + var_1[3];
                                if ((temp_2_1 == join_one) || (temp_2_1 == join_two) || (temp_2_1 == join_three))
                                {
                                    rezult = "Верная последовательность";
                                }
                            }
                        } else rezult = "Неверная последовательность 1";
                    } else rezult = "Неверная последовательность 2_1";
                } else rezult = "Неверная последовательность 2";


            }

            Console.WriteLine(rezult);



            Console.WriteLine("Haжмитe <Enter> для выхода . . . ");
            Console.Read();
        }

    }
}




