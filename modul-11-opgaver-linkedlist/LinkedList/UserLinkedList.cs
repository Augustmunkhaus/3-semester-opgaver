namespace LinkedList
{
    class Node
    {
        public Node(User data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
        public User Data;
        public Node Next;
    }

    class UserLinkedList
    {
        private Node first = null!;

        public void AddFirst(User user)
        {
            Node node = new Node(user, first);
            first = node;
        }

        public User RemoveFirst()
        {
            //det virker lidt skørt, da vi ikke aktivt skriver noget med remove.
            //her siger vi simpelthen bare at pointeren skal pege på det næste
            //element i linkedlisten. da det første element ikke længere bliver peget på,
            //sletter compileren automatisk den første node. meget enkelt.
            first = first.Next;
            
            return null!;
        }

        public void RemoveUser(User user)
        {
            Node node = first;
            Node previous = null!;
            bool found = false;

            while (!found && node != null)
            {
                if (node.Data.Name == user.Name)
                {
                    found = true;
                    if (node == first)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        previous.Next = node.Next;
                    }
                }
                else
                {
                    previous = node;
                    node = node.Next;
                }
            }
        }

        public User GetFirst()
        {
            return first.Data;
        }

        public User GetLast()
        {
            //her laver jeg en ny variabel currentnode og sætter den som den første.
            //så kører jeg igennem listen indtil jeg rammer den node,
            //som har null som sin næste adresse, og returnerer dataen.
            Node currentnode = first;

            while (currentnode != null)
            {
                currentnode = currentnode.Next;
            }

            // TODO: Implement
            return currentnode.Data;
        }

        public bool AddLast(User user)
        { //hvis den første node er null, adder vi bare på first
            if(first==null)
            {
                 first = new Node(user, first);
                return true;
            }
            
            Node currentnode = first;
            //vi kører igennem listen med .Next
            while (currentnode.Next != null)
            {
                currentnode = currentnode.Next;
            }
            //vi laver en ny node der indeholder vores user vi til tilføje, og sætter dens vejviser til null
            Node node = new Node(user, null);
            //den næste node skal være lig med den nye node vi tilføjer
            currentnode.Next = node;

            return true;
             
        }

        public bool RemoveLast()
        { 
            //hvis listen er tom, returner vi false, vi kan ikke slette noget
            
            if (first == null)
            {
                
                return false;
            }
            //vi kører igennem listen med while loopet, og opretter en previous node, som ikke peger på noget endnu, derfor null!
            Node currentnode = first;
            Node previous = null!;
            while (currentnode.Next != null)
            { //her siger vi at previous skal pege på det som currentnode peger på.
                //så går currentnode videre til den næste, og previous peger på den forrige
                previous = currentnode;
                currentnode = currentnode.Next;
                
            }

            //her siger at previous next skal pege på null, altså ingenting, så der ikke bliver peget på den sidste current
            previous.Next = null!;

            return true;
        }

        public int CountUsers()
        {
            //jeg laver en int count til at holde på tal.
            //jeg bruger samme kode igen til at iterate igennem listen.
            //hver gang den en node frem med next, lægger jeg 1 til count.
            //når vi rammer den sidste returnerer vi count.
            int count = 0;
            Node currentnode = first;

            while (currentnode != null)
            {
                currentnode = currentnode.Next;
                count++;
            }

            
            return count;
        }

        public override String ToString()
        {
            Node node = first;
            String result = "";
            while (node != null)
            {
                result += node.Data.Name + ", ";
                node = node.Next;
            }
            return result.Trim();
        }

        public bool Contains(User user)
        {
            //her laver jeg en ny variabel current og sætter den som den første.
            //så kører jeg igennem listen indtil jeg rammer den node som er equal til den user jeg leder efter. altså hvor der er et match
            //så returner jeg true. hvis listen ikke indeholder den person som jeg leder efter, return false
            Node current = first;

            while (current != null)
            {
                if (current.Data.Equals(user))
                {
                    // Found a match
                    return true;
                }

                current = current.Next;
            }

            // No match found
            return false;
        }
    }
}