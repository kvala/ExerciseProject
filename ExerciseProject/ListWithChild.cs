namespace ExerciseProject
{
    public class ListWithChild
    {
        public ListWithChild NextChild;
        public ListWithChild PreChild;
        public ListWithChild Child;
        public int Data;


        public ListWithChild(int data)
        {
            this.Data = data;
        }
    }
}
