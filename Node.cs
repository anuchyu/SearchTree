namespace SearchTree
{
    internal class Node<T> : IComparable<T>
        where T: IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right) : this(data)
        {
            Left = left;
            Right = right;
        }

        public int CompareTo(Node<T>? obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("Несовпадение типов");
            }
        }

        public int CompareTo(T? other)
        {
            return Data.CompareTo((T)other);
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if(node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)

                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
