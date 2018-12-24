using System;
using System.Collections.Generic;

namespace Circle.entity
/*
        Определить класс Окружность на плоскости.Определить площадь и периметр. 
        Создать массив/ список / множество объектов и определить группы окружностей, 
        центры которых лежат на одной прямой. 
        Определить наибольший и наименьший по площади(периметру) объект.
*/
{
    public class CircleItem
    {
        private Point center;
        private int radius;

        public Point Center { get => center; set => center = value; }
        public int Radius { get => radius; set => radius = value; }

        public CircleItem()
        {
        }

        public CircleItem(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public override bool Equals(object obj)
        {
            var item = obj as CircleItem;
            return item != null &&
                   EqualityComparer<Point>.Default.Equals(Center, item.Center) &&
                   Radius == item.Radius;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Center, Radius);
        }

        public override string ToString()
        {
            return "Circle: center " + Center.ToString() + "; radius = " + Radius;
        }
    }
}
