internal class Program
{
    private static void Main(string[] args)
    {
        int front = 0;
        int rear = -1;
        int size = 0;
        int[] queue = new int[10];

        //Creates the queue and intitail values.

        for(int i = 0; i < queue.Length; i++)
        {
            enQueue(ref queue, ref rear, i, ref size);
        }

        //Adds numbers 0-9 to queue. 

        for(int i = 0; i < queue.Length ; i++)
        {
            Console.WriteLine(deQueue(queue, ref front, ref size));
        }

        //Outputs numbers in queue.
    }

    public static bool isEmpty(int size)
    {
        if (size == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

        //If size is 0, the queue is empty.
    }

    public static bool isFull(int size, int[] queue)
    {
        if (size == queue.Length)
        {
            return true;
        }
        else
        {
            return false;
        }

        //If size is the same as the queue length, the queue is full.
    }

    public static void enQueue(ref int[] queue, ref int rear, int value, ref int size)
    {
        if(!isFull(size, queue))
        {
            size = size + 1;
            rear = rear + 1;

            //Updates size and rear.
            if(rear >= queue.Length)
            {
                rear = rear % queue.Length;
            }

            //If statement to make queue circular.

            queue[rear] = value;

            //Adds value to queue.
        }
        else
        {
            Console.WriteLine("Queue full, cannot enqueue.");
        }

        //Error statement.
    }

    public static int deQueue(int[] queue,ref int front, ref int size)
    {
        if (!isEmpty(size))
        {
            int value = 0;
            size = size - 1;
            front = front + 1;

            //Updates values.
            if(front >= queue.Length)
            {
                front = front % queue.Length;
            }

            //If statement to make queue circular.

            value = queue[front];
            return value;
        }
        else
        {
            Console.WriteLine("Queue is empty, cannot dequeue.");
            return 0;
        }

        //Error statement.
    }
}