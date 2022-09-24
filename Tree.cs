namespace SearchTree
{
    internal class Tree<T>
        where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add (T data)
        {
            if (Root == null)
            {
                Root = new Node<T> (data);
                Count = 1;
                return;
            }

            Root.Add (data);
            Count++;
        }

        public List<T> CLR() // в глубину
        {

            if (Root == null)
            {
                return new List<T>();
            }

            return CLR(Root);
        }

        private List<T> CLR(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(CLR(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(CLR(node.Right));
                }
            }
            return list;
        }

        public List<T> RCL()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return RCL(Root);
        }

        private List<T> RCL(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(CLR(node.Right));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(CLR(node.Left));
                }
            }
            return list;
        }
    }
}
