using System;
namespace StaticVsInstanceMethods
{
	public class Quadrilateral
	{
		public int Side1Length { get; set; }
		public int Side2Length { get; set; }
		public int Side3Length { get; set; }
		public int Side4Length { get; set; }

		public static void PrintNumberOfSidesAQuadrilateralHas()
		{
			Console.WriteLine("A quadrilateral has 4 sides.");
		}

		public void PrintNumberOfSidesWithValue()
		{
			List<int> sidesWithAssignedValues = new List<int>();

			if (Side1Length > 0)
			{
				sidesWithAssignedValues.Add(Side1Length);
			}

            if (Side2Length > 0)
            {
                sidesWithAssignedValues.Add(Side2Length);
            }

            if (Side3Length > 0)
            {
                sidesWithAssignedValues.Add(Side3Length);
            }

            if (Side4Length > 0)
            {
                sidesWithAssignedValues.Add(Side4Length);
            }

            Console.WriteLine("This quadrilateral has " + sidesWithAssignedValues.Count + " sides with assigned values");
		}
	}
}