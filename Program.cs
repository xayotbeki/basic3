//1.String ustida amallar---------------------

// string str = "SaLoM NiMa GaP";
// Console.Write("son: ");
// int son = Convert.ToInt32(Console.ReadLine());
// int len = str.Length;
// if(son>=len)
// {
//     System.Console.WriteLine(str.ToUpper());
// }
// else
// {
//     System.Console.WriteLine(str.ToLower());
// }

//2----------------------------------------

// int x = 15;
// int y = 10;
// if(x > y)
// {
//     System.Console.WriteLine("x is greater than y");
// }
// else if(x < y)
// {
//     System.Console.WriteLine("x is less than y");
// }
// else if(x == y)
// {
//     System.Console.WriteLine("x is equal to y");
// }
// else
// {
//     System.Console.WriteLine("x and y are not comparable");
// }

//3
System.Console.Write("Hafta kunini kiriting: ");
string haftaKuni = Console.ReadLine();
haftaKuni = haftaKuni.ToUpper();
switch (haftaKuni)
{
    case "DUSHANBA":
        System.Console.WriteLine("Monday");
        break;
    case "SESHANBA":
        System.Console.WriteLine("Tuesday");
        break;
    case "CHORSHANBA":
        System.Console.WriteLine("Wednesday");
        break;
    case "PAYSHANBA":
        System.Console.WriteLine("Thursday");
        break;
    case "JUMA":
        System.Console.WriteLine("Friday");
        break;
    case "SHANBA":
        System.Console.WriteLine("Saturday");
        break;
    case "YASHSHANBA":
        System.Console.WriteLine("Sunday");
        break;
    default:
        System.Console.WriteLine("Bunday hafta kuni yo'q");
        break;
}