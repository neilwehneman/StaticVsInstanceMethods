namespace StaticVsInstanceMethods;

class Program
{
    static void Main(string[] args)
    {
        // This is a static method. It doesn't depend upon any given instantiated object,
        // and is called based on the class name.
        Quadrilateral.PrintNumberOfSidesAQuadrilateralHas();

        Quadrilateral myParticularQuadrilateral = new Quadrilateral();

        myParticularQuadrilateral.Side1Length = 3;
        myParticularQuadrilateral.Side2Length = 4;
        myParticularQuadrilateral.Side3Length = 5;

        // This is an instance method. It depends upon a particular instantiated object,
        // and is called based on the instantiated object's name.
        myParticularQuadrilateral.PrintNumberOfSidesWithValue();

        Console.ReadKey();
    }
}