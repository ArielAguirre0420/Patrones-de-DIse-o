using System.Collections.Generic;

namespace Builder.Clases
{
    public class ManualCar 
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + "\n";
            }

            return "Product parts: " + str + "\n";
        }
    }
}
