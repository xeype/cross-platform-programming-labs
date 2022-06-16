namespace Lab06.Containers
{
    public class DoubleNode<T>
    {
        public T Data;
        public DoubleNode<T> Previous { get; set; }
        public DoubleNode<T> Next { get; set; }
        
        public DoubleNode(T data)
        {
            Data = data;
        }
    }
}