using System.Collections.Generic;

namespace GpsSkateShop
{
    public class Catagolo
    {
       public List<Shape> GetShapes()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Shape("001", "Trust", 150.00m));
            shapes.Add(new Shape("002", "Aspecto", 150.00m));
            shapes.Add(new Shape("003", "PGS", 150.00m));

            return shapes;
        }
    }
}
