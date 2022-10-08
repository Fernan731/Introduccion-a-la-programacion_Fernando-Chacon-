class programn
{

    static void Main()
    {


        double monto, monto1, monto2;
        string tipo, tipo1, tipo2;

        Console.WriteLine("Ingrese el monto");
        monto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Si es USD o GTQ");
        tipo = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Ingrese el monto 2 ");
        monto1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Es USD GTQ");
        tipo1 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Ingrese el monto 3");
        monto2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Es USD o GTQ");
        tipo2 = Convert.ToString(Console.ReadLine());



        if (monto > monto1 && monto > monto2)
        {
            Console.WriteLine(monto + " " + tipo);




            if (monto1 > monto2)
            {
                Console.WriteLine(monto1 + " " + tipo2);
                Console.WriteLine(monto2 + " " + tipo2);


            }
            else
            {
                Console.WriteLine(monto2 + " " + tipo2);
                Console.WriteLine(monto1 + " " + tipo1);


            }
        }
        if (monto2 > monto1 && monto2 > monto1)
        {
            Console.WriteLine(monto2 + " " + tipo2);




            if (monto1 > monto)
            {
                Console.WriteLine(monto1 + " " + tipo1);
                Console.WriteLine(monto + " " + tipo);


            }
            else
            {
                Console.WriteLine(monto + " " + tipo);
                Console.WriteLine(monto1 + " " + tipo1);


            }

        }
        if (monto1 > monto2 && monto1 > monto)
        {
            Console.WriteLine(monto1 + " " + tipo1);




            if (monto2 > monto)
            {
                Console.WriteLine(monto2 + " " + tipo2);
                Console.WriteLine(monto + " " + tipo);


            }
            else
            {
                Console.WriteLine(monto + " " + tipo);
                Console.WriteLine(monto2 + " " + tipo2);


            }
        }
    }
}
