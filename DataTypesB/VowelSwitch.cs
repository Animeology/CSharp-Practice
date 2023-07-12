namespace CSharp_Practice.DataTypesB
{
    public class VowelSwitch
    {
        public static void VowelOrNot()
        {
            Console.WriteLine("Input a letter and check if it is a vowel or not");

            char letter = Convert.ToChar(Console.Read());

            // If statement
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("{0} is a vowel", letter);
            }
            else
            {
                Console.WriteLine("{0} is a vowel", letter);
            }

            // switch
            //switch (letter)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("{0} is a vowel", letter);
            //        break;
            //    default:
            //        Console.WriteLine("{0} is a vowel", letter);
            //        break;
            //}
        }
    }
}
