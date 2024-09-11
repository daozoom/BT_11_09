class BT_11_09
{
    public void Max()
    {
        int[] mang = new int[10];
        int max = mang[0];
        Console.WriteLine("Nhap phan tu cho mang: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("mang["+i+"] = ");
            mang[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Cac phan tu trong mang:");
        foreach (int i in mang)
        {
            Console.Write(" "+i);
        }
        Console.WriteLine();
        Console.Write("Phan tu lon nhat trong mang:");
        foreach (int i in mang)
        {
            if (max < i)
            {
                max = i;
            }
        }
        Console.WriteLine(max);
    }
    public void sinhSoNN()
    {
        Random rd = new Random();
        int x = rd.Next(1, 7);
        Console.Write("Nhap vao 1 so ngau nhien tu 1 den 6:");
        int number = int.Parse(Console.ReadLine());
        if (number == x)
        {
            Console.WriteLine("Win");
        }
        else
        {
            Console.WriteLine("Lose\nSo ngau nhien la "+x);
        }
    }
    public static void Main(string[] args)
    {
        BT_11_09 bT_11_09 = new BT_11_09();
        bT_11_09.Max();
        //bT_11_09.sinhSoNN();
    }
}