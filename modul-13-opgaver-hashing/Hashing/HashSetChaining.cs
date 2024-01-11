using Hashing;

public class HashSetChaining : HashSet
{
    private Node[] buckets;
    private int currentSize;

    private class Node
    {
        public Node(Object data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
        public Object Data { get; set; }
        public Node Next { get; set; }
    }

    public HashSetChaining(int size)
    {
        buckets = new Node[size];
        currentSize = 0;
    }

    public bool Contains(Object x)
    {
        int h = HashValue(x);
        Node bucket = buckets[h];
        bool found = false;
        while (!found && bucket != null)
        {
            if (bucket.Data.Equals(x))
            {
                found = true;
            }
            else
            {
                bucket = bucket.Next;
            }
        }
        return found;
    }

    public bool Add(Object x)
    {
        int h = HashValue(x);

        Node bucket = buckets[h];
        bool found = false;
        while (!found && bucket != null)
        {
            if (bucket.Data.Equals(x))
            {
                found = true;
            }
            else
            {
                bucket = bucket.Next;
            }
        }

        if (!found)
        {
            Node newNode = new Node(x, buckets[h]);
            buckets[h] = newNode;
            currentSize++;
        }

        return !found;
    }

    public bool Remove(Object x)
    {
        int h = HashValue(x); //beregn hash-v�rdien for objektet

        Node bucket = buckets[h]; //f� den f�rste node i bucket beholderen(arrayet/hashtablet)

        Node previousBucket = null;
        //tjekker om elementet bliver fundet
        bool found = false;

        while (!found && bucket != null) //k�rer igennem den k�dede liste i bucket
        {
            if (bucket.Data.Equals(x)) //tjekker om det data som er i den nuv�rende node er lig med det vi s�ger efter
            {
                found = true; //elementet bliver fundet

                if (bucket == buckets[h]) //s�rligt tilf�lde: hvis det vi vil fjerne er den f�rste node i bucket
                {
                    buckets[h] = buckets[h].Next; //flyt pointeren for den k�dede liste til den n�ste node
                }
                 // hvis vi har en k�dede liste/hashtable hvor der ligger 3 v�rdier i, fx 11, 21, 31
                //og vi skal slette 21, siger koden: pointeren som peger p� previousbucket skal pege p� bucket's n�ste v�rdier. dvs at 
                //hvis vi skal slet 21, f�r vi pointers til at pege p� 11 og 31, og ikke 21.


                else
                {
                    previousBucket.Next = bucket.Next;
                }
                currentSize--; //formindsker st�rrelsen af m�ngden
                
            }
            
            

            else
            { //elementet blev ikke fundet i den nuv�rende node, g� videre til n�ste node

                //n�r koden med previous og og bucket.next er lavet og vi slutter loopet,
                //bliver de pointers som var lavet ovenover slettet. dog peger selve buckets(den k�dede liste) stadig p� 11, som peger p� 31.
                //derfor bliver kun 21 slettet, mens de andre bliver st�ende.
                previousBucket = bucket;
                bucket = bucket.Next;
            }
        }


        return !found;

    }

    private int HashValue(Object x)
    {
        int h = x.GetHashCode();
        if (h < 0)
        {
            h = -h;
        }
        h = h % buckets.Length;
        return h;
    }

    public int Size()
    {
        return currentSize;
    }

    public override String ToString()
    {
        String result = "";
        for (int i = 0; i < buckets.Length; i++)
        {
            Node temp = buckets[i];
            if (temp != null)
            {
                result += i + "\t";
                while (temp != null)
                {
                    result += temp.Data + " (h:" + HashValue(temp.Data) + ")\t";
                    temp = temp.Next;
                }
                result += "\n";
            }
        }
        return result;
    }
}
