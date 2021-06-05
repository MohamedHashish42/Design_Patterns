using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.FlyweightDP
{
    public class ShapeFactory
    {
        private static Dictionary<string, Shape> _cache = new Dictionary<string, Shape>();
        public static Shape GetShape( SharedShapesNames shapeName)
        {
            Shape shape = null;

            if (shapeName == SharedShapesNames.circle)
            {
                string key = SharedShapesNames.circle.ToString();
                if (_cache.ContainsKey(key))
                {
                    return _cache[key];
                }
               
                shape = new Circle();
                _cache.Add(key, shape);
            }

           else if (shapeName == SharedShapesNames.triangle)
            {
                string key = SharedShapesNames.triangle.ToString();
                if (_cache.ContainsKey(key))
                {
                    return _cache[key];
                }

                shape = new Triangle();
                _cache.Add(key, shape);
            }
            return shape;
        }
    }
}
