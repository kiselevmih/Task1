class Task1
{
    static void Main(string[] args)
    {
        if (args.Length < 2
            || !int.TryParse(args[0], out var n) || !int.TryParse(args[1], out var m)
            || n < 1 || m < 1) return;
        --m;
        var index = 1;
        do
        {
            System.Console.Write(index);
            index = (index + m) % n;
            if (index == 0) index = n;
        } while (index != 1);
    }
}