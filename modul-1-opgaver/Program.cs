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
Console.WriteLine(Opgave4.Euclid(36, 60));
Console.WriteLine(Opgave5.Potens(5, 4));
Console.WriteLine(Opgave6.Multiply(5, 4));
Console.WriteLine(Opgave7.Bananrekursiv("egaknanab"));
class Opgave3
{
   /* public static int Faculty(int n)
    {
        return n == 0 ? 1 : n * Faculty(n - 1);
    }
   */

    public static int Faculty(int n)
    {
        //her er termineringsreglen. hvis n rammer 0, returnere vi 1.
        if(n == 0)
        {
            return 1; 
        }
        //her er rekurrensreglen. den fortsætter indtil vi rammer termineringsreglen.       
         //her er den rekursive del, da vi kalder på funktionen inde i selve funktionen.
            return n * Faculty(n - 1);
        
        
        
    }
}

class Opgave4
{
    public static int Euclid(int a, int b)
    {

        // hvis b er mindre eller lig med 0 og der ikke er nogen rest efter modulu, terminer
        if (b <= a && a % b == 0)
        {
            return b;
        }
        //rekurrensregl
        if(a < b)
        {
            return Euclid(b, a);
        }

        // ellers gør dette
        else
        {
            return Euclid(b, a % b);
        }
        
    }

}

class Opgave5
{
    public static int Potens(int n, int p)
    { //terminer hvis potens er 0
        if(p == 0)
        {
            return 1;
        }
       
        //rekurrensregl, returner tallet * funktionen, hvor potensen bliver -1 hver gang rekursionen foregår, indtil termineringsreglen rammes.
        return n*Potens(n,p - 1);      
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
    class Opgave7
    {
    public static string Bananrekursiv(string s)
    {
        // Base case: if the string is empty or has only one character, return it as it is already reversed
        if (string.IsNullOrEmpty(s)) 
        {
            return s;
        }
        else
        {
            // Recursive case: reverse the substring without the last character and append the last character
            return Bananrekursiv(s.Substring(1)) + s[0];
        }
    }






}