class programn
{

    static void Main(string[] args)
    {


        double monto;

        Console.WriteLine("Ingrese el monto");
        monto = Convert.ToDouble(Console.ReadLine());

        if (monto >= 400 && monto <= 1000)
        {
            Console.WriteLine("7% de descuento");
        }
        else if (monto >= 1000 && monto <= 5000)
        {
            Console.WriteLine("10% de descuento");

        }
        else if (monto >= 5000 && monto <= 15000)
        {
            Console.WriteLine("15% en ventas");
        }
        else if (monto >= 15000)
        {
            Console.WriteLine("25% de descuento");
        }
        else if (monto < 400)
        { Console.WriteLine("No hay descuento"); }
    }
}