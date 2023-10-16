namespace boxingandunboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing
            int i = 3;
            object obj = i;
            Console.WriteLine(i);
            Console.WriteLine(obj);

            //unboxing
            int smallerNumber = 10;
            int obj = smallerNumber;
            if(obj2 is int)
            {
                long j = int(obj2);
                Console.WriteLine(obj2);
                Console.WriteLine(j);
            }

            object obj3 = new Person();
            if(obj3 is string)
            {
                string obj3Content=obj3 as string;
                Console.WriteLine(obj3Content);
            }
            
            

            //literals
            long a = 123;
            long b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //operators
            string text = null;
            Console.WriteLine("Length of text:" + text?.Length);
        }
    }
    public class Person
    {
        public string Name;
    }
}