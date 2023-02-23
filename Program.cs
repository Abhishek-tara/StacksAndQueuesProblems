namespace StacksAndQueues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack and Queue Problems");

            Console.WriteLine("Creating Queue using Linked List");

            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

        }
    }
}