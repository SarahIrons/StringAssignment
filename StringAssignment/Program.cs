using System;
using System.Text;


namespace StringAssignment
{
    class Program
    {//STRING ASSIGNMENT
     //Create a console app that does/includes the following:
     //Concatenates three strings.
     //Converts a string to uppercase.
     //Creates a Stringbuilder that builds a paragraph of text, one sentence at a time.
        static void Main(string[] args)
        {
            string a = "I have ";
            string b = "two beautful, perfect ";
            string c = "feline housemates.";
            Console.WriteLine(a + b + c);

            string cats = "Jody + Carlo furrever!";
            Console.WriteLine(cats.ToUpper());

            StringBuilder x = new StringBuilder("So much depends upon ");
            x.AppendLine("a red wheelbarrow ");
            x.AppendLine("glazed with rain water ");
            x.AppendLine("beside the white chickens ");
            x.AppendLine("-William Carlos Williams");
            Console.WriteLine(x);
                   
        }
    }
}
