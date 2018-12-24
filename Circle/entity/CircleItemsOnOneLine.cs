using System;
using System.Collections.Generic;
using System.Text;

namespace Circle.entity
{
    public class CircleItemsOnOneLine
    {
        private List<CircleItem> items;

        public List<CircleItem> Items { get => items; set => items = value; }

        public CircleItemsOnOneLine(List<CircleItem> items)
        {
            Items = items;
        }

        public CircleItemsOnOneLine()
        {
            Items = new List<CircleItem>();
        }

        public override bool Equals(object obj)
        {
            var line = obj as CircleItemsOnOneLine;
            return line != null &&
                   EqualityComparer<List<CircleItem>>.Default.Equals(Items, line.Items);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Items);
        }

        public override string ToString()
        {
            string result = "";
            foreach (CircleItem it in Items)
            {
                result += it.ToString();
            }
            return result;
        }
    }
}
