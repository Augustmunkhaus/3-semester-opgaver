// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, bob!");

/*public class rekursiv
{
    public static int areal(int bredde)
    {
        int resultat;
        if (bredde == 1)
        {
            resultat = 1;
        }
        else
        {
            resultat = bredde + areal(bredde - 1);
        }
        return resultat;
    }
}
*/

Console.WriteLine(Opgave3.Faculty(5)); // Output skal være '120'.
Console.WriteLine(Opgave4.Modulu(20, 10));
Console.WriteLine(Opgave5.Potens(5, 4));
Console.WriteLine(Opgave6.Multiply(5, 4));
class Opgave3
{
    public static int Faculty(int n)
    {
        //her er termineringsreglen. hvis n rammer 0, returnere vi 1.
        if(n == 0)
        {
            return 1; 
        }
        //her er rekurrensreglen. den fortsætter indtil vi rammer termineringsreglen.
        else if (n >= 1)
        { //her er den rekursive del, da vi kalder på funktionen inde i selve funktionen.
            return n * Faculty(n - 1)!;
        }
        return -1;
        
    }
}
class Opgave4
{
    public static int Modulu(int a, int b)
    {
        
        if (b <= a && a % b == 0)
        {
            //termineringsregl
            return b;
        }
        
        else if (a < b)
        {
            //rekurrensregl
            return Modulu(b, a);
        }
        else
        {
            return Modulu(b, a % b);
        }


    }
}

    class Opgave5
    {
        public static int Potens(int n, int p)
        {
            
            if (p == 0)
            {
                //termineringsregl
                return 1;
            }
            
            else if (p > 0)
            {
                //rekurrensregl
                return n * Potens(n, p - 1);
            }


        return -1;


        }



    }
class Opgave6
{
    public static int Multiply(int a, int b)
    {
        if (a == 1)
        {
            // Terminating rule: 1 * b = b
            return b;
        }
        else if (a == 0)
        {
            // Terminating rule: 0 * b = 0
            return 0;
        }
        else if (a > 1)
        {
            // Recurrence rule: a * b = (a - 1) * b + b
            return Multiply(a - 1, b) + b;
        }
        else
        {
            // Handle the case where a is negative, if needed
            return -1; // You can change this to an appropriate value or throw an exception
        }
    }



}