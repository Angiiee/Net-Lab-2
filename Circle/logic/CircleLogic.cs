
using Circle.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circle.logic
{
    public class CircleLogic
    {

        public static double CalculateSquare(CircleItem circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }

        public static double CalculatePerimetr(CircleItem circle)
        {
            return 2 * Math.PI * circle.Radius;
        }

        public static List<CircleItemsOnOneLine> CheckCirclesOnOneLine(List<CircleItem> allCircles)
        {
            List<CircleItemsOnOneLine> result = new List<CircleItemsOnOneLine>();
            foreach (CircleItem circle in allCircles)
            {
                if (result.Count == 0)
                {
                    Console.WriteLine("first " + circle.ToString());
                    CircleItemsOnOneLine oneLine = new CircleItemsOnOneLine();
                    oneLine.Items.Add(circle);
                    result.Add(oneLine);
                }
                else
                {
                    Boolean flag = true;
                    foreach (CircleItemsOnOneLine line in result)
                    {
                        CircleItem circleToCompare = line.Items[0];
                        if (circle.Center.X == circleToCompare.Center.X || circle.Center.Y == circleToCompare.Center.Y)
                        {
                            line.Items.Add(circle);
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        CircleItemsOnOneLine oneLine = new CircleItemsOnOneLine();
                        oneLine.Items.Add(circle);
                        result.Add(oneLine);
                    }

                }
            }
            Console.WriteLine(result);
            return result;

        }

        public static List<CircleItem> FindCirclesMaxSquare(List<CircleItem> allCircles)
        {
            List<CircleItem> result = new List<CircleItem>();
            double maxValue = 0;
            foreach (CircleItem item in allCircles)
            {
                if (CalculateSquare(item) > maxValue)
                {
                    maxValue = CalculateSquare(item);
                }
            }
            foreach (CircleItem item in allCircles)
            {
                if (CalculateSquare(item) == maxValue)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<CircleItem> FindCirclesMaxPerimeter(List<CircleItem> allCircles)
        {
            List<CircleItem> result = new List<CircleItem>();
            double maxValue = 0;
            foreach (CircleItem item in allCircles)
            {
                if (CalculatePerimetr(item) > maxValue)
                {
                    maxValue = CalculatePerimetr(item);
                }
            }
            foreach (CircleItem item in allCircles)
            {
                if (CalculatePerimetr(item) == maxValue)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
