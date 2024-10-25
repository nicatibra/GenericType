namespace Task_15___Generic_type_and_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //T = int

            CustomList<int> array1 = new(5);

            array1.Add(6);
            array1.AddRange(7, 8, 1, 9);
            Console.WriteLine("Your list: " + array1.ToString());

            Console.WriteLine($"List contains your number? : " + array1.Contains(6));

            Console.WriteLine("Sum of elements of list: " + array1.Sum());

            Console.WriteLine("------------------------------------------------------");

            array1.Remove(8);
            array1.RemoveRange(7, 0);
            Console.WriteLine("Elements of list after removing: " + array1.ToString());

            //Console.WriteLine("------------------------------------------------------");


            //T = string

            //CustomList<string> list1 = new();

            //list1.Add("Nicat");
            //list1.Add("Ibrahimli");
            //list1.AddRange("Code", "Academy");
            //Console.WriteLine(list1.Contains("Ibrahimli"));
            //list1.Remove("Ibrahimli");

            //Console.WriteLine(list1.ToString());

        }
    }
}
