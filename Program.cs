int ArraySize;
do
{
    Console.Write("Input array size:");
}
while
(!(int.TryParse(Console.ReadLine(), out ArraySize)));
CustomIntArray array = new(ArraySize);
Console.WriteLine("1) New array");
Console.WriteLine("2) InputData");
Console.WriteLine("3) InputDataRandom");
Console.WriteLine("4) Print");
Console.WriteLine("5) FindValue");
Console.WriteLine("6) DelValue");
Console.WriteLine("7) FindMax");
Console.WriteLine("8) Add");
Console.WriteLine("9) Sort");
while (true)
{
    Console.Write("> ");
    string? input = Console.ReadLine();
    if (input == null) continue;
    int command = input[0];
    switch (command)
    {
        case '1':
            do
            {
                Console.Write("size > ");
            }
            while (!(int.TryParse(Console.ReadLine(), out ArraySize)));
            array = new(ArraySize);
            break;
        case '2':
            Console.Write("data > ");
            array.InputData(Console.ReadLine());
            break;
        case '3':
            array.InputDataRandom();
            break;
        case '4':
            array.Print();
            break;
        case '5':
            int value;
            CustomIntArray outputArray;
            do
            {
                Console.Write("value > ");
            }
            while (!(int.TryParse(Console.ReadLine(), out value)));
            if (array.FindValue(value, out outputArray))
            {
                outputArray.Print();
            }
            break;
        case '6':
            int value1;
            do
            {
                Console.Write("value > ");
            }
            while (!(int.TryParse(Console.ReadLine(), out value1)));
            array.DelValue(value1);
            ArraySize = array.GetSize();
            break;
        case '7':
            int first_index = 0;
            Console.WriteLine($"max: {array.FindMax(ref first_index)} at {first_index}");
            break;
        case '8':
            CustomIntArray rhs = new(ArraySize);
            Console.Write("data > ");
            rhs.InputData(Console.ReadLine());
            array.Add(rhs);
            break;
        case '9':
            array.Sort();
            break;
        case '0':
            return;
    }
}