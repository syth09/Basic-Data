using System;

class TamGiac
{
    private double canhA;
    private double canhB;
    private double canhC;
    private double chieuCao;
    private double canhDay;

    public double CanhA
    {
        get { return canhA; }
        set
        {
            if (value > 0)
                canhA = value;
            else
                throw new ArgumentException("Độ dài cạnh phải lớn hơn 0");
        }
    }

    public double CanhB
    {
        get { return canhB; }
        set
        {
            if (value > 0)
                canhB = value;
            else
                throw new ArgumentException("Độ dài cạnh phải lớn hơn 0");
        }
    }

    public double CanhC
    {
        get { return canhC; }
        set
        {
            if (value > 0)
                canhC = value;
            else
                throw new ArgumentException("Độ dài cạnh phải lớn hơn 0");
        }
    }

    public double ChieuCao
    {
        get { return chieuCao; }
        set
        {
            if (value > 0)
                chieuCao = value;
            else
                throw new ArgumentException("Chiều cao phải lớn hơn 0");
        }
    }

    public double CanhDay
    {
        get { return canhDay; }
        set
        {
            if (value > 0)
                canhDay = value;
            else
                throw new ArgumentException("Độ dài cạnh đáy phải lớn hơn 0");
        }
    }

    // Phương thức nạp chồng tính diện tích
    public double TinhDienTich()
    {
        if (canhDay > 0 && chieuCao > 0)
        {
            return 0.5 * canhDay * chieuCao;
        }
        else
        {
            throw new ArgumentException("Chiều cao và cạnh đáy phải lớn hơn 0");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            TamGiac tamGiac1 = new TamGiac();
            tamGiac1.CanhA = 3;
            tamGiac1.CanhB = 4;
            tamGiac1.CanhC = 5;

            TamGiac tamGiac2 = new TamGiac();
            tamGiac2.CanhDay = 6;
            tamGiac2.ChieuCao = 4;

            Console.WriteLine("Diện tích tam giác là: " + tamGiac2.TinhDienTich());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}