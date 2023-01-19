namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tData Structures : Stacks and Queues");
            Console.WriteLine();
            Console.WriteLine("-------------Stack and Queue Operations-------------");
            Console.WriteLine("1.Push operation");
            Console.WriteLine("2. Peek and Pop till the stack is empty");
            Console.WriteLine("3. Create Queue of 56->30->70");
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
                case 2:
                    linkedListStack.Push(70);
                    linkedListStack.Push(30);
                    linkedListStack.Push(56);
                    linkedListStack.Display();                   
                    linkedListStack.Peek();
                    linkedListStack.Pop();
                    linkedListStack.IsEmpty();
                    linkedListStack.Display();
                    break;
                case 3:
                    LinkedListQueue linkedListQueue = new LinkedListQueue();
                    linkedListQueue.Enqueue(56);
                    linkedListQueue.Enqueue(30);
                    linkedListQueue.Enqueue(70);
                    linkedListQueue.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }
        }
    }
}