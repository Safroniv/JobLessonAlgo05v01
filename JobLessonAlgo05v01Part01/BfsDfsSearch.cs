namespace JobLessonAlgo05v01Part01
{
    public class BfsDfsSearch
    {
        private TreeNode? _root;
        public TreeNode? Root { get { return _root; } set { _root = value; } }
        /// <summary>
        /// Добавление значений нод
        /// </summary>
        /// <param name="value">значения нод</param>
        public void Add(int value)
        {
            if (Root == null)
                Root = new TreeNode(value);
            else
                Add(new TreeNode(value));
        }
        public void RandomTree(int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
                Add(random.Next(10000));
        }
        /// <summary>
        /// Метод добавления нод 
        /// </summary>
        /// <param name="addedNode">добавляемая нода</param>
        private void Add(TreeNode addedNode)
        {
            TreeNode node = Root;
            while (node != null)
            {
                if (node.Value > addedNode.Value)
                {
                    if (node.Right == null)
                        node.Right = addedNode;
                    else
                        node = node.Right;
                }
                else if (node.Value < addedNode.Value)
                {
                    if (node.Left == null)
                        node.Left = addedNode;
                    else
                        node = node.Left;
                }
                else
                    break;
            }
        }
        /// <summary>
        /// Поиск в ширину BFS
        /// </summary>
        /// <param name="value">значения нод поиска в ширину BFS</param>
        /// <returns>значение ноды или ничего</returns>
        public TreeNode BFSearch(int value)
        {
            Console.WriteLine("\n");
            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Поиск в ширину BFS (breadth-filst search)");
            Console.WriteLine($"Иcкомое значение BFS: {value}");
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(Root);

            Console.Write("Список нод: ");
            while (queue.Count != 0)
            {
                TreeNode node = queue.Dequeue();

                if (node != null)
                {
                    Console.Write($" {node.Value} ");
                    if (node.Value == value)
                        return node;
                    else
                    {
                        queue.Enqueue(node.Left);
                        queue.Enqueue(node.Right);
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Поиск в глубину DFS
        /// </summary>
        /// <param name="value">значения нод поиска в глубину DFS</param>
        /// <returns>значение ноды или ничего</returns>
        public TreeNode DFSearch(int value)
        {
            Console.WriteLine("\n");
            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Поиск в глубину DFS (deep-filst search)");
            Console.WriteLine($"Иcкомое значение DFS: {value}");
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(Root);
            Console.Write("Список нод: ");
            while (stack.Count != 0)
            {
                TreeNode node = stack.Pop();
                if (node != null)
                {
                    Console.Write($" {node.Value} ");
                    if (node.Value == value)
                        return node;
                    else
                    {
                        stack.Push(node.Right);
                        stack.Push(node.Left);
                    }
                }
            }
            return null;
        }
    }
}

