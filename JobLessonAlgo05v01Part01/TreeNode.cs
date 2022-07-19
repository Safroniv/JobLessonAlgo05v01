namespace JobLessonAlgo05v01Part01
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
        public TreeNode(int value, TreeNode? left, TreeNode? right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
        public TreeNode(int value)
        {
            Value = value;
        }
    }
}
