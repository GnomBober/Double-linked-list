namespace Program
{
    public class Program
    {
        public static void Main()
        {

        }

        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Prev { get; set; }
            public Node<T> Next { get; set; }
            public Node(T data)
            {
                Data = data;
            }
        }
        public class DoubleList<T>
        {
            Node<T> head;
            Node<T> tail;
            int count;

            public void Add(T data)
            {
                Node<T> node = new Node<T>(data);

                if (head == null)
                    head = node;
                else
                {
                    tail.Next = node;
                    node.Prev = tail;
                }
                tail = node;
                count++;
            }

            public void AddFirst(T data)
            {
                Node<T> node = new Node<T>(data);
                Node<T> temp = head;
                node.Next = temp;
                head = node;
                if (count == 0)
                    tail = head;
                else
                    temp.Prev = node;
                count++;
            }

            public void AddBefore(T data,int index)
            {
                Node<T> node = new Node<T>(data);
                Node<T> temp = head;
                for (int i=0; i<index; i++)
                {
                    temp = temp.Next;
                }
                node.Next = temp;
                node.Prev = temp.Prev;
                temp.Prev.Next = node;
                temp.Prev = node;
                count++;
            }

            public void AddAfter(T data, int index)
            {
                Node<T> node = new Node<T>(data);
                Node<T> temp = head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }
                node.Next = temp.Next;
                node.Prev = temp;
                temp.Next.Prev = node;
                temp.Next = node;
                count++;
            }

            public void Delete(int index) 
            {
                Node<T> temp = head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }
                temp.Prev.Next = temp.Next;
                temp.Next.Prev = temp.Prev;
            }
        }
    }
}
