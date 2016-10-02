using System.Runtime.InteropServices;

namespace ExerciseProject
{
    public class ListWithChildArray
    {

        public static ListWithChild FlattenList(ListWithChild head, ListWithChild tail)
        {
            var current = head;
            while (current != null)
            {
                if (current.Child != null)
                {
                    tail.NextChild = current.Child;
                    current.Child.PreChild = tail;
                    tail = AppendChildtoEnd(current.Child);
                    

                }

                current = current.NextChild;
            }

            return tail;
        }


        public static ListWithChild AppendChildtoEnd(ListWithChild head)
        {
            while (head?.NextChild != null)
            {
                head = head.NextChild;
            }

            return head;
        }



    }
}
