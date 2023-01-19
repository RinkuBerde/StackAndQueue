namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tData Structures : Stacks and Queues");
            Console.WriteLine();
            Console.WriteLine("-------------Stack Operations-------------");
            Console.WriteLine("1.Push operation");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter the option : ");
            int num = Convert.ToInt32(Console.ReadLine());
            LinkedListStack linkedListStack = new LinkedListStack();
            switch (num)
            {
                case 1:
                    linkedListStack.Push(70);
                    linkedListStack.Push(30);
                    linkedListStack.Push(56);
                    linkedListStack.Display();
                    break;
            }
        }
    }
}