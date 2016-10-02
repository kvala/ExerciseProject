namespace ExerciseProject
{
    class Tree
    {
        public Tree Left;
        public Tree Right;
        public int Value;

        public Tree(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }

}
