using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices.Topics
{
    public class Indexer
    {
        private List<string> _data = new List<string>();
        //private string[] _data = new string[10];

        // Define an indexer
        public string this[int index]
        {
            get
            {
                // Return the element at the specified index
                return _data[index];
            }
            set
            {
                // Set the element at the specified index
                //_data[index] = value;
                _data.Add(value);
            }
        }
    }
}
